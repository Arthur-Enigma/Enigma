using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public class FSettings : Form
    {
        public enum Settings
        {
            Reflector,
            Commuter,
            Rotor
        }

        protected List<string> TempName;
        protected List<string> TempValue;

        protected void Add(string name, string value, DataStorage.ListBox listBox)
        {
            string NewName = name + " " + (Int32.Parse(listBox.Items[listBox.Items.Count - 1].ToString().Remove(0, name.Length + 1)) + 1).ToString();
            TempName.Add(NewName);
            TempValue.Add(value);
            listBox.Items.Add(NewName);
            listBox.SelectedItem = NewName;
        }

        protected void Del(DataStorage.ListBox listBox)
        {
            int temp = listBox.SelectedIndex;
            listBox.DisableItem(temp);
            TempValue[temp] = null;

            for (int i = 1; i < listBox.Items.Count; i++)
            {
                if (temp + i < listBox.Items.Count && !listBox.DisabledIndices.Contains(temp + i))
                {
                    listBox.SelectedIndex = temp + i;
                    break;
                }
                else if (temp - i >= 0 && !listBox.DisabledIndices.Contains(temp - i))
                {
                    listBox.SelectedIndex = temp - i;
                    break;
                }
            }
        }

        protected void Del(DataStorage.ListBox listBox, int index)
        {
            listBox.SelectedIndex = 0;
            listBox.DisableItem(index);
            TempValue[index] = null;
        }

        protected void ControllDelete(Button del, DataStorage.ListBox listBox)
        {
            if (listBox.SelectedIndex < 16)
                del.Enabled = false;
            else if (!del.Enabled)
                del.Enabled = true;
        }

        public static string ConvertStrToShow(string obj)
        {
            return obj.Substring(0, obj.IndexOf(' ') + 1) + (int.Parse(obj.Remove(0, obj.IndexOf(' ') + 1)) - 999).ToString();
        }

        public static string ConvertStrToSave(string obj)
        {
            return obj.Substring(0, obj.IndexOf(' ') + 1) + (int.Parse(obj.Remove(0, obj.IndexOf(' ') + 1)) + 999).ToString();
        }

        public static List<string> ConvertListToShow(List<string> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
                arr[i] = arr[i].Substring(0, arr[i].IndexOf(' ') + 1) + (Int32.Parse(arr[i].Remove(0, arr[i].IndexOf(' ') + 1)) - 999).ToString();
            return arr;
        }

        public static List<string> ConvertListToSave(List<string> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
                arr[i] = arr[i].Substring(0, arr[i].IndexOf(' ') + 1) + (Int32.Parse(arr[i].Remove(0, arr[i].IndexOf(' ') + 1)) + 999).ToString();
            return arr;
        }

        protected string GenerateCode(Settings setting)
        {
            Random rnd = new Random();
            int[] arr = new int[100];
            string result = "";

            for (int i = 0; i < 100; i++)
                arr[i] = i;

            if (setting == Settings.Reflector || setting == Settings.Commuter)
            {
                int temp1, temp2;
                arr = arr.OrderBy(x => rnd.Next()).ToArray();

                for (int i = 0; i < arr.Length; i += 2)
                {
                    temp1 = arr[i];
                    temp2 = arr[i + 1];

                    result += "(";
                    if (temp1 > 9)
                        result += temp1.ToString();
                    else
                        result += "0" + temp1.ToString();
                    result += "-";
                    if (temp2 > 9)
                        result +=  temp2.ToString();
                    else
                        result += "0" + temp2.ToString();
                    result += ") ";
                }
                result = result.Substring(0, result.Length - 1);
                return result;
            }
            else
            {
                arr = arr.OrderBy(x => rnd.Next()).ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 9)
                        result += arr[i].ToString() + "-";
                    else
                        result += "0" + arr[i].ToString() + "-";
                }
                result = result.Remove(result.Length - 1);
                return result;
            }
        }

        protected bool IsValueValid(string value, Settings setting)
        {
            if (setting == Settings.Reflector || setting == Settings.Commuter)
            {
                if (value.Length == 399)
                {
                    for (int i = 0; i < 399; i += 8)
                    {
                        if (value[i] != '(')
                            return false;
                        if (!char.IsDigit(value[i + 1]))
                            return false;
                        if (!char.IsDigit(value[i + 2]))
                            return false;
                        if (value[i + 3] != '-')
                            return false;
                        if (!char.IsDigit(value[i + 4]))
                            return false;
                        if (!char.IsDigit(value[i + 5]))
                            return false;
                        if (value[i + 6] != ')')
                            return false;
                        if (i != 392)
                        {
                            if (value[i + 7] != ' ')
                                return false;
                        }
                    }
                }
                else
                    return false;

                return true;
            }
            else
            {
                if (value.Length == 299)
                {
                    for (int i = 0; i < 299; i += 3)
                    {
                        if (!char.IsDigit(value[i]))
                            return false;
                        if (!char.IsDigit(value[i + 1]))
                            return false;
                        if (i != 297 && value[i + 2] != '-')
                            return false;
                    }
                }
                else
                    return false;

                return true;
            }
        }

        protected void SaveParams(List<string> ResultChanged, List<string> ResultAdded, DataStorage.SerializableStringDictionary KeyValuePairs)
        {
            string name;
            for (int i = 0; i < TempName.Count; i++)
            {
                name = ConvertStrToSave(TempName[i]);
                if (TempValue[i] != null)
                {
                    if (KeyValuePairs.ContainsKey(name) && ResultChanged.Contains(TempName[i]))
                        KeyValuePairs[name] = TempValue[i];
                    else if (ResultAdded.Contains(TempName[i]))
                        KeyValuePairs.Add(name, TempValue[i]);
                }
                else
                {
                    if (KeyValuePairs.ContainsKey(name) && ResultChanged.Contains(TempName[i]))
                        KeyValuePairs.Remove(name);
                }
            }
            DataStorage.Settings.Default.Save();
            DataStorage.Settings.Default.Reload();
        }

        public static int[] GetArr(string code, Settings setting)
        {
            if (setting == Settings.Commuter || setting == Settings.Reflector)
            {
                int[] result = new int[100];
                int t1, t2;

                for (int i = 0; i < 399; i += 8)
                {
                    t1 = int.Parse(code.Substring(i + 1, 2));
                    t2 = int.Parse(code.Substring(i + 4, 2));
                    result[t1] = t2;
                    result[t2] = t1;
                }
                return result;
            }
            else
            {
                int[] res = new int[100];
                for (int i = 0; i < res.Length; i++)
                    res[i] = int.Parse(code.Substring(i * 3, 2));
                return res;
            }
        }

        protected List<string> GetChanged(DataStorage.SerializableStringDictionary keyValuePairs)
        {
            List<string> res = new List<string>();
            List<string> SavedName = keyValuePairs.Keys.ToList();
            for (int i = 0; i < TempName.Count; i++)
            {
                if (SavedName.Contains(ConvertStrToSave(TempName[i])))
                {
                    if (TempValue[i] != keyValuePairs.Values.ElementAt(SavedName.IndexOf(ConvertStrToSave(TempName[i]))))
                        res.Add(TempName[i]);
                }

            }
            return res;
        }

        protected List<string> GetAdded(DataStorage.SerializableStringDictionary keyValuePairs, DataStorage.ListBox listBox)
        {
            List<string> res = new List<string>();
            List<string> SavedName = keyValuePairs.Keys.ToList();
            for (int i = 0; i < TempName.Count; i++)
            {
                if (!SavedName.Contains(ConvertStrToSave(TempName[i])) && !listBox.DisabledIndices.Contains(i))
                    res.Add(TempName[i]);
            }
            return res;
        }
    }
}
