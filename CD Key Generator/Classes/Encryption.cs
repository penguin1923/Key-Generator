using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CD_Key_Generator;

namespace CD_Key_Generator.Classes
{//
    public class Encryption : IAlphanumericDictionary
    {

        public Array IntoArray(string ranKey, int previous)
        {
            char[] keyArray = ranKey.ToCharArray();

            if (previous == 1)
            {
                EncryptLetters(keyArray);
            }
            else if (previous == 2)
            {
                EncryptNumbers(keyArray);
            }
            else
            {
                EncryptAlphaNumeric(keyArray);
            }

            return keyArray;
        }

        public String EncryptLetters(char[] keyArray)
        {// how do i fix this from being a double loop?

            string words = "";
            for (int i = 0; i < keyArray.Length; i++)
            { char holder =keyArray[i];
                words += letterDictionary[holder];
                //foreach (KeyValuePair<char, char> kvp in letterDictionary)
                //{
                //    char key = kvp.Key;
                //    char value = kvp.Value;

                //    if (holder == kvp.Key)
                //    {
                //        words += value;
                //    }


                //}
            }
            Console.WriteLine("Your encrypted key is: " + words);
            return words;
        }
        public String EncryptNumbers(char[] keyArray)
        {
            string digits = "";
            for (int i = 0; i < keyArray.Length; i++)
            {
                char holder = keyArray[i];
                foreach (KeyValuePair<char, char> kvp in numberDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;

                    if (holder == kvp.Key)
                    {
                        digits += value;
                    }


                }
            }
            Console.WriteLine("Your encrypted key is: " + digits);
            return digits;
        }

        public String EncryptAlphaNumeric(char[] keyArray)
        {
            string alpha = "";
            for (int i = 0; i < keyArray.Length; i++)
            {
                char holder = keyArray[i];
                foreach (KeyValuePair<char, char> kvp in alphanumericDictionary)
                {
                    char key = kvp.Key;
                    char value = kvp.Value;

                    if (holder == kvp.Key)
                    {
                        alpha += value;
                    }


                }
            }
            Console.WriteLine("Your encrypted key is: " + alpha);
            return alpha;
        }
    }
}
