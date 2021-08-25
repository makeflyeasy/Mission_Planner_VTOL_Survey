using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.ArduPilot;
using MissionPlanner.Controls.PreFlight;
using MissionPlanner.Utilities;

namespace MissionPlanner
{
    public partial class self_inspection : Form
    {
        public self_inspection()
        {
            InitializeComponent();
            
            /*float batterylevel = (float )MainV2.comPort.MAV.cs.battery_voltage;
            float satcount = MainV2.comPort.MAV.cs.satcount;
            
            if (satcount < 3)
            {
                lab_GPS .Visible = true;
                lab_GPS.Text = "GPS状态检查：卫星数量："+ satcount.ToString ()+ "未通过";
                lab_GPS.BackColor = Color.Red;
            }
            else
            {
                lab_GPS.Visible = true;
                lab_GPS.Text = "GPS状态检查：卫星数量：" + satcount.ToString() + "正常";
                lab_GPS.BackColor = Color.Green;
            }
            if (batterylevel < 48)
            {   
                lab_batterylevel.Visible = true;
                lab_batterylevel.Text = "电池电压检查：电池电压:"+batterylevel.ToString("0.##")+"V"+"未通过";
                lab_batterylevel.ForeColor = Color.Red;
            }
            else { 
                lab_batterylevel.Visible = true; 
                lab_batterylevel.Text = "电池电压检查：电池电压:" + batterylevel.ToString("0.##")+"V" + "正常";
                lab_batterylevel.ForeColor = Color.Green ;
            }*/
        }

    }
}
