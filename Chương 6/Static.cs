using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chương_6
{
    #region Bài 1 :
    //internal class Employee
    //{
    //    static Employee()
    //    {
    //        EmployeeId = 10000;
    //    }
    //    public Employee()
    //    {
    //        Id = "EMP" + EmployeeId++;
    //    }
    //    public Employee(string fullName, int phoneNumb, string job, double salary) : this()
    //    {
    //        FullName = fullName;
    //        PhoneNumb = phoneNumb;
    //        Job = job;
    //        Salary = salary;
    //    }
    //    public string Id { get; set; }
    //    public string FullName { get; set; }
    //    public int PhoneNumb { get; set; }
    //    public string Job { get; set; }
    //    public double Salary { get; set; }
    //    public static int EmployeeId { get; set; }
    //    public void CheckIn()
    //    {
    //        Console.WriteLine($"{Id} check in luc 7h.");
    //    }
    //    public void CheckOut()
    //    {
    //        Console.WriteLine($"{Id} check out luc 17h.");
    //    }
    //    public void Working()
    //    {
    //        Console.WriteLine($"{Id} dang chong day.");
    //    }
    //    public static void CalSalary(Employee employee)
    //    {
    //        Console.Write("Nhap so ngay di lam trong thang : ");
    //        int day = int.Parse(Console.ReadLine());
    //        double bonus = employee.Salary * 20 / 100;

    //        if (day >= 22)
    //        {
    //            employee.Salary = employee.Salary * day / 22 + bonus;
    //        }
    //        employee.Salary = employee.Salary * day / 22;

    //        Console.WriteLine($"{employee.Id} luong la : {employee.Salary}");
    //    }
    //}
    //public class Programm
    //{
    //    static void Main()
    //    {
    //        Employee emp = new Employee("ha", 3214, "thoxay", 7000000);

    //        emp.CheckIn();

    //        emp.CheckOut();

    //        emp.Working();

    //        Employee.CalSalary(emp);

    //    }
    //}
    #endregion
    public class BankAccount
    {
        static BankAccount()
        {
            BankId = Math.Pow(10, 13);
        }
        public BankAccount() 
        {
            
        }  
        public BankAccount(string accName, double balance, string bankName, string pin)
        {
            Id = BankId++;
            FullName = accName;
            Balance = balance;
            BankName = bankName;
            ValidMonth = 12;
            ValidYear = 23;
            Pin = pin;
        }
        public static double BankId { get; set; }
        public double Id { get; set; }
        public string FullName { get; set; }
        public double Balance { get; set; }
        public string BankName { get; set; }
        public int ValidMonth { get; set; }
        public int ValidYear { get; set; }
        public string Pin { get; set; }

        public void CheckBalance()
        {
            Console.WriteLine($"ID : {Id} | Your balance is : {Balance}");
        }
        public void Recharge()
        {
            Console.Write("Input Recharge amount : ");
            double rechargeAmount = double.Parse(Console.ReadLine());

            Balance += rechargeAmount;
            Console.WriteLine("Recharge successful");
        }
        public void Withdraw()
        {
            Console.Write("Input Withdraw amount : ");
            double withdrawAmount = double.Parse(Console.ReadLine());

            if (withdrawAmount > Balance || Balance - withdrawAmount < 50000)
            {
                Console.WriteLine("Insufficient Fund.");
            }
            else
            {
                Balance -= withdrawAmount;
                Console.WriteLine("Withdraw Successful.");
            }

        }
        public void TransferTo(BankAccount bankAccount)
        {
            Console.Write("Input Transfer amount : ");
            double transferAmount = double.Parse(Console.ReadLine());

            if (transferAmount > Balance || Balance - transferAmount < 50000)
            {
                Console.WriteLine("Insufficient Fund.");
            }
            else
            {
                Balance -= transferAmount;

                bankAccount.Balance += transferAmount;

                Console.WriteLine("Transer Successful.");
            }

        }
        public static void ShowAccList(BankAccount[] bankAccounts)
        {
            string titleId = "BANK ID";
            string titleFullName = "FULL NAME";
            string titleBalance = "BALANCE";
            string titleBankName = "BANK NAME";
            string titleValidDate = "VALID MONTH/YEAR";
            string titlePin = "PIN CODE";
            Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titleBalance,-20} {titleBankName,-20} {titleValidDate,-20} {titlePin,-20}");
            
            foreach (var account in bankAccounts)
            {
                if (account != null)
                {
                    Console.WriteLine($"{account.Id,-20} {account.FullName,-20} {account.Balance,-20} {account.BankName,-20} {account.ValidMonth + "/" + account.ValidYear,-20} {account.Pin,-20}");
                }
            }
        }

    }
    public class Programm
    {
        static void Main()
        {
            BankAccount[] bankAccountsList = new BankAccount[10];
            int bankAccIndex = 0;
            string key;
            bool end = true;
            while (end)
            {
                Console.WriteLine("* 1 : ADD NEW BANK ACCOUNT");
                Console.WriteLine("* 2 : CHECK BALANCE");
                Console.WriteLine("* 3 : RECHARGE");
                Console.WriteLine("* 4 : WITHDRAW");
                Console.WriteLine("* 5 : TRANSFER");
                Console.WriteLine("* 6 : SHOW LIST OF CURRENT ACCOUNTS");
                Console.WriteLine("* 7 : END");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.Write("INPUT YOUR CHOICE : ");
                key = Console.ReadLine();              
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("PLEASE INPUT VALID CHOICE : ");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        bankAccountsList[bankAccIndex] = AddBankAccount();
                        Console.WriteLine($"SUCCESSFULLY CREATE A NEW ACCOUNT YOUR ID IS : {bankAccountsList[bankAccIndex].Id}");
                        bankAccIndex++;
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        break;
                    case 2:

                        if (CheckID(bankAccountsList, out BankAccount AccFounded))
                        {
                            Console.WriteLine();
                            AccFounded.CheckBalance();
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT FIND YOUR ID.");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 3:
                        if (CheckID(bankAccountsList, out AccFounded))
                        {
                            Console.WriteLine();
                            AccFounded.Recharge();
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT FIND YOUR ID.");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        break;
                    case 4:

                        if (CheckID(bankAccountsList, out AccFounded))
                        {
                            Console.WriteLine();
                            if (CheckPIN(AccFounded))
                            {
                                AccFounded.Withdraw();
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT FIND YOUR ID.");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }

                        break;
                    case 5:
                        if (CheckID(bankAccountsList, out BankAccount SourceAcc, out BankAccount DesAcc) && CheckPIN(SourceAcc))
                        {
                            SourceAcc.TransferTo(DesAcc);
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        else if(SourceAcc.Id == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT FIND SOURCE ID.");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT FIND DESTINATION ID.");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

                        }
                        break;
                    case 6:
                        BankAccount.ShowAccList(bankAccountsList);
                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("YOUR INPUT OF CHOICE IS NOT AVAILABLE");
                        break;
                }
            }
        }

        private static bool CheckPIN(BankAccount accountFounded)
        {
            Console.Write("INPUT PIN CODE : ");
            string pinCheck = Console.ReadLine();
            int tryTurn = 2;
            while (tryTurn > 0)
            {
                if (int.TryParse(pinCheck, out int newPinCheck) == false || pinCheck != accountFounded.Pin)
                {
                    Console.WriteLine("WRONG PIN CODE PLEASE TRY AGAIN : ");
                    pinCheck = Console.ReadLine();
                    tryTurn--;
                }
                else
                {
                    return true;
                }
                if (tryTurn == 0)
                {
                    Console.WriteLine("WRONG INPUT OVER 3 TIME : ");
                    
                }
            }
            return false;

        }
        private static bool CheckID(BankAccount[] bankAccounts, out BankAccount SourceAcc, out BankAccount DesAcc)
        {
            Console.Write("INPUT SOURCE BANK ACCOUNT ID : ");
            double searchId1 = double.Parse(Console.ReadLine());
            
            SourceAcc = new BankAccount();
            DesAcc = new BankAccount();

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i] != null && bankAccounts[i].Id == searchId1)
                {

                    SourceAcc = bankAccounts[i];

                    Console.Write("INPUT DESTINATION BANK ACCOUNT ID: ");
                    double searchId2 = double.Parse(Console.ReadLine());
                 
                    for (int j = 0; j < bankAccounts.Length; j++)
                    {
                        if (bankAccounts[j] != null && bankAccounts[j].Id == searchId2)
                        {
                            DesAcc = bankAccounts[j];

                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private static bool CheckID(BankAccount[] bankAccounts, out BankAccount SearchedAcc)
        {
            Console.Write("INPUT BANK ACCOUNT ID : ");
            double id = double.Parse(Console.ReadLine());
            SearchedAcc = new BankAccount();
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i] != null && bankAccounts[i].Id == id)
                {
                    SearchedAcc = bankAccounts[i];

                    return true;
                }
            }
            return false;
        }

        private static BankAccount AddBankAccount()
        {
            Console.Write("INPUT FULL NAME : ");
            string userName = Console.ReadLine();

            while (int.TryParse(userName, out int newUsername) == true)
            {
                Console.Write("WRONG INPUT PLEASE TRY AGAIN : ");
                userName = Console.ReadLine();
            }

            Console.Write("INPUT YOUR BALANCE (SUFFICIENT FUND MUST BE MORE THAN 50000 VND) : ");
            double balance = double.Parse(Console.ReadLine());

            while (balance < 50000)
            {
                Console.Write("THE AMOUNT MUST BE MORE THAN 50000 VND PLEASE TRY AGAIN : ");
                balance = double.Parse(Console.ReadLine());
            }

            Console.Write("INPUT THE BANK NAME : ");
            string bankName = Console.ReadLine();

            while (int.TryParse(bankName, out int newBankName) == true)
            {
                Console.Write("WRONG BANK NAME PLEASE TRY AGAIN : ");
                bankName = Console.ReadLine();
            }

            Console.Write("INPUT YOUR PIN CODE : ");
            string pin = Console.ReadLine();

            while (int.TryParse(pin, out int newPin) == false || newPin.ToString().Length != 6)
            {
                Console.Write("PIN CODE MUST CONTAIN 6 NUMBER : ");
                pin = Console.ReadLine();
            }

            BankAccount bankAccount = new BankAccount(userName, balance, bankName, pin);

            return bankAccount;
        }
    }
}
