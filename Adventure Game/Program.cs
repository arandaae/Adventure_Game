/*Adventure Game
 * Armando Aranda, 04/21/2022
 * 
 * This work is a derivative of 
 * "C# Adventure Game by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{   
    public static class Game 
    {
        //character name
        static string characterName = "";

        //print out game title and overview
        public static void StartGame()
            {
            //(the next few lines will have your own content)
            Console.Title = "Adventure Game";
            Console.Read();
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome to your Adventure");
            NameCharacter();
            
            }

        //ask player for a name, and save it
        static void NameCharacter()
            {
                 Console.Title = "Character Selection";
                 Console.Read();

                 Console.WriteLine("Enter the name of your character: ");
                 characterName = Console.ReadLine();

                 Console.WriteLine("Great! Your character is now named " + characterName + "!");
            }
        static void Dialog(string message)
        {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(message);
                Console.ResetColor();
            Console.WriteLine("A stranger approaches. Clearing their throat to get your attention, they ask \n");
            Dialog("Have you seen a strange creature around here?\nAbout three feet high, greenish, with fluffy hair?\n");
            Console.WriteLine("How do you answer? 1) Yes, 2) No, Repeat the question, 4) Keep walking");
        }
    }
    class Item 
    {
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();

            

        }
    }
}
