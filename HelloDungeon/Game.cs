using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        //mock menu function
        //string TBD_Menu(string pathway, string playerChoice)
        //{
        //    string playerChoice = "0";

        //    while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
        //    {
        //        //display promblems and solutions
        //        Console.Clear();
        //        Console.WriteLine(prompt);

        //        Console.WriteLine("1." + option1);

        //        Console.WriteLine("2." + option2);

        //        Console.WriteLine("3" + option3);

        //        if (option3 != "")
        //        {
        //            Console.WriteLine("3." + option3);
        //        }

        //        //player input
        //        Console.WriteLine("> ");
        //        playerChoice = Console.ReadLine();

        //        // if invalid input,
        //        if (playerChoice != "1" && playerChoice != "2")
        //        {
        //            if (playerChoice == "3"&& option3 != "")
        //            {
        //                continue;
        //            }

        //            //
        //            Console.Clear();
        //            Console.WriteLine("Invalid Input");
        //            Console.WriteLine("press a button");
        //            Console.ReadKey(true);

        //        }

        //    }

        //    return playerChoice;
        //}

        // mock combat sequence
        // turn based battle between player and opposing forces
        // gives players two actions per turn to attack, heal, or apply a buff
        // on enemy turn, each enemy gets a to preform a action such as attack, defend, buff, or debuff
        // allows for more enemies and even duplicate enemies as well

        void


        //the mock damage calculator function
        float CalculatePain(float health, float attack, float defense)
        {
            float reducedDamage = attack * defense;
            float totalDamage = health - reducedDamage;
            return totalDamage;
        }

        // mock beggining dialogue sequence

        void BeginDialogue(string Text)
        {
            Console.WriteLine(Text);
            Console.WriteLine("PRESS A BUTTON TO ADVANCE DIALOGUE, IT IS RECOMMNENDED TO PLAY WITH CAPS LOCK ON");
            Console.ReadKey(true);
            
        }

        // mock dialogue sequence?
        void Dialogue(string Text)
        {
            Console.WriteLine(Text);
            Console.ReadKey(true);
            
        }


        // mock dialouge advancing function
        void EndDialogue(string Text)
        {
            Console.WriteLine(Text);
            Console.WriteLine("" +
                            "" +
                            "");
            Console.ReadKey(true);



        }


        //mock status function
        void Status(string Name, float Health, float Defense, float Speed)
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Defense: "+ Defense);
            Console.WriteLine("Speed: " + Speed);
            return;
        }

        //mock adding function
        int add(int a,int b)
        {
            int result;

           result = a + b;
            Console.WriteLine(result);
            return result; 
        }

        //float Alligator (float a,float b)
        //{
        //    if (a > b)
        //        return a;
        //    else
        //        return b;
        //}

        //void CountUp(int endNumber)
        //{
            
        //    for (int startNumber = 0; startNumber <= endNumber; startNumber++)
        //    {
        //        Console.WriteLine(startNumber);
        //    }
        //    return;
        //}

        //void CountUpEvenOnly(int FirstNumber, int SecondNumber)
        //{

        //    for (int count = FirstNumber; count <= SecondNumber; count++)
        //    {
        //        if ((count % 2) == 0)
        //            Console.WriteLine(count);
        //    }


        //    int count = FirstNumber;
        //    while (count <= SecondNumber)
        //    {
                
        //        if (count % 2 == 0)
        //        {

        //            Console.WriteLine(count);
        //            count++;
        //        }
        //        else
        //            count++;
                
        //    }

        //}

        public void Run()
        {
            //add(5,-6);
            //Console.WriteLine(Alligator(40f, 42f));
            //Console.ReadKey(true);
            //Console.Clear();

            //CountUpEvenOnly(8, 17);
            //Console.ReadKey(true);
            //Console.Clear();

            //CountUp(9);
            //Console.ReadKey(true);
            //Console.Clear();

            

            
            //states the health, defense, and speed stats for J-CCC (Protagonist)
            string playerName = "J-CCC";
            string playerChoice = "";
            float playerHealth = 10000f;
            float playerDefense = .47f;
            float playerSpeed = 15f;
            bool SHUTDOWN = playerHealth <= 0f;

            //states all moves and options for J-CCC

                //gatling gun weapon
                bool HasGatlingGun = false;
                float GatlingGunDamage = 500f;
            1         

                //flamethrower weapon
                bool HasFlamethrower = false;
                float FlamethrowerDamage = 80f;
            2

                // railgun weapon
                bool HasRailgun = false;
                float RailgunDamage = 240f;
            3

                //freeze ray weapon
                bool HasFreezeBlaster =false;
                float FreezerBlaster = 150f;
            4
                
                //laser gun weapon
                bool HasIonLaser = false;
                float IonLaserDamage = 1000f;
            5

                //stasisbubble tool
                bool HasStasisBubble = false;
                float StasisBubbleDamage = 0f;
            6

                // rocketbooster buff
                bool HasRocketJets = false;
                float RocketJetsDamgage = 0f;
            7

                // healing
                bool SelfRepair = true;
                float SelfRepairHealing = -1500f;
            8


                // kamikaze attack
                bool SelfDestruct = true;
                float SelfDestructDamage = 999999999f;
            /0

            //states all enemies stats and misc.
            

            //states the stats of the stalker
            string stalkerAbout = "A slightly below-average sized, skinny creature with white, almost luminescent skin. They appear to be incredibly malnorished, with build being more bone than flesh.\n Their hunting tactics revolves around observing their prey to get a read on their movement and searching for weak points to attack with lighting fast claw strikes when the target is most vulnerable. Their first priority is conserving energy, which explains their reserved mannered of fighting.";
            float stalkerHealth = 90f;
            float stalkerDefense = .90f;
            float stalkerSpeed = 60f;
            bool stalkerDead = stalkerHealth <= 0;

            //Console.WriteLine(stalkerAbout);

            //states the stats of the sticker
            string stickerAbout = "";
            float stickerHealth = 30;

            //states the stats of the lackey
            float lackeyHealth = 25;






            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //this is at the start of the game that establishs the story and objective (INTRODUCTION)

            //Advance();

            BeginDialogue("TWIST OF FATE");
            Dialogue("TIME: AUGUST 17TH, 3492");
            Dialogue("LOCATION: SECTOR X-79");
            Dialogue("VESSEL NAME: INDAGATUS II");
            Dialogue()

            Dialogue("You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile.");
            Dialogue("However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters.");
            Dialogue("With an monster invasion underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annilation!");
            EndDialogue("Can you change your fate? Y/N");


            

            while (playerChoice!="Y" && playerChoice!="N")
            
            playerChoice = Console.ReadLine();

            if (playerChoice == "Y")



            //while ( ==false)
            //if player selects Y (GAME START)
            {


                Console.WriteLine("Then if you truly believe you can, seek it out and bring this ship from the brink of destruction!");
                Console.WriteLine("You spot a female engineer who seems to have locked herself in a room from the monsters.");
                Console.WriteLine("PRESS A BUTTON");
                Console.ReadKey(true);
                Console.WriteLine("She sees you through the window.");










                //////mock nameing sequence


                //string firstname = "";
                //string secondname = "";
                //string playername = "";
                //Console.WriteLine("Engineer Lady: you! Bot! can you hear me?");
                //Console.ReadKey(true);
                //Console.Clear();


                //while (playerChoice != "1")
                //{
                //    Console.WriteLine("Engineer Lady: State your name!");
                //    Console.Write(">");
                //    firstname = Console.ReadLine();
                //    Console.WriteLine("Engineer lady: " + firstname + " what? You have a last name, right?");
                //    Console.Write(">");
                //    secondname = Console.ReadLine();

                //    playername = firstname + " " + secondname;

                //    playerChoice = "";

                //    while (playerChoice != "1" && playerChoice != "2")
                //    {

                //        Console.WriteLine("\"" + playername + "\"" + "? Is that really your full name?");
                //        Console.WriteLine("1. AFFIRMATIVE");
                //        Console.WriteLine("2. NEGATIVE");

                //        playerChoice = Console.ReadLine();

                //        if (playerChoice == "1")
                //        {

                //            Console.WriteLine(playername + "? " + "what an odd name for some cleaner robot; err, a janus bot. But whatever, that's not important!!");
                //            Console.ReadKey(true);
                //            Console.WriteLine("look " + playername + ", we don't have much time, everything has gone to crap.");
                //            Console.ReadKey(true);


                //        }
                //        else if (playerChoice == "2")
                //        {
                //            Console.WriteLine("Oh come ON! Are you bugged or something?");
                //            Console.ReadKey(true);
                //            Console.Clear();
                //        }
                //        else
                //        {
                //            Console.WriteLine("ERROR: INVALID INPUT, INPUT A NUMBER CORRESPONDING TO A CHOICE");
                //            Console.ReadKey(true);
                //        }
                //    }

                //}

                //Console.Clear();




                //mock new weapon sequence


                while (playerChoice != "1" && playerChoice != "2")
                {

                    //Console.WriteLine("you spot two weapons on the ground,");
                    //Console.WriteLine("the one on the left is a railgun.");
                    //Console.WriteLine("the one on the right is a flamethrower.");
                    //Console.WriteLine("which one do you take?");
                    //Console.WriteLine("1:railgun  2:flamethrower");

                    //    playerChoice = Console.ReadLine();

                    //    if (playerChoice == "1")
                    //    {
                    //        Console.WriteLine("You pick up the railgun and swap out your shoulder mounted pressure washer with it. As you see the azure paint job contrast with your factory default silver finish, You feel as if you are slowly changing into someone else.");
                    //        HasRailgun = true;
                    //        Console.ReadKey(true);
                    //    }
                    //    else if (playerChoice == "2")
                    //    {
                    //        Console.WriteLine("You pick up the flamethrower and swap your vacuum attachment on your arm with. As you see the red details of the flamethrower contrast with your factory default silver finish, you feel as if you are slowly changing into something else.");
                    //        HasFlamethrower = true;
                    //        Console.ReadKey(true);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("ERROR");
                    //        Console.WriteLine("INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                    //        Console.ReadKey(true);
                    //    }

                }




                //if bool monsterdead && bool SHUTDOWN = true



                //mock combat sequence
                Console.WriteLine("CONFRONTATION BEGUN");
                Console.WriteLine("A STALKER APPROACHES");
                while (SHUTDOWN == true && stalkerDead == true)
                {

                }
                //if
                //Console.WriteLine();

                {
                    Console.WriteLine("CONFRONTATION RESOLVED");
                }
            }

            else if (playerChoice == "N")
            {
                Console.WriteLine("BAD END");
                Console.WriteLine("BY FAILING TO EVEN ATTEMPT TO CHANGE FATE, YOU HAVE ALREADY LOST");
                Console.ReadKey(true);
                Console.WriteLine("THE SHIP FALLS TO CHAOS, CLAIMED BY THE CREATURES");
                Console.ReadKey(true);
                Console.WriteLine("THERE WERE NO SURVIVORS");
                return;
            }
            else
            {
                Console.WriteLine("ERROR, INVALID INPUT, INPUT A LETTER CORRESPONDING TO YOUR WANTED CHOICE.");
            };
        }
    }
}
