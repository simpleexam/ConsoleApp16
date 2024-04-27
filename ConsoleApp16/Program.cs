namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persn = new Person("Петров РП", 
                new DateOnly(2000, 12, 05));

            Student stud = new Student("Иванов РР",
                new DateOnly(2005, 05, 14),
                "1pk1");
            //Subject na = new Subject("История",200,);

            persn.PrintInfo();

            stud.PrintInfo();
        }
    }
}