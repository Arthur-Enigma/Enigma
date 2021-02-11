namespace Enigma
{
    partial class SReflectors
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
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.listBox = new DataStorage.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(187, 226);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 40);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(233, 226);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(40, 40);
            this.del.TabIndex = 3;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value:";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(279, 226);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(181, 40);
            this.generate.TabIndex = 8;
            this.generate.Text = "Generate random value";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(466, 226);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(145, 40);
            this.save.TabIndex = 9;
            this.save.Text = "Save all";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.maskedTextBox1.Location = new System.Drawing.Point(245, 15);
            this.maskedTextBox1.Mask = "(00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(366, 20);
            this.maskedTextBox1.TabIndex = 10;
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
            // maskedTextBox2
            // 
            this.maskedTextBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.maskedTextBox2.Location = new System.Drawing.Point(245, 41);
            this.maskedTextBox2.Mask = "(00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) ";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(366, 20);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.maskedTextBox3.Location = new System.Drawing.Point(245, 67);
            this.maskedTextBox3.Mask = "(00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) ";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(366, 20);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.ContextMenuStrip = this.contextMenuStrip1;
            this.maskedTextBox4.Location = new System.Drawing.Point(245, 93);
            this.maskedTextBox4.Mask = "(00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) ";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(366, 20);
            this.maskedTextBox4.TabIndex = 13;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.ContextMenuStrip = this.contextMenuStrip1;
            this.maskedTextBox5.Location = new System.Drawing.Point(245, 119);
            this.maskedTextBox5.Mask = "(00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) (00-00) ";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(366, 20);
            this.maskedTextBox5.TabIndex = 14;
            // 
            // listBox
            // 
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 15);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(169, 251);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // SReflectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.maskedTextBox5);
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
            this.MaximumSize = new System.Drawing.Size(640, 320);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "SReflectors";
            this.Text = "Reflector Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SReflectors_FormClosing);
            this.Load += new System.EventHandler(this.SReflectors_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataStorage.ListBox listBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultValuesToolStripMenuItem;
    }
}