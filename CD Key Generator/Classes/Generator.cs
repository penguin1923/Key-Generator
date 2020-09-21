using System;
using System.Diagnostics.CodeAnalysis;

namespace CD_Key_Generator.Classes

{
    public class Generator
    {
        Randomizer preKey = new Randomizer();
        Encryption newKey = new Encryption();
        Decryption oldKey = new Decryption();
        string programKey = "";
        string encrypt = "";
        string decrypt = "";
        public string ProgramKey(string option, int keyLength)
        {
            if (option == "1")
            {
                programKey = preKey.Letters(keyLength);
            }
            else if (option == "2")
            {
                programKey = preKey.Numbers(keyLength);
            }
            else if (option == "3")
            {
                programKey = preKey.Mixed(keyLength);
            }
            return programKey;
        }

        public string EncryptKey(string programKey, string option)
        {
            if (option == "1")
            {
                encrypt = newKey.EncryptLetters(programKey);
            }
            else if (option == "2")
            {
                encrypt = newKey.EncryptNumbers(programKey);
            }
            else if (option == "3")
            {
                encrypt = newKey.EncryptAlphaNumeric(programKey);
            }
            return encrypt;
        }
        public string DecryptKey(string decryptKey)
        {
            char [] decryptArray = decryptKey.ToCharArray();
            int sum = 0;
            for (int i = 0; i < decryptArray.Length; i++)
            {
                if (decryptArray[i] >= 49 && decryptArray[i] <= 57)
                {
                    sum++;
                }
            }
            if (sum > 0)
            {
                if (decryptArray.Length > sum)
                {
                    decrypt = oldKey.DecryptAlphaNumeric(decryptArray);
                }
                else
                {
                    decrypt = oldKey.DecryptNumbers(decryptArray);
                }
            }
            else
            {
                decrypt =oldKey.DecryptLetters(decryptArray);
            }
            return decrypt;
        }
    }
}
