using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка", "Мяу");
            cat.ShowInfo();
            Dog dog = new Dog("Собака", "Гав");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
