namespace OurProject
{
    partial class Statu
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
            this.altimeterInstrumentControl1 = new AvionicsInstrumentControlDemo.AltimeterInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl1 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.verticalSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl();
            this.airSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // altimeterInstrumentControl1
            // 
            this.altimeterInstrumentControl1.Location = new System.Drawing.Point(22, 20);
            this.altimeterInstrumentControl1.Name = "altimeterInstrumentControl1";
            this.altimeterInstrumentControl1.Size = new System.Drawing.Size(124, 127);
            this.altimeterInstrumentControl1.TabIndex = 0;
            this.altimeterInstrumentControl1.Text = "altimeterInstrumentControl1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(20, 20);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(125, 127);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 2;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(162, 20);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(126, 127);
            this.headingIndicatorInstrumentControl1.TabIndex = 3;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // turnCoordinatorInstrumentControl1
            // 
            this.turnCoordinatorInstrumentControl1.Location = new System.Drawing.Point(20, 17);
            this.turnCoordinatorInstrumentControl1.Name = "turnCoordinatorInstrumentControl1";
            this.turnCoordinatorInstrumentControl1.Size = new System.Drawing.Size(126, 132);
            this.turnCoordinatorInstrumentControl1.TabIndex = 4;
            this.turnCoordinatorInstrumentControl1.Text = "turnCoordinatorInstrumentControl1";
            // 
            // verticalSpeedIndicatorInstrumentControl1
            // 
            this.verticalSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(11, 15);
            this.verticalSpeedIndicatorInstrumentControl1.Name = "verticalSpeedIndicatorInstrumentControl1";
            this.verticalSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(126, 126);
            this.verticalSpeedIndicatorInstrumentControl1.TabIndex = 5;
            this.verticalSpeedIndicatorInstrumentControl1.Text = "verticalSpeedIndicatorInstrumentControl1";
            // 
            // airSpeedIndicatorInstrumentControl1
            // 
            this.airSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(18, 17);
            this.airSpeedIndicatorInstrumentControl1.Name = "airSpeedIndicatorInstrumentControl1";
            this.airSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(125, 127);
            this.airSpeedIndicatorInstrumentControl1.TabIndex = 6;
            this.airSpeedIndicatorInstrumentControl1.Text = "airSpeedIndicatorInstrumentControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.altimeterInstrumentControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高度仪";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.groupBox2.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 159);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "姿态角";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.turnCoordinatorInstrumentControl1);
            this.groupBox3.Location = new System.Drawing.Point(12, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "转弯协调指示器";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.airSpeedIndicatorInstrumentControl1);
            this.groupBox4.Location = new System.Drawing.Point(183, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 155);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "空气速度计";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.verticalSpeedIndicatorInstrumentControl1);
            this.groupBox5.Location = new System.Drawing.Point(352, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 153);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "垂直速度计";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(414, 338);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // Statu
            // 
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statu";
            this.Text = "Statu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public AvionicsInstrumentControlDemo.AltimeterInstrumentControl altimeterInstrumentControl1;
        public AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        public AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        public AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl turnCoordinatorInstrumentControl1;
        public AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl verticalSpeedIndicatorInstrumentControl1;
        public AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl airSpeedIndicatorInstrumentControl1;
        private System.Windows.Forms.Button btn_exit;
    }
}