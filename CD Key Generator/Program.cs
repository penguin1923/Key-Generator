using CD_Key_Generator.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace CD_Key_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator newKey = new Generator();
            while (true)
            {
                Console.WriteLine("Welcome To The Program Key Generator");
                Console.WriteLine("1:Generate a new Program Key");
                Console.WriteLine("2:Decrypt a Program Key");
                Console.WriteLine("Q:Quit");
                Console.WriteLine("");

                string input = Console.ReadLine();

                if (input == "1")
                {

                    //Ask for length and character types from users
                    Console.WriteLine("What is the length of the Program Key?");
                    int keyLength = int.Parse(Console.ReadLine());
                    //int.parse is to convert the string to a integer
                    Console.WriteLine("what Types of Characters are you going use?");
                    Console.WriteLine("1:Characters only A-Z");
                    Console.WriteLine("2:Numbers only 0-9");
                    Console.WriteLine("3:Characters and Numbers");

                    string option=Console.ReadLine();
                    //This is happy user and can definitly be broken no validation yet
                    Console.WriteLine("So you Program Key will be "+keyLength+" characters long and use option "+option);
                    Console.WriteLine("Is this correct? Y or N");
                    string conformation=Console.ReadLine();

                    if (conformation == "Y" || conformation == "y")
                    {//run program
                        newKey.ProgramKey(option,keyLength);
                    }
                    else
                    {//return to input==1 or break to the beginning
                        
                    }
                }
                else if (input == "Q" || input == "q")
                {
                    break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
