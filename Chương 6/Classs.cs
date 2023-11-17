//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
//using System.Linq;
//using System.Net.NetworkInformation;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Chương_6
//{
//    #region Bài 1 :
//    public class Employee
//    {
//        public Employee(int id, string fullName, long phoneNumb, string job)
//        {
//            Id = id;
//            FullName = fullName;
//            PhoneNumb = phoneNumb;
//            Job = job;
//            PaySlip = 6000000;
//            MonthEndSalary = PaySlip;
//        }
//        public Employee(int id, string fullName, long phoneNumb, string job, double groundPay)
//        {
//            Id = id;
//            FullName = fullName;
//            PhoneNumb = phoneNumb;
//            Job = job;
//            PaySlip = groundPay;
//            MonthEndSalary = PaySlip;
//        }
//        public double MonthEndSalary { get; set; }
//        public string FullName { get; set; }
//        public int Id { get; set; }
//        public string Job { get; set; }
//        public double PaySlip { get; set; }
//        public long PhoneNumb { get; set; }

//        public static void CheckIn(Employee employee)
//        {
//            Console.WriteLine($"{employee.FullName} Da check in");
//        }
//        public static void CheckOut(Employee employee)
//        {
//            Console.WriteLine($"{employee.FullName} Da check out");
//        }
//        public static void Working(Employee employee)
//        {
//            Console.WriteLine($"{employee.FullName} Dang chong day");
//        }
//        public static void CalSalary(Employee employee)
//        {
//            Console.Write("Nhap so ngay di lam cua nhan vien : ");
//            int day = int.Parse(Console.ReadLine());
//            double bonus = employee.PaySlip * 20 / 100;

//            if (day >= 22)
//            {
//                employee.MonthEndSalary = (employee.PaySlip * day / 22) + bonus;
//                Console.WriteLine($"Luong cua nhan vien{employee.FullName} la : {Math.Round(employee.MonthEndSalary, 3)}");
//            }
//            else
//            {
//                employee.MonthEndSalary = employee.PaySlip / 22;
//                Console.WriteLine($"Luong cua nhan vien {employee.FullName} la : {Math.Round(employee.MonthEndSalary, 3)}");
//            }
//        }
//    }
//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee(1, "Nguyen Van A", 0328582275, "Manager");
//            Employee employee1 = new Employee(2, "Nguyen Ban V", 0983161277, "Ceo", 10000000);
//            Employee.CheckIn(employee);
//            Employee.CheckOut(employee);
//            Employee.Working(employee);
//            Employee.CalSalary(employee);
//            Console.WriteLine();
//            Employee.CheckIn(employee1);
//            Employee.CheckOut(employee1);
//            Employee.Working(employee1);
//            Employee.CalSalary(employee1);

//        }
//    }
//    #endregion
//    #region Bài 2 :
//    public class Matrix
//    {
//        public Matrix(int rows, int cols)
//        {
//            Row = rows;
//            Col = cols;
//            Matrixs = new int[Row, Col];
//        }
//        public int Row { get; set; }
//        public int Col { get; set; }
//        public int[,] Matrixs { get; set; }
//        public static void NhapMaTran(Matrix matrix)
//        {
//            for (int i = 0; i < matrix.Matrixs.GetLength(0); i++)
//            {
//                for (int j = 0; j < matrix.Matrixs.GetLength(1); j++)
//                {
//                    matrix.Matrixs[i, j] = int.Parse(Console.ReadLine());
//                }
//            }
//        }
//        public static void ShowMaTran(Matrix matrix)
//        {
//            Console.WriteLine("Ma tran vua nhap la : ");
//            for (int i = 0; i < matrix.Matrixs.GetLength(0); i++)
//            {
//                for (int j = 0; j < matrix.Matrixs.GetLength(1); j++)
//                {
//                    Console.Write(matrix.Matrixs[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//        public static void SumMatrix(int[,] matrix, int[,] matrix1)
//        {
//            Matrix matrixSum = new Matrix(matrix.GetLength(0), matrix.GetLength(1));
//            Console.WriteLine("Tong cua 2 ma tran la : ");
//            for (int i = 0; i < matrixSum.Row; i++)
//            {
//                for (int j = 0; j < matrixSum.Col; j++)
//                {
//                    matrixSum.Matrixs[i, j] = matrix[i, j] + matrix1[i, j];
//                }
//            }
//            ShowMaTran(matrixSum);
//        }
//        public static void TichMatrix(int[,] matrix, int[,] matrix1)
//        {
//            if (matrix.GetLength(0) != matrix1.GetLength(1))
//            {
//                Console.WriteLine("Khong thuc hien duoc phep nhan : ");
//            }
//            else
//            {
//                Matrix matrixSum = new Matrix(matrix1.GetLength(0), matrix.GetLength(1));
//                Console.WriteLine("Tong cua 2 ma tran la : ");
//                for (int i = 0; i < matrixSum.Row; i++)
//                {
//                    for (int j = 0; j < matrixSum.Col; j++)
//                    {
//                        for (int k = 0; k < matrixSum.Row; k++)
//                        {
//                            matrixSum.Matrixs[i, j] = matrixSum.Matrixs[i, j] + (matrix[k, j] * matrix1[i, k]);
//                        }
//                    }
//                }
//                ShowMaTran(matrixSum);
//            }


