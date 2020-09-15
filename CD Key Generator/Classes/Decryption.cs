using System;
using System.Collections.Generic;
using System.Text;

namespace CD_Key_Generator.Classes
{
    public class Decryption : IAlphanumericDictionary
    {
        public Array DecryptArray(string decrypt)
        {
            char[] decryptArray = decrypt.ToCharArray();
            int sum = 0;
            for (int i = 0; i < decryptArray.Length; i++)
            {
                if (decryptArray[i] >= 49 && decryptArray[i]<=57)
                {
                    sum++;
                }
            }

            if (sum > 0)
            {
                if (decryptArray.Length > sum)
                {
                    DecryptAlphaNumeric(decryptArray);
                }
                else
                {
                    DecryptNumbers(decryptArray);
                }

            }
            else
            {
                DecryptLetters(decryptArray);
            }

            return decryptArray;
        }
        public string DecryptLetters(char[] decryptArray)
        {
            string words = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char, char> kvp in letterDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;

                    if (holder == kvp.Value)
                    {
                        words += key;
                    }


                }
            }
            Console.WriteLine("Your verifacation key is: " + words);
            return words;
        }
        public string DecryptNumbers(char[] decryptArray)
        {
            string digits = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char, char> kvp in numberDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;

                    if (holder == kvp.Value)
                    {
                        digits += key;
                    }


                }
            }
            Console.WriteLine("Your verifacation key is: " + digits);
            return digits;
        }
        public string DecryptAlphaNumeric(char[] decryptArray)
        {
            string alpha = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char, char> kvp in alphanumericDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;

                    if (holder == kvp.Value)
                    {
                        alpha += key;
                    }


                }
            }
            Console.WriteLine("Your verifacation key is: " + alpha);
            return alpha;
        }
    }
}
