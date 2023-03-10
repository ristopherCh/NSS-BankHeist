namespace BankHeist
{
  class Hacker : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.AlarmScore -= this.SkillLevel;
      System.Console.WriteLine($"{Name} is is hacking the alarm. Decreased alarm score by {SkillLevel} points");
      if (bank.AlarmScore <= 0)
      {
        System.Console.WriteLine($"{Name} has hacked the security!");
      }
    }
  }
}