//        }
//    }
//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Nhap so hang cua ma tran : ");

//            int row = int.Parse(Console.ReadLine());

//            Console.Write("Nhap so cot cua ma tran : ");

//            int col = int.Parse(Console.ReadLine());

//            Matrix matrix = new Matrix(row, col);

//            Matrix.NhapMaTran(matrix);

//            Matrix.ShowMaTran(matrix);

//            Console.Write("Nhap so hang cua ma tran 2 : ");

//            int row1 = int.Parse(Console.ReadLine());

//            Console.Write("Nhap so cot cua ma tran 2 : ");

//            int col1 = int.Parse(Console.ReadLine());

//            Matrix matrix1 = new Matrix(row1, col1);

//            Matrix.NhapMaTran(matrix1);

//            Matrix.ShowMaTran(matrix1);

//            Matrix.SumMatrix(matrix.Matrixs, matrix1.Matrixs);

//            Matrix.TichMatrix(matrix.Matrixs, matrix1.Matrixs);
//        }
//    }
//    #endregion
//    #region Bài 3 :
//    public class PhanSo
//    {
//        public PhanSo(int tuSo, int mauSo)
//        {
//            TuSo = tuSo;
//            MauSo = mauSo;
//        }
//        public int TuSo { get; set; }
//        public int MauSo { get; set; }

//        public static PhanSo NhapPhanSo()
//        {
//            Console.Write("Nhap tu so : ");
//            int tuSo = int.Parse(Console.ReadLine());
//            Console.Write("Nhap mau so : ");
//            int mauSo = int.Parse(Console.ReadLine());

//            PhanSo phanSo = new PhanSo(tuSo, mauSo);

//            Console.Write("Phan so vua nhap la : ");
//            ShowPhanSo(phanSo);
//            return phanSo;
//        }
//        public static void ShowPhanSo(PhanSo phanSo)
//        {
//            Console.WriteLine($"{phanSo.TuSo} / {phanSo.MauSo}");
//        }
//        public static void CongPhanSo(PhanSo phanso1, PhanSo phanso2)
//        {
//            int a = phanso1.MauSo * phanso2.MauSo;
//            int b = (phanso1.TuSo * phanso2.MauSo) + (phanso2.TuSo * phanso1.MauSo);
//            Console.WriteLine($"Tong cua 2 phan so ({phanso1.TuSo} / {phanso1.MauSo}) + ({phanso2.TuSo} / {phanso2.MauSo}) la : ");
//            if (phanso1.MauSo == phanso2.MauSo)
//            {
//                PhanSo phanSoSum = new PhanSo(phanso1.TuSo + phanso2.TuSo, phanso1.MauSo);
//                RutGon(phanSoSum);
//                ShowPhanSo(phanSoSum);
//            }
//            PhanSo phansoSum = new PhanSo(b, a);

//            RutGon(phansoSum);

//            ShowPhanSo(phansoSum);
//        }
//        public static void TruPhanSo(PhanSo phanso1, PhanSo phanso2)
//        {
//            int a = phanso1.MauSo * phanso2.MauSo;
//            int b = (phanso1.TuSo * phanso2.MauSo) - (phanso2.TuSo * phanso1.MauSo);
//            Console.WriteLine($"Hieu cua 2 phan so ({phanso1.TuSo} / {phanso1.MauSo}) - ({phanso2.TuSo} / {phanso2.MauSo}) la : ");
//            if (phanso1.MauSo == phanso2.MauSo)
//            {
//                PhanSo phanSoSum = new PhanSo(phanso1.TuSo - phanso2.TuSo, phanso1.MauSo);
//                RutGon(phanSoSum);
//                ShowPhanSo(phanSoSum);
//            }
//            PhanSo phansoSum = new PhanSo(b, a);

