using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //states the health, defense, and speed stats for J-CCC (Protagonist)
            string playerName = "J-CCC";
            string playerChoice;
            int playerHealth = 10000;
            int playerDefense = 25;
            int playerSpeed = 15;
            bool SHUTDOWN = playerHealth <= 0;
            //states all moves and options for J-CCC
            bool BasicStrike = true;

            bool hasFlamethrower = false;
            int flamethrowerdamage = 80;

            bool hasRailgun = false;
            int railgundamage = 240;

            bool gatlinggun = false;
            int gatlinggundamage = 500; 
            
            

            //states the stats of the stalker
            int stalkerHealth = 0;
            int stalkerdefense = 10;
            int stalkerspeed = 60;
            bool stalkerdead = stalkerHealth <= 0;
            
            

            //states the stats of the sticker
            int stickerHealth = 30;

            //states the stats of the lackey
            int lackeyHealth = 25;




            ////this is at the start of the game that establishs the story and objective
            Console.WriteLine("TWIST OF FATE");
            Console.WriteLine("You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile.");
            Console.WriteLine("However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters.");
            Console.WriteLine("With an alien invasion underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annilation!");
            Console.WriteLine("Can you change your fate? Y/N");
            playerChoice = Console.ReadLine();
            if (playerChoice == "Y")
            {
                ////mock nameing sequence

                Console.WriteLine("You spot a female engineer who seems to have locked herself in a room from the monsters.");
                Console.WriteLine("press spacebar to continue");
                Console.ReadKey(true);
                Console.Write("> ");

                Console.Clear();
                Console.WriteLine("She sees you through the window.");
                //Console.WriteLine("Engineer Lady: You! Bot! Can you hear me? State your name!"); 
                //string firstname = Console.ReadLine();
                //Console.WriteLine("And what is your last name?");
                //string secondname = Console.ReadLine();
                //string playername= firstname+" "+secondname;
                //Console.WriteLine(playername+"? "+"What an odd name for some cleaner robot; or, a Janus Bot. But whatever that's not important!!" );


                //mock new weapon sequence
                Console.WriteLine("you spot two weapons on the ground,");
                Console.WriteLine("the one on the left is a shouldered railgun.");
                Console.WriteLine("the one on the right is a flamethrower for the right arm.");
                Console.WriteLine("which one do you take?");
                Console.WriteLine("1:railgun  2:flamethrower");
                playerChoice = Console.ReadLine();
                if (playerChoice == "1")
                {
                    Console.WriteLine("You pick up the railgun and swap out your shoulder mounted pressure washer with it. As you see the azure paint job contrast with your factory default silver finish, You feel as if you are slowly changing into someone else.");
                    hasRailgun = true;
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("You pick up the flamethrower and swap your vacuum attachment on your arm with. As you see the red details of the flamethrower contrast with your factory default silver finish, you feel as if you are slowly changing into something else.");
                    hasFlamethrower = true;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                }



                //if bool monsterdead && bool SHUTDOWN = true
                //{
                //    Console.WriteLine("CONFRONTATION RESOLVED");
                //}

                ////mock combat sequence
                //Console.WriteLine("CONFRONTATION BEGUN");
                //Console.WriteLine("A STALKER APPROACHES");
                //if
                Console.WriteLine();
            }
            else if (playerChoice == "N")
            {
                Console.WriteLine("BAD END");
                Console.WriteLine("");
            } 
        }
    }
}
