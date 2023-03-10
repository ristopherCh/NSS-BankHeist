namespace BankHeist
{
  class LockSpecialist : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public string StateSpecialty()
    {
      return this.GetType().Name;
    }
    public void PerformSkill(Bank bank)
    {
      bank.VaultScore -= this.SkillLevel;
      System.Console.WriteLine($"{Name} is picking the lock. Decreased Vault Score {SkillLevel} points");
      if (bank.VaultScore <= 0)
      {
        System.Console.WriteLine($"{Name} has successfully picked the lock!");
      }
    }
  }
}