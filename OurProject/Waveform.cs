using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OurProject
{
    public partial class Waveform : Form
    {
        public DataTable dt = new DataTable();
        public Series[] data_series = new Series[13];

        public Waveform()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            dt.Columns.Add("X轴");
            dt.Columns.Add("ACC-X");
            dt.Columns.Add("ACC-Y");
            dt.Columns.Add("ACC-Z");
            dt.Columns.Add("GYR-X");
            dt.Columns.Add("GYR-Y");
            dt.Columns.Add("GYR-Z");
            dt.Columns.Add("MAG-X");
            dt.Columns.Add("MAG-Y");
            dt.Columns.Add("MAG-Z");
            dt.Columns.Add("ROL");
            dt.Columns.Add("PIT");
            dt.Columns.Add("YAW");

            chart1.DataSource = dt;
            for(int i=1;i<=12;i++)
            {
                data_series[i] = new Series();
                data_series[i].YValueMembers = dt.Columns[i].ColumnName;
                data_series[i].XValueMember = dt.Columns[0].ColumnName;
                data_series[i].ChartType = SeriesChartType.Line;
                data_series[i].LegendText = dt.Columns[i].ColumnName;
                data_series[i].BorderWidth = 2;
            }
        }

        private void Waveform_Load(object sender, EventArgs e)
        {
            //chart1.Series.Clear();
        }

        private void cb_accx_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_accx.Checked == true)
            {
                chart1.Series.Add(data_series[1]);
            }
            else
            {
                chart1.Series.Remove(data_series[1]);
            }
            chart1.DataBind();
        }

        private void cb_accy_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_accy.Checked == true)
            {
                chart1.Series.Add(data_series[2]);
            }
            else
            {
                chart1.Series.Remove(data_series[2]);
            }
            chart1.DataBind();
        }

        private void cb_accz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_accz.Checked == true)
            {
                chart1.Series.Add(data_series[3]);
            }
            else
            {
                chart1.Series.Remove(data_series[3]);
            }
            chart1.DataBind();
        }

        private void cb_gyrx_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gyrx.Checked == true)
            {
                chart1.Series.Add(data_series[4]);
            }
            else
            {
                chart1.Series.Remove(data_series[4]);
            }
            chart1.DataBind();
        }

        private void cb_gyry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gyry.Checked == true)
            {
                chart1.Series.Add(data_series[5]);
            }
            else
            {
                chart1.Series.Remove(data_series[5]);
            }
            chart1.DataBind();
        }

        private void cb_gyrz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gyrz.Checked == true)
            {
                chart1.Series.Add(data_series[6]);
            }
            else
            {
                chart1.Series.Remove(data_series[6]);
            }
            chart1.DataBind();
        }

        private void cb_magx_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_magx.Checked == true)
            {
                chart1.Series.Add(data_series[7]);
            }
            else
            {
                chart1.Series.Remove(data_series[7]);
            }
            chart1.DataBind();
        }

        private void cb_magy_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gyry.Checked == true)
            {
                chart1.Series.Add(data_series[8]);
            }
            else
            {
                chart1.Series.Remove(data_series[8]);
            }
            chart1.DataBind();
        }

        private void cb_magz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gyrz.Checked == true)
            {
                chart1.Series.Add(data_series[9]);
            }
            else
            {
                chart1.Series.Remove(data_series[9]);
            }
            chart1.DataBind();
        }

        private void cb_rol_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rol.Checked == true)
            {
                chart1.Series.Add(data_series[10]);
            }
            else
            {
                chart1.Series.Remove(data_series[10]);
            }
            chart1.DataBind();
        }

        private void cb_pit_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pit.Checked == true)
            {
                chart1.Series.Add(data_series[11]);
            }
            else
            {
                chart1.Series.Remove(data_series[11]);
            }
            chart1.DataBind();
        }

        private void cb_yaw_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_yaw.Checked == true)
            {
                chart1.Series.Add(data_series[12]);
            }
            else
            {
                chart1.Series.Remove(data_series[12]);
            }
            chart1.DataBind();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
