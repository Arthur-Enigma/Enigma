namespace Enigma
{
    partial class SRotors
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listBox = new DataStorage.ListBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(245, 12);
            this.maskedTextBox1.Mask = "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(381, 20);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(466, 223);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(160, 40);
            this.save.TabIndex = 20;
            this.save.TabStop = false;
            this.save.Text = "Save all";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(279, 223);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(181, 40);
            this.generate.TabIndex = 19;
            this.generate.TabStop = false;
            this.generate.Text = "Generate random value";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Value:";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(233, 223);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(40, 40);
            this.del.TabIndex = 17;
            this.del.TabStop = false;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(187, 223);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 40);
            this.add.TabIndex = 16;
            this.add.TabStop = false;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listBox
            // 
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(169, 251);
            this.listBox.TabIndex = 15;
            this.listBox.TabStop = false;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(245, 38);
            this.maskedTextBox2.Mask = "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(381, 20);
            this.maskedTextBox2.TabIndex = 22;
            this.maskedTextBox2.TabStop = false;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(245, 64);
            this.maskedTextBox3.Mask = "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(381, 20);
            this.maskedTextBox3.TabIndex = 23;
            this.maskedTextBox3.TabStop = false;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(245, 90);
            this.maskedTextBox4.Mask = "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(381, 20);
            this.maskedTextBox4.TabIndex = 24;
            this.maskedTextBox4.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.setDefaultValuesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.copyToolStripMenuItem.Text = "Copy selected value";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pasteToolStripMenuItem.Text = "Paste selected value";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // setDefaultValuesToolStripMenuItem
            // 
            this.setDefaultValuesToolStripMenuItem.Name = "setDefaultValuesToolStripMenuItem";
            this.setDefaultValuesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.setDefaultValuesToolStripMenuItem.Text = "Set default values";
            this.setDefaultValuesToolStripMenuItem.Click += new System.EventHandler(this.SetDefaultValuesToolStripMenuItem_Click);
            // 
            // SRotors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 276);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 315);
            this.MinimumSize = new System.Drawing.Size(654, 315);
            this.Name = "SRotors";
            this.Text = "Rotor Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SRotors_FormClosing);
            this.Load += new System.EventHandler(this.Rotors_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private DataStorage.ListBox listBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultValuesToolStripMenuItem;
    }
}