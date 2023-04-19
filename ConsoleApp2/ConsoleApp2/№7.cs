using System;
// Task 7
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дайте слово(Находит самое длинное слово и ставит его в начало):");

            string g = Console.ReadLine();
            string[] words7 = g.Split(' ');
            string longestWord = "";

            foreach (string word in words7)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            g = longestWord + " " + g.Replace(longestWord, "");

            Console.WriteLine("Обновленная строка: " + g);

        }
    }
}