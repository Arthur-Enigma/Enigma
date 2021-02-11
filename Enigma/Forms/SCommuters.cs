using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Enigma
{
    public partial class SCommuters : FSettings
    {
        public SCommuters()
        {
            InitializeComponent();
        }

        private void SCommute_Load(object sender, EventArgs e)
        {
            TempName = DataStorage.Settings.Default.Commuters.Keys.ToList();
            TempValue = DataStorage.Settings.Default.Commuters.Values.ToList();
            TempName = ConvertListToShow(TempName);
            listBox.Items.AddRange(TempName.ToArray());
            listBox.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add("Commuter", GenerateCode(Settings.Commuter), listBox);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Del(listBox);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string str;
            do
            {
                str = GenerateCode(Settings.Commuter);
            } while (TempValue.Contains(str));
            TempValue[listBox.SelectedIndex] = str;
            SetText(str);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveParams(TempName, TempName, DataStorage.Settings.Default.Commuters);
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

        private void SCommute_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> Changed = GetChanged(DataStorage.Settings.Default.Commuters);
            List<string> Added = GetAdded(DataStorage.Settings.Default.Commuters, listBox);

            if (Changed.Count != 0 || Added.Count != 0)
            {
                List<string> ResultChanged = new List<string>();
                List<string> ResultAdded = new List<string>();

                SaveProp saveProp = new SaveProp(Changed, Added, ref ResultChanged, ref ResultAdded);
                DialogResult status = saveProp.ShowDialog();
                if (status == DialogResult.Cancel)
                    e.Cancel = true;
                else if (status == DialogResult.OK)
                    SaveParams(ResultChanged, ResultAdded, DataStorage.Settings.Default.Commuters);
                saveProp.Close();
            }
        }

        private void SetText(string text)
        {
            if (IsValueValid(text, Settings.Commuter))
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
            DataStorage.Settings.Default.Commuters = new DataStorage.SerializableStringDictionary
                {
                    { "Commuter 1000", DataStorage.Properties.Commuters.Commuter1000 },
                    { "Commuter 1001", DataStorage.Properties.Commuters.Commuter1001 },
                    { "Commuter 1002", DataStorage.Properties.Commuters.Commuter1002 },
                    { "Commuter 1003", DataStorage.Properties.Commuters.Commuter1003 },
                    { "Commuter 1004", DataStorage.Properties.Commuters.Commuter1004 },
                    { "Commuter 1005", DataStorage.Properties.Commuters.Commuter1005 },
                    { "Commuter 1006", DataStorage.Properties.Commuters.Commuter1006 },
                    { "Commuter 1007", DataStorage.Properties.Commuters.Commuter1007 },
                    { "Commuter 1008", DataStorage.Properties.Commuters.Commuter1008 },
                    { "Commuter 1009", DataStorage.Properties.Commuters.Commuter1009 },
                    { "Commuter 1010", DataStorage.Properties.Commuters.Commuter1010 },
                    { "Commuter 1011", DataStorage.Properties.Commuters.Commuter1011 },
                    { "Commuter 1012", DataStorage.Properties.Commuters.Commuter1012 },
                    { "Commuter 1013", DataStorage.Properties.Commuters.Commuter1013 },
                    { "Commuter 1014", DataStorage.Properties.Commuters.Commuter1014 },
                    { "Commuter 1015", DataStorage.Properties.Commuters.Commuter1015 }
                };
            DataStorage.Settings.Default.Save();
            DataStorage.Settings.Default.Reload();
        }

        private KeyValuePair<List<string>, List<string>> GetDefaultValues()
        {
            return new KeyValuePair<List<string>, List<string>>(new List<string>(new string[] 
            { "Commuter 1000", "Commuter 1001", "Commuter 1002", "Commuter 1003", "Commuter 1004", "Commuter 1005", "Commuter 1006", "Commuter 1007", "Commuter 1008", "Commuter 1009",
              "Commuter 1010", "Commuter 1011", "Commuter 1012", "Commuter 1013", "Commuter 1014", "Commuter 1015" }), 
            new List<string>(new string[] {
                DataStorage.Properties.Commuters.Commuter1000, DataStorage.Properties.Commuters.Commuter1001, DataStorage.Properties.Commuters.Commuter1002,
                DataStorage.Properties.Commuters.Commuter1003, DataStorage.Properties.Commuters.Commuter1004, DataStorage.Properties.Commuters.Commuter1005,
                DataStorage.Properties.Commuters.Commuter1006, DataStorage.Properties.Commuters.Commuter1007, DataStorage.Properties.Commuters.Commuter1008,
                DataStorage.Properties.Commuters.Commuter1009, DataStorage.Properties.Commuters.Commuter1010, DataStorage.Properties.Commuters.Commuter1011,
                DataStorage.Properties.Commuters.Commuter1012, DataStorage.Properties.Commuters.Commuter1013, DataStorage.Properties.Commuters.Commuter1014,
                DataStorage.Properties.Commuters.Commuter1015 }));
        }
    }
}