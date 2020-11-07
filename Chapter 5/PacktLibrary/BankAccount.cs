using System;

namespace Packt.Shared
{
    public class BankAccount
    {
        public string AccountName; //instance member
        public decimal Balance; // instance member
        public static decimal InterestRate; // shared member
    }
    // Each instance of BankAccount will have its own AccountName and Balance values, but all instances will share a single InterestRate value.
}