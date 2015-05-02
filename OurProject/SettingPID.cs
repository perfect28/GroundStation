using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject
{
    public partial class SettingPID : Form
    {
        public SettingPID()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            /*
             * 发送目前有1种功能字：
             * 01: AAAF 10 XX(LEN) XXXX(ROL_P) XXXX(ROL_I) XXXX(ROL_D) XXXX(PIT_P) XXXX(PIT_I) XXXX(PIT_D) XXXX(YAW_P) XXXX(YAW_I) XXXX(YAW_D) 
             */
            int bytes = 60;
            byte[] buffer = new byte[bytes];
            int cnt = 0;
            buffer[cnt++] = 0xAA;
            buffer[cnt++] = 0xAF;
            buffer[cnt++] = 0x10;
            buffer[cnt++] = Convert.ToByte(rol_p.Text, 10);
            buffer[cnt++] = Convert.ToByte(rol_i.Text, 10);
            buffer[cnt++] = Convert.ToByte(rol_d.Text, 10);

            buffer[cnt++] = Convert.ToByte(pit_p.Text, 10);
            buffer[cnt++] = Convert.ToByte(pit_i.Text, 10);
            buffer[cnt++] = Convert.ToByte(pit_d.Text, 10);

            buffer[cnt++] = Convert.ToByte(yaw_p.Text, 10);
            buffer[cnt++] = Convert.ToByte(yaw_i.Text, 10);
            buffer[cnt++] = Convert.ToByte(yaw_d.Text, 10);

            ushort sum = 0;
            for (int i = 0; i < cnt; i++)
                sum += buffer[i];

            buffer[cnt++] = (byte)(sum&0xFF);
            //this.comport.Write(buffer, 0, buffer.Length);
        }
    }
}
