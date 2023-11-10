//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Net.NetworkInformation;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using static Chương_6.Student;

//namespace Chương_6
//{
//    #region Bài 1 :
//    internal class Employee
//    {
//        static Employee()
//        {
//            EmployeeId = 10000;
//        }
//        public Employee()
//        {
//            Id = "EMP" + EmployeeId++;
//        }
//        public Employee(string fullName, int phoneNumb, string job, double salary) : this()
//        {
//            FullName = fullName;
//            PhoneNumb = phoneNumb;
//            Job = job;
//            Salary = salary;
//        }
//        public string Id { get; set; }
//        public string FullName { get; set; }
//        public int PhoneNumb { get; set; }
//        public string Job { get; set; }
//        public double Salary { get; set; }
//        public static int EmployeeId { get; set; }
//        public void CheckIn()
//        {
//            Console.WriteLine($"{Id} check in luc 7h.");
//        }
//        public void CheckOut()
//        {
//            Console.WriteLine($"{Id} check out luc 17h.");
//        }
//        public void Working()
//        {
//            Console.WriteLine($"{Id} dang chong day.");
//        }
//        public static void CalSalary(Employee employee)
//        {
//            Console.Write("Nhap so ngay di lam trong thang : ");
//            int day = int.Parse(Console.ReadLine());
//            double bonus = employee.Salary * 20 / 100;

//            if (day >= 22)
//            {
//                employee.Salary = employee.Salary * day / 22 + bonus;
//            }
//            employee.Salary = employee.Salary * day / 22;

//            Console.WriteLine($"{employee.Id} luong la : {employee.Salary}");
//        }
//    }
//    public class Programm
//    {
//        static void Main()
//        {
//            Employee emp = new Employee("ha", 3214, "thoxay", 7000000);

//            emp.CheckIn();

//            emp.CheckOut();

//            emp.Working();

//            Employee.CalSalary(emp);

//        }
//    }
//    #endregion
//    #region Bài 2 :
//    public class BankAccount
//    {
//        public BankAccount()
//        {
//            Id = BankId++;
//        }

//        public BankAccount(string accName, double balance, string bankName, string pin) : this()
//        {

//            FullName = accName;
//            Balance = balance;
//            BankName = bankName;
//            Pin = pin;
//        }
//        public static double BankId = Math.Pow(10, 13);
//        public double Id { get; set; }
//        public string FullName { get; set; }
//        public double Balance { get; set; }
//        public string BankName { get; set; }

//        public static int ValidMonth = 12;

//        public static int ValidYear = 23;
//        public string Pin { get; set; }

//        public void CheckBalance()
//        {
//            Console.WriteLine($"ID : {Id} | Your balance is : {Balance}");
//        }
//        public void Recharge()
//        {
//            Console.Write("Input Recharge amount : ");
//            double rechargeAmount = double.Parse(Console.ReadLine());

//            Balance += rechargeAmount;
//            Console.WriteLine("Recharge successful");
//        }
//        public void Withdraw()
//        {
//            Console.Write("Input Withdraw amount : ");
//            double withdrawAmount = double.Parse(Console.ReadLine());

//            if (withdrawAmount > Balance || Balance - withdrawAmount < 50000)
//            {
//                Console.WriteLine("Insufficient Fund.");
//            }
//            else
//            {
//                Balance -= withdrawAmount;
//                Console.WriteLine("Withdraw Successful.");
//            }

//        }
//        public void TransferTo(BankAccount bankAccount)
//        {
//            Console.Write("Input Transfer amount : ");
//            double transferAmount = double.Parse(Console.ReadLine());

//            if (transferAmount > Balance || Balance - transferAmount < 50000)
//            {
//                Console.WriteLine("Insufficient Fund.");
//            }
//            else
//            {
//                Balance -= transferAmount;

//                bankAccount.Balance += transferAmount;

//                Console.WriteLine("Transer Successful.");
//            }

//        }
//        public static void ShowAccList(BankAccount[] bankAccounts)
//        {
//            string titleId = "BANK ID";
//            string titleFullName = "FULL NAME";
//            string titleBalance = "BALANCE";
//            string titleBankName = "BANK NAME";
//            string titleValidDate = "VALID MONTH/YEAR";
//            string titlePin = "PIN CODE";
//            Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titleBalance,-20} {titleBankName,-20} {titleValidDate,-20} {titlePin,-20}");

//            foreach (var account in bankAccounts)
//            {
//                if (account != null)
//                {
//                    Console.WriteLine($"{account.Id,-20} {account.FullName,-20} {account.Balance,-20} {account.BankName,-20} {ValidMonth + "/" + ValidYear,-20} {account.Pin,-20}");
//                }
//            }
//        }

