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
            //states the health, defense, and speed stats for all entities
            int jhp = 10000;
            int jdef = 25;
            int jspd = 15;
            int stalkerhp = 50;
            int stalkerdef = 10;
            int stalkerspd = 60;
            int stickerhp = 30;
            int lackeyhp = 25;

            bool SHUTDOWN = jhp <= 0;


            //this is at the start of the game that establishs the story and objective
            Console.WriteLine("TWIST OF FATE");
            Console.WriteLine("You were once a lowly Janus bot, built and tasked to keep the ship INDAGATUS II clean and sterile. However, things took a turn for the worse when the ship made impact with a large asteroid, infested with monsters. with an alien invasion ");
            Console.WriteLine("underway and all security Antesignano wiped out, it is up to you save the ship's inhabitants from annilation!");
            Console.WriteLine("" +
                "Can you change your fate?");
            //string intialanswer = Console.ReadLine;
         
            string playername= firstname+" "+secondname;
            Console.WriteLine("Engineer Lady: You! Bot! Can you hear me? State your name!");
            
            string firstname = Console.ReadLine();
            Console.WriteLine("And what is your last name?");
            string secondname = Console.ReadLine();
            Console.WriteLine(playername+"? "+"What an odd name for some cleaner robot; or, a Janus Bot. But whatever that's not important!!" );
            //Console.WriteLine("You spot a female engineer who seems to have locked herself in a room from the monsters.");
        }
    }
}
