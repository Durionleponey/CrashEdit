using AltUI.Controls;
using AltUI.Forms;
using CrashEdit.Crash;
using System.Security.RightsManagement;

namespace CrashEdit.CE.Forms
{
    public partial class EnvironmentEditor : DarkForm
    {

        public bool UseFog => darkCheckBox1.Checked;
        public bool UseRain => darkCheckBox2.Checked;
        public int FogValue => trackBar1.Value;
        public EnvironmentEditor(EntityUInt32Property flags)
        {
            Icon = Embeds.GetIcon("Wrench");
            InitializeComponent();

            trackBar1.Enabled = false;
            darkCheckBox1.Checked = (flags != null);

        }


        private void darkCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void darkTitle1_Click(object sender, EventArgs e)
        {

        }

        private void darkTitle2_Click(object sender, EventArgs e)
        {


        }

        private void darkButton2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void darkCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Enabled = darkCheckBox1.Checked;
            Console.WriteLine($"hello ---> {trackBar1.Value}");

        }
    }
}
