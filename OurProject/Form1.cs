using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject
{

    public enum DataMode { Char, Hex };
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

   
    public partial class Form1 : Form
    {
        public static int NUM = 200;
        //public static SerialPort comport = new SerialPort();
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public static int pid_num = 0;//表示波形图X轴坐标

        short thr,alt;
        short acc_x, acc_y, acc_z;
        short gyr_x, gyr_y, gyr_z;
        short mag_x, mag_y, mag_z;
        short tel_rol, tel_pit, tel_yaw;
        int mot1, mot2, mot3, mot4;
        short aux1, aux2, aux3, aux4, aux5, aux6;
        float lat, lng;

        /// <summary>
        /// 准备关闭串口=true
        /// </summary>
        private bool m_IsTryToClosePort = false;
        /// <summary>
        /// true表示正在接收数据
        /// </summary>
        private bool m_IsReceiving = false;

        SettingPID settingPID = new SettingPID();
        Waveform waveform = new Waveform();
        MapNav mapNav = new MapNav();
        Statu statu = new Statu();
        DataRow row;

        private float rol;

        public float Rol//横滚 angleZ
        {
          get { return rol; }
          set { 
              rol = value;
          }
        }

        private float pit;

        public float Pit//俯仰 angleX
        {
            get { return pit; }
            set { 
                pit = value;
            }
        }

        private float yaw;

        public float Yaw//航向 angleY
        {
            get { return yaw; }
            set {
                yaw = value;             
            }
        }

        private DataMode CurrentDataMode
        {
            get
            {
                if (rbHex.Checked)
                    return DataMode.Hex;
                else 
                    return DataMode.Char;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Restore the users settings
            InitializeControlValues();

            // Enable/disable controls based on the current state
            EnableControls();

            // When data is recieved through the port, call this method
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }


        private void InitializeControlValues()
        {
            cmbPortName.Items.Clear();
            /*
            foreach (string s in SerialPort.GetPortNames())
                cmbPortName.Items.Add(s);
            */
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cmbPortName.Items.AddRange(ports);
            
            if (cmbPortName.Items.Count > 0)
                cmbPortName.SelectedIndex = 0;
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            rbHex.Checked = true;     
        }

        private void EnableControls()
        {
            //端口groupbox设置
            gbPortSettings.Enabled = !comport.IsOpen;
            
            //发送框textbox及发送按钮button设置
            txtSendData.Enabled = btnSend.Enabled = comport.IsOpen;

            if (comport.IsOpen)
                btnOpenPort.Text = "Close Port";
            else
                btnOpenPort.Text = "Open Port";
        }


        short ByteToDecimal(byte b1,byte b2)
        {
            return (short)Convert.ToDecimal((short)((b1 << 8 )| b2));
        }

        int map_times = 0;
        int data_num = 0;//上次未处理数据长度
        int sum_num = 0;//总帧数
        int sum_byte = 0;//总字节数
        byte[] buffer = new byte[50000];//存放上次未处理数据
        byte sum;//校验和  
        byte[] show_buffer;//显示内容
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (m_IsTryToClosePort) // 关键！！！
            {
                return;
            }
            try
            {
                m_IsReceiving = true; // 关键!!!

                if (CurrentDataMode == DataMode.Char)//收到的数据是字符串
                {
                    string data = comport.ReadExisting();
                    Log(LogMsgType.Incoming, data);
                }
                else if (CurrentDataMode == DataMode.Hex)//收到的数据是16进制
                {
                    /*
                     * 接收目前有4种功能字：
                     * 01：AAAA 01 XX(LEN) XXXX(ROL*100) XXXX(PIT*100) XXXX(YAW*100) XX(SUM)
                     * 02: AAAA 02 XX(LEN) XXXX(ACC_X) XXXX(ACC_Y) XXXX(ACC_Z) XXXX(GYR_X) XXXX(GYR_Y) XXXX(GYR_Z) XXXX(MAG_X) XXXX(MAG_Y) XXXX(MAG_Z) XX(SUM)
                     * 03: AAAA 03 XX(LEN) XXXX(THR) XXXX(YAW) XXXX(ROL) XXXX(PIT) XXXX(AUX1) XXXX(AUX2) XXXX(AUX3) XXXX(AUX4) XXXX(AUX5) XXXX(AUX6) XX(SUM)
                     * 04: AAAA 04 XX(LEN) XXXXXXXX(LAT) XXXXXXXX(LNG) XX(SUM)
                     */

                    /*
                     * 
                    接收数据：AAAA 01 0A FFEF 003F FFFF FFFF 0016 9E
                    接收数据：AAAA 02 12 002C 0000 0F92 FFF6 FFDB FFD0 0000 0000 0000 D3
                 
                    接收数据：AAAA 01 0A 0043 FF56 165A 0000 0000 67
                    接收数据：AAAA 02 0C 0006 FF4A 4402 0000 FFFE FFFF F2
                    接收数据：AAAA 03 0C 0000 0000 0000 0000 0000 0000 63
                    接收数据：AAAA 06 08 FFFF FFFF FFFF FFFF 5A
                    */

                    /**
                     *  AAAA 01 0A 0030 FF4B 1432 0000 0000 1F
                        AAAA 02 0C FD9E 0094 4098 FFFE FFEF FDDD 2E
                        AAAA 03 0C 0000 0000 0000 0000 0000 0000 63
                        AAAA 06 08 FFFF FFFF FFFF FFFF 5A
                     * 
                     *  
                     */

                    int _frame_num = 0; // 接收帧在frame数组里的索引
                    int _frame_len = 0; // 帧长度

 
                    int n = comport.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致 
                    sum_byte += n;

                    if (n > 20000) return;
                    comport.Read(buffer, data_num, n);
                    data_num += n;
                    //Log(LogMsgType.Incoming, "接收数据：" + ByteArrayToHexString(buffer,data_num));
                    int I = 0;
                    //bool flag = false;//是否跳下一帧
                    while (I < data_num - 4)//遍历数据
                    {
                        //if (m_IsTryToClosePort) data_num = 0;
                        if ((buffer[I] == 0xAA) && (buffer[I + 1] == 0xAA))//来自飞控板的数据
                        {
                            _frame_num = buffer[I + 2];
                            _frame_len = buffer[I + 3];

                            // 01 02 03 04
                            // AA AA 01 LEN (FRAME) SUM
                            
                            if ((data_num - I - 5) > _frame_len) //缓冲区还有完整帧
                            {
                                sum = 0;

                                show_buffer = new byte[5 + _frame_len];
                                lock (show_buffer)
                                {  
                                    for (int k = I; k <= I + 4 + _frame_len; k++)
                                        show_buffer[k - I] = buffer[k];
                                }
                                
                                
                                for (int k = I; k <= I + 3 + _frame_len; k++)
                                    sum += buffer[k];
                                if (sum == buffer[I + 4 + _frame_len])
                                {
                                    sum_num++;
                                    //绝对不能直接在这里去显示，串口接收速率慢一倍不止，会卡数据显示！！
                                    //调用invoke方法效率实在是太差！
                                    switch (_frame_num)
                                    {
                                        case 1://Status
                                            Status(I, row);
                                            break;
                                        case 2://Sensor Data
                                            Sensor(I, row);
                                            break;
                                        case 3://Telecontrol Data
                                            TeleControl(I);
                                            break;
                                        case 4://Coordinate
                                            //04: AAAA 04 XX(LEN) XXXXXXXX(LAT) XXXXXXXX(LNG) XX(SUM)
                                            lat = (float)Convert.ToDecimal((int)((buffer[4] << 24) | (buffer[5] << 16) | (buffer[6] << 8) | (buffer[7])));
                                            lng = (float)Convert.ToDecimal((int)((buffer[8] << 24) | (buffer[9] << 16) | (buffer[10] << 8) | (buffer[11])));

                                            lat = lat / 10000000;
                                            lng = lng / 10000000;
                                            map_times++;
                                            break;

                                        case 6://PWM
                                            PWM(I);
                                            break;
                                        default:
                                            //Log(LogMsgType.Error, "不识别功能字");
                                            break;
                                    }//switch
                                    I = I + 5 + _frame_len; // I指向下一帧数据
                                }//通过校验和
                                else//sum校验未通过
                                {
                                    I++;
                                }
                            }//还有完整帧
                            else//HEAD FUN LEN符合要求,但是数据未接收完毕
                            {
                                for (int j = I; j <= data_num - 1; j++)
                                {
                                    buffer[j - I] = buffer[j];
                                }
                                data_num = data_num - I;
                                return;
                            }
                        }//帧头匹配
                        else//HEAD FUN LEN 不符合要求
                        {
                            I++;
                        }
                    }//遍历数据
                    if (I < data_num) // 剩几字节没有处理完
                    {
                        for (int j = I; j <= data_num - 1; j++)
                        {
                            buffer[j - I] = buffer[j];
                        }
                        data_num = data_num - I;
                    }
                }
            }
            finally
            {
                m_IsReceiving = false; 
            }
            
        }

        private void PWM(int I)
        {
            mot1 = (int)ByteToDecimal(buffer[I + 4], buffer[I + 5]);
            mot2 = (int)ByteToDecimal(buffer[I + 6], buffer[I + 7]);
            mot3 = (int)ByteToDecimal(buffer[I + 8], buffer[I + 9]);
            mot4 = (int)ByteToDecimal(buffer[I + 10], buffer[I + 10]);
        }

        private void TeleControl(int I)
        {
 	        //03: AAAA 03 XX(LEN) XXXX(THR) XXXX(YAW) XXXX(ROL) XXXX(PIT) XXXX(AUX1) XXXX(AUX2) XXXX(AUX3) XXXX(AUX4) XXXX(AUX5) XXXX(AUX6) XX(SUM)
            //AAAA 03 0C 03E8 05DA 05DC 05DC 0000 0000 EF
            thr = ByteToDecimal(buffer[I + 4], buffer[I + 5]);
            if (thr < 1000) thr = 1000;
            if (thr > 2000) thr = 2000;
            /*
            throttle.Invoke(new EventHandler(delegate
            {
                throttle.Value = thr;
            }));
            */
            tel_yaw = ByteToDecimal(buffer[I + 6], buffer[I + 7]);
            tel_rol = ByteToDecimal(buffer[I + 8], buffer[I + 9]);
            tel_pit = ByteToDecimal(buffer[I + 10], buffer[I + 11]);
            if (tel_yaw < 1000)
                tel_yaw = 1000;
            if (tel_yaw > 2000)
                tel_yaw = 2000;

            if (tel_rol < 1000)
                tel_rol = 1000;
            if (tel_rol > 2000)
                tel_rol = 2000;

            if (tel_pit < 1000)
                tel_pit = 1000;
            if (tel_pit > 2000)
                tel_pit = 2000;

            aux1 = ByteToDecimal(buffer[I + 12], buffer[I + 13]);
            aux2 = ByteToDecimal(buffer[I + 14], buffer[I + 15]);
            //aux3 = ByteToDecimal(buffer[I + 16], buffer[I + 17]);
            //aux4 = ByteToDecimal(buffer[I + 18], buffer[I + 19]);
            //aux5 = ByteToDecimal(buffer[I + 20], buffer[I + 21]);
            //aux6 = ByteToDecimal(buffer[I + 22], buffer[I + 23]);
        }

        private void Sensor(int I,DataRow row)
        {

            //02: AAAA 02 XX(LEN) XXXX(ACC_X) XXXX(ACC_Y) XXXX(ACC_Z) XXXX(GYR_X) XXXX(GYR_Y) XXXX(GYR_Z) XXXX(MAG_X) XXXX(MAG_Y) XXXX(MAG_Z) XX(SUM)
            acc_x = ByteToDecimal(buffer[I + 4], buffer[I + 5]);
            acc_y = ByteToDecimal(buffer[I + 6], buffer[I + 7]);
            acc_z = ByteToDecimal(buffer[I + 8], buffer[I + 9]);

            gyr_x = ByteToDecimal(buffer[I + 10], buffer[I + 11]);
            gyr_y = ByteToDecimal(buffer[I + 12], buffer[I + 13]);
            gyr_z = ByteToDecimal(buffer[I + 14], buffer[I + 15]);

            mag_x = ByteToDecimal(buffer[I + 16], buffer[I + 17]);
            mag_y = ByteToDecimal(buffer[I + 18], buffer[I + 19]);
            mag_z = ByteToDecimal(buffer[I + 20], buffer[I + 21]);
            //Log(LogMsgType.Incoming, "接收数据：" + ByteArrayToHexString(buffer,data_num));
        }

        private void Status(int I,DataRow row)
        {
            //01：AAAA 01 XX(LEN=) XXXX(ROL*100) XXXX(PIT*100) XXXX(YAW*100) XX(SUM)
            short rol_100 = ByteToDecimal(buffer[I + 4], buffer[I + 5]);
            short pit_100 = ByteToDecimal(buffer[I + 6], buffer[I + 7]);
            short yaw_100 = ByteToDecimal(buffer[I + 8], buffer[I + 9]);


            Rol = (float)rol_100 / 100;
            Pit = (float)pit_100 / 100;
            Yaw = (float)yaw_100 / 100;
            
            //alt = (short)Convert.ToDecimal((int)((buffer[I + 10] << 24) | (buffer[I + 11] << 16) | (buffer[I + 12] << 8) | (buffer[I + 13])));
            //Log(LogMsgType.Incoming, "接收数据：" + ByteArrayToHexString(buffer,data_num));
        }

        //private delegate void DataBind();
        private void ShowWave()
        {
            //DataBind db = new DataBind(waveform.chart1.DataBind);
            //waveform.chart1.Invoke(db);
            waveform.chart1.DataBind();
        }

        private void ShowPID()
        {
            settingPID.tb_acc_x.Text = acc_x.ToString();
            settingPID.tb_acc_y.Text = acc_y.ToString();
            settingPID.tb_acc_z.Text = acc_z.ToString();
            settingPID.tb_gyr_x.Text = gyr_x.ToString();
            settingPID.tb_gyr_y.Text = gyr_y.ToString();
            settingPID.tb_gyr_z.Text = gyr_z.ToString();
            settingPID.tb_mag_x.Text = mag_x.ToString();
            settingPID.tb_mag_y.Text = mag_y.ToString();
            settingPID.tb_mag_z.Text = mag_z.ToString();       
        }

        private void btnSetPID_Click(object sender, EventArgs e)
        {
            if (settingPID.Visible==false)
                settingPID.Show();
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            if (waveform.Visible==false)
                waveform.Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            if (mapNav.Visible == false)
                mapNav.Show();
        }

        private void btn_state_Click(object sender, EventArgs e)
        {
            if (statu.Visible == false)
                statu.Show();
        }


        /*发送按钮响应事件*/
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void SendData()
        {
            /*
             * 发送目前有1种功能字：
             * 01: AAAF 10 XX(LEN) XXXX(ROL_P) XXXX(ROL_I) XXXX(ROL_D) XXXX(PIT_P) XXXX(PIT_I) XXXX(PIT_D) XXXX(YAW_P) XXXX(YAW_I) XXXX(YAW_D) 
             */

            if (CurrentDataMode == DataMode.Char)
            {
                //comport.Write(txtSendData.Text);

                Log(LogMsgType.Outgoing, "【发送】传送文本数据:" + txtSendData.Text);
            }
            else if (CurrentDataMode == DataMode.Hex)
            {
                try
                {
                    byte[] data = HexStringToByteArray(txtSendData.Text);

                    comport.Write(data, 0, data.Length);

                    Log(LogMsgType.Outgoing, "【发送】传送16进制数据:" + txtSendData.Text);
                }
                catch (FormatException)
                {
                    Log(LogMsgType.Error, "Not properly formatted hex string: " + txtSendData.Text);
                }
            }
        }

        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        public static string ByteArrayToHexString(byte[] bytes,int len)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < len; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        } 

        /*清空按钮响应事件*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbTerminal.Text = "";
            sum_num = 0;//总帧数
            sum_byte = 0;//总字节数
        }

        /*打开串口按钮响应事件*/
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            
            if(comport.IsOpen)
            {
                m_IsTryToClosePort = true;
                while (m_IsReceiving)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                comport.Close();
                m_IsTryToClosePort = false;
            }
            else
            {
                /*打开串口*/
                comport.BaudRate = int.Parse(cmbBaudRate.Text);
                comport.DataBits = 8;
                comport.PortName = cmbPortName.Text;

                comport.Open();
                /*
                try
                {
                    comport.Open();
                }
                catch (Exception ex)
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。  
                    comport = new SerialPort();
                    //现实异常信息给客户。  
                    MessageBox.Show(ex.Message);
                }  
                */
            }

            EnableControls();

            if (comport.IsOpen)
                txtSendData.Focus();
        }


        private void Log(LogMsgType logMsgType, string msg)
        {
            rtbTerminal.SelectionColor = LogMsgTypeColor[(int)logMsgType];
            rtbTerminal.AppendText(msg + "\r\n");
            rtbTerminal.ScrollToCaret();
        }

        

        private void main_timer_Tick(object sender, EventArgs e)
        {
            lable_byte_sum.Text = sum_byte.ToString();
            lable_sum.Text = sum_num.ToString();
            if (show_buffer != null)
            {
                Log(LogMsgType.Incoming, "接收数据：" + ByteArrayToHexString(show_buffer, show_buffer.Length));
                show_buffer = null;
            }
            rol_label.Text = rol.ToString();
            axles3D1.AngleZ = -rol;
            yaw_label.Text = yaw.ToString();
            axles3D1.AngleY = yaw;
            pit_label.Text = pit.ToString();
            axles3D1.AngleX = pit;

            row = waveform.dt.NewRow();
            row["X轴"] = ++pid_num;
            row["ROL"] = Rol;
            row["PIT"] = Pit;
            row["YAW"] = Yaw;
            row["ACC-X"] = acc_x;
            row["ACC-Y"] = acc_y;
            row["ACC-Z"] = acc_z;
            row["GYR-X"] = gyr_x;
            row["GYR-Y"] = gyr_y;
            row["GYR-Z"] = gyr_z;
            row["MAG-X"] = mag_x;
            row["MAG-Y"] = mag_y;
            row["MAG-Z"] = mag_z;

            waveform.dt.Rows.Add(row);

            if (waveform.dt.Rows.Count > 300)
            {
                waveform.dt.Rows.RemoveAt(0);
            }

            if (thr >= 1000 && thr <= 2000) 
            //if (pit > 1000 && pit < 2000 && rol > 1000 && rol < 2000 && yaw > 1000 && yaw < 2000)
            {
                settingPID.pb_pit.Value = tel_pit;
                settingPID.pb_rol.Value = tel_rol;
                settingPID.pb_yaw.Value = tel_yaw;
                settingPID.pb_thr.Value = thr;

                settingPID.label_thr.Text = "THR: " + (thr - 1000) / 10 + "%";
                settingPID.label_pit.Text = "PIT: " + (tel_pit - 1000) / 10 + "%";
                settingPID.label_rol.Text = "ROL: " + (tel_rol - 1000) / 10 + "%";
                settingPID.label_yaw.Text = "YAW: " + (tel_yaw - 1000) / 10 + "%";
            }
            
            if (mapNav.IsHandleCreated&&map_times%50==0)
                mapNav.webBrowser1.Document.InvokeScript("setLocation", new object[] { lat, lng });
            if (settingPID.IsHandleCreated)
                ShowPID();
            if (waveform.IsHandleCreated)
                ShowWave();

            statu.attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(Pit, Rol);
            statu.headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters((int)yaw);
        }

        


    }
}
