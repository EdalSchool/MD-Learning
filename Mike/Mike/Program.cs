using System;

namespace Mike
{
    public class Program
    {
        static void Main(string[] args)
        {
            string question;
            string trys;

            var random = new Random();

            var list = new List<string> { "one", "two", "three", "four" };
            int index = random.Next(list.Count);

            Console.WriteLine(list[index]);

            Console.WriteLine("Hi, I am Adam. How can I help you?");
            //Console.WriteLine("Try " + $"sentence{}");
            Console.WriteLine(list[index]);

            question = Console.ReadLine();

            if (question.Contains($"your name"))
            {
                Console.WriteLine("My name its Adam, I am here to help you with anything I can O‿O");
            }

            if (question.Contains("hello")) 
            {
                Console.WriteLine("Hello, how are you?");
            }
        }
    }
}