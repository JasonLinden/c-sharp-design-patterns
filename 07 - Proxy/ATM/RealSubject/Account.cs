using _07___Proxy.ATM.Subject;

namespace _07___Proxy.ATM.RealSubject
{
    /// RealSubject class that handles account management.
    ///
    class Account : IAccount
    {
        // Set default balance to $1000.
        private decimal _balance = 1000;

        public decimal Balance
        {
            get => _balance;
            set
            {
                // Log output when balance is changed.
                if (value == _balance) return;
                _balance = value;
            }
        }

        ///Amount to charge. /// Success or failure of charge.
        public bool ChargeAccount(decimal amount)
        {
            // Check if balance meets or exceeds charge amount.
            if (Balance >= amount)
            {
                // Modify balance.
                Balance -= amount;
                // Charge was successful.
                return true;
            }

            // Charge failed.
            return false;
        }
    }
}
