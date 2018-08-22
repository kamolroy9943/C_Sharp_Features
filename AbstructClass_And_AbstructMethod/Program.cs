namespace AbstructClass_And_AbstructMethod
{

    // Abstract classes are classes that contain one or more abstract methods.

    // An abstract method is a method that is declared, but contains no implementation.

    // In an abstruct classes can have abstruct and non abstruct methods.

    // Abstract classes may not be instantiated.

    // and require subclasses to provide implementations for the abstract methods.




    class Program
    {
        static void Main(string[] args)
        {
            Savings savings = new Savings();
            savings.Diposit(5465464);
        }
    }


    public abstract class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AccountNo { get; set; }

        public string Diposit(double amount)
        {
            Balance += amount;
            return "Deposit Successfull !";
        }

        public virtual string WithDraw(double amount)
        {
            Balance -= amount;
            return "WithDraw Successfull !";
        }

        public abstract void Transfer(string toAccount, double amount);

    }



    public class Savings : BankAccount
    {
        public override void Transfer(string toAccount, double amount)
        {
            //logic
        }

        public override string WithDraw(double amount)
        {
            //logic
            return "something";
        }
    }

    public class Checkings : BankAccount
    {
        public override void Transfer(string toAccount, double amount)
        {
            //logic
        }

        public override string WithDraw(double amount)
        {
            //logic
            return "something";
        }
    }
}
