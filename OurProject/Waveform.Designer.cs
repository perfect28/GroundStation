namespace OurProject
{
    partial class Waveform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_accx = new System.Windows.Forms.CheckBox();
            this.cb_accy = new System.Windows.Forms.CheckBox();
            this.cb_accz = new System.Windows.Forms.CheckBox();
            this.cb_gyrz = new System.Windows.Forms.CheckBox();
            this.cb_gyry = new System.Windows.Forms.CheckBox();
            this.cb_gyrx = new System.Windows.Forms.CheckBox();
            this.cb_yaw = new System.Windows.Forms.CheckBox();
            this.cb_pit = new System.Windows.Forms.CheckBox();
            this.cb_rol = new System.Windows.Forms.CheckBox();
            this.cb_magz = new System.Windows.Forms.CheckBox();
            this.cb_magy = new System.Windows.Forms.CheckBox();
            this.cb_magx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(649, 389);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cb_accx
            // 
            this.cb_accx.AutoSize = true;
            this.cb_accx.Location = new System.Drawing.Point(29, 26);
            this.cb_accx.Name = "cb_accx";
            this.cb_accx.Size = new System.Drawing.Size(54, 16);
            this.cb_accx.TabIndex = 13;
            this.cb_accx.Text = "ACC-X";
            this.cb_accx.UseVisualStyleBackColor = true;
            this.cb_accx.CheckedChanged += new System.EventHandler(this.cb_accx_CheckedChanged);
            // 
            // cb_accy
            // 
            this.cb_accy.AutoSize = true;
            this.cb_accy.Location = new System.Drawing.Point(29, 48);
            this.cb_accy.Name = "cb_accy";
            this.cb_accy.Size = new System.Drawing.Size(54, 16);
            this.cb_accy.TabIndex = 14;
            this.cb_accy.Text = "ACC-Y";
            this.cb_accy.UseVisualStyleBackColor = true;
            this.cb_accy.CheckedChanged += new System.EventHandler(this.cb_accy_CheckedChanged);
            // 
            // cb_accz
            // 
            this.cb_accz.AutoSize = true;
            this.cb_accz.Location = new System.Drawing.Point(29, 70);
            this.cb_accz.Name = "cb_accz";
            this.cb_accz.Size = new System.Drawing.Size(54, 16);
            this.cb_accz.TabIndex = 15;
            this.cb_accz.Text = "ACC-Z";
            this.cb_accz.UseVisualStyleBackColor = true;
            this.cb_accz.CheckedChanged += new System.EventHandler(this.cb_accz_CheckedChanged);
            // 
            // cb_gyrz
            // 
            this.cb_gyrz.AutoSize = true;
            this.cb_gyrz.Location = new System.Drawing.Point(29, 148);
            this.cb_gyrz.Name = "cb_gyrz";
            this.cb_gyrz.Size = new System.Drawing.Size(54, 16);
            this.cb_gyrz.TabIndex = 18;
            this.cb_gyrz.Text = "GYR-Z";
            this.cb_gyrz.UseVisualStyleBackColor = true;
            this.cb_gyrz.CheckedChanged += new System.EventHandler(this.cb_gyrz_CheckedChanged);
            // 
            // cb_gyry
            // 
            this.cb_gyry.AutoSize = true;
            this.cb_gyry.Location = new System.Drawing.Point(29, 126);
            this.cb_gyry.Name = "cb_gyry";
            this.cb_gyry.Size = new System.Drawing.Size(54, 16);
            this.cb_gyry.TabIndex = 17;
            this.cb_gyry.Text = "GYR-Y";
            this.cb_gyry.UseVisualStyleBackColor = true;
            this.cb_gyry.CheckedChanged += new System.EventHandler(this.cb_gyry_CheckedChanged);
            // 
            // cb_gyrx
            // 
            this.cb_gyrx.AutoSize = true;
            this.cb_gyrx.Location = new System.Drawing.Point(29, 104);
            this.cb_gyrx.Name = "cb_gyrx";
            this.cb_gyrx.Size = new System.Drawing.Size(54, 16);
            this.cb_gyrx.TabIndex = 16;
            this.cb_gyrx.Text = "GYR-X";
            this.cb_gyrx.UseVisualStyleBackColor = true;
            this.cb_gyrx.CheckedChanged += new System.EventHandler(this.cb_gyrx_CheckedChanged);
            // 
            // cb_yaw
            // 
            this.cb_yaw.AutoSize = true;
            this.cb_yaw.Location = new System.Drawing.Point(29, 308);
            this.cb_yaw.Name = "cb_yaw";
            this.cb_yaw.Size = new System.Drawing.Size(78, 16);
            this.cb_yaw.TabIndex = 24;
            this.cb_yaw.Text = "Angle_YAW";
            this.cb_yaw.UseVisualStyleBackColor = true;
            this.cb_yaw.CheckedChanged += new System.EventHandler(this.cb_yaw_CheckedChanged);
            // 
            // cb_pit
            // 
            this.cb_pit.AutoSize = true;
            this.cb_pit.Location = new System.Drawing.Point(29, 286);
            this.cb_pit.Name = "cb_pit";
            this.cb_pit.Size = new System.Drawing.Size(78, 16);
            this.cb_pit.TabIndex = 23;
            this.cb_pit.Text = "Angle_PIT";
            this.cb_pit.UseVisualStyleBackColor = true;
            this.cb_pit.CheckedChanged += new System.EventHandler(this.cb_pit_CheckedChanged);
            // 
            // cb_rol
            // 
            this.cb_rol.AutoSize = true;
            this.cb_rol.Location = new System.Drawing.Point(29, 264);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(78, 16);
            this.cb_rol.TabIndex = 22;
            this.cb_rol.Text = "Angle-ROL";
            this.cb_rol.UseVisualStyleBackColor = true;
            this.cb_rol.CheckedChanged += new System.EventHandler(this.cb_rol_CheckedChanged);
            // 
            // cb_magz
            // 
            this.cb_magz.AutoSize = true;
            this.cb_magz.Location = new System.Drawing.Point(29, 227);
            this.cb_magz.Name = "cb_magz";
            this.cb_magz.Size = new System.Drawing.Size(54, 16);
            this.cb_magz.TabIndex = 21;
            this.cb_magz.Text = "MAG-Z";
            this.cb_magz.UseVisualStyleBackColor = true;
            this.cb_magz.CheckedChanged += new System.EventHandler(this.cb_magz_CheckedChanged);
            // 
            // cb_magy
            // 
            this.cb_magy.AutoSize = true;
            this.cb_magy.Location = new System.Drawing.Point(29, 205);
            this.cb_magy.Name = "cb_magy";
            this.cb_magy.Size = new System.Drawing.Size(54, 16);
            this.cb_magy.TabIndex = 20;
            this.cb_magy.Text = "MAG-Y";
            this.cb_magy.UseVisualStyleBackColor = true;
            this.cb_magy.CheckedChanged += new System.EventHandler(this.cb_magy_CheckedChanged);
            // 
            // cb_magx
            // 
            this.cb_magx.AutoSize = true;
            this.cb_magx.Location = new System.Drawing.Point(29, 183);
            this.cb_magx.Name = "cb_magx";
            this.cb_magx.Size = new System.Drawing.Size(54, 16);
            this.cb_magx.TabIndex = 19;
            this.cb_magx.Text = "MAG-X";
            this.cb_magx.UseVisualStyleBackColor = true;
            this.cb_magx.CheckedChanged += new System.EventHandler(this.cb_magx_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_accx);
            this.groupBox1.Controls.Add(this.cb_yaw);
            this.groupBox1.Controls.Add(this.cb_accy);
            this.groupBox1.Controls.Add(this.cb_pit);
            this.groupBox1.Controls.Add(this.cb_accz);
            this.groupBox1.Controls.Add(this.cb_rol);
            this.groupBox1.Controls.Add(this.cb_gyrx);
            this.groupBox1.Controls.Add(this.cb_magz);
            this.groupBox1.Controls.Add(this.cb_gyry);
            this.groupBox1.Controls.Add(this.cb_magy);
            this.groupBox1.Controls.Add(this.cb_gyrz);
            this.groupBox1.Controls.Add(this.cb_magx);
            this.groupBox1.Location = new System.Drawing.Point(658, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 336);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据选择";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(687, 359);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Waveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Waveform";
            this.Text = "Waveform";
            this.Load += new System.EventHandler(this.Waveform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_accx;
        private System.Windows.Forms.CheckBox cb_accy;
        private System.Windows.Forms.CheckBox cb_accz;
        private System.Windows.Forms.CheckBox cb_gyrz;
        private System.Windows.Forms.CheckBox cb_gyry;
        private System.Windows.Forms.CheckBox cb_gyrx;
        private System.Windows.Forms.CheckBox cb_yaw;
        private System.Windows.Forms.CheckBox cb_pit;
        private System.Windows.Forms.CheckBox cb_rol;
        private System.Windows.Forms.CheckBox cb_magz;
        private System.Windows.Forms.CheckBox cb_magy;
        private System.Windows.Forms.CheckBox cb_magx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}