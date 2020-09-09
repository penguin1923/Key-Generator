using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CD_Key_Generator;

namespace CD_Key_Generator.Classes

{
    public class Generator
    {
        Randomizer preKey = new Randomizer();
        string programKey = "";
        public string ProgramKey(string option,int keyLength) 
        {
            
            if (option == "1")
            {
                preKey.Letters(keyLength);
            }
            else if (option == "2")
            {
                preKey.Numbers(keyLength);
                
            }
            else if (option == "3")
            {
                preKey.Mixed(keyLength);
            }
            return programKey;

        }
        
    }
}
