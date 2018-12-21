using BR.AN.PviServices;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EnMon
{
    public partial class frmMain : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Service service;
        private Cpu cpu;
        private Variable trigger1Value, trigger1Delay, trigger1MuteActive, trigger1Alarm;
        private Variable trigger2Value, trigger2Delay, trigger2MuteActive, trigger2Alarm;
        private Variable varActValue, varPeakValue, varPowerConsumed, varPowerLimit, varPowerLimitTarif, varTarifInterval, varTarifTime, varPowerFactor;
        private bool dataChanged;
        private bool beginReadValue;
        private System.Windows.Forms.DataVisualization.Charting.Series seriesActPower;
        private DateTime tarifTime = DateTime.Now;
        private bool saveConsumedPower;

        public frmMain()
        {
            log.Info("Application Start");

            InitializeComponent();
            tabControl1.TabIndex = 0;

            tbTrigger1Value.Tag = labelTrigger1Value;
            tbTrigger1Delay.Tag = labelTrigger1Delay;

            tbTrigger2Value.Tag = labelTrigger2Value;
            tbTrigger2Delay.Tag = labelTrigger2Delay;

            rtbPowerLimit.Tag = labelPowerLimit;
            rtbTarifInterval.Tag = labelTarifInterval;
            rtbPowerFactor.Tag = label7;

            label10.Tag = label9;
            label12.Tag = label11;
            label14.Tag = label13;
            label16.Tag = label15;

            beginReadValue = false;
            dataChanged = true;
            DataChanged = false;

            InitChart();
        }

        #region Private
        private void InitChart()
        {
            if (varTarifInterval == null || !varTarifInterval.IsConnected || !varTarifInterval.DataValid)
                return;
            if (varPowerLimitTarif == null || !varPowerLimitTarif.IsConnected || !varPowerLimitTarif.DataValid)
                return;

            var timeInterval = varTarifInterval.Value.ToInt32(null);
            var powerInterval = varPowerLimitTarif.Value.ToInt32(null);

            var toTime = tarifTime.AddMinutes(timeInterval);

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = tarifTime.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = toTime.ToOADate();

            var series = chart1.Series.Add("IdealPower");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.LegendText = "Limit";
            series.IsVisibleInLegend = false;
            series.Points.AddXY(tarifTime, 0);
            series.Points.AddXY(toTime, powerInterval);
            series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;

            seriesActPower = chart1.Series.Add("ActPower");
            seriesActPower.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            seriesActPower.LegendText = "Odběr";
            seriesActPower.IsVisibleInLegend = false;
            seriesActPower.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            seriesActPower.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
        }

        private void ClearCpuInfo()
        {
            statusLabelCpuState.Text = null;
            statusLabelCpuRuntime.Text = null;
        }

        private void ConnectToPlc()
        {
            log.Info("ConnectToPlc()...");

            string msg = null;

            bool isIp = !string.IsNullOrEmpty(Properties.Settings.Default.PVILocalIP);
            bool isPort = !string.IsNullOrEmpty(Properties.Settings.Default.PVILocalPort);

            if (!isIp && !isPort)
                msg = "PVI adresa není nastavena!";

            if (!isPort && !isIp)
                msg = "PVI port není nastaven!";

            if (string.IsNullOrEmpty(Properties.Settings.Default.PVIDestStation))
                msg = "PVI cílová stanice není nastavena!";

            if (string.IsNullOrEmpty(Properties.Settings.Default.PVISrcStation))
                msg = "PVI zdrojová stanice není nastavena!";

            if (msg != null)
            {
                toolStripStatusLabel1.Text = msg;
                return;
            }

            service = new Service("EnMon");
            service.Error += Service_Error;
            service.Connected += Service_Connected;
            service.Timeout = 10;

            var ip = Properties.Settings.Default.PVIRemoteIP.Trim();
            var port = Properties.Settings.Default.PVIRemotePort.Trim();
            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
                service.Connect();
            else
                service.Connect(ip, Convert.ToInt16(port));


            toolStripStatusLabel1.Text = "Vytvářím spojení se službou...";
            ClearCpuInfo();

            log.Info("ConnectToPlc() OK");
        }

        private bool DataChanged
        {
            get { return dataChanged; }
            set
            {
                if (dataChanged != value && !beginReadValue)
                {
                    dataChanged = value;
                    button2.Enabled = value;
                }
            }
        }

        private void InitVariable(ref Variable variable, string variableName, Control edit, bool liveData = false)
        {
            log.Info($"InitVariable()... {variableName}");

            if (edit != null && edit is Label)
            {
                edit.Enabled = false;
                edit.Text = "Offline";
                (edit.Tag as Label).ImageIndex = 0;
            }

            if (cpu.Variables.Contains(variableName))
                variable = cpu.Variables[variableName];
            else
            {
                variable = new Variable(cpu, variableName)
                {
                    UserData = edit,
                    Access = Access.ReadAndWrite,
                    Active = true,
                    WriteValueAutomatic = false
                };
                variable.Connected += variable_Connected;
                variable.Disconnected += variable_Disconnected;
                variable.Error += variable_Error;
                variable.ValueRead += variable_ValueRead;
                variable.ValueWritten += variable_ValueWritten;

                if (liveData)
                    variable.ValueChanged += variable_ValueChanged;
            }
            if (variable != null)
            {
                if (!variable.IsConnected)
                    variable.Connect();
                else
                    variable.ReadValue();
            }

            log.Info("InitVariable() OK");
        }

        private void WriteVariableValue(Variable variable)
        {
            log.Info($"WriteVariableValue()... {variable?.Name}");

            if (variable != null)
            {
                var edit = variable.UserData as TextBox;
                if (edit != null)
                    (edit.Tag as Label).ImageIndex = 0;

                if (variable.IsConnected)
                {
                    try
                    {
                        variable.Value.Assign(edit.Text);
                        variable.WriteValue();
                    }
                    catch (System.Exception ex)
                    {
                        (edit.Tag as Label).ImageIndex = 1;
                        MessageBox.Show(
                            $"Chyba zápisu hodnoty do proměnné '{variable.Name}'!\n{ex.Message}",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            log.Info("WriteVariableValue()... OK");
        }
        #endregion

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            ConnectToPlc();
            timer1.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Info("Application Closing");

            timer1.Stop();
            if (service != null)
                service.Disconnect(true);
        }

        private void Service_Connected(object sender, PviEventArgs e)
        {
            log.Info($"Service_Connected()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            cpu = new Cpu(service, "cpu");
            cpu.Connection.DeviceType = DeviceType.TcpIp;
            cpu.Connection.TcpIp.DestinationIpAddress = Properties.Settings.Default.PVILocalIP;
            cpu.Connection.TcpIp.DestinationPort = Convert.ToInt16(Properties.Settings.Default.PVILocalPort);
            cpu.Connection.TcpIp.DestinationStation = Convert.ToByte(Properties.Settings.Default.PVIDestStation);
            cpu.Connection.TcpIp.SourceStation = Convert.ToByte(Properties.Settings.Default.PVISrcStation);

            cpu.Connected += cpu_Connected;
            cpu.Disconnected += cpu_Disconnected;
            cpu.Error += cpu_Error;

            cpu.Connect();

            toolStripStatusLabel1.Text = "Vytvářím spojení s PLC...";

            log.Info("Service_Connected()... OK");
        }

        private void Service_Error(object sender, PviEventArgs e)
        {
            log.Info($"Service_Error()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            string msg = string.Format("PVI Error: {0} Addr: {1}", e.ErrorCode, e.Name);
            toolStripStatusLabel1.Text = msg;
        }

        private void cpu_Connected(object sender, PviEventArgs e)
        {
            log.Info($"cpu_Connected()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            toolStripStatusLabel1.Text = "PLC připojeno.";
            statusLabelCpuState.Text = cpu.State.ToString();
            statusLabelCpuRuntime.Text = cpu.RuntimeVersion;

            InitVariable(ref trigger1Value, "gTrigger1Value", tbTrigger1Value);
            InitVariable(ref trigger1Delay, "gTrigger1DeadTime", tbTrigger1Delay);
            InitVariable(ref trigger1MuteActive, "gTrigger1MuteActive", alarm1Ack, true);
            InitVariable(ref trigger1Alarm, "gTrigger1Alarm", tabPageLimit1, true);

            InitVariable(ref trigger2Value, "gTrigger2Value", tbTrigger2Value);
            InitVariable(ref trigger2Delay, "gTrigger2DeadTime", tbTrigger2Delay);
            InitVariable(ref trigger2MuteActive, "gTrigger2MuteActive", alarm2Ack, true);
            InitVariable(ref trigger2Alarm, "gTrigger2Alarm", tabPageLimit2, true);

            InitVariable(ref varPowerLimit, "gPowerLimit", rtbPowerLimit);
            InitVariable(ref varPowerFactor, "gPowerFactor", rtbPowerFactor);

            InitVariable(ref varActValue, "gActPower", label10, true);
            InitVariable(ref varPeakValue, "gPeakPower", label12, true);
            InitVariable(ref varPowerConsumed, "gPowerConsumed", label14, true);
            InitVariable(ref varPowerLimitTarif, "gPowerLimitInterval", label16, true);

            InitVariable(ref varTarifInterval, "gTarifInterval", rtbTarifInterval);
            InitVariable(ref varTarifTime, "gTarifTime", null, true);

            log.Info("cpu_Connected()... OK");

            if (Properties.Settings.Default.AutoSetPlcTime)
                cpu.WriteDateTime(DateTime.Now);
        }

        private void cpu_Disconnected(object sender, PviEventArgs e)
        {
            log.Info($"cpu_Disconnected()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            toolStripStatusLabel1.Text = "PLC odpojeno!";
            statusLabelCpuState.Text = "Offline";
            ClearCpuInfo();

            log.Info("cpu_Disconnected()... OK");
        }

        private void cpu_Error(object sender, PviEventArgs e)
        {
            log.Info($"cpu_Error()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            string msg = string.Format("PVI Error: {0} Addr: {1}", e.ErrorCode, e.Name);
            toolStripStatusLabel1.Text = msg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saveConsumedPower = true;
        }

        private void variable_Connected(object sender, PviEventArgs e)
        {
            log.Info($"variable_Connected()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            var variable = sender as Variable;
            variable.ReadValue();

            if (variable.UserData is Control edit && edit is RegexTextBox)
                edit.Text = "Online";
        }

        private void variable_Disconnected(object sender, PviEventArgs e)
        {
            log.Info($"variable_Disconnected()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            var variable = sender as Variable;

            if (variable.UserData is Control edit && edit is Label)
            {
                edit.Enabled = false;
                (edit.Tag as Label).ImageIndex = 1;
            }
        }

        private void variable_Error(object sender, PviEventArgs e)
        {
            log.Info($"variable_Error()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            var variable = sender as Variable;

            if (variable.UserData is Control edit && edit is RegexTextBox)
            {
                edit.Enabled = false;
                edit.Text = "E" + e.ErrorCode.ToString();
                if (edit.Tag is Label)
                    (edit.Tag as Label).ImageIndex = 0;
            }
        }

        private void variable_ValueChanged(object sender, VariableEventArgs e)
        {
            variable_ValueRead(sender, null);
        }

        private void alarmAck_Click(object sender, EventArgs e)
        {
            if (sender == alarm1Ack && trigger1MuteActive.IsConnected)
            {
                trigger1MuteActive.Value.Assign(true);
                trigger1MuteActive.WriteValue();
            }
            if (sender == alarm2Ack && trigger2MuteActive.IsConnected)
            {
                trigger2MuteActive.Value.Assign(true);
                trigger2MuteActive.WriteValue();
            }
        }

        private void variable_ValueRead(object sender, PviEventArgs e)
        {
            if (IsDisposed) return;

            var variable = sender as Variable;

            if (variable == varTarifTime)
            {
                var dt = variable.Value.ToDateTime(null);
                if (tarifTime != dt)
                {
                    tarifTime = dt;
                    InitChart();
                }
            }

            if (variable.UserData is Control edit)
            {
                beginReadValue = true;
                try
                {
                    edit.Enabled = true;
                    if (variable == varActValue || variable == varPeakValue)
                    {
                        var value = variable.Value.ToDouble(null);
                        edit.Text = string.Format("{0:F1}kWh", value);

                        if (variable == varPeakValue)
                        {
                            var max = (int)(value * 1.2);
                            if (max > progressBar1.Maximum)
                                progressBar1.Maximum = max;
                        }
                        else
                        {
                            if ((int)value > progressBar1.Maximum)
                                progressBar1.Maximum = (int)value;
                            progressBar1.Value = (int)value;
                        }
                    }
                    else
                        if (variable == varPowerConsumed || variable == varPowerLimitTarif)
                    {
                        var value = variable.Value.ToDouble(null);
                        edit.Text = $"{value:F1}kW";

                        if (variable == varPowerLimitTarif)
                        {
                            if (progressBar2.Maximum != (int)value)
                                progressBar2.Maximum = (int)value;
                        }
                        else
                        {
                            if (saveConsumedPower && seriesActPower != null && seriesActPower.Points != null)
                            {
                                saveConsumedPower = false;
                                seriesActPower.Points.AddXY(DateTime.Now.ToOADate(), value);
                            }

                            if ((int)value > progressBar2.Maximum)
                                progressBar2.Maximum = (int)value;
                            progressBar2.Value = (int)value;
                        }
                    }
                    else
                        if (variable == trigger1Alarm || variable == trigger2Alarm)
                    {
                        // Zobrazeni informace na tlacitku pro potvrzeni.
                        var value = variable.Value.ToBoolean(null);
                        (edit as TabPage).ImageIndex = value ? 1 : 2;
                    }
                    else
                        if (variable == trigger1MuteActive || variable == trigger2MuteActive)
                    {
                        // Zobrazeni alarmu na zalozce.
                        var value = variable.Value.ToBoolean(null);
                        (edit as Button).Text = value ? "Utlumeno" : "Potvrdit";
                    }
                    else
                        edit.Text = variable.Value.ToString(null);

                    if (edit.Tag is Label)
                        (edit.Tag as Label).ImageIndex = -1;

                    alarm1Ack.Enabled = trigger1MuteActive.IsConnected && trigger1Alarm.IsConnected && trigger1Alarm.Value.ToBoolean(null);
                    alarm2Ack.Enabled = trigger2MuteActive.IsConnected && trigger2Alarm.IsConnected && trigger2Alarm.Value.ToBoolean(null);
                }
                finally
                {
                    beginReadValue = false;
                }
            }
        }

        private void variable_ValueWritten(object sender, PviEventArgs e)
        {
            log.Info($"variable_ValueWritten()... {e.Name}, {e.Action}, {e.ErrorCode}, {e.ErrorText}");

            var variable = sender as Variable;

            if (variable.UserData is Control edit)
            {
                if (edit.Tag is Label)
                    (edit.Tag as Label).ImageIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.Info("button2_Click()...");

            string valueErrorTemplate = "Zadaná hodnota pro '{0}' není platná!";
            Regex ipRegex = new Regex(@"^(0[0-7]{10,11}|0(x|X)[0-9a-fA-F]{8}|(\b4\d{8}[0-5]\b|\b[1-3]?\d{8}\d?\b)|((2[0-5][0-5]|1\d{2}|[1-9]\d?)|(0(x|X)[0-9a-fA-F]{2})|(0[0-7]{3}))(\.((2[0-5][0-5]|1\d{2}|\d\d?)|(0(x|X)[0-9a-fA-F]{2})|(0[0-7]{3}))){3})$");

            if (!string.IsNullOrEmpty(textBox9.Text) && !ipRegex.IsMatch(textBox9.Text))
            {
                MessageBox.Show(string.Format(valueErrorTemplate, "Remote IP address"));
                return;
            }

            if (!string.IsNullOrEmpty(textBox2.Text) && !ipRegex.IsMatch(textBox2.Text))
            {
                MessageBox.Show(string.Format(valueErrorTemplate, "PLC IP address"));
                return;
            }

            // Zapis nastaveni.
            Properties.Settings.Default.Save();

            // Zapis  hodnot do PLC.
            WriteVariableValue(trigger1Value);
            WriteVariableValue(trigger1Delay);
            WriteVariableValue(trigger2Value);
            WriteVariableValue(trigger2Delay);
            WriteVariableValue(varPowerLimit);
            WriteVariableValue(varTarifInterval);
            WriteVariableValue(varPowerFactor);

            DataChanged = false;

            log.Info("button2_Click()... OK");
        }

        private void editValue_TextChanged(object sender, EventArgs e)
        {
            if (sender is Control edit && edit.Enabled)
                DataChanged = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageLimit1)
            {
                if (trigger1Value != null && trigger1Value.IsConnected)
                    trigger1Value.ReadValue();
                if (trigger1Delay != null && trigger1Delay.IsConnected)
                    trigger1Delay.ReadValue();
            }

            if (tabControl1.SelectedTab == tabPageLimit2)
            {
                if (trigger2Value != null && trigger2Value.IsConnected)
                    trigger2Value.ReadValue();
                if (trigger2Delay != null && trigger2Delay.IsConnected)
                    trigger2Delay.ReadValue();
            }

            if (tabControl1.SelectedTab == tabPagePower)
            {
                if (varPowerLimit != null && varPowerLimit.IsConnected)
                    varPowerLimit.ReadValue();
            }

            if (tabControl1.SelectedTab == tabPageConnection)
            {
                if (cpu != null && cpu.IsConnected)
                    cpu.ReadDateTime();
            }
        }
        #endregion
    }
}
