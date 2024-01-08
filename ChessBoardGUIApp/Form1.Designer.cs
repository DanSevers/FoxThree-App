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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            btnClear = new Button();
            btnFlare1 = new Button();
            btnFlare2 = new Button();
            btnFlare3 = new Button();
            lblFlare1 = new Label();
            lblFlare2 = new Label();
            lblFlare3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
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
            // btnFlare1
            // 
            btnFlare1.BackColor = Color.Red;
            btnFlare1.Location = new Point(24, 61);
            btnFlare1.Name = "btnFlare1";
            btnFlare1.Size = new Size(111, 42);
            btnFlare1.TabIndex = 4;
            btnFlare1.Text = "Flare";
            btnFlare1.UseVisualStyleBackColor = false;
            btnFlare1.Click += btnFlare1_Click;
            // 
            // btnFlare2
            // 
            btnFlare2.BackColor = Color.Red;
            btnFlare2.Location = new Point(24, 146);
            btnFlare2.Name = "btnFlare2";
            btnFlare2.Size = new Size(111, 42);
            btnFlare2.TabIndex = 5;
            btnFlare2.Text = "Flare";
            btnFlare2.UseVisualStyleBackColor = false;
            // 
            // btnFlare3
            // 
            btnFlare3.BackColor = Color.Red;
            btnFlare3.Location = new Point(24, 228);
            btnFlare3.Name = "btnFlare3";
            btnFlare3.Size = new Size(111, 42);
            btnFlare3.TabIndex = 6;
            btnFlare3.Text = "Flare";
            btnFlare3.UseVisualStyleBackColor = false;
            // 
            // lblFlare1
            // 
            lblFlare1.AutoSize = true;
            lblFlare1.BackColor = Color.Black;
            lblFlare1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlare1.ForeColor = Color.Chartreuse;
            lblFlare1.Location = new Point(141, 73);
            lblFlare1.Name = "lblFlare1";
            lblFlare1.Size = new Size(122, 30);
            lblFlare1.TabIndex = 7;
            lblFlare1.Text = "undeployed";
            // 
            // lblFlare2
            // 
            lblFlare2.AutoSize = true;
            lblFlare2.BackColor = Color.Black;
            lblFlare2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlare2.ForeColor = Color.Chartreuse;
            lblFlare2.Location = new Point(141, 158);
            lblFlare2.Name = "lblFlare2";
            lblFlare2.Size = new Size(122, 30);
            lblFlare2.TabIndex = 8;
            lblFlare2.Text = "undeployed";
            // 
            // lblFlare3
            // 
            lblFlare3.AutoSize = true;
            lblFlare3.BackColor = Color.Black;
            lblFlare3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlare3.ForeColor = Color.Chartreuse;
            lblFlare3.Location = new Point(141, 240);
            lblFlare3.Name = "lblFlare3";
            lblFlare3.Size = new Size(122, 30);
            lblFlare3.TabIndex = 9;
            lblFlare3.Text = "undeployed";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(lblFlare2);
            panel2.Controls.Add(lblFlare3);
            panel2.Controls.Add(btnFlare3);
            panel2.Controls.Add(btnFlare1);
            panel2.Controls.Add(lblFlare1);
            panel2.Controls.Add(btnFlare2);
            panel2.Location = new Point(986, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 328);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(1082, 35);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 10;
            label2.Text = "FLARES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1313, 1012);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            ForeColor = Color.DarkSlateGray;
            Name = "Form1";
            Text = "Fox Three Targetting App";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnClear;
        private Label lblFlare3;
        private Label lblFlare2;
        private Label lblFlare1;
        private Button btnFlare3;
        private Button btnFlare2;
        private Button btnFlare1;
        private Panel panel2;
        private Label label2;
    }
}