//            RutGon(phansoSum);

//            ShowPhanSo(phansoSum);
//        }
//        public static void NhanPhanSo(PhanSo phanso1, PhanSo phanso2)
//        {
//            int tuSo = phanso1.TuSo * phanso2.TuSo;
//            int mauSo = phanso1.MauSo * phanso2.MauSo;

//            Console.WriteLine($"Hieu cua 2 phan so ({phanso1.TuSo} / {phanso1.MauSo}) * ({phanso2.TuSo} / {phanso2.MauSo}) la : ");

//            PhanSo tich = new PhanSo(tuSo, mauSo);

//            RutGon(tich);

//            ShowPhanSo(tich);
//        }
//        public static void ChiaPhanSo(PhanSo phanSo1, PhanSo phanSo2)
//        {
//            int tuSo = phanSo1.TuSo * phanSo2.MauSo;
//            int mauSo = phanSo1.MauSo * phanSo2.TuSo;

//            Console.WriteLine($"Hieu cua 2 phan so ({phanSo1.TuSo} / {phanSo1.MauSo}) % ({phanSo2.TuSo} / {phanSo2.MauSo}) la : ");

//            PhanSo thuong = new PhanSo(tuSo, mauSo);

//            RutGon(thuong);

//            ShowPhanSo(thuong);
//        }
//        private static void RutGon(PhanSo phansoSum)
//        {
//            int ucln = UClN(phansoSum);
//            phansoSum.TuSo /= ucln;
//            phansoSum.MauSo /= ucln;
//        }

//        public static int UClN(PhanSo phanSoRutGon)
//        {
//            int ucln = 0;
//            if (phanSoRutGon.TuSo > phanSoRutGon.MauSo)
//            {
//                for (int i = 1; i < phanSoRutGon.TuSo; i++)
//                {
//                    if (phanSoRutGon.TuSo % i == 0 && phanSoRutGon.MauSo % i == 0)
//                    {
//                        ucln = i;
//                    }
//                }
//            }

//            if (phanSoRutGon.TuSo < phanSoRutGon.MauSo)
//            {
//                for (int i = 1; i < phanSoRutGon.MauSo; i++)
//                {
//                    if (phanSoRutGon.TuSo % i == 0 && phanSoRutGon.MauSo % i == 0)
//                    {
//                        ucln = i;
//                    }
//                }
//            }
//            return ucln;
//        }
//    }
//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            PhanSo phanSo = PhanSo.NhapPhanSo();

//            PhanSo phanSo1 = PhanSo.NhapPhanSo();

//            PhanSo.CongPhanSo(phanSo, phanSo1);

//            PhanSo.TruPhanSo(phanSo, phanSo1);


//            PhanSo.NhanPhanSo(phanSo, phanSo1);

//            PhanSo.ChiaPhanSo(phanSo, phanSo1);

//        }
//    }
//    #endregion
//    #region Bài 4 :
//    public class NganHang
//    {
//        public NganHang(long stk, string name, double balance, string bankName, int validMonth, int validYear, int pin)
//        {
//            STK = stk;
//            Name = name;
//            Balance = balance;
//            BankName = bankName;
//            ValidMonth = validMonth;
//            ValidYear = validYear;
//            Pin = pin;

//        }
//        public long STK { get; set; }
//        public string Name { get; set; }
//        public double Balance { get; set; }

//        public string BankName { get; set; }
//        public int ValidMonth { get; set; }

//        public int ValidYear { get; set; }

//        public int Pin { get; set; }
//        public static bool CheckStk(NganHang nganHangs, long stk)
//        {
//            if (stk == nganHangs.STK)
//            {
//                return true;
//            }
//            return false;
//        }
//        public static void NapTien(NganHang[] nganHang)
//        {
//            Console.Write("Nhap so tai khoan : ");
//            long stk = long.Parse(Console.ReadLine());
//            foreach (var item in nganHang)
//            {
//                if (item != null)
//                {
//                    if (CheckStk(item, stk))
//                    {
//                        Console.Write("Nhap tien nap : ");
//                        double tienNap = double.Parse(Console.ReadLine());
//                        item.Balance += tienNap;
//                    }
//                }
//            }
//        }
//        public static void RutTien(NganHang nganHang, double tienRut)
//        {
//            nganHang.Balance -= tienRut;
//            Console.WriteLine("Rut tien thanh cong");
//        }
//        public static void ChuyenTien(NganHang nganHang1, NganHang nganHang2, double tienChuyen)
//        {
//            nganHang1.Balance -= tienChuyen;
//            nganHang2.Balance += tienChuyen;
//            Console.WriteLine("Chuyen tien thanh cong ");
//        }

