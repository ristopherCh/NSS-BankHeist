namespace BankHeist
{
  class Hacker : IRobber
  {
    string Name { get; set; }
    public int SkillLevel { get; set; }
    public void PerformSkill(Bank bank)
    {
      bank.SkillLevel -= this.SkillLevel;
    }
  }
}