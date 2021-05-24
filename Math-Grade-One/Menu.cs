using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Grade_One
{
    class Menu
    {
        public string fname;
        public int points;
        public int tries;
        public int addition;
        public int subtraction;
        public int division;


        public Menu(string fname, int points, int tries, int addition, int subtraction, int division)
        {
            Console.Clear();

            this.fname = fname;
            this.points = points;
            this.tries = tries;
            this.addition = addition;
            this.subtraction = subtraction;
            this.division = division;

            Console.WriteLine("");
            Console.WriteLine(string.Format("hello {0}", fname));
            Console.WriteLine("");

            var Category = new List<string>();
            Category.Add("1. Addition + level:" + addition);
            Category.Add("2. Subtraction - level:" + subtraction);
            Category.Add("3. Division / level:" + division);
            Category.Add("");
            Category.Add("4. Quit");

            // below code prints out the Category list

            for (int i = 0; i < Category.Count; i++)
            {
                Console.WriteLine(Category[i]);
            }

            bool loop = true;

            Console.WriteLine("");
            Console.WriteLine("Select which one by typing the number");
            Console.Write("> ");
            int select = Convert.ToInt32(Console.ReadLine());


            while (loop == true)
            {
                switch (select)
                {
                    case 1:
                        Addition plus = new Addition(fname, points, tries, addition, subtraction, division);
                        loop = false;
                        break;

                    //case '2':
                    //    Subtraction minus = new Subtraction(fname, points, tries, addition, subtraction, division);
                    //    loop = false;
                    //    break;

                    //case "3":
                    //    Division divide = new Division(fname, points, tries, addition, subtraction, division);
                    //    loop = false;
                    //    break;

                    //case '4':
                    //    ExitGame("menu");
                    //    loop = false;
                    //    break;

                    default:
                        Console.WriteLine("Please select a category");
                        break;
                }

            }

        }

    }
}
