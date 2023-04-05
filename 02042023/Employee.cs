using System;
using System.Collections.Generic;
using System.Text;

namespace _02042023
{
    internal class Employee
    {
        private string _name;

        public string Name
        {
            get => this._name;
            set
            {
                if (CheckWord(value))
                    this._name = value;
            }
        }

        private bool CheckWord(string str)
        {
            if (char.IsUpper(str[0]) && !string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsLetter(item))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