//        public static void ShowBalace(NganHang[] nganHang)
//        {
//            Console.Write("Nhap so tai khoan : ");
//            long stk = long.Parse(Console.ReadLine());
//            foreach (var item in nganHang)
//            {
//                if (item != null)
//                {
//                    if (CheckStk(item, stk))
//                    {
//                        Console.WriteLine(item.Balance);
//                    }
//                }
//            }
//        }
//    }
//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            NganHang[] nganHang = new NganHang[100];
//            int index = 0;
//            string key;
//            bool end = true;
//            while (end)
//            {
//                Console.WriteLine("********************************************");
//                Console.WriteLine("* 1 : Them tai khoan moi                   *");
//                Console.WriteLine("* 2 : Kiem tra so du                       *");
//                Console.WriteLine("* 3 : Nap tien                             *");
//                Console.WriteLine("* 4 : Rut tien                             *");
//                Console.WriteLine("* 5 : Chuyen tien                          *");
//                Console.WriteLine("* 6 : Show danh sach                       *");
//                Console.WriteLine("* 7 : End                                  *");
//                Console.WriteLine("********************************************");

//                Console.Write("Nhap lua chon : ");
//                key = Console.ReadLine();
//                if (int.TryParse(key, out int newKey) == false)
//                {
//                    Console.WriteLine("Nhap sai lua chon.");
//                    continue;
//                }
//                switch (newKey)
//                {
//                    case 1:
//                        nganHang[index++] = ThemMoi();
//                        break;
//                    case 2:

//                        NganHang.ShowBalace(nganHang);
//                        break;
//                    case 3:
//                        NganHang.NapTien(nganHang);
//                        break;
//                    case 4:
//                        Console.Write("Nhap so tai khoan : ");
//                        long searchStk = long.Parse(Console.ReadLine());
//                        for (int i = 0; i < index; i++)
//                        {
//                            if (NganHang.CheckStk(nganHang[i], searchStk))
//                            {
//                                QuyTrinhRutTien(nganHang, i);

//                                double amount = NhapSoTien(nganHang, i);

//                                NganHang.RutTien(nganHang[i], amount);

//                                break;
//                            }
//                            else
//                            {
//                                if (index - i == 1)
//                                {
//                                    Console.WriteLine("Khong ton tai stk");
//                                }
//                            }
//                        }
//                        break;
//                    case 5:
//                        Console.Write("Nhap so tai khoan nguon : ");
//                        searchStk = long.Parse(Console.ReadLine());
//                        for (int i = 0; i < index; i++)
//                        {
//                            if (NganHang.CheckStk(nganHang[i], searchStk))
//                            {
//                                QuyTrinhRutTien(nganHang, i);

//                                double amount = NhapSoTien(nganHang, i);

//                                Console.Write("Nhap tai khoan dich : ");
//                                searchStk = long.Parse(Console.ReadLine());
//                                for (int j = 0; j < index; j++)
//                                {
//                                    if (NganHang.CheckStk(nganHang[j], searchStk))
//                                    {
//                                        NganHang.ChuyenTien(nganHang[i], nganHang[j], amount);
//                                        break; // Tat ca dieu kien dung thuc hien chuyen tien out vong lap con
//                                    }
//                                    else
//                                    {
//                                        if (index - j == 1)
//                                        {
//                                            Console.WriteLine("Khong ton tai stk dich");

//                                        }
//                                    }
//                                }
//                                break; // Vong lap con dung da thuc hien xong chuyen tien out vong lap ngaoi
//                            }
//                            else
//                            {
//                                if (index - i == 1)
//                                {
//                                    Console.WriteLine("Khong ton tai stk nguon");
//                                }
//                            }
//                        }
//                        break;
//                    case 6:
//                        ShowDanhSach(nganHang, index);
//                        break;
//                    case 7:
//                        end = false;
//                        break;
//                    default:
//                        Console.WriteLine("Khong ton tai lua chon.");
//                        break;

