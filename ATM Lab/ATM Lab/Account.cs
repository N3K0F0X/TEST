using System.Security.Cryptography.X509Certificates;
//Cody Griffith
//CSE-200 Lab 10
namespace account
{
    public class Account
    {
            public string customerName { get; set; }
            public int pinNumber { get; set; }
            public double accountBalance { get; set; }
            public int accountNumber { get; set; }

        public Account()
        {
            customerName = "Null";
            pinNumber = 1234;
            accountBalance = 10;
            accountNumber = 1;
        }


        public Account(string CName, int Pin, double AccBal, int AccNum)
        {
        customerName = CName;
        pinNumber = Pin;
        accountBalance = AccBal;
        accountNumber = AccNum;
        }

        public void CalcIntrest()
        {
            if (accountBalance <= 1000)
            {
                double intrest1 = accountBalance * 0.03;
                accountBalance = accountBalance + intrest1;
            }
            if (accountBalance <= 10000)
            {
                double intrest2 = accountBalance * 0.05;
                accountBalance = accountBalance + intrest2;
            }

            Account Account1 = new Account("Name",2345,1000,2);
        }
    }
}
