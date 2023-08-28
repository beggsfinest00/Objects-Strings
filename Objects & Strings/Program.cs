namespace Objects___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //makes a object with the name myComputer
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));
            //make an object with the name myOtherComputer
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));
            //make a string and gives it the vaule of myComputer.Tostring, sets a myOtherString equal to myString
            string myString = myComputer.ToString();
            string myOtherString = myString;

            //sets myString = to Hi
            myString = "Hi!";
            //writes (myString) & (myOtherString) to the console
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            //writes (myString == myComputer.ToString) & (myString == myOtherComputer.ToString) to the console
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());
            //writes (myComputer.GetType()) & (myComputer.GetType()) to the console
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myComputer.GetType());
            
            myOtherComputer.PowerOnOff();
            
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i'));

            Console.WriteLine(myString.ToUpper());
        }
    }
}