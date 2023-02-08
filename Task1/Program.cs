using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
                Animal cat = new Cat("Мурка", "Мяу");
                cat.ShowInfo();
                Console.WriteLine();
                Animal dog = new Dog("Барбос", "Гав");
                dog.ShowInfo();
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}
