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
using static System.Net.Mime.MediaTypeNames;

namespace HelloDungeon
{
    class Game
    {
        struct PLAYERTHINGS
        {

        }
        //CAN REESTART GAME
        //HAVE A WAY TO SHOW OPTIONS OR HAVE IT PRESENT AT ALL
        //HAVE A WAY TO ENTER THE MAIN MENU?
        // HAVE A WAY TO QUIT


        //states the health, defense, and speed stats for J-CCC (Protagonist)
        string PlayerName = "J-CCC";
        string PlayerChoice = "";
        float PlayerHealth = 10000f;
        float PlayerDefense = .47f;
        float playerSpeed = 15f;
        bool Playerisalive = true;
        int PlayerMoves = 2;
        int CurrentScene = 0;

        //states all moves and options for J-CCC

        bool HasMopStrike = true;
        float MopStrikeDamage = 50f;

        bool HasElbowStrike = false;
        float ElbowStrike = 150f;

        //gatling gun weapon 1
        //bool HasGatlingGun = false;
        //float GatlingGunDamage = 500f;


        //flamethrower weapon 2
        bool HasFlamethrower = false;
        float FlamethrowerDamage = 80f;


        // railgun weapon 3
        bool HasRailgun = false;
        float RailgunDamage = 240f;


        //freeze ray weapon 4 
        bool HasFreezeBlaster = false;
        float FreezerBlaster = 150f;


        //laser gun weapon 5
        //        bool HasIonLaser = false;
        //float IonLaserDamage = 1000f;


        //stasisbubble tool 6
        //        bool HasStasisBubble = false;
        //float StasisBubbleDamage = 0f;


        // rocketbooster buff 7
        bool HasRocketThrusters = false;
        float RocketThrustersDamage = 0f;


        // healing tool 8
        bool HasSelfRepair = false;
        float SelfRepairHealing = -1500f;


        // shield tool 9
        bool HasShield = true;
        float ShieldDamage = 0f;



        // kamikaze attack 0
        bool SelfDestruct = false;
        float SelfDestructDamage = 999999999f;


        //states all enemies stats and misc.


        //states the stats of the stalker
        //string stalkerAbout = "A slightly below-average sized, skinny creature with white, almost luminescent skin. They appear to be incredibly malnorished, with build being more bone than flesh.\n Their hunting tactics revolves around observing their prey to get a read on their movement and searching for weak points to attack with lighting fast claw strikes when the target is most vulnerable. Their first priority is conserving energy, which explains their reserved mannered of fighting.";

        struct EnemyMonster
        {
            public string MonsterName;
            public string MonsterInfo;
            public float MonsterHealth;
            public float MonsterDefense;
            public float MonsterSpeed;
            public float MonsterDamage;
            public float MonsterMoveCount;
        }


        // struct Attack
        void DisplayStalkerCombatStats(EnemyMonster MonsterA)
        {
            Console.WriteLine("Enemy: " + MonsterA.MonsterName);
            Console.WriteLine("HP: " + MonsterA.MonsterHealth);
            Console.WriteLine("DEF: " + MonsterA.MonsterDefense);
            Console.WriteLine("SPD: " + MonsterA.MonsterSpeed);
            Console.WriteLine("ATK: " + MonsterA.MonsterDamage);
            Console.WriteLine("\n\n");
        }

        void DisplayHurkerCombatStats(EnemyMonster MonsterB)
        {
            Console.WriteLine("Enemy: " + MonsterB.MonsterName);
            Console.WriteLine("HP: " + MonsterB.MonsterHealth);
            Console.WriteLine("DEF: " + MonsterB.MonsterDefense);
            Console.WriteLine("SPD: " + MonsterB.MonsterSpeed);
            Console.WriteLine("ATK: " + MonsterB.MonsterDamage);
            Console.WriteLine("\n\n");
        }


        void Combat (EnemyMonster MonsterA, EnemyMonster MonsterB)
        {
            while (MonsterA.MonsterHealth>=0 ||MonsterB.MonsterHealth>=0)
            {

            DisplayStalkerCombatStats (MonsterA);
            DisplayHurkerCombatStats (MonsterB);
                Console.ReadKey(true);
            StalkerAttacksHurker(ref MonsterA, ref MonsterB);
                Console.WriteLine("\n\n");
                Console.ReadKey(true);
                DisplayStalkerCombatStats(MonsterA);
                DisplayHurkerCombatStats(MonsterB);
                Console.ReadKey(true);
            HurkerAttacksStalker(ref MonsterA, ref MonsterB);
                Console.WriteLine("\n\n");
                Console.ReadKey(true);

            }

            if (MonsterA.MonsterHealth >= 0)
            {
                Console.WriteLine("The Hurker wins!");
            }
            else if (MonsterB.MonsterHealth >= 0);
            {
                Console.WriteLine("The Stalker wins!");
            }
        }

