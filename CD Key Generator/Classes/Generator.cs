namespace CD_Key_Generator.Classes

{
    public class Generator
    {
        Randomizer preKey = new Randomizer();
        Encryption newKey = new Encryption();
        string programKey = "";
        string encrypt = "";
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

    }
}
