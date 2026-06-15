namespace CrashEdit.CE.Forms
{
    partial class EnvironmentEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            darkCheckBox1 = new AltUI.Controls.DarkCheckBox();
            trackBar1 = new TrackBar();
            darkTitle1 = new AltUI.Controls.DarkTitle();
            darkTitle2 = new AltUI.Controls.DarkTitle();
            darkTitle3 = new AltUI.Controls.DarkTitle();
            darkButton1 = new AltUI.Controls.DarkButton();
            darkButton2 = new AltUI.Controls.DarkButton();
            darkTitle4 = new AltUI.Controls.DarkTitle();
            darkButton3 = new AltUI.Controls.DarkButton();
            darkTitle5 = new AltUI.Controls.DarkTitle();
            fogSettingsBox = new AltUI.Controls.DarkGroupBox();
            darkGroupBox1 = new AltUI.Controls.DarkGroupBox();
            dpdParticuleEffect = new AltUI.Controls.DarkComboBox();
            darkButton4 = new AltUI.Controls.DarkButton();
            darkButton5 = new AltUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            fogSettingsBox.SuspendLayout();
            darkGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // darkCheckBox1
            // 
            darkCheckBox1.AutoSize = true;
            darkCheckBox1.Location = new Point(26, 76);
            darkCheckBox1.Name = "darkCheckBox1";
            darkCheckBox1.Offset = 1;
            darkCheckBox1.Size = new Size(103, 29);
            darkCheckBox1.TabIndex = 1;
            darkCheckBox1.Text = "Use Fog";
            darkCheckBox1.CheckedChanged += UseFog_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(275, 76);
            trackBar1.Margin = new Padding(5);
            trackBar1.Maximum = 64;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(370, 69);
            trackBar1.TabIndex = 6;
            trackBar1.Tag = "";
            trackBar1.Scroll += trackBarFogValue_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // darkTitle1
            // 
            darkTitle1.Location = new Point(338, 25);
            darkTitle1.Margin = new Padding(3, 0, 3, 15);
            darkTitle1.Name = "darkTitle1";
            darkTitle1.Size = new Size(115, 30);
            darkTitle1.TabIndex = 7;
            darkTitle1.Text = "Fog Distance";
            darkTitle1.Click += fogDistanceTXT;
            // 
            // darkTitle2
            // 
            darkTitle2.AutoSize = true;
            darkTitle2.Location = new Point(184, 80);
            darkTitle2.Name = "darkTitle2";
            darkTitle2.Size = new Size(94, 25);
            darkTitle2.TabIndex = 8;
            darkTitle2.Text = "Very Close";
            darkTitle2.Click += veryCloseFogTXT;
            // 
            // darkTitle3
            // 
            darkTitle3.AutoSize = true;
            darkTitle3.Location = new Point(651, 76);
            darkTitle3.Name = "darkTitle3";
            darkTitle3.Size = new Size(74, 25);
            darkTitle3.TabIndex = 9;
            darkTitle3.Text = "Very Far";
            darkTitle3.Click += veryFarFogValueTXT;
            // 
            // darkButton1
            // 
            darkButton1.BorderColour = Color.Empty;
            darkButton1.CustomColour = false;
            darkButton1.FlatBottom = false;
            darkButton1.FlatTop = false;
            darkButton1.Location = new Point(538, 611);
            darkButton1.Name = "darkButton1";
            darkButton1.Padding = new Padding(5);
            darkButton1.Size = new Size(112, 34);
            darkButton1.TabIndex = 10;
            darkButton1.Text = "Ok";
            darkButton1.Click += okButtonClick;
            // 
            // darkButton2
            // 
            darkButton2.BorderColour = Color.Empty;
            darkButton2.CustomColour = false;
            darkButton2.FlatBottom = false;
            darkButton2.FlatTop = false;
            darkButton2.Location = new Point(689, 611);
            darkButton2.Name = "darkButton2";
            darkButton2.Padding = new Padding(5);
            darkButton2.Size = new Size(112, 34);
            darkButton2.TabIndex = 11;
            darkButton2.Text = "Cancel";
            darkButton2.Click += cancelButtonClick;
            // 
            // darkTitle4
            // 
            darkTitle4.AutoSize = true;
            darkTitle4.Location = new Point(459, 25);
            darkTitle4.Margin = new Padding(3, 0, 3, 15);
            darkTitle4.Name = "darkTitle4";
            darkTitle4.Size = new Size(115, 25);
            darkTitle4.TabIndex = 12;
            darkTitle4.Text = "Fog Distance";
            darkTitle4.Click += fogDistanceValue;
            // 
            // darkButton3
            // 
            darkButton3.BorderColour = Color.Empty;
            darkButton3.CustomColour = false;
            darkButton3.FlatBottom = false;
            darkButton3.FlatTop = false;
            darkButton3.Location = new Point(38, 611);
            darkButton3.Name = "darkButton3";
            darkButton3.Padding = new Padding(5);
            darkButton3.Size = new Size(163, 34);
            darkButton3.TabIndex = 13;
            darkButton3.Text = "Save As Default";
            darkButton3.Click += saveAsDefaultButtonClick;
            // 
            // darkTitle5
            // 
            darkTitle5.AutoSize = true;
            darkTitle5.Location = new Point(47, 56);
            darkTitle5.Margin = new Padding(3, 0, 3, 15);
            darkTitle5.Name = "darkTitle5";
            darkTitle5.Size = new Size(120, 25);
            darkTitle5.TabIndex = 15;
            darkTitle5.Text = "Particle Preset";
            // 
            // fogSettingsBox
            // 
            fogSettingsBox.AccessibleName = "Fog Settings";
            fogSettingsBox.Controls.Add(darkCheckBox1);
            fogSettingsBox.Controls.Add(trackBar1);
            fogSettingsBox.Controls.Add(darkTitle2);
            fogSettingsBox.Controls.Add(darkTitle3);
            fogSettingsBox.Controls.Add(darkTitle1);
            fogSettingsBox.Controls.Add(darkTitle4);
            fogSettingsBox.Location = new Point(38, 23);
            fogSettingsBox.Name = "fogSettingsBox";
            fogSettingsBox.Size = new Size(748, 150);
            fogSettingsBox.TabIndex = 16;
            fogSettingsBox.TabStop = false;
            fogSettingsBox.Text = "Fog Settings";
            // 
            // darkGroupBox1
            // 
            darkGroupBox1.Controls.Add(darkButton5);
            darkGroupBox1.Controls.Add(darkButton4);
            darkGroupBox1.Controls.Add(dpdParticuleEffect);
            darkGroupBox1.Controls.Add(darkTitle5);
            darkGroupBox1.Location = new Point(38, 195);
            darkGroupBox1.Name = "darkGroupBox1";
            darkGroupBox1.Size = new Size(748, 386);
            darkGroupBox1.TabIndex = 17;
            darkGroupBox1.TabStop = false;
            darkGroupBox1.Text = "Particle Settings";
            // 
            // dpdParticuleEffect
            // 
            dpdParticuleEffect.DrawMode = DrawMode.OwnerDrawVariable;
            dpdParticuleEffect.FormattingEnabled = true;
            dpdParticuleEffect.Items.AddRange(new object[] { "None", "Rain", "Snow" });
            dpdParticuleEffect.Location = new Point(184, 53);
            dpdParticuleEffect.Name = "dpdParticuleEffect";
            dpdParticuleEffect.Size = new Size(182, 32);
            dpdParticuleEffect.TabIndex = 16;
            // 
            // darkButton4
            // 
            darkButton4.BorderColour = Color.Empty;
            darkButton4.CustomColour = false;
            darkButton4.FlatBottom = false;
            darkButton4.FlatTop = false;
            darkButton4.Location = new Point(393, 51);
            darkButton4.Name = "darkButton4";
            darkButton4.Padding = new Padding(5);
            darkButton4.Size = new Size(163, 34);
            darkButton4.TabIndex = 18;
            darkButton4.Text = "Save As Preset";
            // 
            // darkButton5
            // 
            darkButton5.BorderColour = Color.Empty;
            darkButton5.CustomColour = false;
            darkButton5.FlatBottom = false;
            darkButton5.FlatTop = false;
            darkButton5.Location = new Point(562, 51);
            darkButton5.Name = "darkButton5";
            darkButton5.Padding = new Padding(5);
            darkButton5.Size = new Size(163, 34);
            darkButton5.TabIndex = 19;
            darkButton5.Text = "Remove Preset";
            // 
            // EnvironmentEditor
            // 
            AcceptButton = darkButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = darkButton2;
            ClientSize = new Size(822, 672);
            Controls.Add(darkGroupBox1);
            Controls.Add(fogSettingsBox);
            Controls.Add(darkButton3);
            Controls.Add(darkButton2);
            Controls.Add(darkButton1);
            CornerStyle = CornerPreference.Default;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnvironmentEditor";
            Text = "EnvironmentEditor";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            fogSettingsBox.ResumeLayout(false);
            fogSettingsBox.PerformLayout();
            darkGroupBox1.ResumeLayout(false);
            darkGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox1;
        private AltUI.Controls.DarkCheckBox darkCheckBox1;
        private TrackBar trackBar1;
        private AltUI.Controls.DarkTitle darkTitle1;
        private AltUI.Controls.DarkTitle darkTitle2;
        private AltUI.Controls.DarkTitle darkTitle3;
        private AltUI.Controls.DarkButton darkButton1;
        private AltUI.Controls.DarkButton darkButton2;
        private AltUI.Controls.DarkTitle darkTitle4;
        private AltUI.Controls.DarkButton darkButton3;
        private AltUI.Controls.DarkTitle darkTitle5;
        private AltUI.Controls.DarkGroupBox fogSettingsBox;
        private AltUI.Controls.DarkGroupBox darkGroupBox1;
        private AltUI.Controls.DarkButton darkButton5;
        private AltUI.Controls.DarkButton darkButton4;
        private AltUI.Controls.DarkComboBox dpdParticuleEffect;
    }
}