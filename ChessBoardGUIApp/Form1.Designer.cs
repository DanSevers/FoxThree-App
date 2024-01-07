namespace ChessBoardGUIApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a weapon from the dropdown menu and click any cell.";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PowderBlue;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Target", "AIM-120", "AIRS-T", "AGM-88", "GBU-38", "Vulcan Cannon" });
            comboBox1.Location = new Point(646, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(22, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 925);
            panel1.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumTurquoise;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(427, 972);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(152, 28);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Cells";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(971, 1012);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            ForeColor = Color.DarkSlateGray;
            Name = "Form1";
            Text = "Fox Three Targetting App";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnClear;
    }
}
