using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Grade_One
{
    class Division
    {
        public string fname;
        public int points;
        public int tries;
        public int addition;
        public int subtraction;
        public int division;

        public Division(string fname, int points, int tries, int addition, int subtraction, int division)
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

            if (division == 0)
            {
                a = 1;
                b = 5;
            }
            else if (division == 1)
            {
                a = 1;
                b = 10;
            }
            else if (division == 2)
            {
                a = 1;
                b = 15;
            }
            else
            {
                a = 1;
                b = 100;
            }

            switch (division)
            {
                case 0:
                    Console.WriteLine(string.Format("Welcome to level {0} division, you have {1} lives left", subtraction, tries));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if (tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c / d;

                            Console.WriteLine(string.Format("{0} / {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");

                            try
                            {
                                answer = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {

                                Console.WriteLine("The answer can't be left empty or contain letters");
                                Console.ReadLine();
                                break;
                            }

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
                        }



                    }
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished subtraction level {1}", fname, division));
                    division++;
                    Menu addition_level_one = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                // division level 2

                case 1:
                    Console.WriteLine(string.Format("Welcome to level {0} division, you have {1} lives left", division, tries));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if (tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c / d;

                            Console.WriteLine(string.Format("{0} / {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");

                            try
                            {
                                answer = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {

                                Console.WriteLine("The answer can't be left empty or contain letters");
                                Console.ReadLine();
                                break;
                            }

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
                        }



                    }
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished division level {1}", fname, division));
                    division++;
                    Menu addition_level_two = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                case 2:
                    Console.WriteLine(string.Format("Welcome to level {0} division, you have {1} lives left", division, tries));
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        if (tries >= 0)
                        {
                            Random rnd = new Random();
                            int c = rnd.Next(a, b);
                            int d = rnd.Next(a, b);
                            summa = c - d;

                            Console.WriteLine(string.Format("{0} - {1}", c, d));
                            Console.WriteLine("");
                            Console.Write("> ");

                            try
                            {
                                answer = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {

                                Console.WriteLine("The answer can't be left empty or contain letters");
                                Console.ReadLine();
                                break;
                            }

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
                    Console.WriteLine(string.Format("Congratulations {0}, you did it. You have finished subtraction level {1}", fname, division));
                    division++;
                    Menu addition_level_three = new Menu(fname, points, tries, addition, subtraction, division);
                    break;

                default:
                    Console.WriteLine("övrigt ");
                    break;

            }
        }
    }
}