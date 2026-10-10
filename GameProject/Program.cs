using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int health = 3, damage = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r[###]");
            string read = Console.ReadLine();

            if (read == "+")
            {
                health += damage;
                Console.SetCursorPosition(0, 0);

            }
            else if (read == "-")
            {

                health -= damage;
                Console.SetCursorPosition(0, 0);

            }

            if (health == 3)
            {
                Console.WriteLine("\r[###]");


            }

            if (health == 2)
            {

                Console.Write("\r[##-]");
            }

            if (health == 1)
            {

                Console.Write("\r[#--]");
            }
           
            if (health == 0)
            {

                Console.Write("\r[---]");

            }
        }
    }
}
