using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Person
    {
        public DateOnly Birthday { get; set; }
        public string Name { get; set; }
        public Person(string text, DateOnly birth) 
        {
            Name = text;
            Birthday = birth;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"имя человека: {Name}\n" +
                $"дата рождения: {Birthday}");
        }
    }
}
