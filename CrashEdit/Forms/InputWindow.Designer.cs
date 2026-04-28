using AltUI.Controls;

namespace CrashEdit.CE
{
    partial class InputWindow
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
            txtInput1 = new DarkTextBox();
            cmdCancel = new DarkButton();
            cmdOK = new DarkButton();
            lblInput1 = new Label();
            panel1 = new Panel();
            tblPanel = new TableLayoutPanel();
            panel2 = new Panel();
            lblInput2 = new Label();
            txtInput2 = new DarkTextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tblPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput1.BackColor = Color.FromArgb(26, 26, 28);
            txtInput1.BorderStyle = BorderStyle.FixedSingle;
            txtInput1.ForeColor = Color.FromArgb(213, 213, 213);
            txtInput1.Location = new Point(10, 40);
            txtInput1.Margin = new Padding(6, 5, 6, 5);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(428, 31);
            txtInput1.TabIndex = 0;
            txtInput1.TextChanged += txtInput1_TextChanged;
            // 
            // cmdCancel
            // 
            cmdCancel.BorderColour = Color.Empty;
            cmdCancel.CustomColour = false;
            cmdCancel.DialogResult = DialogResult.Cancel;
            cmdCancel.FlatBottom = false;
            cmdCancel.FlatTop = false;
            cmdCancel.Location = new Point(166, 5);
            cmdCancel.Margin = new Padding(6, 5, 6, 5);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Padding = new Padding(9, 10, 9, 10);
            cmdCancel.Size = new Size(114, 45);
            cmdCancel.TabIndex = 3;
            cmdCancel.Text = "Cancel";
            cmdCancel.Click += cmdCancel_Click;
            // 
            // cmdOK
            // 
            cmdOK.BorderColour = Color.Empty;
            cmdOK.CustomColour = false;
            cmdOK.FlatBottom = false;
            cmdOK.FlatTop = false;
            cmdOK.Location = new Point(40, 5);
            cmdOK.Margin = new Padding(6, 5, 6, 5);
            cmdOK.Name = "cmdOK";
            cmdOK.Padding = new Padding(9, 10, 9, 10);
            cmdOK.Size = new Size(114, 45);
            cmdOK.TabIndex = 2;
            cmdOK.Text = "OK";
            cmdOK.Click += cmdOK_Click;
            // 
            // lblInput1
            // 
            lblInput1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInput1.AutoSize = true;
            lblInput1.BackColor = Color.Transparent;
            lblInput1.Location = new Point(9, 10);
            lblInput1.Margin = new Padding(4, 0, 4, 0);
            lblInput1.Name = "lblInput1";
            lblInput1.Size = new Size(49, 25);
            lblInput1.TabIndex = 0;
            lblInput1.Text = "label";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblInput1);
            panel1.Controls.Add(txtInput1);
            panel1.Location = new Point(7, 8);
            panel1.Margin = new Padding(7, 8, 7, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 5, 4, 5);
            panel1.Size = new Size(449, 81);
            panel1.TabIndex = 0;
            // 
            // tblPanel
            // 
            tblPanel.AutoSize = true;
            tblPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblPanel.ColumnCount = 1;
            tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPanel.Controls.Add(panel2, 0, 1);
            tblPanel.Controls.Add(panel1, 0, 0);
            tblPanel.Controls.Add(panel3, 0, 2);
            tblPanel.Dock = DockStyle.Fill;
            tblPanel.Location = new Point(0, 0);
            tblPanel.Margin = new Padding(4, 5, 4, 5);
            tblPanel.Name = "tblPanel";
            tblPanel.RowCount = 3;
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tblPanel.Size = new Size(463, 282);
            tblPanel.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblInput2);
            panel2.Controls.Add(txtInput2);
            panel2.Location = new Point(7, 115);
            panel2.Margin = new Padding(7, 8, 7, 8);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4, 5, 4, 5);
            panel2.Size = new Size(449, 81);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // lblInput2
            // 
            lblInput2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInput2.AutoSize = true;
            lblInput2.BackColor = Color.Transparent;
            lblInput2.Location = new Point(9, 10);
            lblInput2.Margin = new Padding(4, 0, 4, 0);
            lblInput2.Name = "lblInput2";
            lblInput2.Size = new Size(49, 25);
            lblInput2.TabIndex = 1;
            lblInput2.Text = "label";
            // 
            // txtInput2
            // 
            txtInput2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput2.BackColor = Color.FromArgb(26, 26, 28);
            txtInput2.BorderStyle = BorderStyle.FixedSingle;
            txtInput2.ForeColor = Color.FromArgb(213, 213, 213);
            txtInput2.Location = new Point(9, 40);
            txtInput2.Margin = new Padding(6, 5, 6, 5);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(429, 31);
            txtInput2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(cmdOK);
            panel3.Controls.Add(cmdCancel);
            panel3.Location = new Point(173, 219);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 55);
            panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(6, 13);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 27);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // InputWindow
            // 
            AcceptButton = cmdOK;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = cmdCancel;
            ClientSize = new Size(463, 282);
            Controls.Add(tblPanel);
            CornerStyle = CornerPreference.Default;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputWindow";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.FromArgb(31, 31, 32);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tblPanel.ResumeLayout(false);
            tblPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DarkTextBox txtInput1;
        private DarkButton cmdCancel;
        private DarkButton cmdOK;
        private Label lblInput1;
        private Panel panel1;
        private TableLayoutPanel tblPanel;
        private Panel panel3;
        private Panel panel2;
        private Label lblInput2;
        private DarkTextBox txtInput2;
        private PictureBox pictureBox1;
    }
}