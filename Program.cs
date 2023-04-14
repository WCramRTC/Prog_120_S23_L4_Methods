using System.Globalization;

namespace Prog_120_S23_L4_Methods
{
    internal class Program
    {
        static string FirstName = "Will";

        static void Main(string[] args)
        { // Start of Main code
            //string MyFullName = CreateFullName("Will", "Cram");
            //Console.WriteLine(MyFullName);
            Example2();

        } // Main

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }


        // public static RETURN TYPE
        public static string CreateFullName(string firstName, string lastName)
        {
            // IMPORTANT KEYWORD - REUTRN
            return $"{firstName} {lastName}";
        }

        // Outside of Main

        // createa  new method--- like this
        // Declaring a method
        public static void DisplayMyName()
        {
            Console.WriteLine("William Cram");
            Console.WriteLine("Greetings Everyone");
        } // DisplayMyName

        // New method that takes Parameters
        public static void DisplayAName(string firstName, string lastName)
        {

            //string fullName = $"{firstName} {lastName}";
            string fullName = CreateFullName(firstName, lastName);
            Console.WriteLine(fullName);
            Console.WriteLine("Greetings Everyone");
            
            Console.WriteLine($"Welcome to my class, {firstName}");
        } // DisplayAName

        // Void is a keyword that means nothing is REUTRNING fromt the method
        
        // Creating a method that takes two parameters, and RETURNS a string



        public static void Example2()
        {
            // Nothing will happen if the code is not written or connected to the Main method
            // Call a method. It means run the method.
            //ExampleCode();
            // It's an argument
            DisplayAName("David", "Abarca");
            DisplayAName("Nancy", "Le");
            DisplayAName("Morcire", "Sylla");
            DisplayAName("Benel", "Alcine");
        }

        // Inside of class

        // Create a new method that will hold our example code
        public static void ExampleCode()
        {
            // String Literal
            // New Line Character \n
            Random rand = new Random();
            // CALLING a method
            Console.WriteLine(rand.Next(0, 100).ToString());

            // Concatenation - Adding strings together to make one larger string
            // Console.WriteLine(); - Next line
            string greetings = "Hello";
            string audiance = "Everyone";
            string firstName = "Will";
            string lastName = "Cram";
            // Hello, Everyone!
            // 
            // My Name is William Cram
            //Console.WriteLine(greetings + ", " + audiance);
            //Console.WriteLine();
            //Console.WriteLine("My name is " + firstName + " " + lastName);

            // String Literal
            // String literals use a dollar sign in front of double quotes, then you can place curly braces inside of the quotes, and pass variables.
            // New Line Escape Character
            Console.WriteLine($"{greetings}, {audiance}\n\n" +
                $"My name is {firstName} {lastName}");
            Console.Write($"What is your name? ");
            string youName = Console.ReadLine();

            Console.WriteLine(youName);

        } // ExampleCode

        // What is a method?
        // A method is a BLOCK of code, given a name, that you can call over and over again



    } // class

} // namespace