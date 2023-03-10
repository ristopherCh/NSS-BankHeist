namespace BankHeist
{
  interface IRobber
  {
    string Name { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }

    string StateSpecialty();

    void PerformSkill(Bank bank);
  }
}