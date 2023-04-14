namespace Prog_120_S23_L4_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Literal
            // New Line Character \n

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
            Console.WriteLine($"{greetings}, {audiance}\n\nMy name is {firstName}{lastName}");
  

        }
    }
}