namespace BankHeist
{
  class Bank
  {
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }
    public bool IsSecure
    {
      get
      {
        return !(AlarmScore < 0 && VaultScore < 0 && SecurityGuardScore < 0);
      }
    }
  }
}