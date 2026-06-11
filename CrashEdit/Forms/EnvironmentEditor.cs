using AltUI.Controls;
using AltUI.Forms;
using CrashEdit.CE.Properties;
using CrashEdit.Crash;
using System.Security.RightsManagement;

namespace CrashEdit.CE.Forms
{
    public partial class EnvironmentEditor : DarkForm
    {

        public bool UseFog => darkCheckBox1.Checked;
        //public bool UseRain => darkCheckBox2.Checked;
        public int FogValue => trackBar1.Value;
        public EnvironmentEditor(EntityUInt32Property flags)
        {
            Icon = Embeds.GetIcon("Wrench");
            InitializeComponent();

            darkCheckBox1.Checked = Settings.Default.DefaultFogIsActive;

            //darkCheckBox2.Checked = Settings.Default.DefaultRainIsActive;

            //darkCheckBox1.Checked = (flags != null);

            trackBar1.Value = Settings.Default.DefaultFogValue;

            darkTitle4.Text = trackBar1.Value.ToString();

            darkTitle4.Visible = darkCheckBox1.Checked;


        }


        private void useRain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fogDistanceTXT(object sender, EventArgs e)
        {

        }

        private void veryCloseFogTXT(object sender, EventArgs e)
        {


        }

        private void cancelButtonClick(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

        }

        private void okButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void trackBarFogValue_Scroll(object sender, EventArgs e)
        {

        }

        private void UseFog_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Enabled = darkCheckBox1.Checked;
            darkTitle4.Visible = darkCheckBox1.Checked;
            Console.WriteLine($"hello ---> {trackBar1.Value}");

        }

        private void fogDistanceValue(object sender, EventArgs e)
        {


        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            darkTitle4.Text = trackBar1.Value.ToString();

        }

        private void veryFarFogValueTXT(object sender, EventArgs e)
        {

        }

        private void saveAsDefaultButtonClick(object sender, EventArgs e)
        {
            Settings.Default.DefaultFogValue = (byte)trackBar1.Value;
            Settings.Default.DefaultFogIsActive = darkCheckBox1.Checked;
            //Settings.Default.DefaultRainIsActive = darkCheckBox2.Checked;
            Settings.Default.Save();

            DarkMessageBox.ShowInformation("Default values saved.", "Settings");





        }
    }
}
