using System;
using System.Collections.Generic;
using System.Text;

namespace _02042023
{
    internal class Cat : Animal
    {
        private int _age;

        public override int Age
        {
            get => this._age;
            set
            {
                if(value<30)
                    this._age = value;  
            }
        }

        public override string GetInfo()
        {
            return $"Name : {Name} - Age : {Age}";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miaw miaw");
        }
    }
}
