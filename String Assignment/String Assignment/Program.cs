using System; // Import the System namespace to access basic functionality
using System.Text; // Import the System.Text namespace to use StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Concatenate three strings
            string str1 = "Hello"; // First string
            string str2 = "world"; // Second string
            string str3 = "!"; // Third string

            // Concatenating the three strings using the + operator
            string concatenatedString = str1 + " " + str2 + str3;
            Console.WriteLine("Concatenated String: " + concatenatedString); // Output the concatenated string

            // Step 2: Convert a string to uppercase
            string upperCaseString = concatenatedString.ToUpper(); // Convert the concatenated string to uppercase
            Console.WriteLine("Uppercase String: " + upperCaseString); // Output the uppercase string

            // Step 3: Create a StringBuilder and build a paragraph of text
            StringBuilder paragraphBuilder = new StringBuilder(); // Instantiate a new StringBuilder

            // Append sentences to the StringBuilder
            paragraphBuilder.AppendLine("This is the first sentence."); // Add first sentence
            paragraphBuilder.AppendLine("Here is the second sentence."); // Add second sentence
            paragraphBuilder.AppendLine("Finally, this is the third sentence."); // Add third sentence

            // Output the entire paragraph built by the StringBuilder
            Console.WriteLine("Built Paragraph: ");
            Console.WriteLine(paragraphBuilder.ToString()); // Convert StringBuilder to string and output

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}

