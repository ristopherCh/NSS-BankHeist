using System;
using System.Collections.Generic;

namespace BankHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Muscle muscleyTerry = new Muscle();
      muscleyTerry.Name = "muscleyTerry";
      Muscle muscleyPatrick = new Muscle();
      muscleyPatrick.Name = "muscleyPatrick";
      Hacker hackerRoger = new Hacker();
      hackerRoger.Name = "hackerRoger";
      Hacker hackerPete = new Hacker();
      hackerPete.Name = "hackerPete";
      LockSpecialist lockerWill = new LockSpecialist();
      lockerWill.Name = "lockerWill";
      LockSpecialist lockerAna = new LockSpecialist();

      
      List<IRobber> rolodex = new()
      {
        muscleyTerry, 
        muscleyPatrick, 
        hackerPete, 
        hackerRoger, 
        lockerWill, 
        lockerAna
      };

      Console.WriteLine("Plan your heist!");
      Dictionary<string, TeamMember> TheSquad = new();
      
      
      
      
      
      // while (true)
      // {
      //   TeamMember TeamMember = new();
      //   System.Console.WriteLine("What's your team member's name?");
      //   string givenName = Console.ReadLine();
      //   TeamMember.Name = givenName;
      //   if (givenName == "")
      //   {
      //     break;
      //   }
      //   System.Console.WriteLine("What's your team member's skill level? Must be a positive integer less than or equal to 25.");
      //   string MemberSkillLevel = Console.ReadLine();
      //   int MemberSkillInt = int.Parse(MemberSkillLevel);
      //   while (MemberSkillInt < 0 || MemberSkillInt > 25)
      //   {
      //     System.Console.WriteLine("Invalid input, please try again.");
      //     MemberSkillLevel = Console.ReadLine();
      //     MemberSkillInt = int.Parse(MemberSkillLevel);
      //   }
      //   TeamMember.SkillLevel = MemberSkillInt;
      //   System.Console.WriteLine("What's your team leader's courage factor? Must be a decimal between 0.0 and 2.0");
      //   string MemberCourageFactor = Console.ReadLine();
      //   float MemberCourageFloat = float.Parse(MemberCourageFactor);
      //   while (MemberCourageFloat < 0.0 || MemberCourageFloat > 2.0)
      //   {
      //     System.Console.WriteLine("Invalid input, please try again");
      //     MemberCourageFactor = Console.ReadLine();
      //     MemberCourageFloat = float.Parse(MemberCourageFactor);
      //   }
      //   TeamMember.CourageFactor = MemberCourageFloat;
      //   TheSquad.Add(givenName, TeamMember);
      //   // System.Console.WriteLine($"Your esteemed team leader, {TeamMember.Name}, has a skill level of {TeamMember.SkillLevel} and a courage factor of {TeamMember.CourageFactor}");
      // }
      // System.Console.WriteLine("How many times would you like to attempt to rob this bank?");
      // string trialRuns = Console.ReadLine();
      // int trialRunsInt = int.Parse(trialRuns);
      // System.Console.WriteLine("How difficult is this bank?");
      // string bankDifficultyString = Console.ReadLine();


      // int teamSkillLevel = 0;
      // foreach (KeyValuePair<string, TeamMember> member in TheSquad)
      // {
      //   teamSkillLevel += member.Value.SkillLevel;
      // }
      // int successfulRobberies = 0;
      // for (int i = 0; i < trialRunsInt; i++)
      // {
      //   int bankDifficulty = int.Parse(bankDifficultyString);

      //   Random r = new Random();
      //   int luckValue = r.Next(-10, 11);
      //   bankDifficulty += luckValue;

      //   System.Console.WriteLine($"Your team skill level is {teamSkillLevel}. The bank's difficulty level is {bankDifficulty}\n");

      //   if (teamSkillLevel >= bankDifficulty)
      //   {
      //     System.Console.WriteLine("You robbed the crap out of that bank");
      //     System.Console.WriteLine();
      //     successfulRobberies++;
      //   }
      //   else
      //   {
      //     System.Console.WriteLine("Wow you got caught immediately, not great");
      //     System.Console.WriteLine();
      //   }
      // }
      // System.Console.WriteLine($"You successfully robbed the bank {successfulRobberies} out of {trialRunsInt} attempts");
      // System.Console.WriteLine();



    }
  }
}
