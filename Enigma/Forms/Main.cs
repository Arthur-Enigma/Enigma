
using System;
using System.Linq;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            Rotor1Value.Items.AddRange(Crypt.EnglishAlphabet);
            Rotor2Value.Items.AddRange(Crypt.EnglishAlphabet);
            Rotor3Value.Items.AddRange(Crypt.EnglishAlphabet);

            Rotor1Value.SelectedIndex = 0;
            Rotor2Value.SelectedIndex = 0;
            Rotor3Value.SelectedIndex = 0;

            Original_text.Text = DataStorage.Properties.AppResourses.DefaultValue;

       

            //DataStorage.Settings.Default.Reflectors.Clear();
            //DataStorage.Settings.Default.Reflectors = null;

            if (DataStorage.Settings.Default.Reflectors == null)
                SReflectors.SetDefaultValues();
            reflector.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Reflectors.Keys.ToList()).ToArray());
            reflector.SelectedIndex = 0;


            //DataStorage.Settings.Default.Commuters.Clear();
            ///DataStorage.Settings.Default.Commuters = null;

            if (DataStorage.Settings.Default.Commuters == null)
                SCommuters.SetDefaultValues();
            commuter.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Commuters.Keys.ToList()).ToArray());
            commuter.SelectedIndex = 0;


            //DataStorage.Settings.Default.Rotors.Clear();
            //DataStorage.Settings.Default.Rotors = null;

            if (DataStorage.Settings.Default.Rotors == null)
                SRotors.SetDefaultValues();
            rotor1.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            rotor2.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            rotor3.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            rotor1.SelectedIndex = 0;
            rotor2.SelectedIndex = 0;
            rotor3.SelectedIndex = 0;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Treated_text.Text = Crypt.ToCrypt(Original_text.Text, Rotor1Value.SelectedIndex, Rotor2Value.SelectedIndex, Rotor3Value.SelectedIndex,
                FSettings.GetArr(DataStorage.Settings.Default.Rotors[FSettings.ConvertStrToSave(rotor1.SelectedItem.ToString())], FSettings.Settings.Rotor),
                FSettings.GetArr(DataStorage.Settings.Default.Rotors[FSettings.ConvertStrToSave(rotor2.SelectedItem.ToString())], FSettings.Settings.Rotor),
                FSettings.GetArr(DataStorage.Settings.Default.Rotors[FSettings.ConvertStrToSave(rotor3.SelectedItem.ToString())], FSettings.Settings.Rotor),
                FSettings.GetArr(DataStorage.Settings.Default.Reflectors[FSettings.ConvertStrToSave(reflector.SelectedItem.ToString())], FSettings.Settings.Reflector),
                FSettings.GetArr(DataStorage.Settings.Default.Commuters[FSettings.ConvertStrToSave(commuter.SelectedItem.ToString())], FSettings.Settings.Commuter));
        } 

        private void Swap_Click(object sender, EventArgs e)
        {
            Original_text.Text = Treated_text.Text;
            Treated_text.Text = "";
            execute.Select();
        } 

        private void ReflectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SReflectors settings_Of_Reflectors = new SReflectors();
            settings_Of_Reflectors.ShowDialog();
            object temp = reflector.SelectedItem;
            reflector.Items.Clear();
            reflector.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Reflectors.Keys.ToList()).ToArray());
            if (reflector.Items.Contains(temp))
                reflector.SelectedItem = temp;
            else
                reflector.SelectedIndex = 0;
        } 

        private void CommutersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCommuters settings_Of_Commutators = new SCommuters();
            settings_Of_Commutators.ShowDialog();
            object temp = reflector.SelectedItem;
            commuter.Items.Clear();
            commuter.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Commuters.Keys.ToList()).ToArray());
            if (commuter.Items.Contains(temp))
                commuter.SelectedItem = temp;
            else
                commuter.SelectedIndex = 0;
        }

        private void RotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRotors settings_Of_Rotors = new SRotors();
            settings_Of_Rotors.ShowDialog();
            object temp1 = rotor1.SelectedItem;
            object temp2 = rotor2.SelectedItem;
            object temp3 = rotor3.SelectedItem;
            rotor1.Items.Clear();
            rotor2.Items.Clear();
            rotor3.Items.Clear();
            rotor1.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            rotor2.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            rotor3.Items.AddRange(FSettings.ConvertListToShow(DataStorage.Settings.Default.Rotors.Keys.ToList()).ToArray());
            if (rotor1.Items.Contains(temp1))
                rotor1.SelectedItem = temp1;
            else
                rotor1.SelectedIndex = 0;

            if (rotor2.Items.Contains(temp2))
                rotor2.SelectedItem = temp2;
            else
                rotor2.SelectedIndex = 0;

            if (rotor3.Items.Contains(temp3))
                rotor3.SelectedItem = temp3;
            else
                rotor3.SelectedIndex = 0;
        }

        private void AboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Written by Arthur Tsaturian. Copyright © 2018",
                "About programm",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1);
        }
    }
}