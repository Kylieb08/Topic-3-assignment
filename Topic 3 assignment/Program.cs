namespace Topic_3_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie Banman


            //Variables
            string courseName, name, placeOfResidence, dinner;
            double fakeRent, realRent;
            int room, rats, roomates;

            //Assigning values
            courseName = "Computer Science";
            fakeRent = 2.99;
            realRent = 4000;
            room = 29;
            name = "Billyert";
            placeOfResidence = "New York";
            rats = 2;
            roomates = 3;
            dinner = "pizza";

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
        }
    }
}