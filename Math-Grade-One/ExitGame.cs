using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Grade_One
{
    class ExitGame
    {
        public string input;
        public string fname;
        public int points;
        public int addition;
        public int subtraction;
        public int division;

        public ExitGame(string input, string fname, int points, int addition, int subtraction, int division)
        {
            this.input = input;
            this.fname = fname;
            this.points = points;
            this.addition = addition;
            this.subtraction = subtraction;
            this.division = division;

            if(input == "gameover")
            {
                Console.WriteLine(string.Format("Too bad {0} that it didnt go the whole way this time, make sure to practice",fname));
                Console.WriteLine("");
                Console.WriteLine("You got reached the following:");
                Console.WriteLine(string.Format("Points: {0}", points));
                Console.WriteLine(string.Format("Addition level: {0}",addition));
                Console.WriteLine(string.Format("Subtraction level: {0}", subtraction));
                Console.WriteLine(string.Format("Division level: {0}", division));
            }
            else
            {
                Console.WriteLine("too bad you want to end the game, come back for your daily practice");
            }
        }
    }
}
