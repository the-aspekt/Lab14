using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурена");
            Dog dog = new Dog("Шарик");
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
