using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWPX4Flow : MyUserControl, IActivate, IDeactivate
    {
        private bool focusmode = false;

        private OpticalFlow flow = null;

        public ConfigHWPX4Flow()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }

            Enabled = true;

            flow = new OpticalFlow(MainV2.comPort);

            // setup bitmap to screen
            flow.newImage += (s, eh) => imagebox.Image = (Image)eh.Image.Clone();
        }

        private void but_focusmode_Click(object sender, EventArgs e)
        {
            focusmode = !focusmode;
            flow.CalibrationMode(focusmode);
        }

        public void Deactivate()
        {
            if (flow != null)
            {
                flow.CalibrationMode(false);
                flow.Close();
            }
        }
    }
}