using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class Accounts
    {
        public static void Main()
        {
            Console.Write("Please enter the  Account Number: ");
            int Acc_no = int.Parse(Console.ReadLine());

            Console.Write("Please enter the  Account Name: ");
            string Acc_name = Console.ReadLine();

            Console.Write("Please enter the  Account Type: ");
            string Acc_type = Console.ReadLine();

            Console.Write("Please enter the  Amount: ");
            double money = double.Parse(Console.ReadLine());

            Console.Write("Please enter the  Transaction Type: ");
            string Transac_type = Console.ReadLine();


            Accounts acc = new Accounts(Acc_no, Acc_name, Acc_type, money, Transac_type);

            if (acc.Transaction_type == "Deposit")
            {
                acc.credit(acc.Amount);
            }
            else if (acc.Transaction_type == "Withdrawal")
            {
                acc.debit(acc.Amount);
            }
            acc.showdata();
            Console.Read();
        }

        int Account_no;
        string Account_Holder_name;
        string Account_type;
        double Amount;
        double balance;
        string Transaction_type;
        public Accounts(int Acc_no, string Acc_name, string Acc_type,double money, string Transac_type)
        {
            Account_no = Acc_no;
            Account_Holder_name = Acc_name;
            Account_type = Acc_type;
            Amount = money;
            Transaction_type = Transac_type;
            balance = 10000;
        }

        public void debit(double Amount)
        {
            if(balance>=Amount)
            {
                balance -= Amount;
            }
            else
            {
                Console.WriteLine("Balance is Insufficient");
            }
        }

        public void credit(double Amount)
        {
            balance += Amount;
        }

        public void showdata()
        {
            Console.WriteLine("Account Number :" + Account_no);
            Console.WriteLine("Account Holder Name :" + Account_Holder_name);
            Console.WriteLine("Account Type :" + Account_type);
            Console.WriteLine("Amount :" + Amount);
            Console.WriteLine("Available Balance :" + balance);
        }
    }
}