        float StalkerAttacksHurker(ref EnemyMonster MonsterA, ref EnemyMonster MonsterB)
        {
            float reducedDamage = MonsterA.MonsterDamage * MonsterB.MonsterDefense;
            float remainingHealth = MonsterB.MonsterHealth - reducedDamage;
            Console.WriteLine(MonsterA.MonsterName + " claws " + MonsterB.MonsterName + " for " + reducedDamage + " damage!");
            

            return remainingHealth;
        }



        float HurkerAttacksStalker(ref EnemyMonster MonsterA, ref EnemyMonster MonsterB)
        {
            float reducedDamage = MonsterB.MonsterDamage * MonsterA.MonsterDefense;
            float remainingHealth = MonsterA.MonsterHealth -= reducedDamage;
            
            Console.WriteLine(MonsterB.MonsterName + " smacks "+MonsterA.MonsterName+" for "+reducedDamage+" damage!");
            

            return remainingHealth;
        }


        ////void chnageNumber(float a)

        //the mock damage calculator function
        //float CalculateDamage(EnemyMonster MonsterA, EnemyMonster MonsterB )
        //{
        //    float reducedDamage = MonsterA.MonsterDamage * MonsterB.MonsterDefense;
        //    float totalDamage = MonsterB.MonsterHealth - reducedDamage;
        //    Console.WriteLine(MonsterA.MonsterName+"")

        //    return totalDamage;
        //}



        //string monsterAName = "Stalker";
        //float monsterAHealth = 90f;
        //float monsterADefense = .90f;
        //float MonsterASpeed = 60f;
        //float stalkerStrikeDamage = 600f;
        //bool stalkerDead = true;



        //function for stalker info



        //void ShowStatus ()
        //{
        //    Console.WriteLine("STALKER HEALTH: "+stalkerHealth);
        //    Console.WriteLine("STALKER DEFENCE: "+stalkerDefense);
        //    Console.WriteLine("PLAYER HEALTH: " +PlayerHealth);
        //    Console.WriteLine("PLAYER DEFENCE: "+PlayerDefense);

        //    return;
        //}

        //states the stats of the sticker
        //string stickerAbout = "";
        //float stickerHealth = 30;

        //states the stats of the jockey
        //float lackeyHealth = 25;





        // beggining dialogue sequence
        void BeginDialogue(int a, string Text)
        {

            if (a == 0)
            {
                Console.WriteLine("[PRESS A BUTTON TO ADVANCE DIALOGUE]");
                Console.ReadKey(true);
                Console.WriteLine(Text);
                Console.ReadKey(true);
            }
            else if (a == 1)
            {
                Console.WriteLine("[PRESS A BUTTON TO ADVANCE DIALOGUE]");
                Console.ReadKey(true);
                Console.WriteLine("Dr. Ortego: " + Text);
                Console.ReadKey(true);
            }
            else if (a == 2)
            {
                Console.WriteLine("[PRESS A BUTTON TO ADVANCE DIALOGUE]");
                Console.ReadKey(true);
                Console.WriteLine(PlayerName+": " + Text);
                Console.ReadKey(true);
            }
            

        }

        // dialogue sequence
        void Dialogue(int a, string Text)
        {
            if (a==0)
            {
            Console.WriteLine(Text);
            Console.ReadKey(true);
            }
            else if (a==1)
            {
                Console.WriteLine("Dr. Ortego: "+Text);
                Console.ReadKey(true);
            }
            else if (a==2)
            {
                Console.WriteLine(PlayerName+": "+Text);
                Console.ReadKey(true);
            }
            
            

        }


        // dialouge advancing function
        void EndDialogue(int a, string Text)
        {
            if (a == 0)
            {
            Console.WriteLine(Text);
            Console.WriteLine("" +
                            "" +
                            "");
            Console.ReadKey(true);
            }
            else if (a == 1)
            {
                Console.WriteLine("Dr. Ortego: "+Text);
                Console.WriteLine("" +
                                "" +
                                "");
                Console.ReadKey(true);
            }
            else if (a == 2)
            {
                Console.WriteLine(PlayerName+": "+Text);
                Console.WriteLine("" +
                                "" +
                                "");
                Console.ReadKey(true);
            }

            



        }

