namespace myapp
{
    public class Account
    {
        private long accountNo;
        private double balance;
        private string[] payees;
        private long[] payeeAccounts;

        public Account() {}
        public Account(long accountNo, double balance)
        {
            this.accountNo = accountNo;
            this.balance = balance;
        }

        public Account(long accountNo, double balance, string[] payees, long[] payeeAccounts)
        {
            this.accountNo = accountNo;
            this.balance = balance;
            this.payees = payees;
            this.payeeAccounts = payeeAccounts;
        }

        public int debitAmount(double amount) {
            if (amount <= this.balance) {
                return 1;
            }
            return 0;
        }

        public int transferMoney(long payeeAccountNo, double amount){
            for (int x = 0;x < this.payeeAccounts.Length; x++) {
                if (this.payeeAccounts[x].Equals(payeeAccountNo)) {
                    return this.debitAmount(amount);
                }
            }
            return -1;  
        }

        public int transferMoney(string nickName, double amount){
            foreach (string payee in this.payees) {
                if (payee.Equals(nickName)) {
                    return this.debitAmount(amount);
                }
            }
            return -1;
        }

        public long AccountNo { get => accountNo; set => accountNo = value; }
        public double Balance { get => balance; set => balance = value; }
        public string[] Payees { get => payees; set => payees = value; }
        public long[] PayeeAccounts { get => payeeAccounts; set => payeeAccounts = value; }
    }
}