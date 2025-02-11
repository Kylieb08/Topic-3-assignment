using System.Runtime.CompilerServices;

namespace Topic_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie Banman


            //Variables

            //Part one
            string courseName, name, placeOfResidence, dinner;
            double fakeRent, realRent;
            int room, rats, roomates;
            
            //Part two
            string firstName, lastName;
            int year;

            //Part three
            double radius, exponent;
            decimal area;
            decimal roundedArea;

            //Assigning values

            //Part one
            courseName = "Computer Science";
            fakeRent = 2.99;
            realRent = 4000;
            room = 29;
            name = "Billyert";
            placeOfResidence = "New York";
            rats = 2;
            roomates = 3;
            dinner = "pizza";

            //Part two
            firstName = "Kylie";
            lastName = "Banman";
            year = 2026;

            //Part three
            radius = 5.2;
            exponent = 2;
            area = (decimal)(Math.PI * Math.Pow(radius, exponent));
            roundedArea = Decimal.Round(area, 1);

            //Part one
            Console.WriteLine("This is part one of the assignment. It is best read in a New York accent");
            Console.WriteLine("");
            Console.WriteLine("Hello, my name is " + name + ".");
            Console.WriteLine("I live in " + placeOfResidence + ".");
            Console.WriteLine("I have " + roomates + " roomates, " + rats + " of them are rats.");
            Console.WriteLine("We eat " + dinner + " for dinner every night.");
            Console.WriteLine("Da rent? " + fakeRent + " a month.");
            Console.WriteLine("No, I lied, it's actually " + realRent + " dollars. A second");
            Console.WriteLine("Ya know I'm considering getting into a " + courseName + " course to learn programming");
            Console.WriteLine("Maybe if I can get a career in that rent will be affordable.");
            Console.WriteLine("");

            //Part two
            Console.WriteLine("This is part two of the assignment");
            Console.WriteLine(" ");
            Console.WriteLine("My name is " + firstName + " " + lastName + " and I'll graduate in " + year + ".");
            Console.WriteLine(" ");

            //Part three
            Console.WriteLine("This is part three of the assignment");
            Console.WriteLine(" ");
            Console.WriteLine(roundedArea);
            Console.ReadLine();

            //Part four
            Console.WriteLine("This is part four of the assignment");
            Console.WriteLine(" ");
            Console.WriteLine();
        }
    }
}