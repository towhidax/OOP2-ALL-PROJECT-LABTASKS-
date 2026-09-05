using System;

enum AccountType { Savings, Current }

struct Address
{
    public string City;
}

class Account
{
    public static int totalAcc = 0;
    public const string BankName = "MyBank";
    public readonly int accId;

    private double balance;
    public int? branchCode = null;
    public Address userAddress;

    public double Balance
    {
        get { return balance; }
        set { if (value >= 0) balance = value; }
    }

    static Account()
    {
        totalAcc = 0;
    }

    public Account()
    {
        accId = 1;
    }

    public Account(int id, double b) : this()
    {
        accId = id;
        Balance = b;
        totalAcc++;
    }

    public Account(Account acc)
    {
        accId = acc.accId;
        Balance = acc.Balance;
    }

    ~Account() { }

    public virtual void CalculateInterest()
    {
        Console.WriteLine("No interest in base account");
    }

    public void Deposit(double amt)
    {
        Balance = Balance + amt;
    }

    public void Deposit(ref double amt)
    {
        Balance = Balance + amt;
        amt = 0;
    }

    public void GetBonus(out double bonus)
    {
        bonus = 100.50;
    }

    public void AddDeposits(params double[] amts)
    {
        foreach (double a in amts)
        {
            Balance = Balance + a;
        }
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(int id, double b) : base(id, b) { }

    public override void CalculateInterest()
    {
        Console.WriteLine("Savings account interest is 5%");
    }
}

class PremiumSavings : SavingsAccount
{
    public PremiumSavings(int id, double b) : base(id, b) { }

    public sealed override void CalculateInterest()
    {
        Console.WriteLine("Premium account interest is 7%");
    }
}

class CurrentAccount : Account
{
    public CurrentAccount(int id, double b) : base(id, b) { }

    public new void CalculateInterest()
    {
        Console.WriteLine("Current account has 0% interest");
    }
}

class Program
{
    static void Main()
    {
        
        int x = 10;
        double y = x;
        int z = (int)y;

        
        Account a1 = new SavingsAccount(101, 5000);
        a1.CalculateInterest();

        Account a2 = new PremiumSavings(102, 10000);
        a2.CalculateInterest();

        Account a3 = new CurrentAccount(103, 8000);
        a3.CalculateInterest();

        double myDep = 500;
        a1.Deposit(ref myDep);

        double bns;
        a1.GetBonus(out bns);

        a1.AddDeposits(10, 20, 30);

        
        Console.WriteLine("\nArray outputs:");
        int[] arr1 = { 1, 2, 3 };
        Console.WriteLine("1D length: " + arr1.Length);
        foreach (int i in arr1) Console.Write(i + " ");
        Console.WriteLine();

        int[,] arr2 = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine("2D rows: " + arr2.GetLength(0));

        int[][] jArr = new int[2][];
        jArr[0] = new int[] { 1, 2 };
        jArr[1] = new int[] { 3, 4, 5 };

        Console.WriteLine("Jagged array:");
        foreach (int[] inner in jArr)
        {
            foreach (int i in inner)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}