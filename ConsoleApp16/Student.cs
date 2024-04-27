using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Student : Person
    {
        public string Group { get; set; }
        public Student(string text, DateOnly birthday, string group) 
            : base(text, birthday)
        {
            Group=group;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"группа: {Group}");
        }
    }
}