//    }
//    public class Programm
//    {
//        static void Main()
//        {
//            BankAccount[] bankAccountsList = new BankAccount[10];
//            int bankAccIndex = 0;
//            string key;
//            bool end = true;
//            while (end)
//            {
//                Console.WriteLine("* 1 : ADD NEW BANK ACCOUNT");
//                Console.WriteLine("* 2 : CHECK BALANCE");
//                Console.WriteLine("* 3 : RECHARGE");
//                Console.WriteLine("* 4 : WITHDRAW");
//                Console.WriteLine("* 5 : TRANSFER");
//                Console.WriteLine("* 6 : SHOW LIST OF CURRENT ACCOUNTS");
//                Console.WriteLine("* 7 : END");
//                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                Console.Write("INPUT YOUR CHOICE : ");
//                key = Console.ReadLine();
//                if (int.TryParse(key, out int newKey) == false)
//                {
//                    Console.WriteLine("PLEASE INPUT VALID CHOICE : ");
//                    continue;
//                }
//                switch (newKey)
//                {
//                    case 1:
//                        bankAccountsList[bankAccIndex] = AddBankAccount();
//                        Console.WriteLine($"SUCCESSFULLY CREATE A NEW ACCOUNT YOUR ID IS : {bankAccountsList[bankAccIndex].Id}");
//                        bankAccIndex++;
//                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        break;
//                    case 2:
//                        Console.Write("INPUT BANK ACCOUNT ID : ");
//                        var searchedAcc = CheckID(bankAccountsList);
//                        if (searchedAcc == null)
//                        {
//                            Console.WriteLine("CANNOT FIND YOUR ID.");
//                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        }
//                        else
//                        {
//                            searchedAcc.CheckBalance();
//                        }
//                        break;
//                    case 3:
//                        Console.Write("INPUT BANK ACCOUNT ID : ");
//                        searchedAcc = CheckID(bankAccountsList);
//                        if (searchedAcc == null)
//                        {
//                            Console.WriteLine("CANNOT FIND YOUR ID.");
//                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        }
//                        else
//                        {

//                            searchedAcc.Recharge();
//                        }
//                        break;
//                    case 4:
//                        Console.Write("INPUT BANK ACCOUNT ID : ");
//                        searchedAcc = CheckID(bankAccountsList);
//                        if (searchedAcc == null)
//                        {
//                            Console.WriteLine("CANNOT FIND YOUR ID.");
//                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        }
//                        else
//                        {

//                            searchedAcc.Withdraw();
//                        }

//                        break;
//                    case 5:
//                        Console.Write("INPUT SOURCE ACCOUNT ID : ");
//                        var searchedAcc1 = CheckID(bankAccountsList);
//                        if (searchedAcc1 == null)
//                        {
//                            Console.WriteLine("CANNOT FIND YOUR ID.");
//                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        }
//                        else
//                        {
//                            Console.Write("INPUT DESTINATION ACCOUNT ID : ");
//                            var searchedAcc2 = CheckID(bankAccountsList);
//                            if (searchedAcc2 == null)
//                            {
//                                Console.WriteLine("CANNOT FIND DESTINATION ID.");
//                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                            }
//                            else
//                            {
//                                if (CheckPIN(searchedAcc1))
//                                {
//                                    searchedAcc1.TransferTo(searchedAcc2);
//                                }
//                            }
//                        }
//                        break;

//                    case 6:
//                        BankAccount.ShowAccList(bankAccountsList);
//                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
//                        break;
//                    case 7:
//                        end = false;
//                        break;
//                    default:
//                        Console.WriteLine("YOUR INPUT OF CHOICE IS NOT AVAILABLE");
//                        break;
//                }
//            }
//        }

//        private static bool CheckPIN(BankAccount accountFounded)
//        {
//            Console.Write("INPUT PIN CODE : ");
//            string pinCheck = Console.ReadLine();
//            int tryTurn = 2;
//            while (tryTurn > 0)
//            {
//                if (int.TryParse(pinCheck, out int newPinCheck) == false || pinCheck != accountFounded.Pin)
//                {
//                    Console.WriteLine("WRONG PIN CODE PLEASE TRY AGAIN : ");
//                    pinCheck = Console.ReadLine();
//                    tryTurn--;
//                }
//                else
//                {
//                    return true;
//                }
//                if (tryTurn == 0)
//                {
//                    Console.WriteLine("WRONG INPUT OVER 3 TIME : ");

//                }
//            }
//            return false;

//        }
//        private static BankAccount CheckID(BankAccount[] bankAccounts)
//        {

