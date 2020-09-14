using System;
using System.Collections.Generic;
using System.Text;

namespace CD_Key_Generator.Classes
{
    public class ILettersDictionary:INumbersDictionary
    {
        public Dictionary<char, char> letterDictionary = new Dictionary<char, char>()
            {
                {'A','B'},{'B','C'},{'C','D'},{'D','E'},{'E','F'},{'F','G'},
                {'G','H'},{'H','I'},{'I','J'},{'J','K'},{'K','L'},{'L','M'},
                {'M','N'},{'N','O'},{'O','P'},{'P','Q'},{'Q','R'},{'R','S'},
                {'S','T'},{'T','U'},{'U','V'},{'V','W'},{'W','X'},{'X','Y'},
                {'Y','Z'},{'Z','A'}

            };
    }
}
