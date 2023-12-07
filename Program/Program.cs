using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new RubberDuck());
            ducks.Add(new WildDuck());
            ducks.Add(new IronDuck());
            ducks.Add(new RobotDuck());
            foreach (var duck in ducks)
            {
                duck.Fly();
                duck.Quack();
                duck.Swim();
                Console.WriteLine();
            }
        }
    }
}
