using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck() 
            : base(new Fly(), new Quack(), new Swim())
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
