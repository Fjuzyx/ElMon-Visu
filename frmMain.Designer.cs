namespace EnMon
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTrigger1Value = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePower = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTarifInterval = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPowerLimit = new System.Windows.Forms.Label();
            this.tabPageLimit1 = new System.Windows.Forms.TabPage();
            this.alarm1Ack = new System.Windows.Forms.Button();
            this.labelTrigger1Delay = new System.Windows.Forms.Label();
            this.tabPageLimit2 = new System.Windows.Forms.TabPage();
            this.alarm2Ack = new System.Windows.Forms.Button();
            this.labelTrigger2Value = new System.Windows.Forms.Label();
            this.labelTrigger2Delay = new System.Windows.Forms.Label();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelPlcTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelCpuState = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelCpuRuntime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbPowerFactor = new EnMon.RegexTextBox();
            this.rtbTarifInterval = new EnMon.RegexTextBox();
            this.rtbPowerLimit = new EnMon.RegexTextBox();
            this.tbTrigger1Value = new EnMon.RegexTextBox();
            this.tbTrigger1Delay = new EnMon.RegexTextBox();
            this.tbTrigger2Value = new EnMon.RegexTextBox();
            this.tbTrigger2Delay = new EnMon.RegexTextBox();
            this.textBox8 = new EnMon.RegexTextBox();
            this.textBox5 = new EnMon.RegexTextBox();
            this.textBox4 = new EnMon.RegexTextBox();
            this.textBox3 = new EnMon.RegexTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageLimit1.SuspendLayout();
            this.tabPageLimit2.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(226, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zavřít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(145, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Uložit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTrigger1Value
            // 
            this.labelTrigger1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrigger1Value.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTrigger1Value.ImageList = this.imageList1;
            this.labelTrigger1Value.Location = new System.Drawing.Point(3, 9);
            this.labelTrigger1Value.Name = "labelTrigger1Value";
            this.labelTrigger1Value.Size = new System.Drawing.Size(183, 16);
            this.labelTrigger1Value.TabIndex = 0;
            this.labelTrigger1Value.Text = "Hodnota varování (kWh)";
            this.labelTrigger1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1");
            this.imageList1.Images.SetKeyName(1, "2");
            this.imageList1.Images.SetKeyName(2, "3");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePower);
            this.tabControl1.Controls.Add(this.tabPageLimit1);
            this.tabControl1.Controls.Add(this.tabPageLimit2);
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 264);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPagePower
            // 
            this.tabPagePower.Controls.Add(this.label7);
            this.tabPagePower.Controls.Add(this.rtbPowerFactor);
            this.tabPagePower.Controls.Add(this.labelTarifInterval);
            this.tabPagePower.Controls.Add(this.rtbTarifInterval);
            this.tabPagePower.Controls.Add(this.chart1);
            this.tabPagePower.Controls.Add(this.labelPowerLimit);
            this.tabPagePower.Controls.Add(this.rtbPowerLimit);
            this.tabPagePower.Location = new System.Drawing.Point(4, 25);
            this.tabPagePower.Name = "tabPagePower";
            this.tabPagePower.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePower.Size = new System.Drawing.Size(297, 235);
            this.tabPagePower.TabIndex = 3;
            this.tabPagePower.Text = "Výkon";
            this.tabPagePower.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Puls (kWh)";
            // 
            // labelTarifInterval
            // 
            this.labelTarifInterval.AutoSize = true;
            this.labelTarifInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTarifInterval.Location = new System.Drawing.Point(3, 37);
            this.labelTarifInterval.Name = "labelTarifInterval";
            this.labelTarifInterval.Size = new System.Drawing.Size(67, 16);
            this.labelTarifInterval.TabIndex = 2;
            this.labelTarifInterval.Text = "Tarif (min)";
            // 
            // chart1
            // 
            chartArea2.CursorX.AutoScroll = false;
            chartArea2.CursorY.AutoScroll = false;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 93);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(291, 139);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // labelPowerLimit
            // 
            this.labelPowerLimit.AutoSize = true;
            this.labelPowerLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPowerLimit.Location = new System.Drawing.Point(3, 9);
            this.labelPowerLimit.Name = "labelPowerLimit";
            this.labelPowerLimit.Size = new System.Drawing.Size(168, 16);
            this.labelPowerLimit.TabIndex = 0;
            this.labelPowerLimit.Text = "Nasmlouvaný odběr (kWh)";
            // 
            // tabPageLimit1
            // 
            this.tabPageLimit1.Controls.Add(this.alarm1Ack);
            this.tabPageLimit1.Controls.Add(this.labelTrigger1Value);
            this.tabPageLimit1.Controls.Add(this.labelTrigger1Delay);
            this.tabPageLimit1.Controls.Add(this.tbTrigger1Value);
            this.tabPageLimit1.Controls.Add(this.tbTrigger1Delay);
            this.tabPageLimit1.Location = new System.Drawing.Point(4, 25);
            this.tabPageLimit1.Name = "tabPageLimit1";
            this.tabPageLimit1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLimit1.Size = new System.Drawing.Size(297, 235);
            this.tabPageLimit1.TabIndex = 0;
            this.tabPageLimit1.Text = "Alarm 1";
            this.tabPageLimit1.UseVisualStyleBackColor = true;
            // 
            // alarm1Ack
            // 
            this.alarm1Ack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm1Ack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarm1Ack.Location = new System.Drawing.Point(141, 62);
            this.alarm1Ack.Name = "alarm1Ack";
            this.alarm1Ack.Size = new System.Drawing.Size(150, 25);
            this.alarm1Ack.TabIndex = 6;
            this.alarm1Ack.Text = "Reset";
            this.alarm1Ack.UseVisualStyleBackColor = true;
            this.alarm1Ack.Click += new System.EventHandler(this.alarmAck_Click);
            // 
            // labelTrigger1Delay
            // 
            this.labelTrigger1Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrigger1Delay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTrigger1Delay.ImageList = this.imageList1;
            this.labelTrigger1Delay.Location = new System.Drawing.Point(3, 37);
            this.labelTrigger1Delay.Name = "labelTrigger1Delay";
            this.labelTrigger1Delay.Size = new System.Drawing.Size(183, 16);
            this.labelTrigger1Delay.TabIndex = 2;
            this.labelTrigger1Delay.Text = "Zpoždění varování (sek)";
            this.labelTrigger1Delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageLimit2
            // 
            this.tabPageLimit2.Controls.Add(this.alarm2Ack);
            this.tabPageLimit2.Controls.Add(this.labelTrigger2Value);
            this.tabPageLimit2.Controls.Add(this.labelTrigger2Delay);
            this.tabPageLimit2.Controls.Add(this.tbTrigger2Value);
            this.tabPageLimit2.Controls.Add(this.tbTrigger2Delay);
            this.tabPageLimit2.Location = new System.Drawing.Point(4, 25);
            this.tabPageLimit2.Name = "tabPageLimit2";
            this.tabPageLimit2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLimit2.Size = new System.Drawing.Size(297, 235);
            this.tabPageLimit2.TabIndex = 2;
            this.tabPageLimit2.Text = "Alarm 2";
            this.tabPageLimit2.UseVisualStyleBackColor = true;
            // 
            // alarm2Ack
            // 
            this.alarm2Ack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alarm2Ack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarm2Ack.Location = new System.Drawing.Point(141, 62);
            this.alarm2Ack.Name = "alarm2Ack";
            this.alarm2Ack.Size = new System.Drawing.Size(150, 25);
            this.alarm2Ack.TabIndex = 7;
            this.alarm2Ack.Text = "Reset";
            this.alarm2Ack.UseVisualStyleBackColor = true;
            this.alarm2Ack.Click += new System.EventHandler(this.alarmAck_Click);
            // 
            // labelTrigger2Value
            // 
            this.labelTrigger2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrigger2Value.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTrigger2Value.ImageList = this.imageList1;
            this.labelTrigger2Value.Location = new System.Drawing.Point(3, 9);
            this.labelTrigger2Value.Name = "labelTrigger2Value";
            this.labelTrigger2Value.Size = new System.Drawing.Size(183, 16);
            this.labelTrigger2Value.TabIndex = 0;
            this.labelTrigger2Value.Text = "Hodnota varování (kWh)";
            this.labelTrigger2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTrigger2Delay
            // 
            this.labelTrigger2Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrigger2Delay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTrigger2Delay.ImageList = this.imageList1;
            this.labelTrigger2Delay.Location = new System.Drawing.Point(3, 37);
            this.labelTrigger2Delay.Name = "labelTrigger2Delay";
            this.labelTrigger2Delay.Size = new System.Drawing.Size(183, 16);
            this.labelTrigger2Delay.TabIndex = 2;
            this.labelTrigger2Delay.Text = "Zpoždění varování (sek)";
            this.labelTrigger2Delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.checkBox1);
            this.tabPageConnection.Controls.Add(this.labelPlcTime);
            this.tabPageConnection.Controls.Add(this.label1);
            this.tabPageConnection.Controls.Add(this.label2);
            this.tabPageConnection.Controls.Add(this.label6);
            this.tabPageConnection.Controls.Add(this.label5);
            this.tabPageConnection.Controls.Add(this.label4);
            this.tabPageConnection.Controls.Add(this.label3);
            this.tabPageConnection.Controls.Add(this.textBox9);
            this.tabPageConnection.Controls.Add(this.textBox2);
            this.tabPageConnection.Controls.Add(this.textBox8);
            this.tabPageConnection.Controls.Add(this.textBox5);
            this.tabPageConnection.Controls.Add(this.textBox4);
            this.tabPageConnection.Controls.Add(this.textBox3);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 25);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(297, 235);
            this.tabPageConnection.TabIndex = 1;
            this.tabPageConnection.Text = "PLC";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Checked = global::EnMon.Properties.Settings.Default.AutoSetPlcTime;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EnMon.Properties.Settings.Default, "AutoSetPlcTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(182, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Auto set";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // labelPlcTime
            // 
            this.labelPlcTime.AutoSize = true;
            this.labelPlcTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlcTime.Location = new System.Drawing.Point(3, 177);
            this.labelPlcTime.Name = "labelPlcTime";
            this.labelPlcTime.Size = new System.Drawing.Size(61, 16);
            this.labelPlcTime.TabIndex = 13;
            this.labelPlcTime.Text = "PLC time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remote port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remote IP address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dest. station no.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Source station no.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLC port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLC IP address";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVIRemoteIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox9.Location = new System.Drawing.Point(182, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(107, 22);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = global::EnMon.Properties.Settings.Default.PVIRemoteIP;
            this.textBox9.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVILocalIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(182, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = global::EnMon.Properties.Settings.Default.PVILocalIP;
            this.textBox2.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.statusLabelCpuState,
            this.statusLabelCpuRuntime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(305, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // statusLabelCpuState
            // 
            this.statusLabelCpuState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.statusLabelCpuState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabelCpuState.Name = "statusLabelCpuState";
            this.statusLabelCpuState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabelCpuState.Size = new System.Drawing.Size(34, 19);
            this.statusLabelCpuState.Text = "CPU";
            // 
            // statusLabelCpuRuntime
            // 
            this.statusLabelCpuRuntime.Name = "statusLabelCpuRuntime";
            this.statusLabelCpuRuntime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusLabelCpuRuntime.Size = new System.Drawing.Size(20, 19);
            this.statusLabelCpuRuntime.Text = "RT";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Odběr";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Size = new System.Drawing.Size(305, 31);
            this.panel1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(219, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(189, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Max";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(79, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Size = new System.Drawing.Size(305, 31);
            this.panel2.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(219, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "?";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.ImageList = this.imageList1;
            this.label15.Location = new System.Drawing.Point(189, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tarif";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(79, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "?";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.ImageList = this.imageList1;
            this.label13.Location = new System.Drawing.Point(4, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Odebráno";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 31);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 4);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Value = 50;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar2.Location = new System.Drawing.Point(0, 66);
            this.progressBar2.MarqueeAnimationSpeed = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(305, 4);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 18;
            this.progressBar2.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbPowerFactor
            // 
            this.rtbPowerFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPowerFactor.Location = new System.Drawing.Point(222, 62);
            this.rtbPowerFactor.Name = "rtbPowerFactor";
            this.rtbPowerFactor.RegexString = "[-+]?[0-9]*\\.?[0-9]+";
            this.rtbPowerFactor.Size = new System.Drawing.Size(69, 22);
            this.rtbPowerFactor.TabIndex = 5;
            this.rtbPowerFactor.Text = "0.01";
            this.rtbPowerFactor.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // rtbTarifInterval
            // 
            this.rtbTarifInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTarifInterval.Location = new System.Drawing.Point(222, 34);
            this.rtbTarifInterval.Name = "rtbTarifInterval";
            this.rtbTarifInterval.RegexString = "^[0-9]+$";
            this.rtbTarifInterval.Size = new System.Drawing.Size(69, 22);
            this.rtbTarifInterval.TabIndex = 3;
            this.rtbTarifInterval.Text = "15";
            this.rtbTarifInterval.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // rtbPowerLimit
            // 
            this.rtbPowerLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPowerLimit.Location = new System.Drawing.Point(222, 6);
            this.rtbPowerLimit.Name = "rtbPowerLimit";
            this.rtbPowerLimit.RegexString = "^[0-9]+$";
            this.rtbPowerLimit.Size = new System.Drawing.Size(69, 22);
            this.rtbPowerLimit.TabIndex = 1;
            this.rtbPowerLimit.Text = "160";
            this.rtbPowerLimit.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // tbTrigger1Value
            // 
            this.tbTrigger1Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrigger1Value.Location = new System.Drawing.Point(222, 6);
            this.tbTrigger1Value.Name = "tbTrigger1Value";
            this.tbTrigger1Value.RegexString = "^[0-9]+$";
            this.tbTrigger1Value.Size = new System.Drawing.Size(69, 22);
            this.tbTrigger1Value.TabIndex = 1;
            this.tbTrigger1Value.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // tbTrigger1Delay
            // 
            this.tbTrigger1Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrigger1Delay.Location = new System.Drawing.Point(222, 34);
            this.tbTrigger1Delay.Name = "tbTrigger1Delay";
            this.tbTrigger1Delay.RegexString = "^[0-9]+$";
            this.tbTrigger1Delay.Size = new System.Drawing.Size(69, 22);
            this.tbTrigger1Delay.TabIndex = 3;
            this.tbTrigger1Delay.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // tbTrigger2Value
            // 
            this.tbTrigger2Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrigger2Value.Location = new System.Drawing.Point(222, 6);
            this.tbTrigger2Value.Name = "tbTrigger2Value";
            this.tbTrigger2Value.RegexString = "^[0-9]+$";
            this.tbTrigger2Value.Size = new System.Drawing.Size(69, 22);
            this.tbTrigger2Value.TabIndex = 1;
            this.tbTrigger2Value.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // tbTrigger2Delay
            // 
            this.tbTrigger2Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrigger2Delay.Location = new System.Drawing.Point(222, 34);
            this.tbTrigger2Delay.Name = "tbTrigger2Delay";
            this.tbTrigger2Delay.RegexString = "^[0-9]+$";
            this.tbTrigger2Delay.Size = new System.Drawing.Size(69, 22);
            this.tbTrigger2Delay.TabIndex = 3;
            this.tbTrigger2Delay.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVIRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox8.Location = new System.Drawing.Point(182, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.RegexString = "^[0-9]+$";
            this.textBox8.Size = new System.Drawing.Size(107, 22);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = global::EnMon.Properties.Settings.Default.PVIRemotePort;
            this.textBox8.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVIDestStation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(182, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.RegexString = "^[0-9]+$";
            this.textBox5.Size = new System.Drawing.Size(107, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = global::EnMon.Properties.Settings.Default.PVIDestStation;
            this.textBox5.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVISrcStation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Location = new System.Drawing.Point(182, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.RegexString = "^[0-9]+$";
            this.textBox4.Size = new System.Drawing.Size(107, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = global::EnMon.Properties.Settings.Default.PVISrcStation;
            this.textBox4.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EnMon.Properties.Settings.Default, "PVILocalPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(182, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.RegexString = "^[0-9]+$";
            this.textBox3.Size = new System.Drawing.Size(107, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = global::EnMon.Properties.Settings.Default.PVILocalPort;
            this.textBox3.TextChanged += new System.EventHandler(this.editValue_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 397);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 380);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnMon";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePower.ResumeLayout(false);
            this.tabPagePower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageLimit1.ResumeLayout(false);
            this.tabPageLimit1.PerformLayout();
            this.tabPageLimit2.ResumeLayout(false);
            this.tabPageLimit2.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTrigger1Value;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLimit1;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private RegexTextBox textBox3;
        private RegexTextBox textBox5;
        private System.Windows.Forms.Label label6;
        private RegexTextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelCpuState;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelCpuRuntime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label labelTrigger1Delay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private RegexTextBox tbTrigger1Value;
        private RegexTextBox tbTrigger1Delay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RegexTextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TabPage tabPageLimit2;
        private System.Windows.Forms.Label labelTrigger2Value;
        private System.Windows.Forms.Label labelTrigger2Delay;
        private RegexTextBox tbTrigger2Value;
        private RegexTextBox tbTrigger2Delay;
        private System.Windows.Forms.Button alarm1Ack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button alarm2Ack;
        private System.Windows.Forms.TabPage tabPagePower;
        private System.Windows.Forms.Label labelPowerLimit;
        private RegexTextBox rtbPowerLimit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelTarifInterval;
        private RegexTextBox rtbTarifInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPlcTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private RegexTextBox rtbPowerFactor;
    }
}

