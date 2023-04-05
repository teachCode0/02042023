using System;
using System.Collections.Generic;
using System.Text;

namespace _02042023
{
    internal abstract class Animal
    {
        public string Name;
        public abstract int Age { get; set; }

        public abstract void MakeSound();

        public abstract string GetInfo();
    }
}