//                }
//            }
//        }
//        private static void ShowDanhSach(NganHang[] nganHang, int index)
//        {
//            var titleStk = "So Tai Khoan";
//            var titleName = "Ten Khach Hang";
//            var titleBalance = "So Du";
//            var titleBankName = "Ten Ngan Hang";
//            var titleValidMonth = "Thang Het Han";
//            var titleValidYear = "Nam Het Han";
//            var titlePin = "Ma PIN";
//            Console.WriteLine($"{titleStk,-30} {titleName,-30} {titleBalance,-30} {titleBankName,-30} {titleValidMonth,-30} {titleValidYear,-30} {titlePin,-30} ");
//            for (int i = 0; i < index; i++)
//            {
//                Console.WriteLine($"{nganHang[i].STK,-30} {nganHang[i].Name,-30} {nganHang[i].Balance,-30} {nganHang[i].BankName,-30} {nganHang[i].ValidMonth,-30} {nganHang[i].ValidYear,-30} {nganHang[i].Pin,-30} ");
//            }
//        }

//        private static bool QuyTrinhRutTien(NganHang[] nganHang, int index)
//        {
//            Console.Write("Nhap ma PIN : ");
//            int pinSearch = int.Parse(Console.ReadLine());
//            while (pinSearch != nganHang[index].Pin)
//            {
//                Console.Write("Ma PIN sai moi nhap lai : ");
//                pinSearch = int.Parse(Console.ReadLine());
//            }
//            return true;

//        }
//        public static double NhapSoTien(NganHang[] nganHang, int index)
//        {
//            double amount;
//            Console.Write("Nhap so tien : ");
//            amount = double.Parse(Console.ReadLine());
//            while (amount > nganHang[index].Balance || nganHang[index].Balance - amount < 50000)
//            {
//                Console.Write("Khong du so du moi nhap lai so tien : ");
//                amount = double.Parse(Console.ReadLine());
//            }
//            return amount;
//        }
//        public static NganHang ThemMoi()
//        {
//            Console.Write("Nhap stk moi : ");
//            long stk = long.Parse(Console.ReadLine());

//            Console.Write("Nhap ten cua ban : ");
//            string name = Console.ReadLine();

//            Console.Write("Nhap so du : ");
//            double banlace = double.Parse(Console.ReadLine());
//            while (banlace <= 50000)
//            {
//                Console.Write("Nhap so du tren 50000 : ");
//                double newBalance = double.Parse(Console.ReadLine());
//                banlace = newBalance;
//            }

//            Console.Write("Nhap ten ngan hang : ");
//            string bankName = Console.ReadLine();


//            Console.Write("Nhap thang het hang : ");
//            int validMonth = int.Parse(Console.ReadLine());

//            Console.Write("Nhap thang nam hang : ");
//            int validYear = int.Parse(Console.ReadLine());

//            Console.Write("Nhap ma PIN 6 so : ");
//            int pin = int.Parse(Console.ReadLine());

//            char[] pinLength = pin.ToString().ToCharArray();
//            while (pinLength.Length != 6)
//            {
//                Console.Write("Ma PIN khong hop le moi nhap lai : ");
//                int newPin = int.Parse(Console.ReadLine());
//                pin = newPin;
//                pinLength = pin.ToString().ToCharArray();

//            }
//            NganHang nganHang = new NganHang(stk, name, banlace, bankName, validMonth, validYear, pin);
//            return nganHang;
//        }
//    }
//    #endregion
//    #region Bài 5 :
//    public class Student
//    {
//        public Student(int id, string firstName, string midName, string lastName, string ward, string city, double gpa, string major)
//        {
//            Id = id;
//            FirstName = firstName;
//            MidName = midName;
//            LastName = lastName;
//            Ward = ward;
//            City = city;
//            Gpa = gpa;
//            Major = major;
//        }
//        public int Id { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Ward { get; set; }
//        public string MidName { get; set; }
//        public string City { get; set; }
//        public double Gpa { get; set; }
//        public string Major { get; set; }
//        public static void SapXepDiem(Student[] students)
//        {
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].Gpa < students[j].Gpa)
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

//        public static void SapXepTen(Student[] students)
//        {
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].LastName.CompareTo(students[j].LastName) > 0)
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

