﻿using System;
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
    #region Bài 4 :
    //public class NganHang
    //{
    //    public NganHang(long stk, string name, double balance, string bankName, int validMonth, int validYear, int pin)
    //    {
    //        STK = stk;
    //        Name = name;
    //        Balance = balance;
    //        BankName = bankName;
    //        ValidMonth = validMonth;
    //        ValidYear = validYear;
    //        Pin = pin;

    //    }
    //    public long STK { get; set; }
    //    public string Name { get; set; }
    //    public double Balance { get; set; }

    //    public string BankName { get; set; }
    //    public int ValidMonth { get; set; }

    //    public int ValidYear { get; set; }

    //    public int Pin { get; set; }
    //    public bool CheckStk(long stk, NganHang nganHangs)
    //    {
    //        if (nganHangs.STK == stk)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public void NapTien(NganHang nganHang, double tienNap)
    //    {
    //        nganHang.Balance += tienNap;
    //        Console.WriteLine("Nap tien thanh cong");
    //    }
    //    public void RutTien(NganHang nganHang, double tienRut)
    //    {
    //        nganHang.Balance -= tienRut;
    //        Console.WriteLine("Rut tien thanh cong");
    //    }
    //    public void ChuyenTien(NganHang nganHang1, NganHang nganHang2, double tienChuyen)
    //    {
    //        nganHang1.Balance -= tienChuyen;
    //        nganHang2.Balance += tienChuyen;
    //        Console.WriteLine("Chuyen tien thanh cong ");
    //    }
    //}

    //public class New
    //{
    //    static void Main(string[] args)
    //    {
    //        NganHang[] nganHang = new NganHang[100];
    //        int index = 0;
    //        int key;
    //        bool end = true;
    //        while (end)
    //        {
    //            Console.WriteLine("********************************************");
    //            Console.WriteLine("* 1 : Them tai khoan moi                   *");
    //            Console.WriteLine("* 2 : Kiem tra so du                       *");
    //            Console.WriteLine("* 3 : Nap tien                             *");
    //            Console.WriteLine("* 4 : Rut tien                             *");
    //            Console.WriteLine("* 5 : Chuyen tien                          *");
    //            Console.WriteLine("* 6 : Show danh sach                       *");
    //            Console.WriteLine("* 7 : End                                  *");
    //            Console.WriteLine("********************************************");

    //            Console.Write("Nhap lua chon : ");
    //            key = int.Parse(Console.ReadLine());
    //            switch (key)
    //            {
    //                case 1:
    //                    nganHang[index++] = ThemMoi();
    //                    break;
    //                case 2:
    //                    Console.Write("Nhap so tai khoan : ");
    //                    long searchStk = long.Parse(Console.ReadLine());
    //                    for (int i = 0; i < index; i++)
    //                    {
    //                        if (nganHang[i].CheckStk(searchStk, nganHang[i]))
    //                        {
    //                            Console.WriteLine(nganHang[i].Balance);
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            if (index - i == 1)
    //                            {
    //                                Console.WriteLine("Khong ton tai stk");
    //                            }
    //                        }
    //                    }
    //                    break;
    //                case 3:
    //                    Console.Write("Nhap so tai khoan : ");
    //                    searchStk = long.Parse(Console.ReadLine());
    //                    for (int i = 0; i < index; i++)
    //                    {
    //                        if (nganHang[i].CheckStk(searchStk, nganHang[i]))
    //                        {
    //                            Console.Write("Nhap so tien muon nap : ");
    //                            double napTien = long.Parse(Console.ReadLine());
    //                            nganHang[i].NapTien(nganHang[i], napTien);
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            if (index - i == 1)
    //                            {
    //                                Console.WriteLine("Khong ton tai stk");
    //                            }
    //                        }

    //                    }
    //                    break;
    //                case 4:
    //                    Console.Write("Nhap so tai khoan : ");
    //                    searchStk = long.Parse(Console.ReadLine());
    //                    for (int i = 0; i < index; i++)
    //                    {
    //                        if (nganHang[i].CheckStk(searchStk, nganHang[i]))
    //                        {
    //                            QuyTrinhRutTien(nganHang, i);

    //                            double amount = NhapSoTien(nganHang, i);

    //                            nganHang[i].RutTien(nganHang[i], amount);

    //                            break;
    //                        }
    //                        else
    //                        {
    //                            if (index - i == 1)
    //                            {
    //                                Console.WriteLine("Khong ton tai stk");
    //                            }
    //                        }
    //                    }
    //                    break;
    //                case 5:
    //                    Console.Write("Nhap so tai khoan nguon : ");
    //                    searchStk = long.Parse(Console.ReadLine());
    //                    for (int i = 0; i < index; i++)
    //                    {
    //                        if (nganHang[i].CheckStk(searchStk, nganHang[i]))
    //                        {
    //                            QuyTrinhRutTien(nganHang, i);

    //                            double amount = NhapSoTien(nganHang, i);

    //                            Console.Write("Nhap tai khoan dich : ");
    //                            searchStk = long.Parse(Console.ReadLine());
    //                            for (int j = 0; j < index; j++)
    //                            {
    //                                if (nganHang[j].CheckStk(searchStk, nganHang[j]))
    //                                {
    //                                    nganHang[i].ChuyenTien(nganHang[i], nganHang[j], amount);
    //                                    break;
    //                                }
    //                                else
    //                                {
    //                                    if (index - j == 1)
    //                                    {
    //                                        Console.WriteLine("Khong ton tai stk dich");

    //                                    }
    //                                }
    //                            }
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            if (index - i == 1)
    //                            {
    //                                Console.WriteLine("Khong ton tai stk nguon");
    //                            }
    //                        }
    //                    }
    //                    break;
    //                case 6:
    //                    ShowDanhSach(nganHang, index);
    //                    break;
    //                case 7:
    //                    end = false;
    //                    break;
    //            }
    //        }

    //    }

    //    private static void ShowDanhSach(NganHang[] nganHang, int index)
    //    {
    //        var titleStk = "So Tai Khoan";
    //        var titleName = "Ten Khach Hang";
    //        var titleBalance = "So Du";
    //        var titleBankName = "Ten Ngan Hang";
    //        var titleValidMonth = "Thang Het Han";
    //        var titleValidYear = "Nam Het Han";
    //        var titlePin = "Ma PIN";
    //        Console.WriteLine($"{titleStk,-30} {titleName,-30} {titleBalance,-30} {titleBankName,-30} {titleValidMonth,-30} {titleValidYear,-30} {titlePin,-30} ");
    //        for (int i = 0; i < index; i++)
    //        {
    //            Console.WriteLine($"{nganHang[i].STK,-30} {nganHang[i].Name,-30} {nganHang[i].Balance,-30} {nganHang[i].BankName,-30} {nganHang[i].ValidMonth,-30} {nganHang[i].ValidYear,-30} {nganHang[i].Pin,-30} ");
    //        }
    //    }

    //    private static bool QuyTrinhRutTien(NganHang[] nganHang, int index)
    //    {
    //        Console.Write("Nhap ma PIN : ");
    //        int pinSearch = int.Parse(Console.ReadLine());
    //        while (pinSearch != nganHang[index].Pin)
    //        {
    //            Console.Write("Ma PIN sai moi nhap lai : ");
    //            pinSearch = int.Parse(Console.ReadLine());
    //        }
    //        return true;

    //    }
    //    public static double NhapSoTien(NganHang[] nganHang, int index)
    //    {
    //        double amount;
    //        Console.Write("Nhap so tien : ");
    //        amount = double.Parse(Console.ReadLine());
    //        while (amount > nganHang[index].Balance || nganHang[index].Balance - amount < 50000)
    //        {
    //            Console.Write("Khong du so du moi nhap lai so tien : ");
    //            amount = double.Parse(Console.ReadLine());
    //        }
    //        return amount;
    //    }
    //    private static NganHang ThemMoi()
    //    {
    //        Console.Write("Nhap stk moi : ");
    //        long stk = long.Parse(Console.ReadLine());

    //        Console.Write("Nhap ten cua ban : ");
    //        string name = Console.ReadLine();

    //        Console.Write("Nhap so du : ");
    //        double banlace = double.Parse(Console.ReadLine());
    //        while (banlace <= 50000)
    //        {
    //            Console.Write("Nhap so du tren 50000 : ");
    //            double newBalance = double.Parse(Console.ReadLine());
    //            banlace = newBalance;
    //        }

    //        Console.Write("Nhap ten ngan hang : ");
    //        string bankName = Console.ReadLine();


    //        Console.Write("Nhap thang het hang : ");
    //        int validMonth = int.Parse(Console.ReadLine());

    //        Console.Write("Nhap thang nam hang : ");
    //        int validYear = int.Parse(Console.ReadLine());

    //        Console.Write("Nhap ma PIN 6 so : ");
    //        int pin = int.Parse(Console.ReadLine());

    //        char[] pinLength = pin.ToString().ToCharArray();
    //        while (pinLength.Length != 6)
    //        {

    //            Console.Write("Ma PIN khong hop le moi nhap lai : ");
    //            int newPin = int.Parse(Console.ReadLine());
    //            pin = newPin;
    //            pinLength = pin.ToString().ToCharArray();

    //        }
    //        NganHang nganHang = new NganHang(stk, name, banlace, bankName, validMonth, validYear, pin);
    //        return nganHang;
    //    }
    //}
    #endregion
    #region Bài 5 :
    //public class Student
    //{
    //    public Student(int id, string firstName, string midName, string lastName, string ward, string city, double gpa, string major)
    //    {
    //        Id = id;
    //        FirstName = firstName;
    //        MidName = midName;
    //        LastName = lastName;
    //        Ward = ward;
    //        City = city;
    //        Gpa = gpa;
    //        Major = major;
    //    }
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Ward { get; set; }
    //    public string MidName { get; set; }
    //    public string City { get; set; }
    //    public double Gpa { get; set; }
    //    public string Major { get; set; }
    //    public void SapXepDiem(Student[] students, int index)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            for (int j = i + 1; j < index; j++)
    //            {
    //                if (students[i].Gpa < students[j].Gpa)
    //                {
    //                    Student tmp = students[i];
    //                    students[i] = students[j];
    //                    students[j] = tmp;
    //                }
    //            }
    //        }
    //    }

    //    public void SapXepTen(Student[] students, int index)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            for (int j = i + 1; j < index; j++)
    //            {
    //                if (students[i].LastName.CompareTo(students[j].LastName) > 0)
    //                {
    //                    Student tmp = students[i];
    //                    students[i] = students[j];
    //                    students[j] = tmp;
    //                }
    //            }
    //        }
    //    }

    //    internal void SapXepHo(Student[] students, int index)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            for (int j = i + 1; j < index; j++)
    //            {
    //                if (students[i].FirstName.CompareTo(students[j].FirstName) < 0)
    //                {
    //                    Student tmp = students[i];
    //                    students[i] = students[j];
    //                    students[j] = tmp;
    //                }
    //            }
    //        }
    //    }
    //    public void ShowStudent(Student[] students, int index)
    //    {
    //        var titleId = "Ma Sinh Vien";
    //        var titleFirstName = "Ho";
    //        var titleMidName = "Ten Dem";
    //        var titleLastName = "Ten";
    //        var titleWard = "Phuong";
    //        var titleCity = "Thanh Pho";
    //        var titleGpa = "Diem trung binh";
    //        var titleMajor = "Chuyen Nganh";
    //        Console.WriteLine($"{titleId,-20} {titleFirstName,-20} {titleMidName,-20} {titleLastName,-20} {titleWard,-20} {titleCity,-20} {titleGpa,-20} {titleMajor,-20} ");
    //        for (int i = 0; i < index; i++)
    //        {
    //            Console.WriteLine($"{students[i].Id,-20} {students[i].FirstName,-20} {students[i].MidName,-20} {students[i].LastName,-20} {students[i].Ward,-20} {students[i].City,-20} {students[i].Gpa,-20} {students[i].Major,-20} ");
    //        }
    //    }

    //    internal void TimKiemTen(Student[] students, int index, string searchName)
    //    {
    //        int tmp = 0;

    //        Student[] searchedStudent = new Student[index];
    //        for (int i = 0; i < index; i++)
    //        {
    //            if (students[i].LastName == searchName)
    //            {
    //                searchedStudent[tmp] = students[i];
    //                tmp++;
    //            }
    //        }
    //        ShowStudent(searchedStudent, tmp);
    //    }

    //    internal void TimKiemTinh(Student[] students, int index, string searchWard)
    //    {
    //        int tmp = 0;

    //        Student[] searchedStudent = new Student[index];
    //        for (int i = 0; i < index; i++)
    //        {
    //            if (students[i].Ward == searchWard)
    //            {
    //                searchedStudent[tmp] = students[i];
    //                tmp++;
    //            }
    //        }
    //        ShowStudent(searchedStudent, tmp);
    //    }

    //    internal void XoaSinhVien(Student[] students, ref int index, int searchId)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            for (int j = 0; j < index; j++)
    //            {
    //                if (students[i].Id == searchId)
    //                {
    //                    students[j] = students[j + 1];
    //                    index--;
    //                }
    //            }
    //        }
    //    }

    //    internal void LietKeSinhVienTheoTinh(Student[] students, int index)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            int count = 1;
    //            for (int j = i + 1; j < index; j++)
    //            {
    //                if (students[i].City == students[j].City)
    //                {
    //                    count++;
    //                }
    //            }
    //            if (CheckTinh(students, i, students[i].City))
    //            {
    //                Console.WriteLine($"{students[i].City} : {count}");
    //            }
    //        }
    //    }

    //    private bool CheckTinh(Student[] students, int current, string city)
    //    {
    //        for (int i = 0; i < current; i++)
    //        {
    //            if (students[i].City == city)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }

    //    internal void SuaDiem(Student[] students, int index, int searchId)
    //    {
    //        for (int i = 0; i < index; i++)
    //        {
    //            if (students[i].Id == searchId)
    //            {
    //                Console.Write("Nhap so diem moi : ");
    //                double newGpa = double.Parse(Console.ReadLine());
    //                students[i].Gpa = newGpa;
    //            }
    //        }
    //    }
    //}
    //public class New
    //{
    //    static void Main(string[] args)
    //    {
    //        Student[] students = new Student[100];
    //        int index = 0;
    //        int key;
    //        bool end = true;

    //        while (end)
    //        {
    //            Console.WriteLine("************************************************************");
    //            Console.WriteLine("* 1.Them Sinh Vien");
    //            Console.WriteLine("* 2.Danh sach sinh vien");
    //            Console.WriteLine("* 3.Sap xep sinh vien theo diem giam dan");
    //            Console.WriteLine("* 4.Sap xep sinh vien theo ten tang dan");
    //            Console.WriteLine("* 5.Sap xep sinh vien theo ten/ho tang dan || Diem TB giam dan");
    //            Console.WriteLine("* 6.Tim sinh vien theo ten");
    //            Console.WriteLine("* 7.Tim sinh vien theo tinh");
    //            Console.WriteLine("* 8.Xoa sinh vien theo ma");
    //            Console.WriteLine("* 9.Liet ke sinh vien theo tinh");
    //            Console.WriteLine("* 10.Sua diem sinh vien theo ma");
    //            Console.WriteLine("* 11.End");
    //            Console.WriteLine("************************************************************");

    //            Console.WriteLine("Nhap lua chon : ");
    //            key = int.Parse(Console.ReadLine());
    //            switch (key)
    //            {
    //                case 1:
    //                    students[index++] = ThemMoi();
    //                    break;
    //                case 2:
    //                    students[0].ShowStudent(students, index);
    //                    break;
    //                case 3:
    //                    students[0].SapXepDiem(students, index);
    //                    break;
    //                case 4:
    //                    students[0].SapXepTen(students, index);
    //                    break;
    //                case 5:

    //                    if (CheckDiem(students, students[0], index))
    //                    {
    //                        students[0].SapXepDiem(students, index);
    //                    }
    //                    else if (CheckTen(students, students[0], index))
    //                    {
    //                        students[0].SapXepTen(students, index);
    //                    }
    //                    else
    //                    {
    //                        students[0].SapXepHo(students, index);
    //                    }
    //                    break;
    //                case 6:
    //                    Console.Write("Nhap ten sinh vien can tim : ");
    //                    string searchName = Console.ReadLine();
    //                    students[0].TimKiemTen(students, index, searchName);
    //                    break;
    //                case 7:
    //                    Console.Write("Nhap ten sinh vien can tim : ");
    //                    string searchWard = Console.ReadLine();
    //                    students[0].TimKiemTinh(students, index, searchWard);
    //                    break;
    //                case 8:
    //                    Console.Write("Nhap ma sinh vien can xoa : ");
    //                    int searchId = int.Parse(Console.ReadLine());
    //                    students[0].XoaSinhVien(students, ref index, searchId);
    //                    break;
    //                case 9:
    //                    students[0].LietKeSinhVienTheoTinh(students, index);
    //                    break;
    //                case 10:
    //                    Console.Write("Nhap ma sinh vien can sua : ");
    //                    searchId = int.Parse(Console.ReadLine());
    //                    students[0].SuaDiem(students, index, searchId);
    //                    break;
    //                case 11:
    //                    end = false;
    //                    break;
    //            }
    //        }

    //    }

    //    private static bool CheckTen(Student[] students, Student studentOriginal, int index)
    //    {
    //        bool check = true;
    //        for (int i = 1; i < index; i++)
    //        {
    //            if (studentOriginal.LastName == students[i].LastName)
    //            {
    //                check = false;
    //            }
    //        }
    //        return check;
    //    }

    //    private static bool CheckDiem(Student[] students, Student studentOriginal, int index)
    //    {
    //        bool check = true;
    //        for (int i = 1; i < index; i++)
    //        {
    //            if (studentOriginal.Gpa == students[i].Gpa)
    //            {
    //                check = false;
    //            }
    //        }
    //        return check;
    //    }

    //    private static Student ThemMoi()
    //    {
    //        Console.Write("Nhap ma sinh vien : ");

    //        int id = int.Parse(Console.ReadLine());

    //        Console.Write("Nhap ho : ");

    //        string firstName = Console.ReadLine();

    //        Console.Write("Nhap ten dem : ");

    //        string midName = Console.ReadLine();

    //        Console.Write("Nhap ten : ");

    //        string lastName = Console.ReadLine();

    //        Console.Write("Nhap tinh thanh : ");

    //        string ward = Console.ReadLine();

    //        Console.Write("Nhap thanh pho : ");

    //        string city = Console.ReadLine();

    //        Console.Write("Nhap diem trung binh : ");

    //        double gpa = double.Parse(Console.ReadLine());

    //        Console.Write("Nhap chuyen nganh : ");

    //        string major = Console.ReadLine();

    //        Student student = new(id, firstName, midName, lastName, ward, city, gpa, major);

    //        return student;
    //    }
    //}
    #endregion
}


