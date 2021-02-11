using System;
using System.Linq;

namespace Enigma
{
    static class Crypt
    {
        public static object[] EnglishAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public static object[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',
                                ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                '!', '@', '#', '$', '%', '^', '&', '*', '(' ,')', '-', '_', '=', '+', '~', '`', '"', '|', ';', ':', ',', '.', '/', '<', '>', '?', '[', ']', '{', '}' };

        public static string ToCrypt(string txt, int rotor1, int rotor2, int rotor3, 
            int[] rotor1Arr, int[] rotor2Arr, int[] rotor3Arr, int[] Commutator, int[] Reflector)
        { 
            int temp, SIZE_ALPHABET = alphabet.Length;
            string result = "";

            foreach (var i in txt)
            {
                if (alphabet.Contains(i))
                {
                    temp = Array.IndexOf(alphabet, i); //Номер буквы->[0: 25]
                    temp = Commutator[temp]; //Заходим в комутатор
                    temp = rotor1Arr[(SIZE_ALPHABET + (temp + rotor1)) % SIZE_ALPHABET]; //Заходим в первый ротор
                    temp = rotor2Arr[(SIZE_ALPHABET + (temp - rotor1 + rotor2)) % SIZE_ALPHABET]; //Заходим во второй ротор
                    temp = rotor3Arr[(SIZE_ALPHABET + (temp - rotor2 + rotor3)) % SIZE_ALPHABET]; //Заходим в третьий ротор            
                    temp = Reflector[(SIZE_ALPHABET + (temp - rotor3)) % SIZE_ALPHABET]; //Меняем букву в рефлекторе
                    temp = Array.IndexOf(rotor3Arr, ((SIZE_ALPHABET + (temp + rotor3)) % SIZE_ALPHABET)); //Выходим из третьего ротора
                    temp = Array.IndexOf(rotor2Arr, ((SIZE_ALPHABET + (temp - rotor3 + rotor2)) % SIZE_ALPHABET)); //Выходим из второго ротора
                    temp = Array.IndexOf(rotor1Arr, ((SIZE_ALPHABET + (temp - rotor2 + rotor1)) % SIZE_ALPHABET)); //Выходим из первого ротора
                    temp = (SIZE_ALPHABET + (temp - rotor1)) % SIZE_ALPHABET; //Завершаем работу
                    temp = Commutator[temp]; //Меняем букву в комутаторе
                    result += (alphabet[temp]); //Записываем результат
                }
                else
                {
                    result += i;
                }

                rotor1++;
                if (rotor1 == SIZE_ALPHABET) { rotor2++; rotor1 = 0; }
                if (rotor2 == SIZE_ALPHABET) { rotor3++; rotor2 = 0; }
                if (rotor3 == SIZE_ALPHABET) { rotor3 = 0; }
            }
            return result;
        }
    }
}
