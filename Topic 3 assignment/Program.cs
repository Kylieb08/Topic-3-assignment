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
            name = "Kylie";
            placeOfResidence = "New York";
            rats = 2;
            roomates = 3;
            dinner = "pizza";

            Console.WriteLine("Hello, my name is " + name + ".");
            Console.WriteLine("I live in " + placeOfResidence + ".");
            Console.WriteLine("I have " + roomates + ", " + rats + " of them are rats.");
            Console.WriteLine("We eat " + dinner + " for dinner every night.");
            Console.WriteLine("Da rent? " + fakeRent + " a month.");
            Console.WriteLine("No, I lied, it's actually " + realRent + ". A second");
            
        }
    }
}