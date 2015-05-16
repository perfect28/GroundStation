namespace OurProject
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axles3D1 = new MyGLControl.Axles3D();
            this.yaw_label = new System.Windows.Forms.Label();
            this.pit_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rol_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lable_byte_sum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable_sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbChr = new System.Windows.Forms.RadioButton();
            this.rtbTerminal = new System.Windows.Forms.RichTextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnSetPID = new System.Windows.Forms.Button();
            this.btn_state = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.comport = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axles3D1);
            this.groupBox1.Controls.Add(this.yaw_label);
            this.groupBox1.Controls.Add(this.pit_label);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rol_label);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "三维姿态";
            // 
            // axles3D1
            // 
            this.axles3D1.AngleX = 0D;
            this.axles3D1.AngleY = 30D;
            this.axles3D1.AngleZ = -30D;
            this.axles3D1.Azimuth = 0D;
            this.axles3D1.BackColor = System.Drawing.Color.Black;
            this.axles3D1.Elevation = 0D;
            this.axles3D1.Location = new System.Drawing.Point(17, 20);
            this.axles3D1.Name = "axles3D1";
            this.axles3D1.Size = new System.Drawing.Size(256, 236);
            this.axles3D1.TabIndex = 15;
            this.axles3D1.VSync = false;
            // 
            // yaw_label
            // 
            this.yaw_label.AutoSize = true;
            this.yaw_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yaw_label.ForeColor = System.Drawing.Color.Lime;
            this.yaw_label.Location = new System.Drawing.Point(289, 139);
            this.yaw_label.Name = "yaw_label";
            this.yaw_label.Size = new System.Drawing.Size(17, 16);
            this.yaw_label.TabIndex = 14;
            this.yaw_label.Text = "0";
            // 
            // pit_label
            // 
            this.pit_label.AutoSize = true;
            this.pit_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pit_label.ForeColor = System.Drawing.Color.Blue;
            this.pit_label.Location = new System.Drawing.Point(290, 92);
            this.pit_label.Name = "pit_label";
            this.pit_label.Size = new System.Drawing.Size(17, 16);
            this.pit_label.TabIndex = 13;
            this.pit_label.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "偏航角:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "横滚角:";
            // 
            // rol_label
            // 
            this.rol_label.AutoSize = true;
            this.rol_label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rol_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rol_label.Location = new System.Drawing.Point(290, 48);
            this.rol_label.Name = "rol_label";
            this.rol_label.Size = new System.Drawing.Size(17, 16);
            this.rol_label.TabIndex = 10;
            this.rol_label.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "俯仰角:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lable_byte_sum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lable_sum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.gbPortSettings);
            this.groupBox2.Controls.Add(this.btnOpenPort);
            this.groupBox2.Controls.Add(this.gbMode);
            this.groupBox2.Controls.Add(this.rtbTerminal);
            this.groupBox2.Controls.Add(this.lblSend);
            this.groupBox2.Controls.Add(this.txtSendData);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(399, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 450);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据输出";
            // 
            // lable_byte_sum
            // 
            this.lable_byte_sum.AccessibleDescription = "";
            this.lable_byte_sum.AutoSize = true;
            this.lable_byte_sum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_byte_sum.Location = new System.Drawing.Point(235, 290);
            this.lable_byte_sum.Name = "lable_byte_sum";
            this.lable_byte_sum.Size = new System.Drawing.Size(63, 14);
            this.lable_byte_sum.TabIndex = 27;
            this.lable_byte_sum.Text = "已收到：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(166, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "总字节数";
            // 
            // lable_sum
            // 
            this.lable_sum.AutoSize = true;
            this.lable_sum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_sum.Location = new System.Drawing.Point(82, 290);
            this.lable_sum.Name = "lable_sum";
            this.lable_sum.Size = new System.Drawing.Size(63, 14);
            this.lable_sum.TabIndex = 25;
            this.lable_sum.Text = "已收到：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "总帧数";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(461, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 22);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.cmbPortName);
            this.gbPortSettings.Controls.Add(this.cmbBaudRate);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Location = new System.Drawing.Point(19, 351);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(307, 75);
            this.gbPortSettings.TabIndex = 19;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "串口设置";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 27);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(47, 12);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "端口号:";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbPortName.Location = new System.Drawing.Point(65, 25);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(67, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(220, 24);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(61, 20);
            this.cmbBaudRate.TabIndex = 3;
            this.cmbBaudRate.Text = "115200";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(167, 28);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(47, 12);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "波特率:";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPort.Location = new System.Drawing.Point(419, 361);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(75, 60);
            this.btnOpenPort.TabIndex = 21;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // gbMode
            // 
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Controls.Add(this.rbChr);
            this.gbMode.Location = new System.Drawing.Point(332, 351);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(75, 71);
            this.gbMode.TabIndex = 20;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "模式";
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(19, 20);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(41, 16);
            this.rbHex.TabIndex = 2;
            this.rbHex.Text = "HEX";
            // 
            // rbChr
            // 
            this.rbChr.AutoSize = true;
            this.rbChr.Location = new System.Drawing.Point(19, 42);
            this.rbChr.Name = "rbChr";
            this.rbChr.Size = new System.Drawing.Size(41, 16);
            this.rbChr.TabIndex = 0;
            this.rbChr.Text = "CHR";
            // 
            // rtbTerminal
            // 
            this.rtbTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTerminal.Location = new System.Drawing.Point(19, 20);
            this.rtbTerminal.Name = "rtbTerminal";
            this.rtbTerminal.Size = new System.Drawing.Size(493, 254);
            this.rtbTerminal.TabIndex = 15;
            this.rtbTerminal.Text = "";
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(25, 326);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(53, 12);
            this.lblSend.TabIndex = 16;
            this.lblSend.Text = "发送数据";
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(84, 323);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(307, 21);
            this.txtSendData.TabIndex = 17;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(399, 323);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(52, 22);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(72, 370);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(106, 51);
            this.btnWave.TabIndex = 18;
            this.btnWave.Text = "打开波形图";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(223, 369);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(96, 52);
            this.btnMap.TabIndex = 19;
            this.btnMap.Text = "打开地图";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnSetPID
            // 
            this.btnSetPID.Location = new System.Drawing.Point(72, 302);
            this.btnSetPID.Name = "btnSetPID";
            this.btnSetPID.Size = new System.Drawing.Size(106, 48);
            this.btnSetPID.TabIndex = 23;
            this.btnSetPID.Text = "设置PID";
            this.btnSetPID.UseVisualStyleBackColor = true;
            this.btnSetPID.Click += new System.EventHandler(this.btnSetPID_Click);
            // 
            // btn_state
            // 
            this.btn_state.Location = new System.Drawing.Point(223, 302);
            this.btn_state.Name = "btn_state";
            this.btn_state.Size = new System.Drawing.Size(96, 48);
            this.btn_state.TabIndex = 24;
            this.btn_state.Text = "飞机状态";
            this.btn_state.UseVisualStyleBackColor = true;
            this.btn_state.Click += new System.EventHandler(this.btn_state_Click);
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 474);
            this.Controls.Add(this.btn_state);
            this.Controls.Add(this.btnSetPID);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnWave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "HW_31";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yaw_label;
        private System.Windows.Forms.Label pit_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label rol_label;
        private System.Windows.Forms.Label label11;
        private MyGLControl.Axles3D axles3D1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbChr;
        private System.Windows.Forms.RichTextBox rtbTerminal;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnWave;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnSetPID;
        private System.Windows.Forms.Button btn_state;
        private System.Windows.Forms.Label lable_sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_byte_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer main_timer;
        public System.IO.Ports.SerialPort comport;
    }
}

