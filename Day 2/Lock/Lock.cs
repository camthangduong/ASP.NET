using System;
using System.Threading.Tasks;

public class Account {
    private readonly object balanceLock = new object();
    private decimal balance;

    public Account(decimal amount)
    {
        balance = amount;
    }

    public decimal Debit (decimal amount) {
        lock (balanceLock) {
            if (balance >= amount)
            {
                Console.WriteLine("Balance before debit :{0, 5}", balance);
                Console.WriteLine("Amount to remove     :{0, 5}", amount);
                balance = balance - amount;
                Console.WriteLine("Balance after debit  :{0, 5}", balance);
                return amount;
            }
            else
            {
                return 0;
            }
        }
    }

    public void Credit (decimal amount) {
        lock (balanceLock) {
            Console.WriteLine("Balance before credit:{0, 5}", balance);
            Console.WriteLine("Amount to add        :{0, 5}", amount);
            balance = balance + amount;
            Console.WriteLine("Balance after credit :{0, 5}", balance);
        }
    }
}

class AccountTest {
    static void Main () {
        var account = new Account (1000);
        var tasks = new Task[100];
        for (int i = 0; i < tasks.Length; i++) {
            tasks[i] = Task.Run(() => RandomlyUpdate(account));
        }
        Task.WaitAll(tasks);
    }

    static void RandomlyUpdate (Account account) {
        var rnd = new Random();
        for (int i = 0; i < 10; i++) {
            var amount = rnd.Next(1, 100);
            bool doCredit = rnd.NextDouble() < 0.5;
            if (doCredit) {
                account.Credit (amount);
            } else {
                account.Debit(amount);
            }
        }
    }
}