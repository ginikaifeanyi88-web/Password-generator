using System.Text;
using CrypticWizard.RandomWordGenerator;
using static CrypticWizard.RandomWordGenerator.WordGenerator; 
namespace Password_generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter 'generate' to create passwords");
            Console.WriteLine("Enter 'exit' to stop program");

            while (true) {
                string commandEntered = Console.ReadLine();
                if (commandEntered == "generate")
                {
                    Console.WriteLine("Generating passwords...");
                    string weakPassword = createAWeakPassword();
                    Console.WriteLine("Weak Password: " + weakPassword);
                    string strongPassword = createAStrongPassword();
                    Console.WriteLine("Strong Password: " + strongPassword);
                    Console.WriteLine("Enter 'generate' to create passwords");
                    Console.WriteLine("Enter 'exit' to stop program");

                } else if (commandEntered == "exit")
                {
                    break;
                } else
                {
                    Console.WriteLine("Enter 'generate' to create passwords");
                    Console.WriteLine("Enter 'exit' to stop program");
                }
            }
            

        }

        // function to create a weak password
        private static string createAWeakPassword()
        {
            StringBuilder sb;
            string passwordString = "";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                passwordString += (char)rnd.Next('a', 'a' + 26);
            }
            sb = new StringBuilder(passwordString);
            int addARandomCharacter = rnd.Next(0, 2);
            if (addARandomCharacter == 1)
            {
                // inserts an underscore at a random position of the string
                sb[rnd.Next(0, sb.Length)] = (char)rnd.Next(95, 95);
            }
            else
            {
               
            }
            passwordString = sb.ToString();
            return passwordString;
        }

        // Function to create a strong password
        private static string createAStrongPassword()
        {
            WordGenerator myWordGenerator = new WordGenerator();
            Random rnd = new Random();
            StringBuilder sb;
            string strongPasswordFirstWord = "";
            string strongPasswordSecondWord = "";
            string strongPasswordThirdWord = "";
            string strongPasswordFourthWord = "";
            while (strongPasswordFirstWord.Length != 8)
            {
                strongPasswordFirstWord = myWordGenerator.GetWord();
            }
            while (strongPasswordSecondWord.Length != 10)
            {
                strongPasswordSecondWord = myWordGenerator.GetWord();
            }
            while (strongPasswordThirdWord.Length != 7)
            {
                strongPasswordThirdWord = myWordGenerator.GetWord();
            }
            while (strongPasswordFourthWord.Length != 7)
            {
                strongPasswordFourthWord = myWordGenerator.GetWord();
            }
            string passwordString = strongPasswordFirstWord + strongPasswordSecondWord + strongPasswordThirdWord + strongPasswordFourthWord;
            sb = new StringBuilder(passwordString);
            int addARandomCharacter = rnd.Next(0, 2);
            if (addARandomCharacter == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    sb[rnd.Next(0, sb.Length)] = (char)rnd.Next(95, 95);
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    sb[rnd.Next(0, sb.Length)] = (char)rnd.Next(95, 95);
                }
            }
            passwordString = sb.ToString();
            return passwordString;
        }
    }
}
