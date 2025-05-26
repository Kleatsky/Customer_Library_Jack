using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackConsole
{
    internal class PartN
    {
    }
    internal class Part : IPart
    {
        public ImmutableList<string> Poem { get; set; }
        public string[] paragraph = [];

        public Part()
        {
            Poem = ImmutableList<string>.Empty;
        }

        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.AddRange(paragraph);
            Poem = newList;
        }
        public void Show()
        {
            Console.WriteLine();
            foreach (var part in Poem)
            {
                Console.WriteLine(part);
            }
        }
    }
    internal class Part1 : Part
    {
        public string[] paragraph = ["Вот дом,", "Который построил Джек."];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.AddRange(paragraph);
            Poem = newList;
        }
    }
    internal class Part2 : Part
    {
        public string[] paragraph = ["А это пшеница,", "Которая в темном чулане хранится"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part3 : Part
    {
        public string[] paragraph = ["А это веселая птица-синица,", "Которая часто ворует пшеницу,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part4 : Part
    {
        public string[] paragraph = ["Вот кот,", "Который пугает и ловит синицу,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part5 : Part
    {
        public string[] paragraph = ["Вот пес без хвоста,", "Который за шиворот треплет кота,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part6 : Part
    {
        public string[] paragraph = ["А это корова безрогая,", "Лягнувшая старого пса без хвоста,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part7 : Part
    {
        public string[] paragraph = ["А это старушка, седая и строгая,", "Которая доит корову безрогую,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part8 : Part
    {
        public string[] paragraph = ["А это ленивый и толстый пастух,", "Который бранится с коровницей строгою,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }
    internal class Part9 : Part
    {
        public string[] paragraph = ["Вот два петуха,", "Которые будят того пастуха,"];
        public void AddPart(ImmutableList<string> list)
        {
            var newList = list.InsertRange(0, paragraph);
            var newNewList = newList.RemoveAt(2);
            Poem = newNewList;
        }
    }

}
