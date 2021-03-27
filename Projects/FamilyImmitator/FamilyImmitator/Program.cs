using System;
using FamilyLib;

namespace FamilyImmitator
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            Father father = new Father("Nick", 40);
            Father fatherTwo = new Father("Dick", 44);

            family.AddMember(father, father.Greeting);
            family.AddMember(fatherTwo, fatherTwo.Greeting);

            family.DisplayFamilyInfo();
        }
    }
}
