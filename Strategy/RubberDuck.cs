using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new NoFly(), new Quack(), new Swim())
        { }

        public override void Quack()
        {
            _quack.Execute();
        }
        public override void Fly()
        {
            _fly.Execute();
        }
        public override void Swim()
        {
            _swim.Execute();
        }
    }
}
