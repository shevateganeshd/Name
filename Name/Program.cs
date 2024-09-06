using System;

namespace Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool key;
            key = true;
            while(key)
            {
                int k, l;
                int lengthOfName;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter Name(GANESH) only: ");
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                lengthOfName = name.Length;
                for (l = 1; l <= 14; l++)
                {
                    for (k = 0; k < lengthOfName; k++)
                    {
                        if (l == 1)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write(" *******************  ");
                                    break;
                                
                                case 'e':
                                case 'E':
                                    Console.Write(" *******************  ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write(" *******************  ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******         ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write(" *******************  ");
                                    break;
                            }
                        }

                        if (l == 2)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("********************* ");
                                    break;
                                
                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("********************* ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("*******        ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("********************* ");
                                    break;
                            }
                        }

                        if (l == 3)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("********************* ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("********************* ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("********       ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("********************* ");
                                    break;
                            }
                        }

                        if (l == 4)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'H':
                                case 'h':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':

                                    Console.Write("*********      ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("******         ****** ");
                                    break;
                            }
                        }

                        if (l == 5)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******                ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':

                                    Console.Write("**********     ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("******                ");
                                    break;
                            }
                        }

                        if (l == 6)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******                ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("********************* ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("***********    ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("******                ");
                                    break;
                            }
                        }

                        if (l == 7)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("********************* ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******     ********** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("********************* ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("*************  ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("********************  ");
                                    break;
                            }
                        }

                        if (l == 8)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("********************* ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******     ********** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("********************* ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******  ************* ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write(" ******************** ");
                                    break;
                            }
                        }

                        if (l == 9)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("********************* ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******     ********** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("********************* ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******    *********** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("               ****** ");
                                    break;
                            }
                        }

                        if (l == 10)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':

                                    Console.Write("******     ********** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("               ****** ");
                                    break;
                            }
                        }

                        if (l == 11)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("******                ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******      ********* ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("******         ****** ");
                                    break;
                            }
                        }

                        if (l == 12)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("********************* ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******       ******** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("********************* ");
                                    break;
                            }
                        }

                        if (l == 13)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write("********************* ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write("********************* ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******        ******* ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write("********************* ");
                                    break;
                            }
                        }

                        if (l == 14)
                        {
                            switch (name[k])
                            {
                                case 'a':
                                case 'A':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'e':
                                case 'E':
                                    Console.Write(" *******************  ");
                                    break;

                                case 'g':
                                case 'G':
                                    Console.Write(" ************* ****** ");
                                    break;

                                case 'h':
                                case 'H':
                                    Console.Write("******         ****** ");
                                    break;

                                case 'n':
                                case 'N':
                                    Console.Write("******         ****** ");
                                    break;

                                case 's':
                                case 'S':
                                    Console.Write(" *******************  ");
                                    break;
                            }
                        }
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nDo you want to continue: Y/N  ");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y' || response == 'Y')
                    key = true;
                else
                    key = false;
            }
            
        }            
    }
}
