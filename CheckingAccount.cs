using System;

class CheckingAccount : BankAccount
    {

     public override void CalculateInterest()
     {
       Balance = Balance * 1.005;
     }

     public void Withdraw() {}

    }