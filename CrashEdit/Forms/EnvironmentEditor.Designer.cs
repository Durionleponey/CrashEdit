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
            darkGroupBox2 = new AltUI.Controls.DarkGroupBox();
            trackBar2 = new TrackBar();
            darkTitle8 = new AltUI.Controls.DarkTitle();
            darkTitle7 = new AltUI.Controls.DarkTitle();
            darkTitle6 = new AltUI.Controls.DarkTitle();
            darkGroupBox4 = new AltUI.Controls.DarkGroupBox();
            darkCheckBox2 = new AltUI.Controls.DarkCheckBox();
            darkTitle14 = new AltUI.Controls.DarkTitle();
            pictureBox2 = new PictureBox();
            darkTitle10 = new AltUI.Controls.DarkTitle();
            pictureBox1 = new PictureBox();
            darkGroupBox3 = new AltUI.Controls.DarkGroupBox();
            darkNumericUpDown2 = new AltUI.Controls.DarkNumericUpDown();
            darkNumericUpDown1 = new AltUI.Controls.DarkNumericUpDown();
            darkTitle13 = new AltUI.Controls.DarkTitle();
            darkTitle9 = new AltUI.Controls.DarkTitle();
            darkNumericUpDown3 = new AltUI.Controls.DarkNumericUpDown();
            darkTitle12 = new AltUI.Controls.DarkTitle();
            darkTitle11 = new AltUI.Controls.DarkTitle();
            darkButton6 = new AltUI.Controls.DarkButton();
            darkButton5 = new AltUI.Controls.DarkButton();
            darkButton4 = new AltUI.Controls.DarkButton();
            dpdParticuleEffect = new AltUI.Controls.DarkComboBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            fogSettingsBox.SuspendLayout();
            darkGroupBox1.SuspendLayout();
            darkGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            darkGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            darkGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown3).BeginInit();
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
            darkTitle4.Click += fogDistanceValue;
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
            darkTitle5.Location = new Point(47, 56);
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
            fogSettingsBox.Controls.Add(trackBar1);
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
            // darkGroupBox1
            // 
            darkGroupBox1.Controls.Add(darkGroupBox2);
            darkGroupBox1.Controls.Add(darkGroupBox4);
            darkGroupBox1.Controls.Add(darkGroupBox3);
            darkGroupBox1.Controls.Add(darkButton6);
            darkGroupBox1.Controls.Add(darkButton5);
            darkGroupBox1.Controls.Add(darkButton4);
            darkGroupBox1.Controls.Add(dpdParticuleEffect);
            darkGroupBox1.Controls.Add(darkTitle5);
            darkGroupBox1.Location = new Point(38, 210);
            darkGroupBox1.Name = "darkGroupBox1";
            darkGroupBox1.Size = new Size(763, 594);
            darkGroupBox1.TabIndex = 17;
            darkGroupBox1.TabStop = false;
            darkGroupBox1.Text = "Particle Settings";
            // 
            // darkGroupBox2
            // 
            darkGroupBox2.Controls.Add(trackBar2);
            darkGroupBox2.Controls.Add(darkTitle8);
            darkGroupBox2.Controls.Add(darkTitle7);
            darkGroupBox2.Controls.Add(darkTitle6);
            darkGroupBox2.Location = new Point(20, 152);
            darkGroupBox2.Name = "darkGroupBox2";
            darkGroupBox2.Size = new Size(719, 154);
            darkGroupBox2.TabIndex = 27;
            darkGroupBox2.TabStop = false;
            darkGroupBox2.Text = "Particle Amount";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(238, 53);
            trackBar2.Margin = new Padding(5);
            trackBar2.Maximum = 64;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(370, 69);
            trackBar2.TabIndex = 13;
            trackBar2.Tag = "";
            // 
            // darkTitle8
            // 
            darkTitle8.Location = new Point(45, 63);
            darkTitle8.Margin = new Padding(3, 0, 3, 15);
            darkTitle8.Name = "darkTitle8";
            darkTitle8.Size = new Size(72, 30);
            darkTitle8.TabIndex = 14;
            darkTitle8.Text = "Amount";
            // 
            // darkTitle7
            // 
            darkTitle7.AutoSize = true;
            darkTitle7.Location = new Point(614, 53);
            darkTitle7.Name = "darkTitle7";
            darkTitle7.Size = new Size(50, 25);
            darkTitle7.TabIndex = 16;
            darkTitle7.Text = "A lot";
            // 
            // darkTitle6
            // 
            darkTitle6.AutoSize = true;
            darkTitle6.Location = new Point(176, 53);
            darkTitle6.Name = "darkTitle6";
            darkTitle6.Size = new Size(49, 25);
            darkTitle6.TabIndex = 15;
            darkTitle6.Text = "Little";
            // 
            // darkGroupBox4
            // 
            darkGroupBox4.Controls.Add(darkCheckBox2);
            darkGroupBox4.Controls.Add(darkTitle14);
            darkGroupBox4.Controls.Add(pictureBox2);
            darkGroupBox4.Controls.Add(darkTitle10);
            darkGroupBox4.Controls.Add(pictureBox1);
            darkGroupBox4.Location = new Point(20, 457);
            darkGroupBox4.Name = "darkGroupBox4";
            darkGroupBox4.Size = new Size(719, 99);
            darkGroupBox4.TabIndex = 29;
            darkGroupBox4.TabStop = false;
            darkGroupBox4.Text = "Particle Color";
            // 
            // darkCheckBox2
            // 
            darkCheckBox2.AutoSize = true;
            darkCheckBox2.Location = new Point(45, 40);
            darkCheckBox2.Name = "darkCheckBox2";
            darkCheckBox2.Offset = 1;
            darkCheckBox2.Size = new Size(195, 29);
            darkCheckBox2.TabIndex = 34;
            darkCheckBox2.Text = "Use Only One Color";
            // 
            // darkTitle14
            // 
            darkTitle14.Location = new Point(536, 39);
            darkTitle14.Margin = new Padding(3, 0, 3, 15);
            darkTitle14.Name = "darkTitle14";
            darkTitle14.Size = new Size(113, 30);
            darkTitle14.TabIndex = 33;
            darkTitle14.Text = "Lower Color ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(658, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // darkTitle10
            // 
            darkTitle10.Location = new Point(359, 39);
            darkTitle10.Margin = new Padding(3, 0, 3, 15);
            darkTitle10.Name = "darkTitle10";
            darkTitle10.Size = new Size(113, 30);
            darkTitle10.TabIndex = 31;
            darkTitle10.Text = "Upper Color ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(478, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // darkGroupBox3
            // 
            darkGroupBox3.Controls.Add(darkNumericUpDown2);
            darkGroupBox3.Controls.Add(darkNumericUpDown1);
            darkGroupBox3.Controls.Add(darkTitle13);
            darkGroupBox3.Controls.Add(darkTitle9);
            darkGroupBox3.Controls.Add(darkNumericUpDown3);
            darkGroupBox3.Controls.Add(darkTitle12);
            darkGroupBox3.Controls.Add(darkTitle11);
            darkGroupBox3.Location = new Point(20, 324);
            darkGroupBox3.Name = "darkGroupBox3";
            darkGroupBox3.Size = new Size(722, 107);
            darkGroupBox3.TabIndex = 28;
            darkGroupBox3.TabStop = false;
            darkGroupBox3.Text = "Particle Velocity";
            // 
            // darkNumericUpDown2
            // 
            darkNumericUpDown2.Location = new Point(514, 42);
            darkNumericUpDown2.Name = "darkNumericUpDown2";
            darkNumericUpDown2.Size = new Size(72, 31);
            darkNumericUpDown2.TabIndex = 30;
            // 
            // darkNumericUpDown1
            // 
            darkNumericUpDown1.Location = new Point(403, 42);
            darkNumericUpDown1.Name = "darkNumericUpDown1";
            darkNumericUpDown1.Size = new Size(72, 31);
            darkNumericUpDown1.TabIndex = 29;
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
            // darkNumericUpDown3
            // 
            darkNumericUpDown3.Location = new Point(286, 42);
            darkNumericUpDown3.Name = "darkNumericUpDown3";
            darkNumericUpDown3.Size = new Size(72, 31);
            darkNumericUpDown3.TabIndex = 23;
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
            // darkButton6
            // 
            darkButton6.BorderColour = Color.Empty;
            darkButton6.CustomColour = false;
            darkButton6.FlatBottom = false;
            darkButton6.FlatTop = false;
            darkButton6.Location = new Point(459, 91);
            darkButton6.Name = "darkButton6";
            darkButton6.Padding = new Padding(5);
            darkButton6.Size = new Size(203, 34);
            darkButton6.TabIndex = 20;
            darkButton6.Text = "Save As New Preset";
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
            darkButton4.Text = "Save Preset";
            darkButton4.Click += darkButton4_Click;
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
            // EnvironmentEditor
            // 
            AcceptButton = darkButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = darkButton2;
            ClientSize = new Size(822, 897);
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
            Text = " Environment Editor";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            fogSettingsBox.ResumeLayout(false);
            fogSettingsBox.PerformLayout();
            darkGroupBox1.ResumeLayout(false);
            darkGroupBox1.PerformLayout();
            darkGroupBox2.ResumeLayout(false);
            darkGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            darkGroupBox4.ResumeLayout(false);
            darkGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            darkGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)darkNumericUpDown3).EndInit();
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
        private TrackBar trackBar2;
        private AltUI.Controls.DarkTitle darkTitle6;
        private AltUI.Controls.DarkTitle darkTitle7;
        private AltUI.Controls.DarkTitle darkTitle8;
        private AltUI.Controls.DarkButton darkButton6;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDown3;
        private AltUI.Controls.DarkGroupBox darkGroupBox2;
        private AltUI.Controls.DarkTitle darkTitle12;
        private AltUI.Controls.DarkTitle darkTitle11;
        private AltUI.Controls.DarkGroupBox darkGroupBox3;
        private AltUI.Controls.DarkTitle darkTitle13;
        private AltUI.Controls.DarkTitle darkTitle9;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDown2;
        private AltUI.Controls.DarkNumericUpDown darkNumericUpDown1;
        private AltUI.Controls.DarkGroupBox darkGroupBox4;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private PictureBox pictureBox1;
        private AltUI.Controls.DarkTitle darkTitle10;
        private AltUI.Controls.DarkTitle darkTitle14;
        private PictureBox pictureBox2;
        private AltUI.Controls.DarkCheckBox darkCheckBox2;
    }
}