//        internal static void SapXepHo(Student[] students)
//        {
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].FirstName.CompareTo(students[j].FirstName) < 0)
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
//        public static void ShowStudent(Student[] students)
//        {
//            var titleId = "Ma Sinh Vien";
//            var titleFirstName = "Ho";
//            var titleMidName = "Ten Dem";
//            var titleLastName = "Ten";
//            var titleWard = "Phuong";
//            var titleCity = "Thanh Pho";
//            var titleGpa = "Diem trung binh";
//            var titleMajor = "Chuyen Nganh";
//            Console.WriteLine($"{titleId,-20} {titleFirstName,-20} {titleMidName,-20} {titleLastName,-20} {titleWard,-20} {titleCity,-20} {titleGpa,-20} {titleMajor,-20} ");
//            foreach (var item in students)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Id,-20} {item.FirstName,-20} {item.MidName,-20} {item.LastName,-20} {item.Ward,-20} {item.City,-20} {item.Gpa,-20} {item.Major,-20} ");
//                }
//            }

//        }

//        internal static void TimKiemTen(Student[] students, string searchName)
//        {
//            Student[] searchedStudent = new Student[students.Length];
//            int index = 0;
//            foreach (Student item in students)
//            {
//                if (item.LastName == searchName && item != null)
//                {
//                    searchedStudent[index++] = item;
//                }
//            }
//            ShowStudent(searchedStudent);
//        }

//        public static void TimKiemTinh(Student[] students, string searchWard)
//        {
//            int index = 0;

//            Student[] searchedStudent = new Student[students.Length];
//            foreach (Student item in students)
//            {
//                if (item.Ward == searchWard && item != null)
//                {
//                    searchedStudent[index++] = item;
//                }
//            }
//            ShowStudent(searchedStudent);
//        }

//        internal static void XoaSinhVien(Student[] students, int searchId, ref int index)
//        {
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null && students[i].Id == searchId)
//                {
//                    for (int j = i; j < students.Length - 1; j++)
//                    {
//                        students[j] = students[j + 1];
//                    }
//                    index--;
//                }
//            }
//        }
//        public class ListStudent
//        {
//            public ListStudent(string ward, int count)
//            {
//                Ward = ward;
//                Count = count;
//            }
//            public string Ward { get; set; }
//            public int Count { get; set; }
//        }

//        internal static void LietKeSinhVienTheoTinh(Student[] students)
//        {
//            ListStudent[] listStudents = new ListStudent[students.Length];
//            int index = 0;
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    if (CheckStudent(listStudents, index, students[i].Ward))
//                    {
//                        listStudents[index] = new ListStudent(students[i].Ward, CountWard(students, students[i].Ward));
//                        index++;
//                    }
//                }
//            }
//            for (int i = 0; i < listStudents.Length; i++)
//            {
//                if (listStudents[i] != null)
//                {
//                    for (int j = i + 1; j < listStudents.Length; j++)
//                    {
//                        if (listStudents[j] != null)
//                        {
//                            if (listStudents[i].Count < listStudents[j].Count)
//                            {
//                                ListStudent tmp = listStudents[i];
//                                listStudents[i] = listStudents[j];
//                                listStudents[j] = tmp;
//                            }
//                        }
//                    }
//                }
//            }
//            for (int i = 0; i < listStudents.Length; i++)
//            {
//                if (listStudents[i] != null)
//                {
//                    Console.WriteLine($"{listStudents[i].Ward} {listStudents[i].Count}");
//                }

//            }
//        }
//        private static int CountWard(Student[] students, string ward)
//        {
//            int count = 0;
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    if (students[i].Ward == ward)
//                    {
//                        count++;
//                    }
//                }
//            }
//            return count;
//        }

//        private static bool CheckStudent(ListStudent[] students, int current, string ward)
//        {
//            for (int i = 0; i < current; i++)
//            {
//                if (students[i].Ward == ward)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }


//        internal static void SuaDiem(Student[] students, int searchId)
//        {
//            foreach (Student item in students)
//            {
//                if (item != null && item.Id == searchId)
//                {
//                    Console.Write("Nhap so diem moi : ");
//                    double newGpa = double.Parse(Console.ReadLine());
//                    item.Gpa = newGpa;
//                }
//            }
//        }
//    }
//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            Student[] students = new Student[10];
//            int index = 0;
//            int key;
//            bool end = true;

