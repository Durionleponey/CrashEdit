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
            darkCheckBox2 = new AltUI.Controls.DarkCheckBox();
            trackBar1 = new TrackBar();
            darkTitle1 = new AltUI.Controls.DarkTitle();
            darkTitle2 = new AltUI.Controls.DarkTitle();
            darkTitle3 = new AltUI.Controls.DarkTitle();
            darkButton1 = new AltUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // darkCheckBox1
            // 
            darkCheckBox1.AutoSize = true;
            darkCheckBox1.Location = new Point(64, 121);
            darkCheckBox1.Name = "darkCheckBox1";
            darkCheckBox1.Offset = 1;
            darkCheckBox1.Size = new Size(103, 29);
            darkCheckBox1.TabIndex = 1;
            darkCheckBox1.Text = "Use Fog";
            // 
            // darkCheckBox2
            // 
            darkCheckBox2.AutoSize = true;
            darkCheckBox2.Location = new Point(61, 209);
            darkCheckBox2.Name = "darkCheckBox2";
            darkCheckBox2.Offset = 1;
            darkCheckBox2.Size = new Size(106, 29);
            darkCheckBox2.TabIndex = 2;
            darkCheckBox2.Text = "Use Rain";
            darkCheckBox2.CheckedChanged += darkCheckBox2_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(313, 121);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(370, 69);
            trackBar1.TabIndex = 6;
            // 
            // darkTitle1
            // 
            darkTitle1.AutoSize = true;
            darkTitle1.Location = new Point(467, 165);
            darkTitle1.Name = "darkTitle1";
            darkTitle1.Size = new Size(115, 25);
            darkTitle1.TabIndex = 7;
            darkTitle1.Text = "Fog Distance";
            darkTitle1.Click += darkTitle1_Click;
            // 
            // darkTitle2
            // 
            darkTitle2.AutoSize = true;
            darkTitle2.Location = new Point(222, 125);
            darkTitle2.Name = "darkTitle2";
            darkTitle2.Size = new Size(94, 25);
            darkTitle2.TabIndex = 8;
            darkTitle2.Text = "Very Close";
            darkTitle2.Click += darkTitle2_Click;
            // 
            // darkTitle3
            // 
            darkTitle3.AutoSize = true;
            darkTitle3.Location = new Point(689, 121);
            darkTitle3.Name = "darkTitle3";
            darkTitle3.Size = new Size(74, 25);
            darkTitle3.TabIndex = 9;
            darkTitle3.Text = "Very Far";
            // 
            // darkButton1
            // 
            darkButton1.BorderColour = Color.Empty;
            darkButton1.CustomColour = false;
            darkButton1.FlatBottom = false;
            darkButton1.FlatTop = false;
            darkButton1.Location = new Point(633, 319);
            darkButton1.Name = "darkButton1";
            darkButton1.Padding = new Padding(5);
            darkButton1.Size = new Size(112, 34);
            darkButton1.TabIndex = 10;
            darkButton1.Text = "Ok";
            // 
            // EnvironmentEditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(darkButton1);
            Controls.Add(darkTitle3);
            Controls.Add(darkTitle2);
            Controls.Add(darkTitle1);
            Controls.Add(trackBar1);
            Controls.Add(darkCheckBox2);
            Controls.Add(darkCheckBox1);
            CornerStyle = CornerPreference.Default;
            Name = "EnvironmentEditor";
            Text = "EnvironmentEditor";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetCheckBox metroSetCheckBox1;
        private AltUI.Controls.DarkCheckBox darkCheckBox1;
        private AltUI.Controls.DarkCheckBox darkCheckBox2;
        private TrackBar trackBar1;
        private AltUI.Controls.DarkTitle darkTitle1;
        private AltUI.Controls.DarkTitle darkTitle2;
        private AltUI.Controls.DarkTitle darkTitle3;
        private AltUI.Controls.DarkButton darkButton1;
    }
}