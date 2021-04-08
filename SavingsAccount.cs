using System;

class SavingsAccount : BankAccount
    {
      
      public override void CalculateInterest()
      {
        Balance = Balance * 1.05;
      }
      
      public override void Withdraw(double amount) {
        if (Balance < 2000){
          Console.WriteLine("Error: Insufficient balance");
        }
        else{
          base.Withdraw(amount);
        }
      }  
    }