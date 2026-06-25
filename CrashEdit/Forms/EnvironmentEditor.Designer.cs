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
            trackBarFog = new TrackBar();
            darkTitle1 = new AltUI.Controls.DarkTitle();
            darkTitle2 = new AltUI.Controls.DarkTitle();
            darkTitle3 = new AltUI.Controls.DarkTitle();
            darkButton1 = new AltUI.Controls.DarkButton();
            darkButton2 = new AltUI.Controls.DarkButton();
            darkTitle4 = new AltUI.Controls.DarkTitle();
            darkButton3 = new AltUI.Controls.DarkButton();
            darkTitle5 = new AltUI.Controls.DarkTitle();
            fogSettingsBox = new AltUI.Controls.DarkGroupBox();
            darkGroupBoxParticleSettings = new AltUI.Controls.DarkGroupBox();
            darkGroupBoxParticleAmount = new AltUI.Controls.DarkGroupBox();
            ParticleAmountPourcent = new AltUI.Controls.DarkTitle();
            trackBarParticleAmount = new TrackBar();
            darkTitle8 = new AltUI.Controls.DarkTitle();
            darkTitle7 = new AltUI.Controls.DarkTitle();
            darkTitle6 = new AltUI.Controls.DarkTitle();
            darkGroupBoxParticleColor = new AltUI.Controls.DarkGroupBox();
            darkCheckBoxUseOnlyOneColor = new AltUI.Controls.DarkCheckBox();
            darkTitleLowerColor = new AltUI.Controls.DarkTitle();
            pictureBoxLowerColor = new PictureBox();
            darkTitleUpperColor = new AltUI.Controls.DarkTitle();
            pictureBoxUpperColor = new PictureBox();
            darkGroupBoxParticleVelocity = new AltUI.Controls.DarkGroupBox();
            darkNumericUpDownParticleZ = new AltUI.Controls.DarkNumericUpDown();
            darkNumericUpDownParticleY = new AltUI.Controls.DarkNumericUpDown();
            darkTitle13 = new AltUI.Controls.DarkTitle();
            darkTitle9 = new AltUI.Controls.DarkTitle();
            darkNumericUpDownParticleX = new AltUI.Controls.DarkNumericUpDown();
            darkTitle12 = new AltUI.Controls.DarkTitle();
            darkTitle11 = new AltUI.Controls.DarkTitle();
            darkButtonSaveAsNewPreset = new AltUI.Controls.DarkButton();
            darkButtonRemovePreset = new AltUI.Controls.DarkButton();
            darkButtonSavePreset = new AltUI.Controls.DarkButton();
            dpdParticuleEffect = new AltUI.Controls.DarkComboBox();
            darkCheckBoxUseParticleEffect = new AltUI.Controls.DarkCheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBarFog).BeginInit();
            fogSettingsBox.SuspendLayout();
            darkGroupBoxParticleSettings.SuspendLayout();
            darkGroupBoxParticleAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarParticleAmount).BeginInit();
            darkGroupBoxParticleColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLowerColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpperColor).BeginInit();
            darkGroupBoxParticleVelocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleX).BeginInit();
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
            // trackBarFog
            // 
            trackBarFog.Location = new Point(275, 76);
            trackBarFog.Margin = new Padding(5);
            trackBarFog.Maximum = 64;
            trackBarFog.Name = "trackBarFog";
            trackBarFog.Size = new Size(370, 69);
            trackBarFog.TabIndex = 6;
            trackBarFog.Tag = "";
            trackBarFog.ValueChanged += trackBar1_ValueChanged;
            // 
            // darkTitle1
            // 
            darkTitle1.Location = new Point(338, 25);
            darkTitle1.Margin = new Padding(3, 0, 3, 15);
            darkTitle1.Name = "darkTitle1";
            darkTitle1.Size = new Size(115, 30);
            darkTitle1.TabIndex = 7;
            darkTitle1.Text = "Fog Distance";
            // 
            // darkTitle2
            // 
            darkTitle2.AutoSize = true;
            darkTitle2.Location = new Point(184, 80);
            darkTitle2.Name = "darkTitle2";
            darkTitle2.Size = new Size(94, 25);
            darkTitle2.TabIndex = 8;
            darkTitle2.Text = "Very Close";
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
            darkButton1.Location = new Point(538, 833);
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
            darkButton2.Location = new Point(689, 833);
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
            // 
            // darkButton3
            // 
            darkButton3.BorderColour = Color.Empty;
            darkButton3.CustomColour = false;
            darkButton3.FlatBottom = false;
            darkButton3.FlatTop = false;
            darkButton3.Location = new Point(38, 833);
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
            darkTitle5.Location = new Point(236, 43);
            darkTitle5.Margin = new Padding(3, 0, 3, 15);
            darkTitle5.Name = "darkTitle5";
            darkTitle5.Size = new Size(116, 25);
            darkTitle5.TabIndex = 15;
            darkTitle5.Text = "Particle Effect";
            // 
            // fogSettingsBox
            // 
            fogSettingsBox.AccessibleName = "Fog Settings";
            fogSettingsBox.Controls.Add(darkCheckBox1);
            fogSettingsBox.Controls.Add(trackBarFog);
            fogSettingsBox.Controls.Add(darkTitle2);
            fogSettingsBox.Controls.Add(darkTitle3);
            fogSettingsBox.Controls.Add(darkTitle1);
            fogSettingsBox.Controls.Add(darkTitle4);
            fogSettingsBox.Location = new Point(38, 12);
            fogSettingsBox.Name = "fogSettingsBox";
            fogSettingsBox.Size = new Size(763, 170);
            fogSettingsBox.TabIndex = 16;
            fogSettingsBox.TabStop = false;
            fogSettingsBox.Text = "Fog Settings";
            // 
            // darkGroupBoxParticleSettings
            // 
            darkGroupBoxParticleSettings.Controls.Add(darkCheckBoxUseParticleEffect);
            darkGroupBoxParticleSettings.Controls.Add(darkGroupBoxParticleAmount);
            darkGroupBoxParticleSettings.Controls.Add(darkGroupBoxParticleColor);
            darkGroupBoxParticleSettings.Controls.Add(darkGroupBoxParticleVelocity);
            darkGroupBoxParticleSettings.Controls.Add(darkButtonSaveAsNewPreset);
            darkGroupBoxParticleSettings.Controls.Add(darkButtonRemovePreset);
            darkGroupBoxParticleSettings.Controls.Add(darkButtonSavePreset);
            darkGroupBoxParticleSettings.Controls.Add(dpdParticuleEffect);
            darkGroupBoxParticleSettings.Controls.Add(darkTitle5);
            darkGroupBoxParticleSettings.Location = new Point(38, 210);
            darkGroupBoxParticleSettings.Name = "darkGroupBoxParticleSettings";
            darkGroupBoxParticleSettings.Size = new Size(763, 594);
            darkGroupBoxParticleSettings.TabIndex = 17;
            darkGroupBoxParticleSettings.TabStop = false;
            darkGroupBoxParticleSettings.Text = "Particle Settings";
            // 
            // darkGroupBoxParticleAmount
            // 
            darkGroupBoxParticleAmount.Controls.Add(ParticleAmountPourcent);
            darkGroupBoxParticleAmount.Controls.Add(trackBarParticleAmount);
            darkGroupBoxParticleAmount.Controls.Add(darkTitle8);
            darkGroupBoxParticleAmount.Controls.Add(darkTitle7);
            darkGroupBoxParticleAmount.Controls.Add(darkTitle6);
            darkGroupBoxParticleAmount.Location = new Point(20, 152);
            darkGroupBoxParticleAmount.Name = "darkGroupBoxParticleAmount";
            darkGroupBoxParticleAmount.Size = new Size(719, 154);
            darkGroupBoxParticleAmount.TabIndex = 27;
            darkGroupBoxParticleAmount.TabStop = false;
            darkGroupBoxParticleAmount.Text = "Particle Amount";
            // 
            // ParticleAmountPourcent
            // 
            ParticleAmountPourcent.AutoSize = true;
            ParticleAmountPourcent.Location = new Point(393, 21);
            ParticleAmountPourcent.Margin = new Padding(3, 0, 3, 15);
            ParticleAmountPourcent.Name = "ParticleAmountPourcent";
            ParticleAmountPourcent.Size = new Size(115, 25);
            ParticleAmountPourcent.TabIndex = 13;
            ParticleAmountPourcent.Text = "Fog Distance";
            // 
            // trackBarParticleAmount
            // 
            trackBarParticleAmount.Location = new Point(238, 53);
            trackBarParticleAmount.Margin = new Padding(5);
            trackBarParticleAmount.Maximum = 100;
            trackBarParticleAmount.Name = "trackBarParticleAmount";
            trackBarParticleAmount.Size = new Size(370, 69);
            trackBarParticleAmount.TabIndex = 13;
            trackBarParticleAmount.Tag = "";
            trackBarParticleAmount.Scroll += trackBarParticleAmount_Scroll;
            // 
            // darkTitle8
            // 
            darkTitle8.Location = new Point(45, 63);
            darkTitle8.Margin = new Padding(3, 0, 3, 15);
            darkTitle8.Name = "darkTitle8";
            darkTitle8.Size = new Size(104, 30);
            darkTitle8.TabIndex = 14;
            darkTitle8.Text = "Amount (%)";
            // 
            // darkTitle7
            // 
            darkTitle7.AutoSize = true;
            darkTitle7.Location = new Point(614, 53);
            darkTitle7.Name = "darkTitle7";
            darkTitle7.Size = new Size(57, 25);
            darkTitle7.TabIndex = 16;
            darkTitle7.Text = "100%";
            // 
            // darkTitle6
            // 
            darkTitle6.AutoSize = true;
            darkTitle6.Location = new Point(193, 53);
            darkTitle6.Name = "darkTitle6";
            darkTitle6.Size = new Size(37, 25);
            darkTitle6.TabIndex = 15;
            darkTitle6.Text = "0%";
            // 
            // darkGroupBoxParticleColor
            // 
            darkGroupBoxParticleColor.Controls.Add(darkCheckBoxUseOnlyOneColor);
            darkGroupBoxParticleColor.Controls.Add(darkTitleLowerColor);
            darkGroupBoxParticleColor.Controls.Add(pictureBoxLowerColor);
            darkGroupBoxParticleColor.Controls.Add(darkTitleUpperColor);
            darkGroupBoxParticleColor.Controls.Add(pictureBoxUpperColor);
            darkGroupBoxParticleColor.Location = new Point(20, 457);
            darkGroupBoxParticleColor.Name = "darkGroupBoxParticleColor";
            darkGroupBoxParticleColor.Size = new Size(719, 99);
            darkGroupBoxParticleColor.TabIndex = 29;
            darkGroupBoxParticleColor.TabStop = false;
            darkGroupBoxParticleColor.Text = "Particle Color";
            // 
            // darkCheckBoxUseOnlyOneColor
            // 
            darkCheckBoxUseOnlyOneColor.AutoSize = true;
            darkCheckBoxUseOnlyOneColor.Location = new Point(45, 40);
            darkCheckBoxUseOnlyOneColor.Name = "darkCheckBoxUseOnlyOneColor";
            darkCheckBoxUseOnlyOneColor.Offset = 1;
            darkCheckBoxUseOnlyOneColor.Size = new Size(195, 29);
            darkCheckBoxUseOnlyOneColor.TabIndex = 34;
            darkCheckBoxUseOnlyOneColor.Text = "Use Only One Color";
            darkCheckBoxUseOnlyOneColor.CheckedChanged += darkCheckBoxUseOnlyOneColor_CheckedChanged;
            // 
            // darkTitleLowerColor
            // 
            darkTitleLowerColor.Location = new Point(536, 39);
            darkTitleLowerColor.Margin = new Padding(3, 0, 3, 15);
            darkTitleLowerColor.Name = "darkTitleLowerColor";
            darkTitleLowerColor.Size = new Size(113, 30);
            darkTitleLowerColor.TabIndex = 33;
            darkTitleLowerColor.Text = "Lower Color ";
            // 
            // pictureBoxLowerColor
            // 
            pictureBoxLowerColor.BackColor = Color.White;
            pictureBoxLowerColor.Location = new Point(658, 34);
            pictureBoxLowerColor.Name = "pictureBoxLowerColor";
            pictureBoxLowerColor.Size = new Size(36, 39);
            pictureBoxLowerColor.TabIndex = 32;
            pictureBoxLowerColor.TabStop = false;
            // 
            // darkTitleUpperColor
            // 
            darkTitleUpperColor.Location = new Point(359, 39);
            darkTitleUpperColor.Margin = new Padding(3, 0, 3, 15);
            darkTitleUpperColor.Name = "darkTitleUpperColor";
            darkTitleUpperColor.Size = new Size(113, 30);
            darkTitleUpperColor.TabIndex = 31;
            darkTitleUpperColor.Text = "Upper Color ";
            // 
            // pictureBoxUpperColor
            // 
            pictureBoxUpperColor.BackColor = Color.White;
            pictureBoxUpperColor.Location = new Point(478, 34);
            pictureBoxUpperColor.Name = "pictureBoxUpperColor";
            pictureBoxUpperColor.Size = new Size(36, 39);
            pictureBoxUpperColor.TabIndex = 0;
            pictureBoxUpperColor.TabStop = false;
            // 
            // darkGroupBoxParticleVelocity
            // 
            darkGroupBoxParticleVelocity.Controls.Add(darkNumericUpDownParticleZ);
            darkGroupBoxParticleVelocity.Controls.Add(darkNumericUpDownParticleY);
            darkGroupBoxParticleVelocity.Controls.Add(darkTitle13);
            darkGroupBoxParticleVelocity.Controls.Add(darkTitle9);
            darkGroupBoxParticleVelocity.Controls.Add(darkNumericUpDownParticleX);
            darkGroupBoxParticleVelocity.Controls.Add(darkTitle12);
            darkGroupBoxParticleVelocity.Controls.Add(darkTitle11);
            darkGroupBoxParticleVelocity.Location = new Point(20, 324);
            darkGroupBoxParticleVelocity.Name = "darkGroupBoxParticleVelocity";
            darkGroupBoxParticleVelocity.Size = new Size(722, 107);
            darkGroupBoxParticleVelocity.TabIndex = 28;
            darkGroupBoxParticleVelocity.TabStop = false;
            darkGroupBoxParticleVelocity.Text = "Particle Velocity";
            // 
            // darkNumericUpDownParticleZ
            // 
            darkNumericUpDownParticleZ.Location = new Point(514, 42);
            darkNumericUpDownParticleZ.Name = "darkNumericUpDownParticleZ";
            darkNumericUpDownParticleZ.Size = new Size(72, 31);
            darkNumericUpDownParticleZ.TabIndex = 30;
            // 
            // darkNumericUpDownParticleY
            // 
            darkNumericUpDownParticleY.Location = new Point(403, 42);
            darkNumericUpDownParticleY.Name = "darkNumericUpDownParticleY";
            darkNumericUpDownParticleY.Size = new Size(72, 31);
            darkNumericUpDownParticleY.TabIndex = 29;
            // 
            // darkTitle13
            // 
            darkTitle13.Location = new Point(46, 42);
            darkTitle13.Margin = new Padding(3, 0, 3, 15);
            darkTitle13.Name = "darkTitle13";
            darkTitle13.Size = new Size(61, 30);
            darkTitle13.TabIndex = 28;
            darkTitle13.Text = "[0-256]";
            // 
            // darkTitle9
            // 
            darkTitle9.Location = new Point(258, 44);
            darkTitle9.Margin = new Padding(3, 0, 3, 15);
            darkTitle9.Name = "darkTitle9";
            darkTitle9.Size = new Size(22, 30);
            darkTitle9.TabIndex = 27;
            darkTitle9.Text = "X:";
            // 
            // darkNumericUpDownParticleX
            // 
            darkNumericUpDownParticleX.Location = new Point(286, 42);
            darkNumericUpDownParticleX.Name = "darkNumericUpDownParticleX";
            darkNumericUpDownParticleX.Size = new Size(72, 31);
            darkNumericUpDownParticleX.TabIndex = 23;
            // 
            // darkTitle12
            // 
            darkTitle12.Location = new Point(486, 44);
            darkTitle12.Margin = new Padding(3, 0, 3, 15);
            darkTitle12.Name = "darkTitle12";
            darkTitle12.Size = new Size(22, 30);
            darkTitle12.TabIndex = 26;
            darkTitle12.Text = "Z:";
            // 
            // darkTitle11
            // 
            darkTitle11.Location = new Point(373, 42);
            darkTitle11.Margin = new Padding(3, 0, 3, 15);
            darkTitle11.Name = "darkTitle11";
            darkTitle11.Size = new Size(22, 30);
            darkTitle11.TabIndex = 25;
            darkTitle11.Text = "Y:";
            // 
            // darkButtonSaveAsNewPreset
            // 
            darkButtonSaveAsNewPreset.BorderColour = Color.Empty;
            darkButtonSaveAsNewPreset.CustomColour = false;
            darkButtonSaveAsNewPreset.FlatBottom = false;
            darkButtonSaveAsNewPreset.FlatTop = false;
            darkButtonSaveAsNewPreset.Location = new Point(477, 37);
            darkButtonSaveAsNewPreset.Name = "darkButtonSaveAsNewPreset";
            darkButtonSaveAsNewPreset.Padding = new Padding(5);
            darkButtonSaveAsNewPreset.Size = new Size(203, 34);
            darkButtonSaveAsNewPreset.TabIndex = 20;
            darkButtonSaveAsNewPreset.Text = "Save As New Preset";
            darkButtonSaveAsNewPreset.Click += darkButtonSaveAsNewPreset_Click;
            // 
            // darkButtonRemovePreset
            // 
            darkButtonRemovePreset.BorderColour = Color.Empty;
            darkButtonRemovePreset.CustomColour = false;
            darkButtonRemovePreset.FlatBottom = false;
            darkButtonRemovePreset.FlatTop = false;
            darkButtonRemovePreset.Location = new Point(574, 72);
            darkButtonRemovePreset.Name = "darkButtonRemovePreset";
            darkButtonRemovePreset.Padding = new Padding(5);
            darkButtonRemovePreset.Size = new Size(163, 34);
            darkButtonRemovePreset.TabIndex = 19;
            darkButtonRemovePreset.Text = "Remove Preset";
            // 
            // darkButtonSavePreset
            // 
            darkButtonSavePreset.BorderColour = Color.Empty;
            darkButtonSavePreset.CustomColour = false;
            darkButtonSavePreset.FlatBottom = false;
            darkButtonSavePreset.FlatTop = false;
            darkButtonSavePreset.Location = new Point(411, 72);
            darkButtonSavePreset.Name = "darkButtonSavePreset";
            darkButtonSavePreset.Padding = new Padding(5);
            darkButtonSavePreset.Size = new Size(163, 34);
            darkButtonSavePreset.TabIndex = 18;
            darkButtonSavePreset.Text = "Save Preset";
            darkButtonSavePreset.Click += darkButtonSavePreset_Click;
            // 
            // dpdParticuleEffect
            // 
            dpdParticuleEffect.DrawMode = DrawMode.OwnerDrawVariable;
            dpdParticuleEffect.FormattingEnabled = true;
            dpdParticuleEffect.Items.AddRange(new object[] { "None" });
            dpdParticuleEffect.Location = new Point(196, 86);
            dpdParticuleEffect.Name = "dpdParticuleEffect";
            dpdParticuleEffect.Size = new Size(182, 32);
            dpdParticuleEffect.TabIndex = 16;
            dpdParticuleEffect.SelectedIndexChanged += dpdParticuleEffect_SelectedIndexChanged;
            // 
            // darkCheckBoxUseParticleEffect
            // 
            darkCheckBoxUseParticleEffect.AutoSize = true;
            darkCheckBoxUseParticleEffect.Location = new Point(26, 77);
            darkCheckBoxUseParticleEffect.Name = "darkCheckBoxUseParticleEffect";
            darkCheckBoxUseParticleEffect.Offset = 1;
            darkCheckBoxUseParticleEffect.Size = new Size(127, 29);
            darkCheckBoxUseParticleEffect.TabIndex = 13;
            darkCheckBoxUseParticleEffect.Text = "Use Particle";
            darkCheckBoxUseParticleEffect.CheckedChanged += darkCheckBoxUseParticleEffect_CheckedChanged;
            // 
            // EnvironmentEditor
            // 
            AcceptButton = darkButton1;
            AccessibleName = "EnvironmentEditorWindow";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = darkButton2;
            ClientSize = new Size(822, 897);
            Controls.Add(darkGroupBoxParticleSettings);
            Controls.Add(fogSettingsBox);
            Controls.Add(darkButton3);
            Controls.Add(darkButton2);
            Controls.Add(darkButton1);
            CornerStyle = CornerPreference.Default;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnvironmentEditor";
            Text = " Environment Editor";
            Load += EnvironmentEditor_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarFog).EndInit();
            fogSettingsBox.ResumeLayout(false);
            fogSettingsBox.PerformLayout();
            darkGroupBoxParticleSettings.ResumeLayout(false);
            darkGroupBoxParticleSettings.PerformLayout();
            darkGroupBoxParticleAmount.ResumeLayout(false);
            darkGroupBoxParticleAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarParticleAmount).EndInit();
            darkGroupBoxParticleColor.ResumeLayout(false);
            darkGroupBoxParticleColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLowerColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpperColor).EndInit();
            darkGroupBoxParticleVelocity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleY).EndInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDownParticleX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox1;
        private AltUI.Controls.DarkCheckBox darkCheckBox1;
        private TrackBar trackBarFog;
        private AltUI.Controls.DarkTitle darkTitle1;
        private AltUI.Controls.DarkTitle darkTitle2;
        private AltUI.Controls.DarkTitle darkTitle3;
        private AltUI.Controls.DarkButton darkButton1;
        private AltUI.Controls.DarkButton darkButton2;
        private AltUI.Controls.DarkTitle darkTitle4;
        private AltUI.Controls.DarkButton darkButton3;
        private AltUI.Controls.DarkTitle darkTitle5;
        private AltUI.Controls.DarkGroupBox fogSettingsBox;
        private AltUI.Controls.DarkGroupBox darkGroupBoxParticleSettings;
        private AltUI.Controls.DarkButton darkButtonRemovePreset;
        private AltUI.Controls.DarkButton darkButtonSavePreset;
        private AltUI.Controls.DarkComboBox dpdParticuleEffect;
        private TrackBar trackBarParticleAmount;
        private AltUI.Controls.DarkTitle darkTitle6;
        private AltUI.Controls.DarkTitle darkTitle7;
        private AltUI.Controls.DarkTitle darkTitle8;
        private AltUI.Controls.DarkButton darkButtonSaveAsNewPreset;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDownParticleX;
        private AltUI.Controls.DarkGroupBox darkGroupBoxParticleAmount;
        private AltUI.Controls.DarkTitle darkTitle12;
        private AltUI.Controls.DarkTitle darkTitle11;
        private AltUI.Controls.DarkGroupBox darkGroupBoxParticleVelocity;
        private AltUI.Controls.DarkTitle darkTitle13;
        private AltUI.Controls.DarkTitle darkTitle9;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDownParticleZ;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDownParticleY;
        private AltUI.Controls.DarkGroupBox darkGroupBoxParticleColor;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private PictureBox pictureBoxUpperColor;
        private AltUI.Controls.DarkTitle darkTitleUpperColor;
        private AltUI.Controls.DarkTitle darkTitleLowerColor;
        private PictureBox pictureBoxLowerColor;
        private AltUI.Controls.DarkCheckBox darkCheckBoxUseOnlyOneColor;
        private AltUI.Controls.DarkTitle ParticleAmountPourcent;
        private AltUI.Controls.DarkCheckBox darkCheckBoxUseParticleEffect;
    }
}