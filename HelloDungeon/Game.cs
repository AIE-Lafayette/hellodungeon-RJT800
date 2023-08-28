using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            string playerChoice = "";
            int playerHealth = 10000;
            int playerDefense = 25;
            int playerSpeed = 15;
            bool SHUTDOWN = playerHealth <= 0;

            //states all moves and options for J-CCC
            bool BasicStrike = true;
            int BasicStrikeDamage = 50;

            bool SelfDestruct = true;
            int SelfDestructDamage = 999999999;
            bool HasFlamethrower = false;
            int FlamethrowerDamage = 80;

            bool HasRailgun = false;
            int RailgunDamage = 240;

            bool GatlingGun = false;
            int GatlinggunDamage = 500;

            bool TranquilizerDart = false;
            int TranquilizerDamage = 0;


            //states the stats of the stalker
            string StalkerAbout = "A slightly below-average sized, skinny creature with white, almost luminescent skin. They appear to be incrediblymalnorished, with build being more bone than flesh. Their hunting tactics revolves around observing their prey to get a read on their movement and searching for weak points to attack with lighting fast claw strikes when the target is most vulnerable. Their first priority is conserving energy, which explains their reserved mannered of fighting.";
            int stalkerHealth = 90;
            int stalkerdefense = 10;
            int stalkerspeed = 60;
            bool StalkerDead = stalkerHealth <= 0;
            
            

            //states the stats of the sticker
            int stickerHealth = 30;

            //states the stats of the lackey
            int lackeyHealth = 25;


            //printname();

            ////this is at the start of the game that establishs the story and objective
            //Console.WriteLine("TWIST OF FATE");
            //Console.WriteLine("PRESS A BUTTON, IT IS RECOMMNENDED TO PLAY WITH CAPS LOCK ON");
            //Console.ReadKey(true);
            //Console.WriteLine("You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile.");
            //Console.ReadKey(true);
            //Console.WriteLine("However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters.");
            //Console.ReadKey(true);
            //Console.WriteLine("With an alien invasion underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annilation!");
            //Console.ReadKey(true);
            //Console.WriteLine("Can you change your fate? Y/N");
            //playerChoice = Console.ReadLine();
            //if (playerChoice == "Y")
            {
                ;

                //    Console.WriteLine("Then if you truly believe you can, seek it out and bring this ship from the brink of destruction!");


                //    Console.WriteLine("You spot a female engineer who seems to have locked herself in a room from the monsters.");
                //    Console.WriteLine("PRESS A BUTTON");
                //    Console.ReadKey(true);

                //    Console.WriteLine("She sees you through the window.");

                ////mock nameing sequence
                
                string firstname="";
                string secondname="";
                string playername = "";
                Console.WriteLine("Engineer Lady: you! Bot! can you hear me?");
                Console.ReadKey(true);
                Console.Clear();


                while (playerChoice != "1")
                {
                    Console.WriteLine("Engineer Lady: State your name!");
                    Console.Write(">");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Engineer lady: "+firstname+" what? You have a last name, right?");
                    Console.Write(">");
                    secondname = Console.ReadLine();

                    playername = firstname + " " + secondname;

                    playerChoice = "";
                    
                    while (playerChoice != "1" && playerChoice != "2")
                    {

                        Console.WriteLine("\"" + playername + "\"" + "? Is that really your full name?");
                        Console.WriteLine("1. AFFIRMATIVE");
                        Console.WriteLine("2. NEGATIVE");

                        playerChoice = Console.ReadLine();

                        if (playerChoice == "1")
                        {
                        
                            Console.WriteLine(playername + "? " + "what an odd name for some cleaner robot; err, a janus bot. But whatever, that's not important!!");
                            Console.ReadKey(true);
                            Console.WriteLine("look " + playername + ", we don't have much time, everything has gone to crap.");
                            Console.ReadKey(true);
                        
                        
                        }
                        else if (playerChoice == "2")
                        {
                            Console.WriteLine("Oh come ON! Are you bugged or something?");
                            Console.ReadKey(true);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("ERROR: INVALID INPUT, INPUT A NUMBER CORRESPONDING TO A CHOICE");
                            Console.ReadKey(true);
                        }
                    }
                    
                }

                Console.Clear();

                //Console.Clear();

                //mock new weapon sequence
                //Console.WriteLine("you spot two weapons on the ground,");
                //Console.WriteLine("the one on the left is a railgun.");
                //Console.WriteLine("the one on the right is a flamethrower.");
                //Console.WriteLine("which one do you take?");
                //Console.WriteLine("1:railgun  2:flamethrower");


                //for (playerChoice = Console.ReadLine(); playerChoice == "1" || playerChoice == "2");
                {
                    
                //    if (playerChoice == "1")
                //{
                //    Console.WriteLine("You pick up the railgun and swap out your shoulder mounted pressure washer with it. As you see the azure paint job contrast with your factory default silver finish, You feel as if you are slowly changing into someone else.");
                //    HasRailgun = true;
                //}
                //else if (playerChoice == "2")
                //{
                //    Console.WriteLine("You pick up the flamethrower and swap your vacuum attachment on your arm with. As you see the red details of the flamethrower contrast with your factory default silver finish, you feel as if you are slowly changing into something else.");
                //    HasFlamethrower = true;
                //}
                //else
                //{
                //    Console.WriteLine("ERROR");
                //    Console.WriteLine("INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                //}

                }
                



                //if bool monsterdead && bool SHUTDOWN = true



                //mock combat sequence
                Console.WriteLine("CONFRONTATION BEGUN");
                Console.WriteLine("A STALKER APPROACHES");
                while (SHUTDOWN == true && StalkerDead == true )
                {

                }
                //if
                //Console.WriteLine();

                {
                    Console.WriteLine("CONFRONTATION RESOLVED");
                }
            }
            //else if (playerChoice == "N")
            //{
            //    Console.WriteLine("BAD END");
            //    Console.WriteLine("BY FAILING TO EVEN ATTEMPT TO CHANGE FATE, YOU HAVE ALREADY LOST");
            //    Console.ReadKey(true);
            //    Console.WriteLine("THE SHIP FALLS TO CHAOS, CLAIMED BY THE CREATURES");
            //    Console.ReadKey(true);
            //    Console.WriteLine("THERE WERE NO SURVIVORS");

             
        }
    }
}
