 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount() : this(1000)
        { 

          
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;

            Console.WriteLine ("The balance is " + Balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance > amount){
              
              Balance = Balance - amount;
            }

            else{
              Console.WriteLine("Error, not enough balance to withdraw");
            }

            Console.WriteLine("Your balance is " + Balance);
        }
        
        public abstract void CalculateInterest();

    }