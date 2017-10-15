using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostsManagement
{
    public partial class StartSettingsForm : Form
    {
        public StartSettingsForm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LaunchTheSettingsWizard = false;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
