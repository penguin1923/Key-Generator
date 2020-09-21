using System;
using System.Linq;


namespace CD_Key_Generator.Classes
{
    public class Encryption : IAlphanumericDictionary
    {   char[] keyArray;
        
        public String EncryptLetters(string ranKey)
        {
            keyArray = ranKey.ToArray();
            string words = "";
            for (int i = 0; i < keyArray.Length; i++)
            {
                char holder = keyArray[i];
                words += letterDictionary[holder];
            }    
            return words;
        }
        public String EncryptNumbers(string ranKey)
        {
            keyArray = ranKey.ToArray();
            string digits = "";
            for (int i = 0; i < keyArray.Length; i++)
            {
                char holder = keyArray[i];
                digits += numberDictionary[holder];
            }
            return digits;
        }

        public String EncryptAlphaNumeric(string ranKey)
        {
            keyArray = ranKey.ToArray();
            string alpha = "";
            for (int i = 0; i < keyArray.Length; i++)
            {
                char holder = keyArray[i];
                alpha += alphanumericDictionary[holder];
            }
            return alpha;
        }
    }
}
