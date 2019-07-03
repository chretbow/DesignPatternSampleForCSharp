﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件操作");
        }
    }
}
