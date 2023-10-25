using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chương_5
{
    internal class kieudulieustruct
    {
        #region Bài 1 :
        //struct Point
        //{
        //    public int X;
        //    public int Y;
        //}
        //static double CalDistance(Point p1, Point p2)
        //{
        //    int dx = p1.X - p2.X;
        //    int dy = p1.Y - p2.Y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}
        //static void Main(string[] args)
        //{
        //    Point point1, point2;
        //    Console.WriteLine("Nhap toa do diem 1 : ");
        //    Console.Write("X : ");
        //    point1.X = int.Parse(Console.ReadLine());
        //    Console.Write("Y : ");
        //    point1.Y = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Nhap toa do diem 2 : ");
        //    Console.Write("X : ");
        //    point2.X = int.Parse(Console.ReadLine());
        //    Console.Write("Y : ");
        //    point2.Y = int.Parse(Console.ReadLine());
        //    Console.Write(CalDistance(point1, point2));
        //    Console.WriteLine();
        //}
        #endregion
        #region Bài 2 :
        //struct Point
        //{
        //    public Point (int x, int y)
        //    {
        //       X = x;
        //       Y = y;
        //    }
        //    public int X;
        //    public int Y;
        //}
        //static int Chuvi(Point p1)
        //{
        //    int chuvi = (p1.X + p1.Y) / 2;
        //    return chuvi;
        //}
        //static int DienTich(Point p1)
        //{
        //    int dientich = p1.X * p1.Y;
        //    return dientich;
        //}
        //static void Main(string[] args)
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    Point p1 = new Point(a,b);
        //    Console.WriteLine($"Chu vi la : {Chuvi(p1)}");
        //    Console.WriteLine($"Dien tich la : {DienTich(p1)}");    
        //}
        #endregion
        #region Bài 3 :
        //struct Point
        //{
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public int X;
        //    public int Y;

        //}
        //struct TamGiac
        //{
        //    public TamGiac(Point x, Point y, Point z)
        //    {
        //        A = x;
        //        B = y;
        //        C = z;
        //    }
        //    public Point A { get; set; }
        //    public Point B { get; set; }
        //    public Point C { get; set; }
        //}

        //static double AB(TamGiac tamgiac)
        //{
        //    double aB = Math.Sqrt(Math.Pow(tamgiac.A.X - tamgiac.B.X, 2) + Math.Pow(tamgiac.A.Y - tamgiac.B.Y, 2));

        //    return aB;
        //}
        //static double AC(TamGiac tamgiac)
        //{
        //    double aC = Math.Sqrt(Math.Pow(tamgiac.A.X - tamgiac.C.X, 2) + Math.Pow(tamgiac.A.Y - tamgiac.C.Y, 2));

        //    return aC;
        //}
        //static double BC(TamGiac tamgiac)
        //{
        //    double bC = Math.Sqrt(Math.Pow(tamgiac.B.X - tamgiac.C.X, 2) + Math.Pow(tamgiac.B.Y - tamgiac.C.Y, 2));

        //    return bC;
        //}
        //static double ChuVi(TamGiac tamgiac)
        //{
        //    double chuVi = AB(tamgiac) + AC(tamgiac) + BC(tamgiac);
        //    return chuVi;
        //}
        //static double ChieuCao(TamGiac tamgiac)
        //{
        //    double p = ChuVi(tamgiac) / 2;
        //    double h = 2 * (Math.Sqrt(p * (p - AB(tamgiac) * (p - AC(tamgiac) * (p - BC(tamgiac)) / 2))));
        //    return h;
        //}
        //static double DienTich(TamGiac tamgiac)
        //{
        //    double p = ChuVi(tamgiac) / 2;
        //    double dienTich = (p * ChieuCao(tamgiac)) / 2;
        //    return dienTich;
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Nhap A: ");
        //    var element1 = Console.ReadLine().Split(' ');
        //    Point A = new Point(int.Parse(element1[0]), int.Parse(element1[1]));

        //    Console.Write("Nhap B: ");
        //    var element2 = Console.ReadLine().Split(' ');
        //    Point B = new Point(int.Parse(element2[0]), int.Parse(element2[1]));

        //    Console.Write("Nhap C: ");
        //    var element3 = Console.ReadLine().Split(' ');
        //    Point C = new Point(int.Parse(element3[0]), int.Parse(element3[1]));

        //    TamGiac tamGiac = new TamGiac(A, B, C);

        //    Console.WriteLine($"Chu vi tam giac la : {Math.Round(ChuVi(tamGiac), 3)} ");
        //    Console.WriteLine($"Dien tich tam giac la : {Math.Round(DienTich(tamGiac), 3)} ");
        //}
        #endregion
        #region Bài 4 :
        //struct DayOfWeek
        //{
        //    public DayOfWeek(int date, string english, string vnese)
        //    {
        //        DATECODE = date;
        //        NAME = english;
        //        TEN = vnese;
        //    }
        //    public int DATECODE;
        //    public string NAME;
        //    public string TEN;
        //}                
        //static void Main(string[] args)
        //{
        //    DayOfWeek[] dayOfWeeks = new DayOfWeek[] 
        //    {
        //    new DayOfWeek(1, "Monday","Thu hai"),
        //    new DayOfWeek(2, "Tuesday","Thu ba"),
        //    new DayOfWeek(3, "Wednesday","Thu tu"),
        //    new DayOfWeek(4, "Thursday","Thu nam"),
        //    new DayOfWeek(5, "Friday","Thu sau"),
        //    new DayOfWeek(6, "Saturday","Thu bay"),
        //    new DayOfWeek(7, "Sunday","Chu nhat")
        //    };
        //    Console.Write("Chon ngay tu 1-7 : ");
        //    int day = int.Parse(Console.ReadLine());

        //    if(day >= 1 && day <= dayOfWeeks.Length)
        //    {
        //        DayOfWeek selectedDay = dayOfWeeks[day - 1];
        //        Console.WriteLine($"{selectedDay.DATECODE} : {selectedDay.NAME} - {selectedDay.TEN}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid");
        //    }
        //}
        #endregion
        #region Bài 5 :
        //struct Zodiac
        //{
        //    public Zodiac(int startDate, int startMonth, int endDate, int endMonth, string zodiacName)
        //    {
        //        StartDay = startDate;
        //        StarMonth = startMonth;
        //        EndDay = endDate;
        //        EndMonth = endMonth;
        //        ZodiacName = zodiacName;
        //    }
        //    public int StartDay { get; set; }
        //    public int StarMonth { get; set; }
        //    public int EndDay { get; set; }
        //    public int EndMonth { get; set; }
        //    public string ZodiacName { get; set; }
        //}
        //static void Main(string[] args)
        //{
        //    Zodiac[] zodiacs = new Zodiac[]
        //    {
        //        new Zodiac (21,3,20,4,"Bach Duong"),
        //        new Zodiac (21,4,20,5,"Kim Nguu"),
        //        new Zodiac (21,5,20,6,"Song Tu"),
        //        new Zodiac (22,6,22,7,"Cu Giai"),
        //        new Zodiac (22,7,22,8,"Su Tu"),
        //        new Zodiac (23,8,22,9,"Xu Nu"),
        //        new Zodiac (23,9,23,10,"Thien Binh"),
        //        new Zodiac (24,10,22,11,"Bo Cap"),
        //        new Zodiac (23,11,21,12,"Nhan Ma"),
        //        new Zodiac (22,12,19,1,"Ma Ket"),
        //        new Zodiac (20,1,18,2,"Bao Binh"),
        //        new Zodiac (19,2,20,3,"Song Ngu")
        //    };
        //    Console.Write("Nhap ngay va thang sinh : ");
        //    var element = Console.ReadLine().Split(' ');
        //    int date = int.Parse(element[0]);
        //    int month = int.Parse(element[1]);
        //    string cungHoangDao = Check(zodiacs, date, month);
        //    if (cungHoangDao != null)
        //    {
        //        Console.WriteLine(cungHoangDao);
        //    }
        //    else
        //    {
        //        Console.WriteLine("INVALID MONTH");
        //    }
        //}
        //static string Check(Zodiac[] zodiac, int date, int month)
        //{
        //    foreach (var item in zodiac)
        //    {
        //        if (month == item.StarMonth && date >= item.StartDay || month == item.EndMonth && date < item.EndDay)
        //        {
        //            return item.ZodiacName;
        //        }
        //    }
        //    return null;
        //}
        #endregion
        #region Bài 6 :
        //struct Name
        //{
        //    public Name(string firstName, string midName, string lastName)
        //    {
        //        FirstName = firstName;
        //        MidName = midName;
        //        LastName = lastName;
        //    }
        //    public string FirstName { get; set; }
        //    public string MidName { get; set; }
        //    public string LastName { get; set; }

        //}
        //struct Address
        //{
        //    public Address(string ward, string district, string city)
        //    {
        //        City = city;
        //        Ward = ward;
        //        District = district;
        //    }
        //    public string City { get; set; }
        //    public string Ward { get; set; }
        //    public string District { get; set; }
        //}
        //struct Grade
        //{
        //    public Grade(double engGrade, double mathGrade, double cGrade)
        //    {
        //        EngGrade = engGrade;
        //        MathhGrade = mathGrade;
        //        CGrade = cGrade;
        //    }
        //    public double EngGrade { get; set; }
        //    public double MathhGrade { get; set; }
        //    public double CGrade { get; set; }
        //}
        //struct Student
        //{
        //    public Student(Name name,Address address,Grade grade)
        //    {
        //        FullName = name;
        //        Address = address;
        //        Grade = grade;
        //    }
        //    public Name FullName { get; set; }
        //    public Address Address { get; set; }
        //    public Grade Grade { get; set;
        //    }

        //}

        //static void AddStudent()
        //{
        //    Student[] students = new Student[5];
        //    students[0].FullName.FirstName = new Student();

        //}
        //static void LuaChon()
        //{
        //    Console.WriteLine("Lua chon hanh dong  ");
        //    Console.WriteLine("1 : Them Sinh Vien  ");
        //    Console.WriteLine("2 : Danh sach sv  ");
        //    Console.WriteLine("3 : Sap xep theo diem giam dan  ");
        //    Console.WriteLine("4 : Sap xep theo diem tang dan  ");
        //    Console.WriteLine("5 : Sap xep theo diem giam dan , ho tang dan , ten tang dan  ");
        //    Console.WriteLine("6 : Tim sv theo ten  ");
        //    Console.WriteLine("7 : Tim sv theo tinh  ");
        //    Console.WriteLine("8 : Xoa sv theo ma : ");
        //    Console.WriteLine("9 : So luong sv theo tinh  ");
        //    Console.WriteLine("10 : So luong sv mon tieng anh   ");
        //    Console.WriteLine("11 : Sua diem mon C++ theo ma sv  ");
        //    Console.WriteLine("12 : Ket thuc  ");
        //}
        //static void NhapLuaChon()
        //{
        //    Console.Write("Moi ban nhap lua chon : ");
        //    int key = int.Parse(Console.ReadLine());
        //    switch (key)
        //    {
        //        case 1:
        //            AddStudent();
        //                break;
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    LuaChon();
        //    NhapLuaChon();
        //}
        #endregion
        #region Bài 7 :
        //struct Character
        //{
        //    public Character(char kyTu)
        //    {
        //        KyTu = kyTu;
        //    }
        //    public char KyTu;
        //}
        //static Character[] Input(out Character[] character)
        //{

        //    var element = Console.ReadLine().ToCharArray();
        //    character = new Character[element.Length];
        //    for (int i = 0; i < character.Length; i++)
        //    {
        //        character[i].KyTu = element[i];
        //    }
        //    return character;
        //}
        //static void ShowArray(Character[] characters)
        //{
        //    for (int i = 0; i < characters.Length; i++)
        //    {
        //        int count = 1;
        //        for (int j = i + 1; j < characters.Length; j++)
        //        {
        //            if (characters[i].KyTu == characters[j].KyTu)
        //            {
        //                count++;
        //            }
        //        }
        //        if (Check(characters, i, characters[i].KyTu))
        //        {
        //            Console.WriteLine($"{characters[i].KyTu} : {count} ");
        //        }
        //    }
        //}
        //static bool Check(Character[] characters, int current, char value)
        //{
        //    for (int i = 0; i < current; i++)
        //    {
        //        if (characters[i].KyTu == value)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //static void Main(string[] args)
        //{
        //    Input(out Character[] characters);
        //    ShowArray(characters);            
        //}
        #endregion

        //struct DayTang
        //{
        //    public DayTang(int numb)
        //    {
        //        Numb = numb;
        //    }
        //    public int Numb;
        //}
        //static DayTang[] Input(out DayTang[] dayTang)
        //{
        //    var element = Console.ReadLine().Split(' ');
        //    dayTang = new DayTang[element.Length];
        //    for (int i = 0; i < dayTang.Length; i++)
        //    {
        //        dayTang[i].Numb = int.Parse(element[i]);
        //    }
        //    return dayTang;
        //}
        //static int ShowDayTang(DayTang[] dayTang)
        //{
        //    int currentLength = 1;
        //    for (int i = 1; i < dayTang.Length; i++)
        //    {
        //        if (dayTang[i].Numb > dayTang[i - 1].Numb)
        //        {
        //            currentLength++;
        //        }
        //        else
        //        {
        //            currentLength = 1;
        //        }
        //    }

        //    return currentLength;
        //}
        //static void Main(string[] args)
        //{
        //    Input(out DayTang[] dayTang);
        //    Console.WriteLine(ShowDayTang(dayTang));            
        //}
        
    }
   
}