//            double id = double.Parse(Console.ReadLine());

//            foreach (var account in bankAccounts)
//            {
//                if (account != null && account.Id == id)
//                {
//                    return account;
//                }
//            }
//            return null;
//        }
//        private static BankAccount AddBankAccount()
//        {
//            Console.Write("INPUT FULL NAME : ");
//            string userName = Console.ReadLine();

//            while (int.TryParse(userName, out int newUsername) == true)
//            {
//                Console.Write("WRONG INPUT PLEASE TRY AGAIN : ");
//                userName = Console.ReadLine();
//            }

//            Console.Write("INPUT YOUR BALANCE (SUFFICIENT FUND MUST BE MORE THAN 50000 VND) : ");
//            double balance = double.Parse(Console.ReadLine());

//            while (balance < 50000)
//            {
//                Console.Write("THE AMOUNT MUST BE MORE THAN 50000 VND PLEASE TRY AGAIN : ");
//                balance = double.Parse(Console.ReadLine());
//            }

//            Console.Write("INPUT THE BANK NAME : ");
//            string bankName = Console.ReadLine();

//            while (int.TryParse(bankName, out int newBankName) == true)
//            {
//                Console.Write("WRONG BANK NAME PLEASE TRY AGAIN : ");
//                bankName = Console.ReadLine();
//            }

//            Console.Write("INPUT YOUR PIN CODE : ");
//            string pin = Console.ReadLine();

//            while (int.TryParse(pin, out int newPin) == false || newPin.ToString().Length != 6)
//            {
//                Console.Write("PIN CODE MUST CONTAIN 6 NUMBER : ");
//                pin = Console.ReadLine();
//            }

//            BankAccount bankAccount = new BankAccount(userName, balance, bankName, pin);

//            return bankAccount;
//        }
//    }
//    #endregion
//    #region Bài 3 :
//    public class Student
//    {
//        public Student()
//        {
//            Id = "ST" + IDindex++;
//        }

//        public Student(string firstName, string midName, string lastName, string addr, string gpa, string major) : this()
//        {
//            FirstName = firstName;
//            MiddleName = midName;
//            LastName = lastName;
//            Address = addr;
//            Gpa = gpa;
//            Major = major;

//        }
//        public static int IDindex = 1000;
//        public string Id { get; set; }
//        public string FirstName { get; set; }
//        public string MiddleName { get; set; }
//        public string LastName { get; set; }
//        public string Address { get; set; }
//        public string Gpa { get; set; }
//        public string Major { get; set; }

//        internal static void ShowStudentList(Student[] students)
//        {
//            var titleId = "STUDENT ID";
//            var titleFullname = "STUDENT FULL NAME";
//            var titleAddress = "STUDENT ADDRESS";
//            var titleGpa = "STUDENT GPA";
//            var titleMajor = "STUDENT MAJOR";
//            Console.WriteLine($"{titleId,-20} {titleFullname,-20} {titleAddress,-20} {titleGpa,-20} {titleMajor,-20}");

//            foreach (var student in students)
//            {
//                if (student != null)
//                {
//                    Console.WriteLine($"{student.Id,-20} {student.FirstName + " " + student.MiddleName + " " + student.LastName,-20} {student.Address,-20} {student.Gpa,-20} {student.Major,-20}");
//                }
//            }
//            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
//        }

//        internal static void GpaDescendSort(Student[] students)
//        {
//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null && students[i].Gpa.CompareTo(students[j].Gpa) > 0)
//                        {
//                            Student tmp = students[i];
//                            students[i] = students[j];
//                            students[j] = tmp;
//                        }
//                    }
//                }
//            }
//        }

//        internal static void NameAscendSort(Student[] students)
//        {
//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null && students[i].LastName.CompareTo(students[j].LastName) < 0)
//                        {
//                            Student tmp = students[i];
//                            students[i] = students[j];
//                            students[j] = tmp;
//                        }
//                    }
//                }
//            }
//        }

//        internal static void FindStudentByName(Student[] students)
//        {
//            Console.Write("ENTER THE SEARCH STUDENT NAME : ");
//            string name = Console.ReadLine();
//            Student[] searchedStudent = new Student[students.Length];
//            int searchedStudentIndex = 0;
//            while (int.TryParse(name, out int newName) == true)
//            {
//                Console.Write("WRONG INPUT PLEASE TRY AGAIN : ");
//                name = Console.ReadLine();
//            }

//            foreach (var item in students)
//            {
//                if (item != null && item.LastName == name)
//                {
//                    searchedStudent[searchedStudentIndex] = item;
//                    searchedStudentIndex++;
//                }
//            }
//            ShowStudentList(searchedStudent);
//        }

