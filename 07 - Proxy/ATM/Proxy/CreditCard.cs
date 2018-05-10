using _07___Proxy.ATM.RealSubject;
using _07___Proxy.ATM.Subject;

namespace _07___Proxy.ATM.Proxy
{
    /// Proxy class for Account handles Credit transactions.
    ///

    class CreditCard : IAccount
    {
        private readonly Account _account;
        public decimal Balance { get; set; }

        ///

        /// Instantiate CreditCard proxy class while also creating new Account instance.
        ///

        public CreditCard()
        {
            _account = new Account();
        }

        /// Instantiate CreditCard proxy class with passed Account instance.
        ///Underlying Account instance to use. 
        public CreditCard(Account account)
        {
            _account = account;
        }

        ///

        /// Charge passed amount to underlying account.
        ///

        ///Amount of charge. /// Success or failure of charge.
        public bool ChargeAccount(decimal amount)
        {
            // Modify balance.
            _account.Balance -= amount;
            // Charge was successful.
            return true;
        }
    }
}
