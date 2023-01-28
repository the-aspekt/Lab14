using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal abstract class Anymal
    {
        public abstract string Name { get; set; }
        public Anymal(string name)
        {
           Name = name;
        }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    internal class Cat : Anymal
    {
        private string name;
        public override string Name 
        {
            get => name;
            set => name = value;
        }

        public Cat(string name)
            :base(name)
        {

        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    internal class Dog : Anymal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
    : base(name)
        {

        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }

}