        //function for upcoming decision from dialogue
        void DecisionDialogue(int a, string Text)
        {
            if (a == 0)
            {
            Console.WriteLine(Text);
            Console.WriteLine("" +
                            "" +
                            "");
            }
            else if (a == 1)
            {
                Console.WriteLine("Dr. Ortego: "+Text);
                Console.WriteLine("" +
                                "" +
                                "");
            }
            else if (a == 2)
            {
                Console.WriteLine(PlayerName+": "+Text);
                Console.WriteLine("" +
                                "" +
                                "");
            }
            
        }

        



        //function for menu
        void MainMenu ()
        {
            DecisionDialogue(0, "PAUSED");
            Console.WriteLine("1. Resume");
            Console.WriteLine("2. Restart");
            Console.WriteLine("3. Return to Start");
            Console.WriteLine("4. Quit Game");
            PlayerChoice = "";
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "2" && PlayerChoice != "4")
            {
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    return;
                }
                else if (PlayerChoice == "2")
                {
                    CurrentScene = 1;
                }
                else if (PlayerChoice == "3")
                {
                    CurrentScene = 0;
                    return;
                }
                else if (PlayerChoice == "4")
                {
                    Playerisalive = false;   
                }
                else
                {
                    DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                }
                
            }
            
        }

        //mock menu function
        string TBD_Menu(string prompt, string option1, string option2, string option3)
        {
            PlayerChoice = "0";

            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
            {
                //display promblems and solutions
                
                Console.WriteLine(prompt);

                Console.WriteLine("1." + option1);

                Console.WriteLine("2." + option2);

                Console.WriteLine("3" + option3);

                if (option3 != "")
                {
                    Console.WriteLine("3." + option3);
                }

                //player input
                Console.WriteLine("> ");
                PlayerChoice = Console.ReadLine();

                // if invalid input,
                if (PlayerChoice != "1" && PlayerChoice != "2")
                {
                    if (PlayerChoice == "3"&& option3 != "")
                    {
                        continue;
                    }

                    //
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("press a button");
                    Console.ReadKey(true);

                }

            }

            return PlayerChoice;
        }


        //function for introduction
        void Introduction()
        {
            BeginDialogue(0, "TWIST OF FATE: \n METAMORPHIS");
            Dialogue(0, "[IT IS RECOMMENDED TO PLAY WITH CAPS LOCK ON]");
            Dialogue(0,"You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile.");
            Dialogue(0, "However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters.");
            Dialogue(0, "With an monster invasion underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annihilation!");
            DecisionDialogue(0, "Can you change your fate? Y/N");


            while (PlayerChoice != "Y" && PlayerChoice != "N")
            {
                
            PlayerChoice = Console.ReadLine();
                
                if (PlayerChoice == "Y")
                {
                    EndDialogue(0, "Then if you truly believe you can, seek it out and bring this ship from the brink of destruction!");
                    CurrentScene = 1;
                    return;
                }
                else if (PlayerChoice == "N")
                {
                    BeginDialogue(0, "BAD END");
                    Dialogue(0, "BY FAILING TO EVEN ATTEMPT TO CHANGE FATE, YOU HAVE ALREADY LOST");
                    Dialogue(0, "THE SHIP FALLS TO CHAOS, CLAIMED BY THE CREATURES");
                    EndDialogue(0, "THERE WERE NO SURVIVORS");
                    Playerisalive = false;
                    return;
                }
                else
                {
                    DecisionDialogue(0, "ERROR, INVALID INPUT, INPUT A LETTER CORRESPONDING TO YOUR WANTED CHOICE.");
                    
                }
            }
            return;
        }

        //function for beggining sequence
        void BegginingSequence ()
        {
            BeginDialogue(0, "TIME: AUGUST 17TH, 3492");
            Dialogue(0, "LOCATION: SECTOR X-79");
            EndDialogue(0, "VESSEL NAME: INDAGATUS II");
            BeginDialogue(1,"Stay back! Don't come any closer!");
            Dialogue(0, "the creature stares at the woman with the eyes of a predator as it assumes its attack position.");
            Dialogue(1, "Someone please, Help me! Anybody!");
            Dialogue(0, "The Creature leaps towards Dr. Ortego.");
            Dialogue(0, "CLANK");
            Dialogue(1, "Wh... What?");
            Dialogue(0, "Dr. Ortego looks to see the creature being held back by a Janus Bot.");
            Dialogue(2, "DR. ORTEGO, ARE YOU HURT, PLEASE STATE YOUR HEALTH RATING.");
            Dialogue(1, "[Suprised] I... I'm fi-");
            EndDialogue(2, "EXCUSE ME DR. ORTEGO, BUT I MUST FIRST CLEAN THIS STAIN BEFORE I CAN SPEAK WITH YOU");
            CurrentScene = 2;

        }




        //function for tutorial battle sequence
        //void TutorialSequence()
        //{
        //    EndDialogue(0, "UNKNOWN STAIN DETECTED: CLEANSE ALL STAINS BEFORE CONTINUING.");

        //    ShowStatus();



        //    while (stalkerHealth > 0)
        //    {
                
        //        Dialogue(0, "Select the \"Mop Strike\" Option by inputing the Number corresponding to the option.");
        //        DecisionDialogue(0, "1: Mop Strike");
        //        Console.WriteLine("2: MENU");
                
                
        //        PlayerChoice = Console.ReadLine();
                
        //        if (PlayerChoice == "1")
        //        {

        //            stalkerHealth = CalculateDamage(stalkerHealth, MopStrikeDamage, stalkerDefense);
        //        }
        //        else if (PlayerChoice == "2")
        //        {
        //            MainMenu();
        //            return;
        //        }
        //        else
        //        {
        //            DecisionDialogue(0, "ERROR, INPUT A NUMBER CORRESPONDING TO THE OPTION");
        //        }
        //        ShowStatus();

        //    }
        //    if (stalkerHealth <= 0)
        //    { CurrentScene = 4; }
        //    return;
        //}


        void VictorySequence()
        {
            BeginDialogue(0, "YOU WON");
                Playerisalive = false;
        }

        //function for naming sequence
        void NamingSequence ()
        {
            
                    
            string firstname = "";
            string secondname = "";
            string playername = "";
            Console.WriteLine("Engineer Lady: you! Bot! can you hear me?");
            Console.ReadKey(true);
            Console.Clear();

            while (PlayerChoice != "1")
            {
                Console.WriteLine("Engineer Lady: State your name!");
                Console.Write(">");
                firstname = Console.ReadLine();
                Console.WriteLine("Engineer lady: " + firstname + " what? You have a last name, right?");
                Console.Write(">");
                secondname = Console.ReadLine();

                playername = firstname + " " + secondname;

                PlayerChoice = "";

                while (PlayerChoice != "1" && PlayerChoice != "2")
                {

                    Console.WriteLine("\"" + playername + "\"" + "? Is that really your full name?");
                    Console.WriteLine("1. AFFIRMATIVE");
                    Console.WriteLine("2. NEGATIVE");

                    PlayerChoice = Console.ReadLine();

                    if (PlayerChoice == "1")
                    {

                        Console.WriteLine(playername + "? " + "what an odd name for some cleaner robot; err, a janus bot. But whatever, that's not important!!");
                        Console.ReadKey(true);
                        Console.WriteLine("look " + playername + ", we don't have much time, everything has gone to crap.");
                        Console.ReadKey(true);


                    }
                    else if (PlayerChoice == "2")
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
                return;
            }

        }




        //function for new weapon sequence
        void NewWeapon()
        {
            
            BeginDialogue(0, "you spot two weapons on the ground,");
                Dialogue(0, "the one on the left is a railgun.");
                Dialogue(0, "the one on the right is a flamethrower.");
                Dialogue(0, "which one do you take?");
                DecisionDialogue(0, "1:railgun  2:flamethrower");

            while (PlayerChoice != "1" && PlayerChoice != "2")
            {

                

                PlayerChoice = Console.ReadLine();

                if (PlayerChoice == "1")
                {
                    HasRailgun = true;
                    Dialogue(0, "You pick up the railgun and swap out your shoulder mounted pressure washer with it. As you see the azure paint job contrast with your factory default silver finish, You feel as if you are slowly changing into someone else.");
                    
                }
                else if (PlayerChoice == "2")
                {
                    
                    HasFlamethrower = true;
                    Dialogue(0, "You pick up the flamethrower and swap your vacuum attachment on your arm with. As you see the red details of the flamethrower contrast with your factory default silver finish, you feel as if you are slowly changing into something else.");
                    
                }
                else
                {
                   
                    DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                    
                }
            }
        }


        // function for game over sequence 
        //1:restart fight   2: restart from begginning  3: return to main menu  4:quit game
        void GameOver ()
        {
                BeginDialogue(0, "YOUR JOURNEY HAS COME TO AN END.");
                Dialogue(0, "YOUR EFFORTS IN CHANGING YOUR FATE WERE IN VAIN.");
                Dialogue(0, "THE MONSTERS ENVELOP THE SHIP, LEAVING NO SURVIVORS.");
            Dialogue(0, "WILL YOU ATTEMPT TO CHANGE FATE ONCE MORE?");
            DecisionDialogue(0, "1: TRY AGAIN");

            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "2" && PlayerChoice != "4" )
            {
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice=="1")
                {
                    CurrentScene = 9;
                }
                else if (PlayerChoice=="2")
                {
                    CurrentScene = 1;
                }
                else if (PlayerChoice=="3")
                {
                    CurrentScene = 0;
                }
                else if (PlayerChoice=="4")
                {
                    Playerisalive = false;
                }
                else
                {
                    DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                }
            }

        }

       

        //funtion for checking which weapons player has
        //bool WeaponCheck (bool HasGatlingGun, bool HasFlamethrower, bool HasRailgun, bool HasFreezeBlaster, bool HasIonLaser, bool HasStasisBubble, bool HasRocketThrusters, bool SelfRepair, bool SelfDestruct )
        //{
        //    if (HasGatlingGun = false)
        //    {

        //    }
        //}



        




        //funtion for setting up everything for fight sequence
        


        // mock combat sequence
        // turn based battle between player and opposing forces
        // gives players two actions per turn to attack, heal, or apply a buff
        // on enemy turn, each enemy gets a to preform a action such as attack, defend, buff, or debuff
        // allows for more enemies and even duplicate enemies as well

        string PlayerTurn (string prompt, string option1, string option2, string option3)
        {
            float movecount = 2f;
            PlayerChoice = "0";


            for (movecount = 2f; movecount == 0f; movecount--)
            {
                while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
                {
                    //display promblems and solutions
                    
                    Console.WriteLine(prompt);

                    Console.WriteLine("1." + option1);

                    Console.WriteLine("2." + option2);

                    Console.WriteLine("3" + option3);

                    if (option3 != "")
                    {
                        Console.WriteLine("3." + option3);
                    }

                    //player input
                    Console.WriteLine("> ");
                    PlayerChoice = Console.ReadLine();

                    // if invalid input,
                    if (PlayerChoice != "1" && PlayerChoice != "2")
                    {
                        if (PlayerChoice == "3" && option3 != "")
                        {
                            continue;
                        }

                        //
                        Console.Clear();
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("press a button");
                        Console.ReadKey(true);

                    }

                }

                
            }
            return PlayerChoice;
        }


        

        


        //mock status function
        void StatusMenu(string Name, float Health, float Defense, float Speed)
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Defense: "+ Defense);
            Console.WriteLine("Speed: " + Speed);
            return;
        }

       

        

        public void Run()
        {
            
            
            EnemyMonster MonsterA;
            MonsterA.MonsterName = "Stalker";
            MonsterA.MonsterInfo = "A slightly below-average sized, skinny creature with white, almost luminescent skin. They appear to be incredibly malnorished, with build being more bone than flesh.\n Their hunting tactics revolves around observing their prey to get a read on their movement and searching for weak points to attack with lighting fast claw strikes when the target is most vulnerable. Their first priority is conserving energy, which explains their reserved mannered of fighting.";
            MonsterA.MonsterHealth = 280f;
            MonsterA.MonsterDefense = .90f;
            MonsterA.MonsterSpeed = 60f;
            MonsterA.MonsterDamage = 90f;
            MonsterA.MonsterMoveCount = 1f;
            

            //string monsterAName = "Stalker";
            //float monsterAHealth = 90f;
            //float monsterADefense = .90f;
            //float MonsterASpeed = 60f;

            EnemyMonster MonsterB;
            MonsterB.MonsterName = "Hurker";
            MonsterB.MonsterInfo = "TBD";
            MonsterB.MonsterHealth = 500f;
            MonsterB.MonsterDefense = .45f;
            MonsterB.MonsterSpeed = 30f;
            MonsterB.MonsterDamage = 125f;
            MonsterB.MonsterMoveCount = 1f;

            Combat(MonsterA, MonsterB);


            //DisplayStalkerCombatStats( MonsterA);
            //DisplayHurkerCombatStats( MonsterB);

            
            //while (Playerisalive == true)
            //{
            //    if (CurrentScene == 0)
            //    {
            //        Introduction();
            //    }    
            //    else if (CurrentScene ==1)
            //    {
            //        BegginingSequence();
            //    }
            //    else if (CurrentScene==2)
            //    {
            //        //TutorialSequence();
            //    }
            //    else if (CurrentScene ==3)
            //    {
            //        NamingSequence();
            //    }
            //    else if (CurrentScene ==4)
            //    {
            //        VictorySequence();
            //    }
            //    else 
            //    {
            //        GameOver();
            //    }

            //}
            
        }
    }
}
