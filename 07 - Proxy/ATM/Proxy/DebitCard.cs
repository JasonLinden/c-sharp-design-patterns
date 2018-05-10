using _07___Proxy.ATM.RealSubject;
using _07___Proxy.ATM.Subject;

namespace _07___Proxy.ATM.Proxy
{
    class DebitCard : IAccount
    {
        private readonly Account _account;
        public decimal Balance { get; set; }

        ///

        /// Instantiate DebitCard proxy class while also creating new Account instance.
        ///

        public DebitCard()
        {
            _account = new Account();
        }

        /// Instantiate DebitCard proxy class with passed Account instance.
        ///Underlying Account instance to use. 
        public DebitCard(Account account)
        {
            _account = account;
        }

        /// Charge passed amount to underlying account.
        ///

        ///Amount of charge. /// Success or failure of charge.
        public bool ChargeAccount(decimal amount)
        {
            // Check if balance meets or exceeds charge amount.
            if (_account.Balance >= amount)
            {
                // Log successful charge message.
                // Modify balance.
                _account.Balance -= amount;
                // Charge was successful.
                return true;
            }

            // Log that charge failed due to insufficient funds.
            // Charge failed.
            return false;
        }
    }
}
