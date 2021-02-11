using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Enigma
{
    public partial class SRotors : FSettings
    {
        public SRotors()
        {
            InitializeComponent();
        }

        private void Rotors_Load(object sender, EventArgs e)
        {
            TempName = DataStorage.Settings.Default.Rotors.Keys.ToList();
            TempValue = DataStorage.Settings.Default.Rotors.Values.ToList();
            TempName = ConvertListToShow(TempName);
            listBox.Items.AddRange(TempName.ToArray());
            listBox.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add("Rotor", GenerateCode(Settings.Rotor), listBox);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Del(listBox);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string str = GenerateCode(Settings.Rotor);
            TempValue[listBox.SelectedIndex] = str;
            SetText(str);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveParams(TempName, TempName, DataStorage.Settings.Default.Rotors);
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

        private void SRotors_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> Changed = GetChanged(DataStorage.Settings.Default.Rotors);
            List<string> Added = GetAdded(DataStorage.Settings.Default.Rotors, listBox);

            if (Changed.Count != 0 || Added.Count != 0)
            {
                List<string> ResultChanged = new List<string>();
                List<string> ResultAdded = new List<string>();

                SaveProp saveProp = new SaveProp(Changed, Added, ref ResultChanged, ref ResultAdded);
                DialogResult status = saveProp.ShowDialog();
                if (status == DialogResult.Cancel)
                    e.Cancel = true;
                else if (status == DialogResult.OK)
                    SaveParams(ResultChanged, ResultAdded, DataStorage.Settings.Default.Rotors);
                saveProp.Close();
            }
        }

        private void SetText(string text)
        {
            if (IsValueValid(text, Settings.Rotor))
            {
                maskedTextBox1.Text = text.Substring(0, 74);
                maskedTextBox2.Text = text.Substring(75, 74);
                maskedTextBox3.Text = text.Substring(150, 74);
                maskedTextBox4.Text = text.Substring(225, 74);
            }
        
        }

        public static void SetDefaultValues()
        {
            DataStorage.Settings.Default.Rotors = new DataStorage.SerializableStringDictionary
                {
                    { "Rotor 1000", DataStorage.Properties.Rotors.Rotor1000 },
                    { "Rotor 1001", DataStorage.Properties.Rotors.Rotor1001 },
                    { "Rotor 1002", DataStorage.Properties.Rotors.Rotor1002 },
                    { "Rotor 1003", DataStorage.Properties.Rotors.Rotor1003 },
                    { "Rotor 1004", DataStorage.Properties.Rotors.Rotor1004 },
                    { "Rotor 1005", DataStorage.Properties.Rotors.Rotor1005 },
                    { "Rotor 1006", DataStorage.Properties.Rotors.Rotor1006 },
                    { "Rotor 1007", DataStorage.Properties.Rotors.Rotor1007 },
                    { "Rotor 1008", DataStorage.Properties.Rotors.Rotor1008 },
                    { "Rotor 1009", DataStorage.Properties.Rotors.Rotor1009 },
                    { "Rotor 1010", DataStorage.Properties.Rotors.Rotor1010 },
                    { "Rotor 1011", DataStorage.Properties.Rotors.Rotor1011 },
                    { "Rotor 1012", DataStorage.Properties.Rotors.Rotor1012 },
                    { "Rotor 1013", DataStorage.Properties.Rotors.Rotor1013 },
                    { "Rotor 1014", DataStorage.Properties.Rotors.Rotor1014 },
                    { "Rotor 1015", DataStorage.Properties.Rotors.Rotor1015 }
                };
            DataStorage.Settings.Default.Save();
            DataStorage.Settings.Default.Reload();
        }

        private KeyValuePair<List<string>, List<string>> GetDefaultValues()
        {
            return new KeyValuePair<List<string>, List<string>>(new List<string>(new string[]
            { "Rotor 1000", "Rotor 1001", "Rotor 1002", "Rotor 1003", "Rotor 1004", "Rotor 1005", "Rotor 1006", "Rotor 1007", "Rotor 1008", "Rotor 1009",
              "Rotor 1010", "Rotor 1011", "Rotor 1012", "Rotor 1013", "Rotor 1014", "Rotor 1015" }),
            new List<string>(new string[] {
                DataStorage.Properties.Rotors.Rotor1000, DataStorage.Properties.Rotors.Rotor1001, DataStorage.Properties.Rotors.Rotor1002,
                DataStorage.Properties.Rotors.Rotor1003, DataStorage.Properties.Rotors.Rotor1004, DataStorage.Properties.Rotors.Rotor1005,
                DataStorage.Properties.Rotors.Rotor1006, DataStorage.Properties.Rotors.Rotor1007, DataStorage.Properties.Rotors.Rotor1008,
                DataStorage.Properties.Rotors.Rotor1009, DataStorage.Properties.Rotors.Rotor1010, DataStorage.Properties.Rotors.Rotor1011,
                DataStorage.Properties.Rotors.Rotor1012, DataStorage.Properties.Rotors.Rotor1013, DataStorage.Properties.Rotors.Rotor1014,
                DataStorage.Properties.Rotors.Rotor1015 }));
        }

    }
}
