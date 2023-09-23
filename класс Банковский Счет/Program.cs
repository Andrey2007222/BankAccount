enum AccountType { Current, Savings }
class Bank
{
    public Bank(string accountNumber, decimal balans, AccountType type)
    {
        AccountNumber = accountNumber;
        Balans = balans;
        Type = type;
    }
    public string AccountNumber { get; set; }
    public decimal Balans { get; set; }
    public AccountType Type { get; set; }
    public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balans}, Type - {Type}";

}
class Program
{
    static void Main()
    {
        AccountType accountType = AccountType.Current;
        Console.WriteLine(accountType);
        Bank bank = new Bank("123EF4D", 120_000, AccountType.Savings);
        Console.WriteLine(bank);
    }
}