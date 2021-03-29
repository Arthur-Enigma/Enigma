using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Enigma
{
    public partial class SaveProp : Form
    {
        List<string> changed;
        List<string> added;
        List<string> ResultChanged;
        List<string> ResultAdded;

        public SaveProp(List<string> changed, List<string> added, ref List<string> ResultChanged, ref List<string> ResultAdded)
        {
            InitializeComponent();

            this.changed = changed;
            this.added = added;
            this.ResultChanged = ResultChanged;
            this.ResultAdded = ResultAdded;
        }

        private void SaveProp_Load(object sender, EventArgs e)
        {
                checkedListBox1.Items.AddRange(changed.ToArray());
                checkedListBox2.Items.AddRange(added.ToArray());
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, checkBox1.Checked);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, checkBox2.Checked);
            }
        }

        private void SaveProp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                {
                    string[] temp = new string[checkedListBox1.CheckedItems.Count];
                    checkedListBox1.CheckedItems.CopyTo(temp, 0);
                    ResultChanged.AddRange(temp);
                }

                {
                    string[] temp = new string[checkedListBox2.CheckedItems.Count];
                    checkedListBox2.CheckedItems.CopyTo(temp, 0);
                    ResultAdded.AddRange(temp);
                }
            }
        }
    }
}
