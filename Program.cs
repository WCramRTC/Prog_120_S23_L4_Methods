namespace Prog_120_S23_L4_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        { // Start of Main code
          // Nothing will happen if the code is not written or connected to the Main method
          // Call a method. It means run the method.
            //ExampleCode();

        } // Main

        // Outside of Main

        // createa  new method--- like this
        // Declaring a method
        public static void DisplayMyName()
        {

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