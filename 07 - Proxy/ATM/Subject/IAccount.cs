namespace _07___Proxy.ATM.Subject
{
    interface IAccount
    {
        decimal Balance { get; set; }
        bool ChargeAccount(decimal amount);
    }
}
