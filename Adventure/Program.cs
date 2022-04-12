using System;
using System.Collections.Generic;

//Terrific!
//Luis Ceballo
//2021/02/23
/*This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/*/

namespace Adventure
{
    class Game 
    {
         static string characterName = "Joe";
        static int scenario = 3;
        static List<string> Inventory = new List<string>();

         
        static string[] partOne = {"You find yourself in the middle of a big yellow hall, you can A)take at the close by door or B) Continue walking foward.",
        "Behind the door you find a room with a hockey stick and some bread. You take them both.",
        "You find yourself in the middle of more larger hall.",
        "You heard a weird sound far behind you, out of fear you run away.",
        "You find you yourself in from of 2 doors, one is close and the other is not. Using the hockey stick you open the close door.",
        "You find yourself in from of 2 doors, one is close and the other is not. With nothing for you to force open the close door, you enter the open door."};

        static string[] partTwo = {"You find yourself in a blue hall now. Darker and still uncomfortable like the last one... you decide to move forward",
        "After a while you heard some noises from the left of the next hall! but you are prepared with your hockey stick. Yet no monster in there, only a key. You take the key",
        "After while you heard some noises from the left of the next hall! and so you decide to take another way foward.",
        "You find yourself some staircases, and decide to go down..."};

        static string[] partThree = { "You find youself in a ver dark room now.... and someone is watching you! Run!",
        "You throw you hockey stick and slow the monster down!",
        "You run as fast a you can!",
        "After minutes of running, you are free of the monster... but now you are hungry...",
        "You eat the bread! and recover your stamina.",
        "... you move foward.",
        "After a while, you find one last door at the end of the hall... and you heard the monster closing on you!",
        "You use the key! and finally wake up in your room.... was it all a dream?",
        "You have nothing to open it! But you manage to wake up in your room, all cover of piss and sweat... was it all dream?"};

        public static void startGame()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;  
            Console.Title = "BackRoom!";

            Console.WriteLine(

                @"   ____             _                              
 |  _ \           | |                             
 | |_) | __ _  ___| | ___ __ ___   ___  _ __ ___  
 |  _ < / _` |/ __| |/ / '__/ _ \ / _ \| '_ ` _ \ 
 | |_) | (_| | (__|   <| | | (_) | (_) | | | | | |
 |____/ \__,_|\___|_|\_\_|  \___/ \___/|_| |_| |_|
                                                  
                                                  


   +------------+
   |      B     |
 +----------------+
 |                |
 |                |
 |                |
 |                |
 |                |
 |                |
 |         +---+  |
 |         |   |  |
 |         +---+  |
 |                |
 |                |
 |                |
 |                |
 |                |
 +----------------+
"

                );
            Console.WriteLine("Where the monster save the world.");
            Console.ReadKey();
            Console.Write("By Luiyo");
            Console.ReadKey();
            
            Console.Clear();
           
            nameCharacter();
            choice();
            endGame();
            

        }

        public static void nameCharacter()
        {
           
            Console.Title = "Character name";
            Console.Write("What's your name adventurer?");
            characterName = Console.ReadLine();
            dialog("\nWelcome! " + characterName);

        }

        public static void dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        public static void dialog(string message, string color)
        {
            
            if( color.ToLower() == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
               
            }
            else if (color.ToLower() == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
            }
            else if (color.ToLower() == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }



        static void choice()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            string input;
            Console.WriteLine(partOne[0]);
            Console.Write("Enter your choice: ");
            input = Console.ReadLine();


            for (int i = 1; i <= scenario; i++)
            {
                switch (i)
                {
                    case 1:
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partOne[1]);
                            Inventory.Add("Hockey stick");
                            Inventory.Add("Bread");
                            Item item = new Item();
                            
                            
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partOne[2]);
                        }
                        else
                        {
                            Console.WriteLine("You decide to do nothing...");
                        }
                        Console.WriteLine(partOne[3]);
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partOne[4]);
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partOne[5]);
                        }
                        else
                        {
                            Console.WriteLine("You decide to do nothing...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine(partTwo[0]);
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partTwo[1]);
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partTwo[2]);
                        }
                        Console.WriteLine(partTwo[3]);
                        break;
                    case 3:
                        Console.WriteLine(partThree[0]);
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partThree[1]);
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partThree[2]);
                        }
                        Console.WriteLine(partThree[3]);
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partThree[4]);
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partThree[5]);
                        }
                        Console.WriteLine(partThree[6]);
                        
                        if (input.ToUpper() == "A")
                        {
                            Console.WriteLine(characterName + " " + partThree[7]);
                            Console.ReadKey();
                        }
                        else if (input.ToUpper() == "B")
                        {
                            Console.WriteLine(characterName + " " + partThree[8]);
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }

        public static void endGame()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "the end";
            Console.WriteLine("The story ends here...");
            Console.WriteLine("Congragulations! " + characterName);

            if (Inventory.Count > 3)
            {
                Console.WriteLine("This are the items you found! : ");

                foreach (string item in Inventory)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You didn't found anything... better luck nex time!");
                Console.ResetColor();
            }
            Console.Write("Thanks for playing! ");
            Console.WriteLine("Please press enter to exit");
            Console.ReadKey();
        }
    }

    public class Item 
    {
        public string Name = "Rock";
        public string Description = "Ordinary rock. Nothing special";
        string[] itemName = new string[] {"Bat", "Key", "Bread", "Stick" };
        string[] itemDescription = new string[] {"A toy bat, very cute.",
        "It can open close doors with it.",
        "Looks cold...",
        "Good for breaking things and defense!"};

        public Item()
        {
            Random randomNumber = new Random();
            int number;
            number = randomNumber.Next(itemName.Length);
            Name = itemName[number];
            Description = itemDescription[number];
            Console.WriteLine("You found a " + Name + "( " + Description + ").");
        }

    }


    class Program
    {
        static void Main()
        {
            Console.WindowWidth = 200;
            
            Game.startGame();
            Console.ReadKey();
           
            
        }
    }
}
