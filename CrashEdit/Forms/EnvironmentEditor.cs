using AltUI.Controls;
using AltUI.Forms;
using CrashEdit.CE.Properties;
using CrashEdit.Crash;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Net.Security;
using System.Security.RightsManagement;
using System.Text.Json;
using static CrashEdit.CE.EntityPropertyBox;

namespace CrashEdit.CE.Forms
{
    public partial class EnvironmentEditor : DarkForm
    {

        public bool UseFog => darkCheckBox1.Checked;
        public string ParticleEffec => (string)dpdParticuleEffect.SelectedItem;
        public int FogValue => trackBarFog.Value;
        public int ParticleValue => trackBarParticleAmount.Value;


        private List<ListItem> savedItems = new List<ListItem>();

        private const string FilePath = "CrashEdit.exe.savedenvironmentPreset.json";


        public class FieldData
        {
            public short ParticleAmount { get; set; }

            public short VelocityX { get; set; }
            public short VelocityY { get; set; }
            public short VelocityZ { get; set; }

            public uint UpperColor { get; set; }
            public uint LowerColor { get; set; }

        }

        public class ListItem
        {
            public string Name { get; set; }
            public List<FieldData> Fields { get; set; } = new List<FieldData>();
        }

        public EnvironmentEditor(EntityUInt32Property flags)
        {
            Icon = Embeds.GetIcon("Wrench");
            InitializeComponent();

            darkCheckBox1.Checked = Settings.Default.DefaultFogIsActive;

            dpdParticuleEffect.SelectedItem = Settings.Default.DefaultParticleEffec;

            //darkCheckBox1.Checked = (flags != null);

            trackBarFog.Value = Settings.Default.DefaultFogValue;

            darkTitle4.Text = trackBarFog.Value.ToString();

            darkTitle4.Visible = darkCheckBox1.Checked;


        }

        private void cancelButtonClick(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

        }

        private void okButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void UseFog_CheckedChanged(object sender, EventArgs e)
        {
            trackBarFog.Enabled = darkCheckBox1.Checked;
            darkTitle4.Visible = darkCheckBox1.Checked;
            Console.WriteLine($"hello ---> {trackBarFog.Value}");

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            darkTitle4.Text = trackBarFog.Value.ToString();

        }

        private void veryFarFogValueTXT(object sender, EventArgs e)
        {

        }

        private void saveAsDefaultButtonClick(object sender, EventArgs e)
        {
            Settings.Default.DefaultFogValue = (byte)trackBarFog.Value;
            Settings.Default.DefaultFogIsActive = darkCheckBox1.Checked;
            Console.WriteLine(dpdParticuleEffect.SelectedItem);
            Settings.Default.DefaultParticleEffec = (string)dpdParticuleEffect.SelectedItem;
            Settings.Default.Save();

            DarkMessageBox.ShowInformation("Default values saved.", "Settings");





        }

        private void LoadItemsFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string jsonString = File.ReadAllText(FilePath);
                    savedItems = JsonSerializer.Deserialize<List<ListItem>>(jsonString) ?? new List<ListItem>();

                    //dpdParticuleEffect.Items.Clear();
                    foreach (var item in savedItems)
                    {
                        Console.Write(item);
                        Console.WriteLine(item.Name.ToString());
                        dpdParticuleEffect.Items.Add(item.Name);
                    }

