using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Howdy Y'all!!");
                Console.ReadKey();
            }
            else if (args[0] == "french" || args[0] == "French")
            {
                Console.WriteLine("Bonjour!!");
                Console.ReadKey();
            }
            else if (args[0] == "spanish" || args[0] == "Spanish")
            {
                Console.WriteLine("Hola!!");
                Console.ReadKey();
            }
            else if (args[0] == "japanese" || args[0] == "Japanese")
            {
                Console.WriteLine("Konnichiwa!!");
                Console.ReadKey();
            }
            else if (args[0] == "german" || args[0] == "German")
            {
                Console.WriteLine("Guten Tag!!");
                Console.ReadKey();
            }
            else if (args[0] == "arabic" || args[0] == "Arabic")
            {
                Console.WriteLine("Asalaam alaikum!!");
                Console.ReadKey();
            }
            else if (args[0] == "hebrew" || args[0] == "Hebrew")
            {
                Console.WriteLine("Shalom!!");
                Console.ReadKey();
            }
            else if (args[0] == "chinese" || args[0] == "Chinese")
            {
                Console.WriteLine("Nǐ hǎo!!");
                Console.ReadKey();
            }
            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();
            Console.WriteLine($"Welcome to this feature rich application {name}! What is your favorite color?" );
            var color = Console.ReadLine();
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat", "Dog" };

            Random random = new System.Random();

            var randomNum = random.Next(animals.Length);

            Console.WriteLine($"So {name}, How would you like a {color} {animals[randomNum]}?");

            var response = Console.ReadLine();

            Console.WriteLine($"Seriously.... I offer you a {color} {animals[randomNum]} and all you have to say is {response}??? RUDE! Why don't you just go ahead and press enter to close this window and never open this application again you sick fuck!");
            Console.ReadLine();

            foreach (var animal in animals)
            {
                var sylCount = 0;
                foreach (var currentChar in animal)
                {
                    if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' || currentChar == 'y') 
                    {
                        sylCount++;
                    }
                }
                if (sylCount >= 2)
                {
                    Console.WriteLine(animal);
                }
                
            }
        }
    }
}
