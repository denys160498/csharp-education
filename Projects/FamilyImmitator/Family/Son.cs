using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyLib
{
    public class Son : FamilyMember
    {
        public bool IsAdult 
        { get{ return age > 18; } }

        public Son(string name, short age, Family family) : base(name, age, "Son", family)
        {
            
        }

        public override void DoResponsibilities()
        {
            if (IsAdult)
            {
                Console.WriteLine("Son is working");
            }
            else
            {
                Console.WriteLine("Son is studing");
            }
        }

        public override void Greeting(string name)
        {
            Console.WriteLine($"I`m new son {name}");
        }

        public override void SayingGoodbye(string name)
        {
            Console.WriteLine($"Farewell!");
        }
    }
}
