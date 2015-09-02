namespace _11.Bank_account
{
    using System;

    class bankAccount
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            string IBAN;
            long cardNumber1;
            long cardNumber2;
            long cardNumber3;

            firstName = "Softuni";
            middleName = "Avgust";
            lastName = "Month";
            balance = 850.44M;
            bankName = "AlphaBank";
            IBAN = "BG85STSA12345678954321";
            cardNumber1 = 6775021178884332;
            cardNumber2 = 1234529091298001;
            cardNumber3 = 1234539102309111;

            Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, balance, bankName, IBAN, cardNumber1, cardNumber2, cardNumber3);  
        }
    }
}
