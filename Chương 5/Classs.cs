using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Chương_5
{
    #region Bài 1 :
    //public class Employee
    //{
    //    public Employee(long id, string name, long phone, string pos, long pay)
    //    {
    //        ID = id;
    //        Name = name;
    //        PhoneNumb = phone;
    //        Stelle = pos;
    //        PayCheck = pay;

    //    }
    //    public long ID { get; set; }
    //    public string Name { get; set; }
    //    public long PhoneNumb { get; set; }
    //    public string Stelle { get; set; }
    //    public long PayCheck { get; set; }
    //    public void CheckIn(int hour)
    //    {
    //        Console.WriteLine($"Check in luc : {hour} ");
    //    }
    //    public void CheckOut(int hour) { Console.WriteLine($"Check out luc : {hour} "); }
    //    public void Working(string work)
    //    {
    //        Console.WriteLine(work);
    //    }
    //    public void CalLuong(int workday, long luongCung)
    //    {
    //        long newluong = (luongCung * 20) / 100;

    //        if (workday >= 22)
    //        {
    //            Console.WriteLine((workday * luongCung / 22) + newluong);
    //        }
    //        else
    //        {
    //            Console.WriteLine(workday * luongCung / 22);
    //        }
    //    }
    //}
    //public class NEW
    //{
    //    static void Main(string[] args)
    //    {

    //        Employee employee = new Employee(2132412, "abc", 3212412, "Tho xay", 5000000);
    //        Console.WriteLine(employee.Name);
    //        employee.CheckIn(7);
    //        employee.CheckOut(15);
    //        employee.Working("chong day");
    //        employee.CalLuong(22, employee.PayCheck);
    //    }
    //}
    #endregion
    #region Bài 2 :
    //public class MaTran
    //{
    //    public MaTran(int colNumb, int rowNumb)
    //    {
    //        Columm = colNumb;
    //        RowNumb = rowNumb;
    //        Value = new int[colNumb, rowNumb];
    //    }
    //    public int Columm { get; set; }
    //    public int RowNumb { get; set; }
    //    public int[,] Value { get; set; }
    //    public void ShowMaTran(int[,] maxtrix)
    //    {
    //        for (int i = 0; i < maxtrix.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < maxtrix.GetLength(1); j++)
    //            {
    //                Console.Write(maxtrix[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    public int[,] NhapMaTran(int columm, int row)
    //    {
    //        int[,] matrix = new int[columm, row];


    //        for (int i = 0; i < columm; i++)
    //        {
    //            for (int j = 0; j < row; j++)
    //            {
    //                Console.Write($"Nhap phan tu {i},{j} : ");
    //                matrix[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }

    //        return matrix;
    //    }
    //    public int[,] SumMaTran(int[,] matrix)
    //    {
    //        Console.WriteLine("Nhap ma tran : ");

    //        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];

    //        for (int i = 0; i < matrix1.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < matrix1.GetLength(1); j++)
    //            {
    //                Console.Write($"Nhap phan tu {i},{j} : ");
    //                matrix1[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //        Console.WriteLine("Ma tran vua nhap la : ");

    //        ShowMaTran(matrix1);

    //        Console.WriteLine("Tong cua ma tran 1 va 2 la : ");

    //        for (int i = 0; i < matrix.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < matrix.GetLength(1); j++)
    //            {
    //                matrix[i, j] += matrix1[i, j];
    //            }
    //        }
    //        ShowMaTran(matrix);

    //        return matrix;
    //    }
    //    public int[,] TichMaTran(int[,] matrix)
    //    {
    //        Console.WriteLine("Nhap ma tran : ");

    //        int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];

    //        for (int i = 0; i < matrix1.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < matrix1.GetLength(1); j++)
    //            {
    //                Console.Write($"Nhap phan tu {i},{j} : ");
    //                matrix1[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //        Console.WriteLine("Ma tran vua nhap la : ");

    //        ShowMaTran(matrix1);

    //        int[,] maTranTich = new int[matrix.GetLength(0), matrix1.GetLength(1)];

    //        Console.WriteLine("Tich cua ma tran 1 va 2 la : ");

    //        for (int i = 0; i < maTranTich.GetLength(1); i++)
    //        {
    //            for (int j = 0; j < maTranTich.GetLength(0); j++)
    //            {                  
    //                for (int c = 0; c < maTranTich.GetLength(0); c++)
    //                {
    //                    maTranTich[i,j] = maTranTich[i,j] + (matrix[i,c] * matrix1[c,j]);
    //                }
    //            }
    //        }

    //        ShowMaTran(maTranTich);

    //        return maTranTich;
    //    }

    //}
    //public class New
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Nhap so cot : ");
    //        int columm = int.Parse(Console.ReadLine());

    //        Console.Write("Nhap so hang : ");
    //        int row = int.Parse(Console.ReadLine());

    //        MaTran matrix = new(columm, row);

    //        int[,] a = matrix.NhapMaTran(columm, row);

    //        matrix.ShowMaTran(a);

    //        matrix.SumMaTran(a);

    //        matrix.TichMaTran(a);
    //    }
    //}
    #endregion
    #region Bài 3 :
    //public class PhanSo
    //{
    //    public PhanSo(int tuSo, int mauSo)
    //    {
    //        TuSo = tuSo;
    //        MauSo = mauSo;
    //        Value = tuSo / mauSo;
    //    }
    //    public int TuSo { get; set; }
    //    public int MauSo { get; set; }
    //    public double Value { get; set; }
    //    public PhanSo CongPhanSo(PhanSo phanSof1, PhanSo phanSof2)
    //    {
    //        Console.WriteLine("Tong la : ");

    //        PhanSo sum = new PhanSo(phanSof1.TuSo, phanSof1.MauSo);

    //        sum.TuSo = (phanSof1.TuSo * phanSof2.MauSo) + (phanSof2.TuSo * phanSof1.MauSo);

    //        sum.MauSo = phanSof1.MauSo * phanSof2.MauSo;

    //        RutGon(sum);
    //        return sum;
    //    }
    //    public PhanSo TruPhanSo(PhanSo phanSof1, PhanSo phanSof2)
    //    {
    //        Console.WriteLine("Hieu la : ");

    //        PhanSo sum = new PhanSo(phanSof1.TuSo, phanSof1.MauSo);
    //        sum.TuSo = (phanSof1.TuSo * phanSof2.MauSo) - (phanSof2.TuSo * phanSof1.MauSo);

    //        sum.MauSo = phanSof1.MauSo * phanSof2.MauSo;

    //        RutGon(sum);
    //        return sum;
    //    }
    //    public PhanSo NhanPhanSo(PhanSo phanSof1, PhanSo phanSof2)
    //    {
    //        Console.WriteLine("Tich la : ");

    //        PhanSo tich = new PhanSo(phanSof1.TuSo, phanSof1.MauSo);

    //        tich.TuSo *= phanSof2.TuSo;
    //        tich.MauSo *= phanSof2.MauSo;

    //        return tich;
    //    }
    //    public PhanSo ChiaPhanSo(PhanSo phanSof1, PhanSo phanSof2)
    //    {
    //        Console.WriteLine("Thuong la : ");
    //        PhanSo thuong = new PhanSo(phanSof1.TuSo, phanSof1.MauSo);

    //        thuong.TuSo *= phanSof2.MauSo;
    //        thuong.MauSo *= phanSof2.TuSo;

    //        RutGon(thuong);
    //        return thuong;
    //    }
    //    public PhanSo RutGon(PhanSo phanSo)
    //    {
    //        int ucln = 1;
    //        if(phanSo.TuSo > phanSo.MauSo)
    //        {
    //            for (int i = 1; i < phanSo.TuSo; i++)
    //            {
    //                if (phanSo.TuSo / i == 0 && phanSo.MauSo / i == 0)
    //                {
    //                    ucln = i;   
    //                }
    //            }
    //        }
    //        else
    //        {
    //            for (int i = 1; i <= phanSo.MauSo; i++)
    //            {
    //                if (phanSo.TuSo % i == 0 && phanSo.MauSo % i == 0)
    //                {
    //                    ucln = i;
    //                }
    //            }
    //        }

    //        phanSo.TuSo /= ucln;
    //        phanSo.MauSo /= ucln;

    //        return phanSo;
    //    }
    //    public void ShowPhanSo(PhanSo phanSo)
    //    {
    //        Console.WriteLine(phanSo.TuSo == phanSo.MauSo ? 1 : $"{phanSo.TuSo} / {phanSo.MauSo}");
    //    }
    //}
    //public class New
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Nhap tu so f1 : ");
    //        int tuSof1 = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Nhap tu so f1 : ");
    //        int mauSof1 = int.Parse(Console.ReadLine());
    //        PhanSo phanSof1 = new PhanSo(tuSof1, mauSof1);

    //        Console.Write("Nhap tu so f2 : ");
    //        int tuSof2 = int.Parse(Console.ReadLine());
    //        Console.Write("Nhap mau so f2 : ");
    //        int mauSof2 = int.Parse(Console.ReadLine());
    //        PhanSo phanSof2 = new PhanSo(tuSof2, mauSof2);

    //        PhanSo cong = phanSof1.CongPhanSo(phanSof1, phanSof2);
    //        cong.ShowPhanSo(cong);

    //        PhanSo tru = phanSof1.TruPhanSo(phanSof1, phanSof2);
    //        tru.ShowPhanSo(tru);

    //        PhanSo tich = phanSof1.NhanPhanSo(phanSof1, phanSof2);
    //        tich.ShowPhanSo(tich);

    //        PhanSo thuong = phanSof1.ChiaPhanSo(phanSof1, phanSof2);
    //        thuong.ShowPhanSo(thuong);

    //    }
    //}
    #endregion
    public class NganHang
    {
        public NganHang(long stk, string name, double balance, string bankName, int validMonth, int validYear, int pin)
        {
            STK = stk;
            Name = name;
            Balance = balance;
            BankName = bankName;
            ValidMonth = validMonth;
            ValidYear = validYear;
            Pin = pin;

        }
        public long STK { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public string BankName { get; set; }
        public int ValidMonth { get; set; }

        public int ValidYear { get; set; }

        public int Pin { get; set; }
        public bool CheckStk(long stk, NganHang nganHangs)
        {
            if (nganHangs.STK == stk)
            {
                return true;
            }
            return false;
        }
        public double NapTien(NganHang nganHang, double tienNap)
        {
            nganHang.Balance += tienNap;
            return nganHang.Balance;
        }
        public double RutTien(NganHang nganHang, double tienRut)
        {
            nganHang.Balance -= tienRut;
            return nganHang.Balance;
        }
    }

    public class New
    {
        static void Main(string[] args)
        {
            NganHang[] nganHang = new NganHang[100];
            int index = 0;
            int key;
            bool end = true;
            while (end)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("* 1 : Them tai khoan moi                   *");
                Console.WriteLine("* 2 : Kiem tra so du                       *");
                Console.WriteLine("* 3 : Nap tien                             *");
                Console.WriteLine("* 4 : Rut tien                             *");
                Console.WriteLine("* 5 : Chuyen tien                          *");
                Console.WriteLine("* 6 : Show danh sach                       *");
                Console.WriteLine("* 7 : End                                  *");
                Console.WriteLine("********************************************");

                Console.Write("Nhap lua chon : ");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        nganHang[index++] = ThemMoi();
                        break;
                    case 2:
                        Console.Write("Nhap so tai khoan : ");
                        long searchStk = long.Parse(Console.ReadLine());
                        for (int i = 0; i < index; i++)
                        {
                            if (nganHang[i].CheckStk(searchStk, nganHang[i]))
                            {
                                Console.WriteLine(nganHang[i].Balance);
                                break;
                            }
                            else
                            {

                                if (index - i == 1)
                                {
                                    Console.WriteLine("Khong ton tai stk");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Nhap so tai khoan : ");
                        searchStk = long.Parse(Console.ReadLine());
                        for (int i = 0; i < index; i++)
                        {
                            if (nganHang[i].CheckStk(searchStk, nganHang[i]))
                            {
                                Console.Write("Nhap so tien muon nap : ");
                                double napTien = long.Parse(Console.ReadLine());
                                nganHang[i].NapTien(nganHang[i], napTien);
                                break;
                            }
                            else
                            {
                                if (index - i == 1)
                                {
                                    Console.WriteLine("Khong ton tai stk");
                                }
                            }

                        }
                        break;
                    case 4:
                        Console.Write("Nhap so tai khoan : ");
                        searchStk = long.Parse(Console.ReadLine());
                        for (int i = 0; i < index; i++)
                        {
                            if (nganHang[i].CheckStk(searchStk, nganHang[i]))
                            {
                                Console.Write("Nhap ma PIN : ");
                                int pinSearch = int.Parse(Console.ReadLine());
                                while (pinSearch != nganHang[i].Pin)
                                {
                                    Console.Write("Ma PIN sai moi nhap lai : ");
                                    pinSearch = int.Parse(Console.ReadLine());
                                }

                                Console.Write("Nhap so tien muon rut : ");
                                double amount = double.Parse(Console.ReadLine());
                                while (amount > nganHang[i].Balance || nganHang[i].Balance - amount < 50000)
                                {
                                    Console.Write("Khong du so du moi nhap lai so tien : ");
                                    amount = double.Parse(Console.ReadLine());
                                }
                                nganHang[i].RutTien(nganHang[i], amount);
                            }
                            else
                            {

                                if (index - i == 1)
                                {
                                    Console.WriteLine("Khong ton tai stk");
                                }
                            }

                        }
                        break;
                }
            }

        }

        private static NganHang ThemMoi()
        {
            Console.Write("Nhap stk moi : ");
            long stk = long.Parse(Console.ReadLine());

            Console.Write("Nhap ten cua ban : ");
            string name = Console.ReadLine();

            Console.Write("Nhap so du : ");
            double banlace = double.Parse(Console.ReadLine());
            while (banlace <= 50000)
            {
                Console.Write("Nhap so du tren 50000 : ");
                double newBalance = double.Parse(Console.ReadLine());
                banlace = newBalance;
            }

            Console.Write("Nhap ten ngan hang : ");
            string bankName = Console.ReadLine();


            Console.Write("Nhap thang het hang : ");
            int validMonth = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang nam hang : ");
            int validYear = int.Parse(Console.ReadLine());

            Console.Write("Nhap ma PIN 6 so : ");
            int pin = int.Parse(Console.ReadLine());

            char[] pinLength = pin.ToString().ToCharArray();
            while (pinLength.Length != 6)
            {

                Console.Write("Ma PIN khong hop le moi nhap lai : ");
                int newPin = int.Parse(Console.ReadLine());
                pin = newPin;
                pinLength = pin.ToString().ToCharArray();

            }
            NganHang nganHang = new NganHang(stk, name, banlace, bankName, validMonth, validYear, pin);
            return nganHang;
        }
    }
}


