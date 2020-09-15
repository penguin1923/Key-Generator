using System;
using System.Collections.Generic;
using System.Text;

namespace CD_Key_Generator.Classes
{
    public class Menu
    {
        public void MainMenu()
        {
            Generator newKey = new Generator();
            Decryption decrypt = new Decryption();
            Menu menu = new Menu();
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
                    int keyLength = 0;
                    do
                    {
                        try
                        {
                            keyLength = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please input a valid answer");
                            Console.WriteLine();
                            menu.MainMenu();
                        }
                    } while (keyLength < 1);
                    
                    //int.parse is to convert the string to a integer
                    Console.WriteLine("what Types of Characters are you going use?");
                    Console.WriteLine("1:Characters only A-Z");
                    Console.WriteLine("2:Numbers only 0-9");
                    Console.WriteLine("3:Characters and Numbers");
                    string option = Console.ReadLine();
                    //This is happy user and can definitly be broken no validation yet
                    Console.WriteLine("So your Program Key will be " + keyLength + " characters long and use option " + option);
                    Console.WriteLine("Is this correct? Y or N");
                    string conformation = Console.ReadLine();

                    if (conformation == "Y" || conformation == "y" && (option == "1" || option=="2"||option=="3"))
                    {//run program
                        Console.Clear();
                        newKey.ProgramKey(option, keyLength);
                    }
                    else
                    {//return to input==1 or break to the beginning
                        Console.Clear();
                        Console.WriteLine(option+" is not a valid option please try again");
                        Console.WriteLine();
                        menu.MainMenu();
                    }
                }else if (input == "2") 
                {
                    //needs to go through a decrypter
                    Console.Clear();
                    Console.WriteLine("What is the key to be decrypted?");
                    string decryptKey = Console.ReadLine().ToUpper();
                    decrypt.DecryptArray(decryptKey);
                }
                else if (input == "Q" || input == "q")
                {
                    break;
                }
                else
                {
                    menu.InvalidOption();
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        public void InvalidOption()
        {
            Console.Clear();
            MainMenu();
        }
    }
}
