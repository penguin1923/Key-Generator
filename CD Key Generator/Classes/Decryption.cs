using System;
using System.Collections.Generic;

namespace CD_Key_Generator.Classes
{
    public class Decryption
    {
        public string DecryptLetters(char[] decryptArray)
        {
            string words = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char, char> kvp in Lexicon.letterDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;
                    if (holder == kvp.Value)
                    {
                        words += key;
                    }
                }
            }
            return words;
        }
        public string DecryptNumbers(char[] decryptArray)
        {
            string digits = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char,char> kvp in Lexicon.numberDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;
                    if (holder == kvp.Value)
                    {
                        digits += key;
                    }
                }
            }
            return digits;
        }
        public string DecryptAlphaNumeric(char[] decryptArray)
        {
            string alpha = "";
            for (int i = 0; i < decryptArray.Length; i++)
            {
                char holder = decryptArray[i];
                foreach (KeyValuePair<char, char> kvp in Lexicon.alphanumericDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;
                    if (holder == kvp.Value)
                    {
                        alpha += key;
                    }
                }
            }
            return alpha;
        }
    }
}
