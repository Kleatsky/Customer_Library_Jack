using System.Collections.Immutable;

namespace JackConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImmutableList<string> poem = ImmutableList<string>.Empty;

            
            var part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var part4 = new Part4();
            var part5 = new Part5();
            var part6 = new Part6();
            var part7 = new Part7();
            var part8 = new Part8();
            var part9 = new Part9();
            Part[] parts = { part1 , part2, part3, part4, part5, part6, part7, part8, part9 };




            parts[0].Poem = ["Вот дом,", "который построил Джек."];
            ((Part2)parts[1]).AddPart(((Part1)parts[0]).Poem);
            ((Part3)parts[2]).AddPart(((Part2)parts[1]).Poem);
            ((Part4)parts[3]).AddPart(((Part3)parts[2]).Poem);
            ((Part5)parts[4]).AddPart(((Part4)parts[3]).Poem);
            ((Part6)parts[5]).AddPart(((Part5)parts[4]).Poem);
            ((Part7)parts[6]).AddPart(((Part6)parts[5]).Poem);
            ((Part8)parts[7]).AddPart(((Part7)parts[6]).Poem);
            ((Part9)parts[8]).AddPart(((Part8)parts[7]).Poem);

            
            foreach (var part in parts)
            {
                part.Show();
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