//        internal static void FindStudentByAddress(Student[] students)
//        {
//            Console.Write("ENTER THE SEARCH STUDENT NAME : ");
//            string addr = Console.ReadLine();
//            Student[] searchedStudent = new Student[students.Length];
//            int searchedStudentIndex = 0;
//            while (int.TryParse(addr, out int newAddr) == true)
//            {
//                Console.Write("WRONG INPUT PLEASE TRY AGAIN : ");
//                addr = Console.ReadLine();
//            }

//            foreach (var item in students)
//            {
//                if (item != null && item.Address == addr)
//                {
//                    searchedStudent[searchedStudentIndex] = item;
//                    searchedStudentIndex++;
//                }
//            }
//            ShowStudentList(searchedStudent);
//        }

//        internal static void DeleteStudentByID(Student[] students, ref int index)
//        {
//            Console.Write("ENTER ID OF DELETED STUDENT : ");
//            string id = Console.ReadLine();

//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i; j < students.Length; j++)
//                    {
//                        if (students[j] != null && students[j].Id == id)
//                        {
//                            students[j] = students[j + 1];
//                        }
//                    }
//                }
//            }
//            index--;
//        }
//        public class ListStudentWard
//        {
//            public ListStudentWard(string ward, int count)
//            {
//                Ward = ward;
//                Count = count;
//            }
//            public string Ward { get; set; }
//            public int Count { get; set; }
//        }

//        internal static void AlterStudentGpa(Student[] students)
//        {
//            Console.Write("ENTER STUDENT ID : ");
//            string studentId = Console.ReadLine();

//            var searchedStudent = CheckStudentId(students, studentId);
//            if (searchedStudent != null)
//            {
//                Console.Write("ENTER NEW GPA : ");
//                string newGpa = Console.ReadLine();
//                while (double.TryParse(newGpa, out double gpa) == false || newGpa == searchedStudent.Gpa) ;
//                {
//                    Console.Write("INVALID INPUT PLEASE TRY AGAIN : ");
//                    newGpa = Console.ReadLine();
//                }

//                searchedStudent.Gpa = newGpa;
//                Console.WriteLine("SUCCESSFULLY ALTER STUDENT GPA.");
//            }
//            else
//            {
//                Console.WriteLine("CANNOT FIND STUDENT ID.");
//            }
//        }

//        private static Student CheckStudentId(Student[] students, string id)
//        {
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null && students[i].Id == id)
//                {
//                    return students[i];
//                }
//            }
//            return null;
//        }
//    }
//    public class Programm
//    {
//        static void Main()
//        {
//            Student[] students = new Student[10];
//            int studentIndex = 0;
//            string key;
//            bool end = true;

//            while (end)
//            {

//                Console.WriteLine("* 1.Them Sinh Vien");
//                Console.WriteLine("* 2.Danh sach sinh vien");
//                Console.WriteLine("* 3.Sap xep sinh vien theo diem giam dan");
//                Console.WriteLine("* 4.Sap xep sinh vien theo ten tang dan");
//                Console.WriteLine("* 5.Sap xep sinh vien theo ten/ho tang dan || Diem TB giam dan");
//                Console.WriteLine("* 6.Tim sinh vien theo ten");
//                Console.WriteLine("* 7.Tim sinh vien theo tinh");
//                Console.WriteLine("* 8.Xoa sinh vien theo ma");
//                Console.WriteLine("* 9.Liet ke sinh vien theo tinh");
//                Console.WriteLine("* 10.Sua diem sinh vien theo ma");
//                Console.WriteLine("* 11.End");
//                Console.WriteLine("---------------------------------------------------------------------------------------------------------");

//                Console.WriteLine("Nhap lua chon : ");

//                key = Console.ReadLine();
//                if (int.TryParse(key, out int newKey) == false || newKey < 1)
//                {
//                    Console.Write("CHOICE DOESN'T EXIST PLEASE TRY AGAIN : ");
//                    continue;
//                }
//                switch (newKey)
//                {
//                    case 1:
//                        students[studentIndex++] = CreatNewStudent();
//                        break;
//                    case 2:
//                        ShowStudentList(students);
//                        break;
//                    case 3:
//                        GpaDescendSort(students);
//                        break;
//                    case 4:
//                        NameAscendSort(students);
//                        break;
//                    case 5:
//                        SortStudent(students);
//                        break;
//                    case 6:
//                        FindStudentByName(students);
//                        break;
//                    case 7:
//                        FindStudentByAddress(students);
//                        break;
//                    case 8:
//                        DeleteStudentByID(students, ref studentIndex);
//                        break;
//                    case 9:
//                        ListStudentsByWard(students);
//                        break;
//                    case 10:
//                        AlterStudentGpa(students);
//                        break;
//                    case 11:
//                        end = false;
//                        break;
//                    default:
//                        Console.WriteLine("INVALID CHOICE.");
//                        break;
//                }
//            }
//        }

