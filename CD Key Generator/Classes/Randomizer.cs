using System;
using System.Text;


namespace CD_Key_Generator.Classes
{//This whole class is for the purposes of making sure i can do this. I know that if i wanted it for security purposes 
 //   i have to use RNGCryptoServiceProvider and not Random
    public class Randomizer
    {
        Encryption crypt = new Encryption();
        String ranKey = "";
        public string Letters(int keyLength)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            for (int i = 0; i < keyLength; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            //toupper isnt needed because these are the assigned char values for capitals only 
            ranKey = str_build.ToString();
            return ranKey;
        }
        public string Numbers(int keyLength)

        {

            Random random = new Random();
            StringBuilder str_build = new StringBuilder();

            for (int i = 0; i < keyLength; i++)
            {
                str_build.Append(random.Next(10));
            }
            ranKey = str_build.ToString();
            return crypt.EncryptNumbers(ranKey);

        }
        public string Mixed(int keyLength)
        {
            char[] randomChar = "abcdefghijklmnopqrstuvwxyz123456789".ToCharArray();
            Random random = new Random();
            string randomString = "";
           
            for (int i = 0; i < keyLength; i++)
            {
                randomString += randomChar[random.Next(0, 35)];
            }
            ranKey = randomString.ToString().ToUpper();
            return crypt.EncryptAlphaNumeric(ranKey);
        }
    }
}

