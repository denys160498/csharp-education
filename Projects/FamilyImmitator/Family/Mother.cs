using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyLib
{
    public class Mother : FamilyMember
    {
        string[] resonsibilities = { "Washing", "Cooking", "Cleaning" };

        public Mother(string name, short age, Family family) : base(name, age, "Mother", family)
        {
           
        }
        
        public override void DoResponsibilities()
        {
            Console.WriteLine("Mother doing: ");
            for (int i = 0; i < resonsibilities.Length; i++)
            {
                Console.WriteLine($"\t{resonsibilities[i]}");
            }
        }

        public override void Greeting(string name)
        {
            Console.WriteLine($"Hi, I'm mom {name}");
        }

        public override void SayingGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, I was glad to be part of you, mom {name}");
        }
    }
}
