using FtpTest1;
using ICSharpCode.SharpZipLib.Zip;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial  class AutoUpdater
    {
        
        public void Update ()
        {
            try
            {
                FastZip fz = new FastZip();
                FtpWeb fw = new FtpWeb("47.108.137.134", "MissionPlannerVtolSurvey", "doc", "bfxKe68Erv4qB");
                string filepath = Settings.GetRunningDirectory() + "ver0.txt";
                StreamReader oldsr = new StreamReader(filepath);
                string oldstr = oldsr.ReadLine();
                oldsr.Close();
                string status = fw.Download(Settings.GetRunningDirectory(), "ver.txt");
                StreamReader newsr = new StreamReader(Settings.GetRunningDirectory()+"ver.txt");
                string newstr = newsr.ReadLine();
                newsr.Close();
                if (oldstr != newstr)
                {
                    //if ((int)DialogResult.Yes == CustomMessageBox.Show("检测到有新版本，是否更新", "提示", MessageBoxButtons.YesNo))
                    {
                        fw.Download(Settings.GetRunningDirectory(), "Mission Planner Vtol Survey V1.1.rar");
                        fz.ExtractZip(Settings.GetRunningDirectory() + "Mission Planner Vtol Survey V1.1.rar", "../" + Settings.GetRunningDirectory(), null);
                    }
                }
            }
            catch { }
        }
        
    }
}
