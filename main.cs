using System;

class MainClass {
  public static void Main (string[] args) {
    

    //Write code to implement the test cases below

            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */

      SavingsAccount test1 = new SavingsAccount();
      test1.Deposit(2000);
      test1.Withdraw(5000);
      test1.CalculateInterest();
      test1.Withdraw(500);


      CheckingAccount test2 = new CheckingAccount();
      test2.Deposit(2000);
      test2.Withdraw(5000);
      test2.CalculateInterest();
      test2.Withdraw(500);

  }
}