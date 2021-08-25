using MissionPlanner.Controls;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigGPSInject : MyUserControl, IActivate, IDeactivate
    {
        public ConfigGPSInject()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            gps.Activate();
        }

        public void Deactivate()
        {
            gps.Deactivate();
        }
    }
}