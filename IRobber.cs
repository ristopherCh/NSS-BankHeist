namespace BankHeist
{
  interface IRobber
  {
    string Name { get; set; }
    int SkillLevel { get; set; }
    void PerformSkill(Bank bank);
  }
}