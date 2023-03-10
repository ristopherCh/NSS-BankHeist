using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace BankHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      int val = 5;
      Muscle muscleyTerry = new Muscle();
      muscleyTerry.Name = "muscleyTerry";
      muscleyTerry.SkillLevel = 15*val;
      muscleyTerry.PercentageCut = 15;

      Muscle muscleyPatrick = new Muscle();
      muscleyPatrick.Name = "muscleyPatrick";
      muscleyPatrick.SkillLevel = 15*val;
      muscleyPatrick.PercentageCut = 15;

      Hacker hackerRoger = new Hacker();
      hackerRoger.SkillLevel = 20*val;
      hackerRoger.PercentageCut = 20;
      hackerRoger.Name = "hackerRoger";
      Hacker hackerPete = new Hacker();
      hackerPete.SkillLevel = 25*val;
      hackerPete.PercentageCut = 25;
      hackerPete.Name = "hackerPete";

      LockSpecialist lockerWill = new LockSpecialist();
      lockerWill.SkillLevel = 30*val;
      lockerWill.PercentageCut = 30;
      lockerWill.Name = "lockerWill";

      LockSpecialist lockerAna = new LockSpecialist();
      lockerAna.SkillLevel = 12*val;
      lockerAna.PercentageCut = 12;
      lockerAna.Name = "lockerAna";


      List<IRobber> rolodex = new()
      {
        muscleyTerry,
        muscleyPatrick,
        hackerPete,
        hackerRoger,
        lockerWill,
        lockerAna
      };

      // foreach (IRobber teamMember in rolodex)
      // {
      //   System.Console.WriteLine(teamMember.Name);
      // }

      // while (true)
      // {
      //   System.Console.WriteLine("Give a name to a new team member:");
      //   string newMemberName = Console.ReadLine();
      //   if (newMemberName == "")
      //   {
      //     break;
      //   }
      //   System.Console.WriteLine("What's this new member's cut?");
      //   string newMemberCutString = Console.ReadLine();
      //   int newMemberCut = int.Parse(newMemberCutString);
      //   System.Console.WriteLine("What's the new member's specialty? Choose from: 1) Hacker, 2) Muscle, or 3) LockSpecialist");
      //   string newMemberSpecialty = Console.ReadLine();
      //   System.Console.WriteLine("What's the new member's skill level?");
      //   string newMemberSkillString = Console.ReadLine();
      //   int newMemberSkillLevel = int.Parse(newMemberSkillString);
      //   if (newMemberSpecialty == "1")
      //   {
      //     Hacker newMember = new Hacker();
      //     newMember.Name = newMemberName;
      //     newMember.PercentageCut = newMemberCut;
      //     newMember.SkillLevel = newMemberSkillLevel;
      //     rolodex.Add(newMember);
      //   }
      //   else if (newMemberSpecialty == "2")
      //   {
      //     Muscle newMember = new Muscle();
      //     newMember.Name = newMemberName;
      //     newMember.PercentageCut = newMemberCut;
      //     newMember.SkillLevel = newMemberSkillLevel;
      //     rolodex.Add(newMember);
      //   }
      //   else if (newMemberSpecialty == "3")
      //   {
      //     LockSpecialist newMember = new LockSpecialist();
      //     newMember.Name = newMemberName;
      //     newMember.PercentageCut = newMemberCut;
      //     newMember.SkillLevel = newMemberSkillLevel;
      //     rolodex.Add(newMember);
      //   }
      // }

      System.Console.WriteLine("Let's start a HEIST!");

      Random r = new Random();
      Bank RichBank = new Bank();
      RichBank.CashOnHand = r.Next(50000, 1000000);
      RichBank.AlarmScore = r.Next(100);
      RichBank.VaultScore = r.Next(100);
      RichBank.SecurityGuardScore = r.Next(100);

      Dictionary<string, int> BankScores = new Dictionary<string, int>();

      BankScores.Add("Alarm", RichBank.AlarmScore);
      BankScores.Add("Vault", RichBank.VaultScore);
      BankScores.Add("Security Guards", RichBank.SecurityGuardScore);


      // string keyOfMaxValue = BankScores.Where(x => x.Value == BankScores.Values.Max()).Select(x=>x.Key).First();
      // string keyOfMaxValue = BankScores.OrderByDescending(x => x.Value).First().Key;
      string keyOfMaxValue = BankScores.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
      string keyOfMinValue = BankScores.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

      System.Console.WriteLine($"Recon time! Most secure: {keyOfMaxValue}. Least secure: {keyOfMinValue}");

      List<IRobber> crew = new();
      int totalledTake = 0;
      while (true)
      {
        for (int i = 0; i < rolodex.Count; i++)
        {
          IRobber teamMember = rolodex[i];
          if (totalledTake + teamMember.PercentageCut < 100)
          {
            System.Console.WriteLine($@"
            {i}: {teamMember.Name}: {teamMember.StateSpecialty()}
              Skill level: {teamMember.SkillLevel}
              Percentage cut: {teamMember.PercentageCut}
        ");
          }
        }
        System.Console.WriteLine("Which operative would you like to add to your crew?");
        string crewMemberString = Console.ReadLine();
        if (crewMemberString == "")
        {
          break;
        }
        int crewMember = int.Parse(crewMemberString);
        totalledTake += rolodex[crewMember].PercentageCut;
        crew.Add(rolodex[crewMember]);
        rolodex.RemoveAt(crewMember);
      }

      System.Console.WriteLine("Ok now we're REALLY starting this heist!");

      foreach (IRobber teamMember in crew)
      {
        teamMember.PerformSkill(RichBank);
      }

      if (RichBank.IsSecure)
      {
        System.Console.WriteLine("This bank is secure. You're in prison. What were you thinking.");
      }
      else
      {
        System.Console.WriteLine($@"YOU DID IT! Here's the breakdown:");
        foreach(IRobber teamMember in crew) 
        {
          float perc = (float)teamMember.PercentageCut / 100;
          System.Console.WriteLine($"{teamMember.Name}: ${perc*RichBank.CashOnHand}");
        }
      }











      // Console.WriteLine("Plan your heist!");
      // Dictionary<string, TeamMember> TheSquad = new();





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
      //   {D
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
