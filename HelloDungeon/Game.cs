using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace HelloDungeon
{
    class Game
    {





        string PlayerChoice = "";
        int CurrentScene = 0;

        bool GameOver;


        //ALL CHARACTERS

        //Player
        Character Player0;
        Character PlayerA;
        Character PlayerB;
        Character PlayerC;

        //stalker enemy
        Character Stalker;

        // hurker enemy
        Character Hurker;





        //ALL MOVES

        //mopstrike move
        Attack Mopstrike;

        //roundhouse kick move
        Attack SpinKick;

        //Elbow strike move
        Attack ElbowStrike;

        //Shoulder bash move
        Attack ShoulderBash;

        // flamethrower move
        Attack FlameThrower;

        //railgun move
        Attack Railgun;

        //gatling gun move
        Attack GatlingGun;

        //states all moves and options for J-CCC


        //gatling gun weapon 1
        //float GatlingGunDamage = 500f;




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







        // struct for Characters
        struct Character
        {
            public string CharacterName;
            public string CharacterInfo;
            public float CharacterHealth;
            public float CharacterDefense;
            public float CharacterSpeed;
            public float CharacterDamageMultiplier;
            public float CharacterEnergyCount;
            public Attack CharacterAttack1;
            public Attack CharacterAttack2;

        }

        // struct for all attacks
        struct Attack
        {
            public string AttackName;
            public string AttackInfo;
            public float AttackDamage;
            public float AttackCritChance;
            public float AttackDOT;
            public float AttackEnergyCost;

        }



        void DisplayStalkerCombatStats(Character Stalker)
        {
            Console.WriteLine("Enemy: " + Stalker.CharacterName);
            Console.WriteLine("HP: " + Stalker.CharacterHealth);
            Console.WriteLine("DEF: " + Stalker.CharacterDefense);
            Console.WriteLine("SPD: " + Stalker.CharacterSpeed);
            Console.WriteLine("ATK: " + Stalker.CharacterDamageMultiplier);
            Console.WriteLine("WEAPON: " + Stalker.CharacterAttack1.AttackDamage);
            Console.WriteLine("\n\n");
        }

        void DisplayHurkerCombatStats(Character Hurker)
        {
            Console.WriteLine("NAME: " + Hurker.CharacterName);
            Console.WriteLine("HP: " + Hurker.CharacterHealth);
            Console.WriteLine("DEF: " + Hurker.CharacterDefense);
            Console.WriteLine("SPD: " + Hurker.CharacterSpeed);
            Console.WriteLine("ATK: " + Hurker.CharacterDamageMultiplier);
            Console.WriteLine("WEAPON: " + Hurker.CharacterAttack1.AttackDamage);
            Console.WriteLine("\n\n");
        }


        //void Combat (Character Stalker, Character Hurker)
        //{


        //    DisplayStalkerCombatStats (Stalker);
        //    DisplayHurkerCombatStats (Hurker);
        //        Console.ReadKey(true);
        //    StalkerAttacksHurker(ref Stalker, ref Hurker);

        //        Console.ReadKey(true);
        //        DisplayStalkerCombatStats(Stalker);
        //        DisplayHurkerCombatStats(Hurker);
        //        Console.ReadKey(true);
        //    HurkerAttacksStalker(ref Hurker, ref Stalker);

        //        Console.ReadKey(true);

        //}

        //void CombatResults()
        //{
        //    if (Stalker.CharacterHealth > 0 && Character.CharacterHealth < 0)
        //    {
        //        Dialogue(0,"The Stalker wins!");
        //    }
        //    else if (Character.CharacterHealth > 0 && Stalker.CharacterHealth < 0)
        //    {
        //        Dialogue(0,"The Hurker wins!");
        //    }
        //}

        float StalkerAttacksHurker(ref Character Stalker, ref Character Hurker)
        {
            float reducedDamage = (Stalker.CharacterDamageMultiplier + Stalker.CharacterAttack1.AttackDamage) * Hurker.CharacterDefense;
            float remainingHealth = Hurker.CharacterHealth - reducedDamage;
            if (remainingHealth > 0)
            {
            EndDialogue(0, Stalker.CharacterName + " claws " + Hurker.CharacterName + " for " + reducedDamage + " damage!");
            
            }
            else if (remainingHealth < 0)
            {
                Dialogue(0, Stalker.CharacterName + " claws " + Hurker.CharacterName + " for " + reducedDamage + " damage!");
                EndDialogue(0, Hurker.CharacterName + " is finished!");
            }

            return remainingHealth;
        }



        float HurkerAttacksStalker(ref Character Stalker, ref Character Hurker)
        {

            float reducedDamage = (Hurker.CharacterDamageMultiplier + Hurker.CharacterAttack1.AttackDamage) * Stalker.CharacterDefense;
            float remainingHealth = Stalker.CharacterHealth - reducedDamage;
            if (remainingHealth > 0)
            {
                EndDialogue(0, Hurker.CharacterName + " smacks " + Stalker.CharacterName + " for " + reducedDamage + " damage!");

            }
            else if (remainingHealth < 0)
            {
                Dialogue(0, Hurker.CharacterName + " smacks " + Stalker.CharacterName + " for " + reducedDamage + " damage!"); ;
                EndDialogue(0, Stalker.CharacterName + " is finished ");
            }

            return remainingHealth;
        }


        void AttackMove(ref Attack move, ref Character target)
        {
            
            //float combinedAttackDamage = (move.CharacterDamageMultiplier * move.CharacterAttack);
            //float reducedDamage = (combinedAttackDamage * target.CharacterDefense);
            //float remainingHealth = target.CharacterHealth - reducedDamage;
        }

        /// <summary>
        /// create a function that takes a integer array.
        /// the function should print out the sum of all of the values in the array
        /// input: int[] numbers = int [3] {1,2, 3};
        /// output: 6
        /// </summary>


        int[] theints=new int[4] {45,78,1,4};
        int[] uhh = new int[7] { 7, 7, 7, 7, 7, 7, 7 };
        void add(int[] i )
        {
            int sum;
            for (int sum = , int[] !=, sum++)
            {

            }
            
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
                Console.WriteLine("Aedificator Ortego: " + Text);
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
                Console.WriteLine("Aedificator Ortego: " + Text);
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
                Console.WriteLine("Aedificator Ortego: " + Text);
                Console.WriteLine("" +
                                "" +
                                "");
                Console.ReadKey(true);
            }


            



        }

        //function for upcoming decision from dialogue
        string DecisionDialogue(int a, string Question, string option1, string option2, string option3)
        {
            PlayerChoice = "";
            while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
            {
                //display promblems and solutions

                if (a == 0)
                {
                    {
                    Console.WriteLine(Question);
                    Console.WriteLine("" +
                                    "" +
                                    "");

                    Console.WriteLine("1:" + option1);

                    Console.WriteLine("2:" + option2);


                    if (option3 != "")
                    {
                        Console.WriteLine("3:" + option3);
                    }

                    //player input
                    Console.Write("> ");
                    PlayerChoice = Console.ReadLine();
                    }

                // if invalid input,
                if (PlayerChoice != "1" && PlayerChoice != "2")
                {
                    if (PlayerChoice == "3" && option3 != "")
                    {
                        continue;
                    }


                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("press a button");
                    Console.ReadKey(true);
                }

                }
                else if (a == 1)
                {
                    Console.WriteLine("Aedificator Ortego: " + Question);
                    Console.WriteLine("" +
                                    "" +
                                    "");

                    Console.WriteLine("1:" + option1);

                    Console.WriteLine("2:" + option2);


                    if (option3 != "")
                    {
                        Console.WriteLine("3:" + option3);
                    }

                    //player input
                    Console.Write("> ");
                    PlayerChoice = Console.ReadLine();
                }

                // if invalid input,
                if (PlayerChoice != "1" && PlayerChoice != "2")
                {
                    if (PlayerChoice == "3" && option3 != "")
                    {
                        continue;
                    }


                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("press a button");
                    Console.ReadKey(true);

                }






                //return PlayerChoice;
            }
            return PlayerChoice;
        }


            void ShowStatus(Character Character)
            {
                Console.WriteLine("NAME: " + Character.CharacterName);
                Console.WriteLine("HP: " + Character.CharacterHealth);
                Console.WriteLine("DEF: " + Character.CharacterDefense);
                Console.WriteLine("SPD: " + Character.CharacterSpeed);
                Console.WriteLine("ATK: " + Character.CharacterAttack1);
                Console.WriteLine("ATK MULTI: " + Character.CharacterDamageMultiplier);
                Console.WriteLine("ENERGY: " + Character.CharacterEnergyCount);
                Console.WriteLine("\n\n");



            }
            //PlayerC.CharacterName = "J-CCC";
            //PlayerC.CharacterInfo = "A robot with new found purpose";
            //PlayerC.CharacterHealth = 3750f;
            //PlayerC.CharacterDefense = .50f;
            //PlayerC.CharacterSpeed = 15f;
            //PlayerC.CharacterDamageMultiplier = 1.2f;
            //PlayerC.CharacterEnergyCount = 3f;
            //PlayerC.CharacterAttack = Mopstrike;

        void ShowWeaponStats (Attack Attack)
        {
            Console.WriteLine("WEAPON: "+ Attack.AttackName);
            Console.WriteLine("INFO: "+Attack.AttackInfo);
            Console.WriteLine("DAMAGE: "+Attack.AttackDamage);
            Console.WriteLine("CRITICAL CHANCE: "+Attack.AttackCritChance);
            if (Attack.AttackDOT != 0)
            {
                Console.WriteLine("DAMAGE OVER TIME (DOT): "+Attack.AttackDOT);
            }
            Console.WriteLine("ENERGY COST: "+Attack.AttackEnergyCost);

        }
            void ShowCompleteStatus()
            {

            }

        void Combat()
        {

        }


        void BuildaRobot()
        {
            BeginDialogue(0, "IN AEDIFICATOR ORTEGO'S OFFICE");
            Dialogue(1, "Finally, I got his core out!");
            Dialogue(1, "Better be careful with this, these power cores can be very volatile.");
            EndDialogue(1, "Okay, so first thing's first, I'm gonna need to put you into a new chassis, but what to pick...");

            int uhh = 0;
            while (uhh == 0)
            {
                uhh = 1;
                DecisionDialogue(0, "SELECT A CHASSIS", "Hermes Chassis: enables faster movement at the cost of of being weaker", "Hercules' Chassis: Boasts stronger offensive capabilites.", "Salus' Chassis: offers higher durability at the cost of agility.");

                if (PlayerChoice == "1")
                {
                    Player0 = PlayerA;
                }
                else if (PlayerChoice == "2")
                {
                    Player0 = PlayerB;
                }
                else if (PlayerChoice == "3")
                {
                    Player0 = PlayerC;
                }

                ShowStatus(Player0);

                DecisionDialogue(1, "Would this be a good fit?", "Yeah!", "Nah...", "");

                if (PlayerChoice == "1")
                {
                    uhh++;
                }
                else if (PlayerChoice == "2")
                {
                    return;
                }
            }

        Dialogue(1, "Okay, now I need to give him a weapon, can't have him running around just flailing his arms at this things.");
        DecisionDialogue(1, "What should I give him?", "Gatling gun: "+ GatlingGun.AttackInfo, "Flamethrower: "+FlameThrower.AttackInfo,"fulgur"+Railgun.AttackInfo);

        if (PlayerChoice == "1")
        {
            Player0.CharacterAttack2 = GatlingGun;
        }
        else if (PlayerChoice == "2")
        {
            Player0.CharacterAttack2 = FlameThrower;
        }
        else if (PlayerChoice == "3")
        {
            Player0.CharacterAttack2 = Railgun;
        }

        ShowWeaponStats(Player0.CharacterAttack2);

        DecisionDialogue(1, "Would this serve him well?", "Yeah!", "On second thought...", "");

        if (PlayerChoice == "1")
        {
            uhh++;
        }
        else if (PlayerChoice == "2")
        {
            return;
        }

        Dialogue(1, "Alright! We're doing this! We're actually doing this");
        Dialogue(1, "Get ready to fight!");
        CurrentScene = 1;

    }

        void TestDrive()
        {
            Dialogue(1, "uhhh");
        }


        void Start()
        {
            //all moves

            //.AttackName =
            //.AttackInfo =
            //.AttackDamage =
            //.AttackCritChance =
            //.AttackDOT =
            //.AttackEnergyCost =

            //default attacks

            Mopstrike.AttackName = "Mopstrike";
            Mopstrike.AttackInfo = "One swipe and the dirt is gone!";
            Mopstrike.AttackDamage = 25f;
            Mopstrike.AttackCritChance = 1f;
            Mopstrike.AttackDOT = 0f;
            Mopstrike.AttackEnergyCost = 1f;

            SpinKick.AttackName = "SpinKick";
            SpinKick.AttackInfo = "PREFORM A HIGH-SPEED 360 KICK.";
            SpinKick.AttackDamage = 50f;
            SpinKick.AttackCritChance = 50f;
            SpinKick.AttackDOT = 0f;
            SpinKick.AttackEnergyCost = 1f;

            ElbowStrike.AttackName = "Elbow_Strike";
            ElbowStrike.AttackInfo = "Thrust your elbow joint forward in a quick motion.";
            ElbowStrike.AttackDamage = 75f;
            ElbowStrike.AttackCritChance = 15f;
            ElbowStrike.AttackDOT = 0f;
            ElbowStrike.AttackEnergyCost = 1f;

            ShoulderBash.AttackName = "ShoulderBash";
            ShoulderBash.AttackInfo = "FROM A DASH, THROW YOUR WEIGHT FORWARD SHOULDER FIRST";
            ShoulderBash.AttackDamage = 100f;
            ShoulderBash.AttackCritChance = 33f;
            ShoulderBash.AttackDOT = 0f;
            ShoulderBash.AttackEnergyCost = 2f;

            // actual weapons

            GatlingGun.AttackName = "Gatling Gun";
            GatlingGun.AttackInfo = "A rapid-firing multiple-barrel firearm";
            GatlingGun.AttackDamage = 50f * 15f;
            GatlingGun.AttackCritChance = 25f;
            GatlingGun.AttackDOT = 0f;
            GatlingGun.AttackEnergyCost = 1f;

            FlameThrower.AttackName = "Ignis_Interjicio";
            FlameThrower.AttackInfo = "A flamethrower with a fire red finish, yeah that's all i got for now";
            FlameThrower.AttackDamage = 250f;
            FlameThrower.AttackCritChance = 50f;            
            FlameThrower.AttackDOT = 50f;
            FlameThrower.AttackEnergyCost = 2f;

            Railgun.AttackName = "Fulgur_Iactus";
            Railgun.AttackInfo = "A Bulky shoulder-mounted Railgun, modified to charge and fire a Bolt of Lighting faster than normal. It's very wellkempt,and has a nice azure finish.";
            Railgun.AttackDamage = 1000f;
            Railgun.AttackCritChance = 10f;
            Railgun.AttackDOT = 0f;
            Railgun.AttackEnergyCost = 3f;


            // ALL CHARACTER AND ENTITIES


            //template
            ///.CharacterName =
            ///.CharacterInfo +
            ///.CharacterHealth =
            ///.CharacterDefense =
            ///.CharacterSpeed =
            ///.CharacterDamageMultiplier =
            ///.CharacterEnergyCount =
            ///.CharacterAttack1 =
            ///.CharacterAttack2 =

            Player0.CharacterName= "J-CCC";
            Player0.CharacterInfo = "A Standard Janus Bot";
            Player0.CharacterHealth = 10000f;
            Player0.CharacterDefense = .47f;
            Player0.CharacterSpeed = 15f;
            Player0.CharacterDamageMultiplier = 1.0f;
            Player0.CharacterEnergyCount = 2f;
            Player0.CharacterAttack1 = Mopstrike;
            Player0.CharacterAttack2 = Mopstrike;

            PlayerA.CharacterName = "J-CCC";
            PlayerA.CharacterInfo = "A Fast robot with new found purpose";
            PlayerA.CharacterHealth = 1500f;
            PlayerA.CharacterDefense = .80f;
            PlayerA.CharacterSpeed = 75f;
            PlayerA.CharacterDamageMultiplier = 0.9f;
            PlayerA.CharacterEnergyCount = 5f;
            PlayerA.CharacterAttack1 = SpinKick;
            PlayerA.CharacterAttack2 = Mopstrike;

            PlayerB.CharacterName = "J-CCC";
            PlayerB.CharacterInfo = "A Dangerous robot with new found purpose";
            PlayerB.CharacterHealth = 2250f;
            PlayerB.CharacterDefense = .69f;
            PlayerB.CharacterSpeed = 45f;
            PlayerB.CharacterDamageMultiplier = 1.8f;
            PlayerB.CharacterEnergyCount = 4f;
            PlayerB.CharacterAttack1 = ElbowStrike;
            PlayerB.CharacterAttack2 = Mopstrike;


            PlayerC.CharacterName = "J-CCC";
            PlayerC.CharacterInfo = "A Bulky robot with new found purpose";
            PlayerC.CharacterHealth = 3750f;
            PlayerC.CharacterDefense = .50f;
            PlayerC.CharacterSpeed = 15f;
            PlayerC.CharacterDamageMultiplier = 1.2f;
            PlayerC.CharacterEnergyCount = 3f;
            PlayerC.CharacterAttack1 = ShoulderBash;
            PlayerC.CharacterAttack2 = Mopstrike;



            // enemies

            Stalker.CharacterName = "Stalker";
            Stalker.CharacterInfo = "A slightly below-average sized, skinny creature with white, almost luminescent skin. They appear to be incredibly malnorished, with build being more bone than flesh.\n Their hunting tactics revolves around observing their prey to get a read on their movement and searching for weak points to attack with lighting fast claw strikes when the target is most vulnerable. Their first priority is conserving energy, which explains their reserved mannered of fighting.";
            Stalker.CharacterHealth = 280f;
            Stalker.CharacterDefense = .90f;
            Stalker.CharacterSpeed = 60f;
            Stalker.CharacterDamageMultiplier = 1.0f;
            Stalker.CharacterEnergyCount = 1f;
            Stalker.CharacterAttack1 = FlameThrower;
            

            
            Hurker.CharacterName = "Hurker";
            Hurker.CharacterInfo = "TBD";
            Hurker.CharacterHealth = 500f;
            Hurker.CharacterDefense = .45f;
            Hurker.CharacterSpeed = 30f;
            Hurker.CharacterDamageMultiplier = 1.6f;
            Hurker.CharacterEnergyCount = 1f;
            Hurker.CharacterAttack1 = Railgun;
            }

                                                                                                void Update()
        {
            if (CurrentScene == 0)
            {
                BuildaRobot();
                //Combat(Stalker, Hurker);
            }
            else if (CurrentScene == 1)
            {
                TestDrive();
            }
        }
        

                                                                                                void End()
        {
            Console.WriteLine("You have saved the ship!!");
        }


        //function for menu
        //void MainMenu ()
        //{
        //    DecisionDialogue(0, "PAUSED");
        //    Console.WriteLine("1. Resume");
        //    Console.WriteLine("2. Restart");
        //    Console.WriteLine("3. Return to Start");
        //    Console.WriteLine("4. Quit Game");
        //    PlayerChoice = "";
        //    while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "2" && PlayerChoice != "4")
        //    {
        //        PlayerChoice = Console.ReadLine();
        //        if (PlayerChoice == "1")
        //        {
        //            return;
        //        }
        //        else if (PlayerChoice == "2")
        //        {
        //            CurrentScene = 1;
        //        }
        //        else if (PlayerChoice == "3")
        //        {
        //            CurrentScene = 0;
        //            return;
        //        }
        //        else if (PlayerChoice == "4")
        //        {
        //            Playerisalive = false;   
        //        }
        //        else
        //        {
        //            DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
        //        }
                
        //    }
            
        //}

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
        //void Introduction()
        //{
        //    BeginDialogue(0, "TWIST OF FATE: \n METAMORPHIS");
        //    Dialogue(0, "[IT IS RECOMMENDED TO PLAY WITH CAPS LOCK ON]");
        //    Dialogue(0,"You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile.");
        //    Dialogue(0, "However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters.");
        //    Dialogue(0, "With an monster invasion underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annihilation!");
        //    DecisionDialogue(0, "Can you change your fate? Y/N");


        //    while (PlayerChoice != "Y" && PlayerChoice != "N")
        //    {
                
        //    PlayerChoice = Console.ReadLine();
                
        //        if (PlayerChoice == "Y")
        //        {
        //            EndDialogue(0, "Then if you truly believe you can, seek it out and bring this ship from the brink of destruction!");
        //            CurrentScene = 1;
        //            return;
        //        }
        //        else if (PlayerChoice == "N")
        //        {
        //            BeginDialogue(0, "BAD END");
        //            Dialogue(0, "BY FAILING TO EVEN ATTEMPT TO CHANGE FATE, YOU HAVE ALREADY LOST");
        //            Dialogue(0, "THE SHIP FALLS TO CHAOS, CLAIMED BY THE CREATURES");
        //            EndDialogue(0, "THERE WERE NO SURVIVORS");
        //            Playerisalive = false;
        //            return;
        //        }
        //        else
        //        {
        //            DecisionDialogue(0, "ERROR, INVALID INPUT, INPUT A LETTER CORRESPONDING TO YOUR WANTED CHOICE.");
                    
        //        }
        //    }
        //    return;
        //}

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


        //void VictorySequence()
        //{
        //    BeginDialogue(0, "YOU WON");
        //        Playerisalive = false;
        //}

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
        //void NewWeapon()
        //{
            
        //    BeginDialogue(0, "you spot two weapons on the ground,");
        //        Dialogue(0, "the one on the left is a railgun.");
        //        Dialogue(0, "the one on the right is a flamethrower.");
        //        Dialogue(0, "which one do you take?");
        //        DecisionDialogue(0, "1:railgun  2:flamethrower");

        //    while (PlayerChoice != "1" && PlayerChoice != "2")
        //    {

                

        //        PlayerChoice = Console.ReadLine();

        //        if (PlayerChoice == "1")
        //        {
        //            HasRailgun = true;
        //            Dialogue(0, "You pick up the railgun and swap out your shoulder mounted pressure washer with it. As you see the azure paint job contrast with your factory default silver finish, You feel as if you are slowly changing into someone else.");
                    
        //        }
        //        else if (PlayerChoice == "2")
        //        {
                    
        //            HasFlamethrower = true;
        //            Dialogue(0, "You pick up the flamethrower and swap your vacuum attachment on your arm with. As you see the red details of the flamethrower contrast with your factory default silver finish, you feel as if you are slowly changing into something else.");
                    
        //        }
        //        else
        //        {
                   
        //            DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
                    
        //        }
        //    }
        //}


        // function for game over sequence 
        //1:restart fight   2: restart from begginning  3: return to main menu  4:quit game
        //void GameOver ()
        //{
        //        BeginDialogue(0, "YOUR JOURNEY HAS COME TO AN END.");
        //        Dialogue(0, "YOUR EFFORTS IN CHANGING YOUR FATE WERE IN VAIN.");
        //        Dialogue(0, "THE MONSTERS ENVELOP THE SHIP, LEAVING NO SURVIVORS.");
        //    Dialogue(0, "WILL YOU ATTEMPT TO CHANGE FATE ONCE MORE?");
        //    DecisionDialogue(0, "1: TRY AGAIN");

        //    while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "2" && PlayerChoice != "4" )
        //    {
        //        PlayerChoice = Console.ReadLine();
        //        if (PlayerChoice=="1")
        //        {
        //            CurrentScene = 9;
        //        }
        //        else if (PlayerChoice=="2")
        //        {
        //            CurrentScene = 1;
        //        }
        //        else if (PlayerChoice=="3")
        //        {
        //            CurrentScene = 0;
        //        }
        //        else if (PlayerChoice=="4")
        //        {
        //            Playerisalive = false;
        //        }
        //        else
        //        {
        //            DecisionDialogue(0, "INVALID INPUT, PLEASE INPUT THE NUMBER PERTAINING TO YOUR DESIRED CHOICE");
        //        }
        //    }

        //}

       

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

        //string Decision (string prompt, string option1, string option2, string option3)
        //{
        //    float movecount = 2f;
        //    PlayerChoice = "0";


        //    for (movecount = 2f; movecount == 0f; movecount--)
        //    {
        //        while (PlayerChoice != "1" && PlayerChoice != "2" && PlayerChoice != "3")
        //        {
        //            //display promblems and solutions
                    
        //            Console.WriteLine(prompt);

        //            Console.WriteLine("1." + option1);

        //            Console.WriteLine("2." + option2);

        //            Console.WriteLine("3" + option3);

        //            if (option3 != "")
        //            {
        //                Console.WriteLine("3." + option3);
        //            }

        //            //player input
        //            Console.WriteLine("> ");
        //            PlayerChoice = Console.ReadLine();

        //            // if invalid input,
        //            if (PlayerChoice != "1" && PlayerChoice != "2")
        //            {
        //                if (PlayerChoice == "3" && option3 != "")
        //                {
        //                    continue;
        //                }

        //                //
        //                Console.Clear();
        //                Console.WriteLine("Invalid Input");
        //                Console.WriteLine("press a button");
        //                Console.ReadKey(true);

        //            }

        //        }

                
        //    }
        //    return PlayerChoice;
        //}

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
            //ALWAYS HAVE THE TEST FUNCTION UNDERNEATH START!!!!!!!!!!!!!!!!!!!!
            Start();


            while (GameOver==false)
            {
                Update();
            }


            End();
            
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
