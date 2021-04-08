using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyLib
{
    public class Father : FamilyMember
    {
        private bool hasWork = true;

        public Father(string name, short age, Family family) : base (name, age, "Father", family)
        {
        }

        public void Work()
        {
            if (hasWork)
            {
                Console.WriteLine("Father is working");
            }
            else
            {
                Console.WriteLine("Father doesn`t have work!");
            }
        }

        public override void DoResponsibilities()
        {
            Work();
        }

        public override void Greeting(string name)
        {
            Console.WriteLine($"Hi, I`m your new father {name}.");
        }

        public override void SayingGoodbye(string name)
        {
            Console.WriteLine($"It`s so pity, but we should say goodbye! (father {name}) ");
        }
    }
}
