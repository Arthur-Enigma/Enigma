using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Enigma
{
    public partial class SReflectors : FSettings
    {
        public SReflectors()
        {
            InitializeComponent();
        }

        private void SReflectors_Load(object sender, EventArgs e)
        {
            TempName = DataStorage.Settings.Default.Reflectors.Keys.ToList();
            TempValue = DataStorage.Settings.Default.Reflectors.Values.ToList();
            TempName = ConvertListToShow(TempName);
            listBox.Items.AddRange(TempName.ToArray());
            listBox.SelectedIndex = 0;
        } 

        private void Add_Click(object sender, EventArgs e)
        {
            Add("Reflector", GenerateCode(Settings.Reflector), this.listBox);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Del(this.listBox);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string str = GenerateCode(Settings.Reflector);
            TempValue[listBox.SelectedIndex] = str;
            SetText(str);
        } 

        private void Save_Click(object sender, EventArgs e)
        {
            SaveParams(TempName, TempName, DataStorage.Settings.Default.Reflectors);
        } 

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TempValue[listBox.SelectedIndex]);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetText(Clipboard.GetText());
            TempValue[listBox.SelectedIndex] = Clipboard.GetText();
        }

        private void SetDefaultValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> DefaultValues = GetDefaultValues().Value;
            for (int i = 0; i < DefaultValues.Count; i++)
                TempValue[i] = DefaultValues[i];
            for (int i = DefaultValues.Count; i < TempValue.Count; i++)
                TempValue[i] = null;
            for (int i = DefaultValues.Count; i < listBox.Items.Count; i++)
                Del(listBox, i);
            listBox.SelectedIndex = 0;
            SetText(TempValue[listBox.SelectedIndex]);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
                SetText(TempValue[listBox.SelectedIndex]);            
            ControllDelete(del, this.listBox);
        }

        private void SReflectors_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> Changed = GetChanged(DataStorage.Settings.Default.Reflectors);
            List<string> Added = GetAdded(DataStorage.Settings.Default.Reflectors, listBox);

            if (Changed.Count != 0 || Added.Count != 0)
            {
                List<string> ResultChanged = new List<string>();
                List<string> ResultAdded = new List<string>();

                SaveProp saveProp = new SaveProp(Changed, Added, ref ResultChanged, ref ResultAdded);
                DialogResult status = saveProp.ShowDialog();
                if (status == DialogResult.Cancel)
                    e.Cancel = true;
                else if (status == DialogResult.OK)
                    SaveParams(ResultChanged, ResultAdded, DataStorage.Settings.Default.Reflectors);
                saveProp.Close();
            }
        } 

        private void SetText(string text)
        {
            if (IsValueValid(text, Settings.Reflector))
            {
                maskedTextBox1.Text = text.Substring(0, 79);
                maskedTextBox2.Text = text.Substring(80, 80);
                maskedTextBox3.Text = text.Substring(160, 80);
                maskedTextBox4.Text = text.Substring(240, 80);
                maskedTextBox5.Text = text.Substring(320, 79);
            }
        }

        public static void SetDefaultValues()
        {
            DataStorage.Settings.Default.Reflectors = new DataStorage.SerializableStringDictionary
                {
                    { "Reflector 1000", DataStorage.Properties.Reflectors.Reflector1000 },
                    { "Reflector 1001", DataStorage.Properties.Reflectors.Reflector1001 },
                    { "Reflector 1002", DataStorage.Properties.Reflectors.Reflector1002 },
                    { "Reflector 1003", DataStorage.Properties.Reflectors.Reflector1003 },
                    { "Reflector 1004", DataStorage.Properties.Reflectors.Reflector1004 },
                    { "Reflector 1005", DataStorage.Properties.Reflectors.Reflector1005 },
                    { "Reflector 1006", DataStorage.Properties.Reflectors.Reflector1006 },
                    { "Reflector 1007", DataStorage.Properties.Reflectors.Reflector1007 },
                    { "Reflector 1008", DataStorage.Properties.Reflectors.Reflector1008 },
                    { "Reflector 1009", DataStorage.Properties.Reflectors.Reflector1009 },
                    { "Reflector 1010", DataStorage.Properties.Reflectors.Reflector1010 },
                    { "Reflector 1011", DataStorage.Properties.Reflectors.Reflector1011 },
                    { "Reflector 1012", DataStorage.Properties.Reflectors.Reflector1012 },
                    { "Reflector 1013", DataStorage.Properties.Reflectors.Reflector1013 },
                    { "Reflector 1014", DataStorage.Properties.Reflectors.Reflector1014 },
                    { "Reflector 1015", DataStorage.Properties.Reflectors.Reflector1015 }
                };
            DataStorage.Settings.Default.Save();
            DataStorage.Settings.Default.Reload();
        }

        private KeyValuePair<List<string>, List<string>> GetDefaultValues()
        {
            return new KeyValuePair<List<string>, List<string>>(new List<string>(new string[]
            { "Reflector 1000", "Reflector 1001", "Reflector 1002", "Reflector 1003", "Reflector 1004", "Reflector 1005", "Reflector 1006", "Reflector 1007", "Reflector 1008", "Reflector 1009",
              "Reflector 1010", "Reflector 1011", "Reflector 1012", "Reflector 1013", "Reflector 1014", "Reflector 1015", }),
            new List<string>(new string[] {
                DataStorage.Properties.Reflectors.Reflector1000, DataStorage.Properties.Reflectors.Reflector1001, DataStorage.Properties.Reflectors.Reflector1002,
                DataStorage.Properties.Reflectors.Reflector1003, DataStorage.Properties.Reflectors.Reflector1004, DataStorage.Properties.Reflectors.Reflector1005,
                DataStorage.Properties.Reflectors.Reflector1006, DataStorage.Properties.Reflectors.Reflector1007, DataStorage.Properties.Reflectors.Reflector1008,
                DataStorage.Properties.Reflectors.Reflector1009, DataStorage.Properties.Reflectors.Reflector1010, DataStorage.Properties.Reflectors.Reflector1011,
                DataStorage.Properties.Reflectors.Reflector1012, DataStorage.Properties.Reflectors.Reflector1013, DataStorage.Properties.Reflectors.Reflector1014,
                DataStorage.Properties.Reflectors.Reflector1015 }));
        }
    }
}