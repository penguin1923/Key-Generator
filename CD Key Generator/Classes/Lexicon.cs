﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CD_Key_Generator.Classes
{
    static class Lexicon
    {
        public static Dictionary<char, char> letterDictionary = new Dictionary<char, char>()
            {
                {'A','B'},{'B','C'},{'C','D'},{'D','E'},{'E','F'},{'F','G'},
                {'G','H'},{'H','I'},{'I','J'},{'J','K'},{'K','L'},{'L','M'},
                {'M','N'},{'N','O'},{'O','P'},{'P','Q'},{'Q','R'},{'R','S'},
                {'S','T'},{'T','U'},{'U','V'},{'V','W'},{'W','X'},{'X','Y'},
                {'Y','Z'},{'Z','A'}

            };

        public static Dictionary<char, char> numberDictionary = new Dictionary<char, char>()
            {
                {'0','1'},{'1','2'},{'2','3'},{'3','4'},{'4','5'},
                {'5','6'},{'6','7'},{'7','8'},{'8','9'},{'9','0'}

            };

        public static Dictionary<char, char> alphanumericDictionary = new Dictionary<char, char>()
            {
                {'A','B'},{'B','C'},{'C','D'},{'D','E'},{'E','F'},{'F','G'},
                {'G','H'},{'H','I'},{'I','J'},{'J','K'},{'K','L'},{'L','M'},
                {'M','N'},{'N','O'},{'O','P'},{'P','Q'},{'Q','R'},{'R','S'},
                {'S','T'},{'T','U'},{'U','V'},{'V','W'},{'W','X'},{'X','Y'},
                {'Y','Z'},{'Z','1'},{'1','2'},{'2','3'},{'3','4'},
                {'4','5'},{'5','6'},{'6','7'},{'7','8'},{'8','9'},{'9','A'}

            };
    }
}
