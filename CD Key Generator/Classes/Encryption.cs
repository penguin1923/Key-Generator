using System;
using System.Collections.Generic;
using System.Text;

namespace CD_Key_Generator.Classes
{
    public class Encryption
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
        {
            string words = "";
            Console.WriteLine("you made it");
            return words;
        }
        public String EncryptNumbers(char[] keyArray)
        {
            string digits = "";
            return digits;
        }

        public String EncryptAlphaNumeric(char[] keyArray)
        {
            string alpha = "";
            return alpha;
        }
    }
}
