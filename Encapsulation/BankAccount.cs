public class BankAccount
{
  private decimal _balance;
  public decimal balance { get { return _balance; } }
  public void Deposit(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Amount must be positive");
    }
    _balance += amount;
  }
  public bool Withdraw(decimal amount)
  {
    if (_balance > 0) { return true; }
    return false;
  }
}