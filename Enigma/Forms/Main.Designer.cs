namespace Enigma
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Treated_text = new System.Windows.Forms.TextBox();
            this.Original_text = new System.Windows.Forms.TextBox();
            this.Rotor1Value = new System.Windows.Forms.ComboBox();
            this.Rotor2Value = new System.Windows.Forms.ComboBox();
            this.execute = new System.Windows.Forms.Button();
            this.swap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commutatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflector = new System.Windows.Forms.ComboBox();
            this.commuter = new System.Windows.Forms.ComboBox();
            this.rotor1 = new System.Windows.Forms.ComboBox();
            this.rotor2 = new System.Windows.Forms.ComboBox();
            this.rotor3 = new System.Windows.Forms.ComboBox();
            this.Rotor3Value = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Treated_text
            // 
            this.Treated_text.Location = new System.Drawing.Point(12, 261);
            this.Treated_text.Multiline = true;
            this.Treated_text.Name = "Treated_text";
            this.Treated_text.ReadOnly = true;
            this.Treated_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Treated_text.Size = new System.Drawing.Size(720, 225);
            this.Treated_text.TabIndex = 3;
            // 
            // Original_text
            // 
            this.Original_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Original_text.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Original_text.Location = new System.Drawing.Point(12, 26);
            this.Original_text.Multiline = true;
            this.Original_text.Name = "Original_text";
            this.Original_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Original_text.Size = new System.Drawing.Size(720, 225);
            this.Original_text.TabIndex = 4;
            // 
            // Rotor1Value
            // 
            this.Rotor1Value.FormattingEnabled = true;
            this.Rotor1Value.Location = new System.Drawing.Point(738, 26);
            this.Rotor1Value.Name = "Rotor1Value";
            this.Rotor1Value.Size = new System.Drawing.Size(73, 21);
            this.Rotor1Value.TabIndex = 5;
            // 
            // Rotor2Value
            // 
            this.Rotor2Value.FormattingEnabled = true;
            this.Rotor2Value.Location = new System.Drawing.Point(817, 27);
            this.Rotor2Value.Name = "Rotor2Value";
            this.Rotor2Value.Size = new System.Drawing.Size(73, 21);
            this.Rotor2Value.TabIndex = 6;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(738, 421);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(169, 65);
            this.execute.TabIndex = 8;
            this.execute.TabStop = false;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // swap
            // 
            this.swap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swap.BackgroundImage")));
            this.swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swap.Location = new System.Drawing.Point(913, 421);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(50, 65);
            this.swap.TabIndex = 9;
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutProgrammToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reflectorsToolStripMenuItem,
            this.commutatorsToolStripMenuItem,
            this.rotorsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // reflectorsToolStripMenuItem
            // 
            this.reflectorsToolStripMenuItem.Name = "reflectorsToolStripMenuItem";
            this.reflectorsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.reflectorsToolStripMenuItem.Text = "Reflectors";
            this.reflectorsToolStripMenuItem.Click += new System.EventHandler(this.ReflectorsToolStripMenuItem_Click);
            // 
            // commutatorsToolStripMenuItem
            // 
            this.commutatorsToolStripMenuItem.Name = "commutatorsToolStripMenuItem";
            this.commutatorsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.commutatorsToolStripMenuItem.Text = "Commuters";
            this.commutatorsToolStripMenuItem.Click += new System.EventHandler(this.CommutersToolStripMenuItem_Click);
            // 
            // rotorsToolStripMenuItem
            // 
            this.rotorsToolStripMenuItem.Name = "rotorsToolStripMenuItem";
            this.rotorsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.rotorsToolStripMenuItem.Text = "Rotors";
            this.rotorsToolStripMenuItem.Click += new System.EventHandler(this.RotorsToolStripMenuItem_Click);
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutProgrammToolStripMenuItem.Text = "About programm";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.AboutProgrammToolStripMenuItem_Click);
            // 
            // reflector
            // 
            this.reflector.FormattingEnabled = true;
            this.reflector.Location = new System.Drawing.Point(739, 81);
            this.reflector.Name = "reflector";
            this.reflector.Size = new System.Drawing.Size(103, 21);
            this.reflector.TabIndex = 11;
            // 
            // commuter
            // 
            this.commuter.FormattingEnabled = true;
            this.commuter.Location = new System.Drawing.Point(866, 81);
            this.commuter.Name = "commuter";
            this.commuter.Size = new System.Drawing.Size(103, 21);
            this.commuter.TabIndex = 12;
            // 
            // rotor1
            // 
            this.rotor1.FormattingEnabled = true;
            this.rotor1.Location = new System.Drawing.Point(739, 54);
            this.rotor1.Name = "rotor1";
            this.rotor1.Size = new System.Drawing.Size(72, 21);
            this.rotor1.TabIndex = 13;
            // 
            // rotor2
            // 
            this.rotor2.FormattingEnabled = true;
            this.rotor2.Location = new System.Drawing.Point(895, 54);
            this.rotor2.Name = "rotor2";
            this.rotor2.Size = new System.Drawing.Size(72, 21);
            this.rotor2.TabIndex = 14;
            // 
            // rotor3
            // 
            this.rotor3.FormattingEnabled = true;
            this.rotor3.Location = new System.Drawing.Point(817, 54);
            this.rotor3.Name = "rotor3";
            this.rotor3.Size = new System.Drawing.Size(72, 21);
            this.rotor3.TabIndex = 15;
            // 
            // Rotor3Value
            // 
            this.Rotor3Value.FormattingEnabled = true;
            this.Rotor3Value.Location = new System.Drawing.Point(896, 27);
            this.Rotor3Value.Name = "Rotor3Value";
            this.Rotor3Value.Size = new System.Drawing.Size(73, 21);
            this.Rotor3Value.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 501);
            this.Controls.Add(this.rotor3);
            this.Controls.Add(this.rotor2);
            this.Controls.Add(this.rotor1);
            this.Controls.Add(this.commuter);
            this.Controls.Add(this.reflector);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.Rotor3Value);
            this.Controls.Add(this.Rotor2Value);
            this.Controls.Add(this.Rotor1Value);
            this.Controls.Add(this.Original_text);
            this.Controls.Add(this.Treated_text);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(995, 540);
            this.MinimumSize = new System.Drawing.Size(995, 540);
            this.Name = "Main";
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Treated_text;
        private System.Windows.Forms.TextBox Original_text;
        private System.Windows.Forms.ComboBox Rotor1Value;
        private System.Windows.Forms.ComboBox Rotor2Value;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commutatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.ComboBox reflector;
        private System.Windows.Forms.ComboBox commuter;
        private System.Windows.Forms.ComboBox rotor1;
        private System.Windows.Forms.ComboBox rotor2;
        private System.Windows.Forms.ComboBox rotor3;
        private System.Windows.Forms.ComboBox Rotor3Value;
    }
}

