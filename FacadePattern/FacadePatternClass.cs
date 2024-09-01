namespace FacadePattern
{

    //Facade Pattern is a structural design pattern that provides a simplified interface to a complex system of classes,
    //libraries, or frameworks. The purpose of the Facade Pattern is to hide the complexities of the system
    //and provide an easy-to-use interface for the client.

    /// <summary>
    /// The AccountManager class handles operations related to accounts, such as verifying an account number, withdrawing money, and depositing money.
    /// </summary>
    public class AccountManager
    {
        /// <summary>
        /// Verifies the account.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        /// <returns></returns>
        public bool VerifyAccount(string accountNumber)
        {
            Console.WriteLine("Verifying account number");
            return true;
        }

        /// <summary>
        /// Withdraws the money.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        public void WithdrawMoney(string accountNumber)
        {
            Console.WriteLine($"Withdraw amount from account {accountNumber}");

        }

        /// <summary>
        /// Deposits the money.
        /// </summary>
        /// <param name="accountNumber">The account number.</param>
        public void DepositMoney(string accountNumber)
        {
            Console.WriteLine($"Deposited in account number {accountNumber}");
        }
    }

    /// <summary>
    /// The TransactionProcessing class handles the actual transaction process, such as transferring an amount of money between accounts.
    /// </summary>
    public class TransactionProcessing
    {
        /// <summary>
        /// Transfers the amount.
        /// </summary>
        /// <param name="withdrawAccount">The withdraw account.</param>
        /// <param name="creditAccount">The credit account.</param>
        /// <param name="money">The money.</param>
        /// <returns></returns>
        public bool TransferAmount(string withdrawAccount, string creditAccount, double money)
        {
            Console.WriteLine($"Transaction money from {withdrawAccount} to account {creditAccount} and amount {money}");
            return true;
        }
    }

    /// <summary>
    /// The FinancialFacade class provides a simplified interface to the client by combining the operations from the AccountManager and TransactionProcessing classes.
    /// </summary>
    public class FinancialFacade
    {
        /// <summary>
        /// The account manager
        /// </summary>
        private AccountManager accountManager;
        /// <summary>
        /// The TRF
        /// </summary>
        private TransactionProcessing trf;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialFacade"/> class.
        /// </summary>
        public FinancialFacade()
        {
            accountManager = new AccountManager();
            trf = new TransactionProcessing();
        }

        /// <summary>
        /// Transfers the money.
        /// </summary>
        /// <param name="debitAc">The debit ac.</param>
        /// <param name="creditAc">The credit ac.</param>
        /// <param name="money">The money.</param>
        public void TransferMoney(string debitAc, string creditAc, double money)
        {
            if (accountManager.VerifyAccount(debitAc) && accountManager.VerifyAccount(creditAc))
            {
                accountManager.WithdrawMoney(debitAc);
                accountManager.DepositMoney(creditAc);
                trf.TransferAmount(debitAc, creditAc, money);
            }
        }
    }
}
