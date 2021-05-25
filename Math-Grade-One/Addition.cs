using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Grade_One
{
    class Addition
    {
        public string fname;
        public int points;
        public int tries;
        public int addition;
        public int subtraction;
        public int division;

        public Addition(string fname, int points, int tries, int addition, int subtraction, int division)
        {
            Console.Clear();

            this.fname = fname;
            this.points = points;
            this.tries = tries;
            this.addition = addition;
            this.subtraction = subtraction;
            this.division = division;



            
            int a;
            int b;
            int summa;
            int counter = 10;
            int answer;

            // Code below checks at what level the user is 

            if(addition == 0)
            {
                a = 0;
                b = 5;
            }else if(addition == 1)
            {
                a = 0;
                b = 10;
            }else if(addition == 2)
            {
                a = 0;
                b = 15;
            }
            else
            {
                a = 0;
                b = 100;
            }

            switch (addition)
            {
                case 0:
                    Console.WriteLine(string.Format("Nivå {0} i Addition", addition));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if(tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c + d;

                            Console.WriteLine(string.Format("{0} + {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");
                            answer = Convert.ToInt32(Console.ReadLine());

                            if (answer == summa)
                            {
                                Console.Clear();
                                points++;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is correct, you have {0} points", points));
                                Console.WriteLine("");
                            }
                            else
                            {
                                tries--;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is wrong, Right answer is {0}, you have {0} tries", summa, tries));
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            ExitGame EndGame = new ExitGame("gameover", fname, points, addition, subtraction, division);
                        }



                    }
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished addition level {1}", fname, addition));
                    addition++;
                   Menu addition_level_one = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                    // addition level 2

                case 1:
                    Console.WriteLine(string.Format("Nivå {0} i Addition", addition));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if (tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c + d;

                            Console.WriteLine(string.Format("{0} + {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");
                            answer = Convert.ToInt32(Console.ReadLine());

                            if (answer == summa)
                            {
                                Console.Clear();
                                points++;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is correct, you have {0} points", points));
                                Console.WriteLine("");
                            }
                            else
                            {
                                tries--;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is wrong, Right answer is {0}, you have {0} tries", summa, tries));
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            ExitGame EndGame = new ExitGame("gameover", fname, points, addition, subtraction, division);
                        }



                    }
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished addition level {1}", fname, addition));
                    addition++;
                    Menu addition_level_two = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                case 2:
                    Console.WriteLine(string.Format("Nivå {0} i Addition", addition));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if (tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c + d;

                            Console.WriteLine(string.Format("{0} + {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");
                            answer = Convert.ToInt32(Console.ReadLine());

                            if (answer == summa)
                            {
                                Console.Clear();
                                points++;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is correct, you have {0} points", points));
                                Console.WriteLine("");
                            }
                            else
                            {
                                tries--;
                                Console.WriteLine("");
                                Console.WriteLine(string.Format("That is wrong, Right answer is {0}, you have {1} tries", summa, tries));
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            ExitGame EndGame = new ExitGame("gameover", fname, points, addition, subtraction, division);
                            break;
                        }



                    }
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished addition level {1}", fname, addition));
                    addition++;
                    Menu addition_level_three = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                default:
                    Console.WriteLine("övrigt ");
                    break;

            }
        }
    }
}