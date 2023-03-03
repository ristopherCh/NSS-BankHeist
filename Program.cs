using System;
using System.Collections.Generic;

namespace BankHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan your heist!");
      Dictionary<string, TeamMember> TheSquad = new();
      while (true)
      {
        TeamMember TeamMember = new();
        System.Console.WriteLine("What's your team member's name?");
        string givenName = Console.ReadLine();
        TeamMember.Name = givenName;
        if (givenName == "")
        {
          break;
        }
        System.Console.WriteLine("What's your team member's skill level? Must be a positive integer less than or equal to 10.");
        string MemberSkillLevel = Console.ReadLine();
        int MemberSkillInt = int.Parse(MemberSkillLevel);
        while (MemberSkillInt < 0 || MemberSkillInt > 10)
        {
          System.Console.WriteLine("Invalid input, please try again.");
          MemberSkillLevel = Console.ReadLine();
          MemberSkillInt = int.Parse(MemberSkillLevel);
        }
        TeamMember.SkillLevel = MemberSkillInt;
        System.Console.WriteLine("What's your team leader's courage factor? Must be a decimal between 0.0 and 2.0");
        string MemberCourageFactor = Console.ReadLine();
        float MemberCourageFloat = float.Parse(MemberCourageFactor);
        while (MemberCourageFloat < 0.0 || MemberCourageFloat > 2.0)
        {
          System.Console.WriteLine("Invalid input, please try again");
          MemberCourageFactor = Console.ReadLine();
          MemberCourageFloat = float.Parse(MemberCourageFactor);
        }
        TeamMember.CourageFactor = MemberCourageFloat;
        TheSquad.Add(givenName, TeamMember);
        System.Console.WriteLine($"Your esteemed team leader, {TeamMember.Name}, has a skill level of {TeamMember.SkillLevel} and a courage factor of {TeamMember.CourageFactor}");
        foreach (KeyValuePair<string,TeamMember> member in TheSquad)
        {
            System.Console.WriteLine(member.Key);
        }
      }
    }
  }
}
