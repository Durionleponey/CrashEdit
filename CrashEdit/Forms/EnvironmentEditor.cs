using AltUI.Controls;
using AltUI.Forms;
using CrashEdit.CE.Properties;
using CrashEdit.Crash;
using System.Net.Security;
using System.Security.RightsManagement;
using System.Text.Json;
using static CrashEdit.CE.EntityPropertyBox;

namespace CrashEdit.CE.Forms
{
    public partial class EnvironmentEditor : DarkForm
    {

        public bool UseFog => darkCheckBox1.Checked;
        public string DefaultParticleEffec => (string)dpdParticuleEffect.SelectedItem;
        public int FogValue => trackBar1.Value;


        private List<ListItem> savedItems = new List<ListItem>();

        private const string FilePath = "CrashEdit.exe.savedenvironmentPreset.json";



        //test ROBIN
        public static readonly ListItem Robin = new()
        {

            Name = "test",
            Fields = new List<FieldData>
                {
                    new FieldData { ParticleAmount = 50, VelocityY = 200, VelocityX = 150}
                }


        };




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

                    //lbSavedProperties.Items.Clear();
                    foreach (var item in savedItems)
                    {
                        Console.WriteLine(item.Name.ToString());
                        //lbSavedProperties.Items.Add(item.Name);
                    }

                    Console.WriteLine("Properties list loaded successfully.");
                }
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error loading properties list: {ex.Message}", Resources.Title_Error);
            }
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

        private void darkButton4_Click(object sender, EventArgs e)
        {
            AddSavedItem(Robin.Name, Robin.Fields);
        }
    }
}
