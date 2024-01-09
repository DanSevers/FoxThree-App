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
            label3 = new Label();
            label4 = new Label();
            btnAim120 = new Button();
            btnAirst = new Button();
            btnAgm88 = new Button();
            btnGbu38 = new Button();
            btnVulcan = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 15);
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
            comboBox1.Location = new Point(1036, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(274, 41);
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
            btnClear.BackColor = Color.DarkCyan;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.MintCream;
            btnClear.Location = new Point(46, 513);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(173, 38);
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
            panel2.Location = new Point(1227, 62);
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
            label2.Location = new Point(1323, 27);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 10;
            label2.Text = "FLARES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(-3, -4);
            label3.Name = "label3";
            label3.Size = new Size(281, 80);
            label3.TabIndex = 11;
            label3.Text = "FoxThree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(246, 34);
            label4.TabIndex = 12;
            label4.Text = "Choose your weapon";
            // 
            // btnAim120
            // 
            btnAim120.BackColor = Color.LightBlue;
            btnAim120.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAim120.Location = new Point(23, 208);
            btnAim120.Name = "btnAim120";
            btnAim120.Size = new Size(227, 41);
            btnAim120.TabIndex = 13;
            btnAim120.Text = "AIM-120";
            btnAim120.UseVisualStyleBackColor = false;
            btnAim120.MouseEnter += MyButton_MouseEnter;
            btnAim120.MouseLeave += MyButton_MouseLeave;
            // 
            // btnAirst
            // 
            btnAirst.BackColor = Color.LightSalmon;
            btnAirst.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAirst.Location = new Point(23, 266);
            btnAirst.Name = "btnAirst";
            btnAirst.Size = new Size(227, 41);
            btnAirst.TabIndex = 14;
            btnAirst.Text = "AIRS-T";
            btnAirst.UseVisualStyleBackColor = false;
            btnAirst.MouseEnter += MyButton_MouseEnter;
            btnAirst.MouseLeave += MyButton_MouseLeave;
            // 
            // btnAgm88
            // 
            btnAgm88.BackColor = Color.GhostWhite;
            btnAgm88.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgm88.Location = new Point(23, 323);
            btnAgm88.Name = "btnAgm88";
            btnAgm88.Size = new Size(227, 41);
            btnAgm88.TabIndex = 15;
            btnAgm88.Text = "AGM-88";
            btnAgm88.UseVisualStyleBackColor = false;
            btnAgm88.MouseEnter += MyButton_MouseEnter;
            btnAgm88.MouseLeave += MyButton_MouseLeave;
            // 
            // btnGbu38
            // 
            btnGbu38.BackColor = Color.DarkSeaGreen;
            btnGbu38.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGbu38.Location = new Point(23, 379);
            btnGbu38.Name = "btnGbu38";
            btnGbu38.Size = new Size(227, 41);
            btnGbu38.TabIndex = 16;
            btnGbu38.Text = "GBU-38";
            btnGbu38.UseVisualStyleBackColor = false;
            btnGbu38.MouseEnter += MyButton_MouseEnter;
            btnGbu38.MouseLeave += MyButton_MouseLeave;
            // 
            // btnVulcan
            // 
            btnVulcan.BackColor = Color.LightGray;
            btnVulcan.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVulcan.Location = new Point(23, 436);
            btnVulcan.Name = "btnVulcan";
            btnVulcan.Size = new Size(227, 41);
            btnVulcan.TabIndex = 17;
            btnVulcan.Text = "Vulcan Cannon";
            btnVulcan.UseVisualStyleBackColor = false;
            btnVulcan.MouseEnter += MyButton_MouseEnter;
            btnVulcan.MouseLeave += MyButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1530, 1012);
            Controls.Add(btnVulcan);
            Controls.Add(btnGbu38);
            Controls.Add(btnAgm88);
            Controls.Add(btnAirst);
            Controls.Add(btnAim120);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClear);
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
        private Label label4;
        private Label label3;
        private Button btnVulcan;
        private Button btnGbu38;
        private Button btnAgm88;
        private Button btnAirst;
        private Button btnAim120;
    }
}
