using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Dog:Animal
    {
        string name;

        public Dog(string name,string say)
            : base(name)
        {
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}
