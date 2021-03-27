using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyLib
{
    public delegate void MemberOperation (string name);

    public sealed class Family
    {
        private List<FamilyMember> familyMembers;
        public List<FamilyMember> FamilyMembers { get { return familyMembers; } }

        public int MembersCount 
         { get { return familyMembers.Count; } }


        public Family()
        {
            familyMembers = new List<FamilyMember>();
        }

        public Family(List<FamilyMember> newFamily)
        {
            familyMembers = newFamily;
        }

        public IEnumerator<FamilyMember> GetEnumerator()
        {
            return familyMembers.GetEnumerator();
        }

        public void AddMember(FamilyMember newMember, MemberOperation Greeting)
        {
            familyMembers.Add(newMember);
            Greeting?.Invoke(newMember.Name);
        }

        public void RemoveMember(FamilyMember memberToRemove, MemberOperation SayingGoodBye)
        {
            familyMembers.Remove(memberToRemove);
            SayingGoodBye?.Invoke(memberToRemove.Name);
        }

        public void DisplayFamilyInfo()
        {
            string memAmout = MembersCount == 1 ? "member" : "members";
            Console.WriteLine($"The family consist of {MembersCount} {memAmout}");

            foreach (FamilyMember member in this)
            {
                member.DisplayInfo();
            }
        }
    }
}
