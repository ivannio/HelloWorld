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
            
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat", "Dog" };

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
