using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Subject
    {
        string Name { set; get; }
        int Hours { set; get; }
        string ExamType { set; get; }
        public void SubjectInfo()
        {
            Console.WriteLine($"Название предмета:{Name}\n" +
                $"Количество часов:{Hours}\n" +
                $"Тип итоговой аттестации:{ExamType}");
        }

    }
}