//        private static void ListStudentsByWard(Student[] students)
//        {
//            ListStudentWard[] listStudentWard = new ListStudentWard[students.Length];
//            int index = 0;
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null && CheckStudent(listStudentWard, i, students[i].Address))
//                {
//                    listStudentWard[index] = new ListStudentWard(students[i].Address, CountStudent(students, students[i].Address));
//                    index++;
//                }
//            }

//            StudentsListDescentSort(listStudentWard);

//            foreach (var item in listStudentWard)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Ward} : {item.Count}");
//                }
//            }
//        }

//        private static void StudentsListDescentSort(ListStudentWard[] listStudentWard)
//        {
//            for (int i = 0; i < listStudentWard.Length; i++)
//            {
//                if (listStudentWard[i] != null)
//                {
//                    for (int j = i + 1; j < listStudentWard.Length; j++)
//                    {
//                        if (listStudentWard[j] != null && listStudentWard[i].Count < listStudentWard[j].Count)
//                        {
//                            ListStudentWard tmp = listStudentWard[i];
//                            listStudentWard[i] = listStudentWard[j];
//                            listStudentWard[j] = tmp;
//                        }
//                    }
//                }
//            }
//        }

//        private static int CountStudent(Student[] students, string address)
//        {
//            int count = 0;
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null && students[i].Address == address)
//                {
//                    count++;
//                }
//            }
//            return count;
//        }

//        private static bool CheckStudent(ListStudentWard[] listStudentWard, int current, string addr)
//        {
//            for (int i = 0; i < current; i++)
//            {
//                if (listStudentWard[i] != null && listStudentWard[i].Ward == addr)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        private static void SortStudent(Student[] students)
//        {
//            GpaDescendSort(students);

//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].Gpa == students[j].Gpa && students[i].LastName.CompareTo(students[j].LastName) > 0 || students[i].Gpa == students[j].Gpa && students[i].FirstName.CompareTo(students[j].FirstName) > 0)
//                            {
//                                Student tmp = students[i];
//                                students[i] = students[j];
//                                students[j] = tmp;
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        private static Student CreatNewStudent()
//        {
//            Console.Write("ENTER YOUR FIRST NAME  : ");
//            string firstName = Console.ReadLine();

//            while (int.TryParse(firstName, out int newFirstName) == true)
//            {
//                Console.Write("YOUR NAME CANNOT BE A NUMMBER TRY AGAIN : ");
//                firstName = Console.ReadLine();
//            }
//            Console.Write("ENTER YOUR MIDDLE NAME : ");
//            string midName = Console.ReadLine();

//            while (int.TryParse(midName, out int newMidName) == true)
//            {
//                Console.Write("YOUR NAME CANNOT BE A NUMMBER TRY AGAIN : ");
//                midName = Console.ReadLine();
//            }
//            Console.Write("ENTER YOUR LAST NAME   : ");
//            string lastName = Console.ReadLine();

//            while (int.TryParse(lastName, out int newLastName) == true)
//            {
//                Console.Write("YOUR NAME CANNOT BE A NUMMBER TRY AGAIN : ");
//                lastName = Console.ReadLine();
//            }
//            Console.Write("ENTER YOUR ADDRESS     : ");
//            string addr = Console.ReadLine();

//            while (int.TryParse(addr, out int newAddr) == true)
//            {
//                Console.Write("YOUR ADDRESS CANNOT BE A NUMMBER TRY AGAIN : ");
//                addr = Console.ReadLine();
//            }
//            Console.Write("ENTER YOUR GPA         : ");
//            string gpa = Console.ReadLine();

//            while (double.TryParse(gpa, out double newGpa) == false)
//            {
//                Console.Write("WRONG GPA INPUT TRY AGAIN : ");
//                gpa = Console.ReadLine();
//            }
//            Console.Write("ENTER YOUR MAJOR       : ");
//            string major = Console.ReadLine();

//            while (int.TryParse(major, out int newMajor) == true)
//            {
//                Console.Write("YOUR MAJOR CANNOT BE A NUMMBER TRY AGAIN : ");
//                major = Console.ReadLine();
//            }

//            Student student = new Student(firstName, midName, lastName, addr, gpa, major);

//            return student;
//        }
//    }
//    #endregion
//}
