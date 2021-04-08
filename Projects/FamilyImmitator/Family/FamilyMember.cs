using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyLib
{
    public abstract class FamilyMember : IPerson
    {
        protected string name;
        public string Name 
        {
            get { return name; }
        }

        protected short age;
        public short Age
        {
            get { return age; }
        }

        protected Family family;

        public string Role { get; set; }

        public FamilyMember(string name, short age, string role, Family family)
        {
            this.name = name;
            this.age = age;
            Role = role;
            this.family = family;
        }

        public abstract void DoResponsibilities();
        public abstract void Greeting(string name);
        public abstract void SayingGoodbye(string name);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Role}: {name}, {age} years old.");
        }

    }
}