//            while (end)
//            {
//                Console.WriteLine("************************************************************");
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
//                Console.WriteLine("************************************************************");

//                Console.WriteLine("Nhap lua chon : ");
//                key = int.Parse(Console.ReadLine());
//                switch (key)
//                {
//                    case 1:
//                        students[index++] = ThemMoi();
//                        break;
//                    case 2:
//                        Student.ShowStudent(students);
//                        break;
//                    case 3:
//                        Student.SapXepDiem(students);
//                        break;
//                    case 4:
//                        Student.SapXepTen(students);
//                        break;
//                    case 5:

//                        if (CheckDiem(students))
//                        {
//                            Student.SapXepDiem(students);
//                            for (int i = 0; i < students.Length; i++)
//                            {
//                                if (students[i] != null)
//                                {
//                                    for (int j = 0; j < students.Length; j++)
//                                    {
//                                        if (students[j] != null)
//                                        {
//                                            if (students[i].Gpa == students[j].Gpa && students[i].LastName.CompareTo(students[j].LastName) < 0)
//                                            {
//                                                Student tmp = students[i];
//                                                students[i] = students[j];
//                                                students[j] = tmp;
//                                            }
//                                            else if (students[i].Gpa == students[j].Gpa && students[i].LastName.CompareTo(students[j].LastName) == 0 && students[i].FirstName.CompareTo(students[j].FirstName) > 0)
//                                            {
//                                                Student tmp = students[i];
//                                                students[i] = students[j];
//                                                students[j] = tmp;
//                                            }
//                                        }

//                                    }
//                                }

//                            }
//                        }
//                        else if (CheckTen(students))
//                        {
//                            Student.SapXepTen(students);
//                        }
//                        else
//                        {
//                            Student.SapXepDiem(students);
//                        }
//                        break;
//                    case 6:
//                        Console.Write("Nhap ten sinh vien can tim : ");
//                        string searchName = Console.ReadLine();
//                        Student.TimKiemTen(students, searchName);
//                        break;
//                    case 7:
//                        Console.Write("Nhap ten sinh vien can tim : ");
//                        string searchWard = Console.ReadLine();

//                        Student.TimKiemTinh(students, searchWard);
//                        break;
//                    case 8:
//                        Console.Write("Nhap ma sinh vien can xoa : ");
//                        int searchId = int.Parse(Console.ReadLine());
//                        Student.XoaSinhVien(students, searchId, ref index);
//                        break;
//                    case 9:
//                        Student.LietKeSinhVienTheoTinh(students);
//                        break;
//                    case 10:
//                        Console.Write("Nhap ma sinh vien can sua : ");
//                        searchId = int.Parse(Console.ReadLine());
//                        Student.SuaDiem(students, searchId);
//                        break;
//                    case 11:
//                        end = false;
//                        break;
//                    default:
//                        Console.WriteLine("sai");
//                        break;
//                }
//            }

//        }
//        private static bool CheckTen(Student[] students)
//        {

//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].LastName != students[j].LastName)
//                            {
//                                return true;
//                            }
//                        }
//                    }
//                }
//            }
//            return false;
//        }

//        private static bool CheckDiem(Student[] students)
//        {

//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    for (int j = i + 1; j < students.Length; j++)
//                    {
//                        if (students[j] != null)
//                        {
//                            if (students[i].Gpa == students[j].Gpa)
//                            {
//                                return true;
//                            }
//                        }

//                    }
//                }

//            }
//            return false;
//        }

//        private static Student ThemMoi()
//        {
//            Console.Write("Nhap ma sinh vien : ");

//            int id = int.Parse(Console.ReadLine());

//            Console.Write("Nhap ho : ");

//            string firstName = Console.ReadLine();

//            Console.Write("Nhap ten dem : ");

//            string midName = Console.ReadLine();

//            Console.Write("Nhap ten : ");

//            string lastName = Console.ReadLine();

//            Console.Write("Nhap tinh thanh : ");

//            string ward = Console.ReadLine();

//            Console.Write("Nhap thanh pho : ");

//            string city = Console.ReadLine();

//            Console.Write("Nhap diem trung binh : ");

//            double gpa = double.Parse(Console.ReadLine());

//            Console.Write("Nhap chuyen nganh : ");

//            string major = Console.ReadLine();


//            return new Student(id, firstName, midName, lastName, ward, city, gpa, major);

//        }
//    }
//    #endregion

//}


