using System;

namespace ProjetoPontoNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} ! How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What is your genre?");
            var genre = Console.ReadLine();
            var sex = "man";
            if (genre == "F")
            {
                sex = "woman";
            }
            Console.WriteLine($"{Environment.NewLine} Hello {name}! You are a {sex} and you are {age} years old");
            
        }
    }
}
