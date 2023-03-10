namespace BankHeist
{
  class Muscle : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.SecurityGuardScore -= this.SkillLevel;
      System.Console.WriteLine($"{Name} is is fighting the security guards. Decreased guard score by {SkillLevel} points");
      if (bank.SecurityGuardScore <= 0)
      {
        System.Console.WriteLine($"{Name} has whipped those security guards!");
      }
    }
  }
}