                    Console.WriteLine("Preset list loaded successfully.");
                }
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error loading Preset list: {ex.Message}", Resources.Title_Error);
            }
        }

        private void LoadIemsValueInForm()
        {

            //Console.WriteLine(savedItems);


            var selectedIndex = dpdParticuleEffect.SelectedIndex;
            var selectedPreset = savedItems[selectedIndex].Fields[0];


            trackBarParticleAmount.Value = selectedPreset.ParticleAmount;
            darkNumericUpDownParticleX.Value = selectedPreset.VelocityX;
            darkNumericUpDownParticleY.Value = selectedPreset.VelocityY;
            darkNumericUpDownParticleZ.Value = selectedPreset.VelocityZ;
            pictureBoxUpperColor.BackColor = Color.FromArgb(unchecked((int)selectedPreset.UpperColor));
            pictureBoxLowerColor.BackColor = Color.FromArgb(unchecked((int)selectedPreset.LowerColor));


        }

        private void AddSavedItem(string itemName, List<FieldData> fields)
        {
            var newItem = new ListItem
            {
                Name = itemName,
                Fields = fields
            };
            savedItems.Add(newItem);
            try
            {
                SaveItemsToFile();
                DarkMessageBox.ShowInformation($"Saved selected {fields.Count} field(s) successfully.", "Save Properties");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error saving fields: {ex.Message}", Resources.Title_Error);
            }
        }

        private void SaveItemsToFile()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(savedItems, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, jsonString);
                Console.WriteLine("Environment Preset list saved successfully.");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error saving properties list: {ex.Message}", Resources.Title_Error);
            }
        }

        private void darkButtonSavePreset_Click(object sender, EventArgs e)
        {


        }

        private void EnvironmentEditor_Load(object sender, EventArgs e)
        {
            EnableDisableParticleEffect();
            LoadItemsFromFile();
            //LoadIemsValueInForm();
            UpdatePourcentTrackBarParticleAmount();
            EnableDisableParticleEffect();


        }

        private void UpdatePourcentTrackBarParticleAmount()
        {

            ParticleAmountPourcent.Text = trackBarParticleAmount.Value.ToString() + "%";

        }

        private void EnableDisableParticleEffect()
        {

            var enable = darkCheckBoxUseParticleEffect.Checked;
            
            darkGroupBoxParticleAmount.Enabled = enable;
            darkGroupBoxParticleVelocity.Enabled = enable;
            darkGroupBoxParticleColor.Enabled = enable;

            darkButtonRemovePreset.Enabled = enable;
            darkButtonSaveAsNewPreset.Enabled = enable;
            darkButtonSavePreset.Enabled = enable;

            pictureBoxUpperColor.Visible = enable;
            pictureBoxLowerColor.Visible = enable;

            darkTitleLowerColor.Visible = enable;
            darkTitleUpperColor.Visible = enable;

            dpdParticuleEffect.Enabled = enable;

            ParticleAmountPourcent.Visible = enable;




        }

        private void dpdParticuleEffect_SelectedIndexChanged(object sender, EventArgs e)
        {


            LoadIemsValueInForm();
            UpdatePourcentTrackBarParticleAmount();




        }

        private void trackBarParticleAmount_Scroll(object sender, EventArgs e)
        {
            ParticleAmountPourcent.Text = trackBarParticleAmount.Value.ToString() + "%";
        }

        private void showHideLowerColor()
        {

            var hideLowerColor = darkCheckBoxUseOnlyOneColor.Checked;

            if (hideLowerColor)
            {

                darkTitleUpperColor.Text = "Particle Color";


            }
            else
            {

                darkTitleUpperColor.Text = "Upper Color";


            }

            darkTitleLowerColor.Visible = !hideLowerColor;
            pictureBoxLowerColor.Visible = !hideLowerColor;


        }

        private void darkCheckBoxUseOnlyOneColor_CheckedChanged(object sender, EventArgs e)
        {
            showHideLowerColor();

        }

        private void darkButtonSaveAsNewPreset_Click(object sender, EventArgs e)
        {

            
            using (InputWindow inputWindow = new InputWindow(Resources.EntityBox_CmdAdd, "Save As Preset", "Enter Preset Name:", string.Empty, -1))
            {

                if (inputWindow.ShowDialog(this) == DialogResult.OK)
                {

                    string presetName = inputWindow.Input;
                    List<FieldData> fields = createPresetFields();

                    AddSavedItem(presetName,fields);

                }
                else { return; }

            }

            
        }

        private List<FieldData> createPresetFields()
        {

            List<FieldData> list = new List<FieldData>();
            list[0].ParticleAmount = (short)trackBarParticleAmount.Value;
            list[0].VelocityX = (short)darkNumericUpDownParticleX.Value;
            list[0].VelocityY = (short)darkNumericUpDownParticleY.Value;
            list[0].VelocityZ = (short)darkNumericUpDownParticleZ.Value;
            list[0].UpperColor = (uint)pictureBoxLowerColor.BackColor.ToArgb();
            list[0].LowerColor = (uint)pictureBoxLowerColor.BackColor.ToArgb();

            return list;


        }

        private void darkButtonRemovePreset_Click(object sender, EventArgs e)
        {

        }

        private void darkCheckBoxUseParticleEffect_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableParticleEffect();


        }
    }
}
