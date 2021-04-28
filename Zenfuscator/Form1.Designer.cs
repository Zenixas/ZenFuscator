
namespace Zenfuscator
{
    partial class Form1
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(23, 81);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(241, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(276, 81);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(127, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Select file";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(23, 159);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Name protection";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(23, 201);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(161, 15);
            this.metroCheckBox2.TabIndex = 3;
            this.metroCheckBox2.Text = "Fake obfuscation attribute";
            this.metroCheckBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(23, 138);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(97, 15);
            this.metroCheckBox3.TabIndex = 4;
            this.metroCheckBox3.Text = "Junk Attribute";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseSelectable = true;
            this.metroCheckBox3.CheckedChanged += new System.EventHandler(this.metroCheckBox3_CheckedChanged);
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(23, 180);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(85, 15);
            this.metroCheckBox4.TabIndex = 5;
            this.metroCheckBox4.Text = "Anti de4dot";
            this.metroCheckBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox4.UseSelectable = true;
            this.metroCheckBox4.CheckedChanged += new System.EventHandler(this.metroCheckBox4_CheckedChanged);
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(23, 117);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(101, 15);
            this.metroCheckBox5.TabIndex = 6;
            this.metroCheckBox5.Text = "Encrypt strings";
            this.metroCheckBox5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox5.UseSelectable = true;
            this.metroCheckBox5.CheckedChanged += new System.EventHandler(this.metroCheckBox5_CheckedChanged);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "100"};
            this.metroTextBox2.Location = new System.Drawing.Point(276, 139);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(127, 23);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.Text = "100";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(276, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Number of attribute";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(276, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "File name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "ZEN"};
            this.metroTextBox3.Location = new System.Drawing.Point(276, 187);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(127, 23);
            this.metroTextBox3.TabIndex = 10;
            this.metroTextBox3.Text = "ZEN";
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(276, 216);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(127, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Protect!";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "𝘗𝘙𝘖𝘑𝘌𝘊𝘛 𝘡𝘌𝘕";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

