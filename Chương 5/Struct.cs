//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Http.Headers;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Metadata.W3cXsd2001;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Chương_5
//{
//    internal class kieudulieustruct
//    {
//        #region Bài 1 :
//        //struct Point
//        //{
//        //    public int X;
//        //    public int Y;
//        //}
//        //static double CalDistance(Point p1, Point p2)
//        //{
//        //    int dx = p1.X - p2.X;
//        //    int dy = p1.Y - p2.Y;
//        //    return Math.Sqrt(dx * dx + dy * dy);
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Point point1, point2;
//        //    Console.WriteLine("Nhap toa do diem 1 : ");
//        //    Console.Write("X : ");
//        //    point1.X = int.Parse(Console.ReadLine());
//        //    Console.Write("Y : ");
//        //    point1.Y = int.Parse(Console.ReadLine());
//        //    Console.WriteLine("Nhap toa do diem 2 : ");
//        //    Console.Write("X : ");
//        //    point2.X = int.Parse(Console.ReadLine());
//        //    Console.Write("Y : ");
//        //    point2.Y = int.Parse(Console.ReadLine());
//        //    Console.Write(CalDistance(point1, point2));
//        //    Console.WriteLine();
//        //}
//        #endregion
//        #region Bài 2 :
//        //struct Point
//        //{
//        //    public Point (int x, int y)
//        //    {
//        //       X = x;
//        //       Y = y;
//        //    }
//        //    public int X;
//        //    public int Y;
//        //}
//        //static int Chuvi(Point p1)
//        //{
//        //    int chuvi = (p1.X + p1.Y) / 2;
//        //    return chuvi;
//        //}
//        //static int DienTich(Point p1)
//        //{
//        //    int dientich = p1.X * p1.Y;
//        //    return dientich;
//        //}
//        //static void Main(string[] args)
//        //{
//        //    int a = int.Parse(Console.ReadLine());
//        //    int b = int.Parse(Console.ReadLine());
//        //    Point p1 = new Point(a,b);
//        //    Console.WriteLine($"Chu vi la : {Chuvi(p1)}");
//        //    Console.WriteLine($"Dien tich la : {DienTich(p1)}");    
//        //}
//        #endregion
//        #region Bài 3 :
//        //struct Point
//        //{
//        //    public Point(int x, int y)
//        //    {
//        //        X = x;
//        //        Y = y;
//        //    }
//        //    public int X;
//        //    public int Y;

//        //}
//        //struct TamGiac
//        //{
//        //    public TamGiac(Point x, Point y, Point z)
//        //    {
//        //        A = x;
//        //        B = y;
//        //        C = z;
//        //    }
//        //    public Point A { get; set; }
//        //    public Point B { get; set; }
//        //    public Point C { get; set; }
//        //}

//        //static double AB(TamGiac tamgiac)
//        //{
//        //    double aB = Math.Sqrt(Math.Pow(tamgiac.A.X - tamgiac.B.X, 2) + Math.Pow(tamgiac.A.Y - tamgiac.B.Y, 2));

//        //    return aB;
//        //}
//        //static double AC(TamGiac tamgiac)
//        //{
//        //    double aC = Math.Sqrt(Math.Pow(tamgiac.A.X - tamgiac.C.X, 2) + Math.Pow(tamgiac.A.Y - tamgiac.C.Y, 2));

//        //    return aC;
//        //}
//        //static double BC(TamGiac tamgiac)
//        //{
//        //    double bC = Math.Sqrt(Math.Pow(tamgiac.B.X - tamgiac.C.X, 2) + Math.Pow(tamgiac.B.Y - tamgiac.C.Y, 2));

//        //    return bC;
//        //}
//        //static double ChuVi(TamGiac tamgiac)
//        //{
//        //    double chuVi = AB(tamgiac) + AC(tamgiac) + BC(tamgiac);
//        //    return chuVi;
//        //}
//        //static double ChieuCao(TamGiac tamgiac)
//        //{
//        //    double p = ChuVi(tamgiac) / 2;
//        //    double h = 2 * (Math.Sqrt(p * (p - AB(tamgiac) * (p - AC(tamgiac) * (p - BC(tamgiac)) / 2))));
//        //    return h;
//        //}
//        //static double DienTich(TamGiac tamgiac)
//        //{
//        //    double p = ChuVi(tamgiac) / 2;
//        //    double dienTich = (p * ChieuCao(tamgiac)) / 2;
//        //    return dienTich;
//        //}

//        //static void Main(string[] args)
//        //{
//        //    Console.Write("Nhap A: ");
//        //    var element1 = Console.ReadLine().Split(' ');
//        //    Point A = new Point(int.Parse(element1[0]), int.Parse(element1[1]));

//        //    Console.Write("Nhap B: ");
//        //    var element2 = Console.ReadLine().Split(' ');
//        //    Point B = new Point(int.Parse(element2[0]), int.Parse(element2[1]));

//        //    Console.Write("Nhap C: ");
//        //    var element3 = Console.ReadLine().Split(' ');
//        //    Point C = new Point(int.Parse(element3[0]), int.Parse(element3[1]));

//        //    TamGiac tamGiac = new TamGiac(A, B, C);

//        //    Console.WriteLine($"Chu vi tam giac la : {Math.Round(ChuVi(tamGiac), 3)} ");
//        //    Console.WriteLine($"Dien tich tam giac la : {Math.Round(DienTich(tamGiac), 3)} ");
//        //}
//        #endregion
//        #region Bài 4 :
//        //struct DayOfWeek
//        //{
//        //    public DayOfWeek(int date, string english, string vnese)
//        //    {
//        //        DATECODE = date;
//        //        NAME = english;
//        //        TEN = vnese;
//        //    }
//        //    public int DATECODE;
//        //    public string NAME;
//        //    public string TEN;
//        //}                
//        //static void Main(string[] args)
//        //{
//        //    DayOfWeek[] dayOfWeeks = new DayOfWeek[] 
//        //    {
//        //    new DayOfWeek(1, "Monday","Thu hai"),
//        //    new DayOfWeek(2, "Tuesday","Thu ba"),
//        //    new DayOfWeek(3, "Wednesday","Thu tu"),
//        //    new DayOfWeek(4, "Thursday","Thu nam"),
//        //    new DayOfWeek(5, "Friday","Thu sau"),
//        //    new DayOfWeek(6, "Saturday","Thu bay"),
//        //    new DayOfWeek(7, "Sunday","Chu nhat")
//        //    };
//        //    Console.Write("Chon ngay tu 1-7 : ");
//        //    int day = int.Parse(Console.ReadLine());

//        //    if(day >= 1 && day <= dayOfWeeks.Length)
//        //    {
//        //        DayOfWeek selectedDay = dayOfWeeks[day - 1];
//        //        Console.WriteLine($"{selectedDay.DATECODE} : {selectedDay.NAME} - {selectedDay.TEN}");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("Invalid");
//        //    }
//        //}
//        #endregion
//        #region Bài 5 :
//        //struct Zodiac
//        //{
//        //    public Zodiac(int startDate, int startMonth, int endDate, int endMonth, string zodiacName)
//        //    {
//        //        StartDay = startDate;
//        //        StarMonth = startMonth;
//        //        EndDay = endDate;
//        //        EndMonth = endMonth;
//        //        ZodiacName = zodiacName;
//        //    }
//        //    public int StartDay { get; set; }
//        //    public int StarMonth { get; set; }
//        //    public int EndDay { get; set; }
//        //    public int EndMonth { get; set; }
//        //    public string ZodiacName { get; set; }
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Zodiac[] zodiacs = new Zodiac[]
//        //    {
//        //        new Zodiac (21,3,20,4,"Bach Duong"),
//        //        new Zodiac (21,4,20,5,"Kim Nguu"),
//        //        new Zodiac (21,5,20,6,"Song Tu"),
//        //        new Zodiac (22,6,22,7,"Cu Giai"),
//        //        new Zodiac (22,7,22,8,"Su Tu"),
//        //        new Zodiac (23,8,22,9,"Xu Nu"),
//        //        new Zodiac (23,9,23,10,"Thien Binh"),
//        //        new Zodiac (24,10,22,11,"Bo Cap"),
//        //        new Zodiac (23,11,21,12,"Nhan Ma"),
//        //        new Zodiac (22,12,19,1,"Ma Ket"),
//        //        new Zodiac (20,1,18,2,"Bao Binh"),
//        //        new Zodiac (19,2,20,3,"Song Ngu")
//        //    };
//        //    Console.Write("Nhap ngay va thang sinh : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    int date = int.Parse(element[0]);
//        //    int month = int.Parse(element[1]);
//        //    string cungHoangDao = Check(zodiacs, date, month);
//        //    if (cungHoangDao != null)
//        //    {
//        //        Console.WriteLine(cungHoangDao);
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("INVALID MONTH");
//        //    }
//        //}
//        //static string Check(Zodiac[] zodiac, int date, int month)
//        //{
//        //    foreach (var item in zodiac)
//        //    {
//        //        if (month == item.StarMonth && date >= item.StartDay || month == item.EndMonth && date < item.EndDay)
//        //        {
//        //            return item.ZodiacName;
//        //        }
//        //    }
//        //    return null;
//        //}
//        #endregion
//        #region Bài 6 :
//        //struct Name
//        //{
//        //    public Name(string firstName, string midName, string lastName)
//        //    {
//        //        FirstName = firstName;
//        //        MidName = midName;
//        //        LastName = lastName;
//        //    }
//        //    public string FirstName { get; set; }
//        //    public string MidName { get; set; }
//        //    public string LastName { get; set; }
//        //    public override string ToString() => $"{FirstName} {MidName} {LastName}";

//        //}
//        //struct Address
//        //{
//        //    public Address(string city, string ward, string district)
//        //    {
//        //        City = city;
//        //        Ward = ward;
//        //        District = district;
//        //    }
//        //    public string City { get; set; }
//        //    public string Ward { get; set; }
//        //    public string District { get; set; }
//        //    public override string ToString() => $"{City} {Ward} {District}";

//        //}
//        //struct Grade
//        //{
//        //    public Grade(double engGrade, double mathGrade, double cGrade)
//        //    {
//        //        EngGrade = engGrade;
//        //        MathhGrade = mathGrade;
//        //        CGrade = cGrade;
//        //        SumGrad = engGrade + mathGrade + cGrade;
//        //    }
//        //    public double EngGrade { get; set; }
//        //    public double MathhGrade { get; set; }
//        //    public double CGrade { get; set; }
//        //    public override string ToString() => $"{EngGrade} {MathhGrade} {CGrade}";

//        //    public double SumGrad;

//        //}
//        //struct Student
//        //{
//        //    public Student(Name name, Address address, Grade grade, int msv, string major)
//        //    {
//        //        FullName = name;
//        //        Address = address;
//        //        Grade = grade;
//        //        MaSv = msv;
//        //        Major = major;
//        //    }
//        //    public Name FullName { get; set; }
//        //    public Address Address { get; set; }
//        //    public Grade Grade { get; set; }
//        //    public int MaSv;
//        //    public string Major;

//        //}

//        //static void Main(string[] args)
//        //{
//        //    int indexStudent = 0;
//        //    Student[] students = new Student[100];
//        //    int key;

//        //    do
//        //    {
//        //        Console.WriteLine("--------------------------------------------------------------------");
//        //        Console.WriteLine("1 : Them Sinh Vien  ");
//        //        Console.WriteLine("2 : Danh sach sv  ");
//        //        Console.WriteLine("3 : Sap xep theo diem giam dan  ");
//        //        Console.WriteLine("4 : Sap xep theo ten tang dan  ");
//        //        Console.WriteLine("5 : Sap xep theo diem giam dan , ho tang dan , ten tang dan  ");
//        //        Console.WriteLine("6 : Tim sv theo ten  ");
//        //        Console.WriteLine("7 : Tim sv theo tinh  ");
//        //        Console.WriteLine("8 : Xoa sv theo ma : ");
//        //        Console.WriteLine("9 : So luong sv theo tinh  ");
//        //        Console.WriteLine("10 : So luong sv mon tieng anh   ");
//        //        Console.WriteLine("11 : Sua diem mon C++ theo ma sv  ");
//        //        Console.WriteLine("12 : Ket thuc  ");
//        //        Console.WriteLine("--------------------------------------------------------------------");
//        //        Console.Write("Moi ban nhap lua chon : ");
//        //        key = int.Parse(Console.ReadLine());
//        //        switch (key)
//        //        {
//        //            case 1:
//        //                students[indexStudent++] = AddStudent();
//        //                break;
//        //            case 2:
//        //                ShowStudent(students, indexStudent);
//        //                break;
//        //            case 3:
//        //                ShortStudentByGPA(students, indexStudent);
//        //                break;
//        //            case 4:
//        //                ShortStudentByName(students, indexStudent);
//        //                break;
//        //            case 5:
//        //                if (ShortStudentIfGPA(students, indexStudent))
//        //                {
//        //                    ShortStudentByGPA(students, indexStudent);
//        //                }
//        //                else if (ShortStudentIfLastName(students, indexStudent))
//        //                {
//        //                    ShortStudentByName(students, indexStudent);
//        //                    break;
//        //                }
//        //                else
//        //                {
//        //                    ShortStudentFirst(students, indexStudent);
//        //                }
//        //                break;
//        //            case 6:
//        //                FindStudentByName(students, indexStudent);
//        //                break;
//        //            case 7:
//        //                FindStudentByCity(students, indexStudent);
//        //                break;
//        //            case 8:
//        //                DeleteStudent(students, ref indexStudent);
//        //                break;
//        //            case 9:
//        //                ListStudentByWard(students, indexStudent);
//        //                break;
//        //                case 10:
//        //                ListStudentByEng(students, indexStudent);
//        //                break;
//        //            case 11:
//        //                FixCGrade(students, indexStudent);
//        //                break;
//        //        }
//        //    }
//        //    while (key != 12);
//        //}

//        //private static void FixCGrade(Student[] students, int indexStudent)
//        //{
//        //    Console.WriteLine("Nhap ma sinh vien muon sua diem : ");
//        //    int msv = int.Parse(Console.ReadLine());
//        //    Console.WriteLine("Nhap diem moi :");
//        //    double newCGrade = double.Parse(Console.ReadLine());

//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        if (students[i].MaSv == msv)
//        //        {
//        //            Grade grade = new Grade(students[i].Grade.EngGrade, students[i].Grade.MathhGrade,newCGrade);
//        //            students[i].Grade = grade;
//        //        }
//        //    }
//        //}

//        //private static void ListStudentByEng(Student[] students, int indexStudent)
//        //{

//        //    NewWard[] newWards = new NewWard[indexStudent];
//        //    int index = 0;
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {

//        //        if (CheckENG(students[i].Grade.EngGrade, index, newWards))
//        //        {
//        //            newWards[index].NewEng = students[i].Grade.EngGrade;
//        //            newWards[index].Count = CoutEng(students, indexStudent, students[i].Grade.EngGrade);
//        //            index++;
//        //        }
//        //    }
//        //    Array.Sort(newWards, (p1, p2) => (p2.Count - p1.Count));

//        //    for (int i = 0; i < index; i++)
//        //    {
//        //        Console.WriteLine(newWards[i].NewEng + " " + newWards[i].Count);
//        //    }
//        //}

//        //private static int CoutEng(Student[] students, int indexStudent, double eng)
//        //{
//        //    int count = 0;
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {

//        //        if (students[i].Grade.EngGrade == eng)
//        //        {
//        //            count++;
//        //        }
//        //    }
//        //    return count;
//        //}

//        //private static bool CheckENG(double engGrade, int index, NewWard[] newWards)
//        //{
//        //    for (int i = 0; i < index; i++)
//        //    {
//        //        if (engGrade == newWards[i].NewEng)
//        //        {
//        //            return false;
//        //        }
//        //    }
//        //    return true;
//        //}

//        //struct NewWard
//        //{
//        //    public string Ward { get; set; }
//        //    public int Count {  get; set; }
//        //    public double NewEng;
//        //}

//        //private static void ListStudentByWard(Student[] students, int indexStudent)
//        //{
//        //    NewWard[] newWards = new NewWard[indexStudent];
//        //    int index = 0;
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {                              

//        //        if (CheckA(students[i].Address.Ward, index, newWards)) {
//        //            newWards[index].Ward = students[i].Address.Ward;
//        //            newWards[index].Count = Cout(students, indexStudent, students[i].Address.Ward);    
//        //            index++;
//        //        }             
//        //    }
//        //    Array.Sort(newWards,(p1,p2) =>( p2.Count - p1.Count));

//        //    for (int i = 0; i < index; i++)
//        //    {
//        //        Console.WriteLine(newWards[i].Ward + "" + newWards[i].Count);
//        //    }
//        //}

//        //private static int Cout(Student[] students, int indexStudent , string student)
//        //{
//        //    int count = 0;
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {

//        //        if (students[i].Address.Ward == student)
//        //        {
//        //            count++;
//        //        }
//        //    }
//        //    return count;
//        //}

//        //private static bool CheckA(string students, int indexStudent, NewWard[] student)
//        //{
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //       if (students == student[i].Ward)
//        //        {
//        //            return false;
//        //        }
//        //    }
//        //    return true;
//        //}

//        //private static void DeleteStudent(Student[] students, ref int indexStudent)
//        //{
//        //    int msv = int.Parse(Console.ReadLine());
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i; j < indexStudent; j++)
//        //        {
//        //            if (students[i].MaSv == msv)
//        //            {
//        //                students[j] = students[j + 1];
//        //                indexStudent--;
//        //            }
//        //        }
//        //    }         
//        //}

//        //private static void FindStudentByCity(Student[] students, int indexStudent)
//        //{
//        //    Student[] a = new Student[indexStudent];
//        //    int index = 0;
//        //    Console.Write("Nhap tinh thanh : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    string newAdress = element[0] + element[1]; 
//        //    foreach (var item in students)
//        //    {
//        //        if (item.Address.City == newAdress)
//        //        {
//        //            a[index++] = item;

//        //        }   
//        //    }
//        //    ShowStudent(a, index);

//        //}

//        //private static void FindStudentByName(Student[] students, int indexStudent)
//        //{
//        //    Student[] a = new Student[indexStudent];
//        //    int index = 0;
//        //    Console.Write("Nhap ten Sv : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    string newName = element[0];
//        //    foreach (var item in students)
//        //    {
//        //        if (item.FullName.LastName == newName)
//        //        {
//        //            a[index++] = item;

//        //        }
//        //    }
//        //    ShowStudent(a, index);
//        //}

//        //private static bool ShortStudentFirst(Student[] students, int indexStudent)
//        //{
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i + 1; j < indexStudent; j++)
//        //        {
//        //            if (students[i].FullName.FirstName.CompareTo(students[j].FullName.FirstName) == 0)
//        //            {
//        //                return false;
//        //            }
//        //        }
//        //    }
//        //    return true;
//        //}

//        //private static bool ShortStudentIfLastName(Student[] students, int indexStudent)
//        //{
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i + 1; j < indexStudent; j++)
//        //        {
//        //            if (students[i].FullName.LastName.CompareTo(students[j].FullName.LastName) == 0)
//        //            {
//        //                return false;
//        //            }
//        //        }
//        //    }
//        //    return true;
//        //}

//        //private static bool ShortStudentIfGPA(Student[] students, int indexStudent)
//        //{
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i + 1; j < indexStudent; j++)
//        //        {
//        //            if (students[i].Grade.SumGrad == students[j].Grade.SumGrad)
//        //            {
//        //                return false;
//        //            }
//        //        }
//        //    }
//        //    return true;
//        //}

//        //private static void ShortStudentByName(Student[] students, int indexStudent)
//        //{
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i + 1; j < indexStudent; j++)
//        //        {
//        //            if (students[i].FullName.LastName.CompareTo(students[j].FullName.LastName) > 0)
//        //            {
//        //                Student tmp = students[i];
//        //                students[i] = students[j];
//        //                students[j] = tmp;
//        //            }
//        //        }
//        //    }
//        //}

//        //private static void ShortStudentByGPA(Student[] students, int indexStudent)
//        //{

//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        for (int j = i + 1; j < indexStudent; j++)
//        //        {
//        //            if (students[i].Grade.SumGrad < students[j].Grade.SumGrad)
//        //            {
//        //                Student tmp = students[i];
//        //                students[i] = students[j];
//        //                students[j] = tmp;
//        //            }
//        //        }
//        //    }
//        //}

//        //private static void ShowStudent(Student[] students, int indexStudent)
//        //{
//        //    var titleMsv = "Msv";
//        //    var titleFullName = "FullName";
//        //    var titleAdress = "Address";
//        //    var titleGrade = "Diem";
//        //    var titleMajor = "Major";
//        //    Console.WriteLine($"{titleMsv,-15} {titleFullName,-20} {titleAdress,-25} {titleGrade,-30} {titleMajor,-35}");
//        //    for (int i = 0; i < indexStudent; i++)
//        //    {
//        //        Console.WriteLine($"{students[i].MaSv,-15} {students[i].FullName,-20} {students[i].Address,-25} {students[i].Grade,-30} {students[i].Major,-35}");
//        //    }
//        //}

//        //private static Student AddStudent()
//        //{
//        //    Name name = CreatName();

//        //    Address address = CreatAdress();
//        //    Grade grade = CreatGrade();
//        //    Console.Write("Nhap msv : ");
//        //    int msv = int.Parse(Console.ReadLine());
//        //    Console.Write("Nhap chuyen nganh : ");
//        //    string major = Console.ReadLine();
//        //    return new Student(name, address, grade, msv, major);
//        //}

//        //private static Grade CreatGrade()
//        //{
//        //    Console.Write("Nhap diem 3 mon: ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    double engGrade = double.Parse(element[0]);
//        //    double mathGrade = double.Parse(element[1]);
//        //    double cGrade = double.Parse(element[2]);
//        //    return new Grade(engGrade, mathGrade, cGrade);
//        //}

//        //private static Name CreatName()
//        //{
//        //    Console.Write("Nhap ho va ten : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    string firstName = element[0];
//        //    string midName = element[1];
//        //    string lastName = element[2];
//        //    return new Name(firstName, midName, lastName);
//        //}

//        //private static Address CreatAdress()
//        //{
//        //    Console.Write("Nhap dia chi : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    string city = element[0] + element[1];
//        //    string ward = element[2] + element[3];
//        //    string district = element[4] + element[5];
//        //    return new Address(city, ward, district);
//        //}
//        #endregion
//        #region Bài 7 :
//        //struct Character
//        //{
//        //    public Character(char kyTu)
//        //    {
//        //        KyTu = kyTu;
//        //    }
//        //    public char KyTu;
//        //}
//        //static Character[] Input(out Character[] character)
//        //{

//        //    var element = Console.ReadLine().ToCharArray();
//        //    character = new Character[element.Length];
//        //    for (int i = 0; i < character.Length; i++)
//        //    {
//        //        character[i].KyTu = element[i];
//        //    }
//        //    return character;
//        //}
//        //static void ShowArray(Character[] characters)
//        //{
//        //    for (int i = 0; i < characters.Length; i++)
//        //    {
//        //        int count = 1;
//        //        for (int j = i + 1; j < characters.Length; j++)
//        //        {
//        //            if (characters[i].KyTu == characters[j].KyTu)
//        //            {
//        //                count++;
//        //            }
//        //        }
//        //        if (Check(characters, i, characters[i].KyTu))
//        //        {
//        //            Console.WriteLine($"{characters[i].KyTu} : {count} ");
//        //        }
//        //    }
//        //}
//        //static bool Check(Character[] characters, int current, char value)
//        //{
//        //    for (int i = 0; i < current; i++)
//        //    {
//        //        if (characters[i].KyTu == value)
//        //        {
//        //            return false;
//        //        }
//        //    }
//        //    return true;
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Input(out Character[] characters);
//        //    ShowArray(characters);            
//        //}
//        #endregion
//        #region Bài 8 :
//        //struct DayTang
//        //{
//        //    public DayTang(int numb)
//        //    {
//        //        Numb = numb;
//        //    }
//        //    public int Numb;
//        //}
//        //static DayTang[] Input(out DayTang[] dayTang)
//        //{
//        //    var element = Console.ReadLine().Split(' ');
//        //    dayTang = new DayTang[element.Length];
//        //    for (int i = 0; i < dayTang.Length; i++)
//        //    {
//        //        dayTang[i].Numb = int.Parse(element[i]);
//        //    }
//        //    return dayTang;
//        //}
//        //static int ShowDayTang(DayTang[] dayTang)
//        //{
//        //    int currentLength = 1;
//        //    int maxLength = 1;
//        //    for (int i = 1; i < dayTang.Length; i++)
//        //    {
//        //        if (dayTang[i].Numb > dayTang[i - 1].Numb)
//        //        {
//        //            currentLength++;
//        //        }
//        //        else
//        //        {
//        //            if (currentLength > maxLength)
//        //            {
//        //                maxLength = currentLength;
//        //                currentLength = 1;
//        //            }
//        //        }             
//        //    }
//        //    if (currentLength > maxLength)
//        //    {
//        //        maxLength = currentLength;
//        //    }
//        //    return maxLength;
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Input(out DayTang[] dayTang);
//        //    Console.WriteLine(ShowDayTang(dayTang));
//        //}
//        #endregion
//        #region Bài 9 :
//        //struct Number
//        //{
//        //    public Number(int value, int count)
//        //    {
//        //        Numb = value;
//        //        Count = count;
//        //    }
//        //    public int Numb { get; set; }
//        //    public int Count { get; set; }

//        //}
//        //static void CountNumb(out Number[] numbers)
//        //{
//        //    Console.Write("Nhap cac phan tu trong mang : ");
//        //    var element = Console.ReadLine().Split(' ');
//        //    numbers = new Number[element.Length];
//        //    for (int i = 0; i < numbers.Length; i++)
//        //    {
//        //        numbers[i].Numb = int.Parse(element[i]);
//        //    }
//        //    for (int i = 0; i < numbers.Length; i++)
//        //    {
//        //        numbers[i].Count = 1;
//        //        for (int j = i + 1; j < numbers.Length; j++)
//        //        {
//        //            if (numbers[i].Numb == numbers[j].Numb)
//        //            {
//        //                numbers[i].Count++;
//        //            }
//        //        }               
//        //    }                      
//        //}
//        //static void ReverseSort(Number[] numbers)
//        //{
//        //    for (int i = 0; i < numbers.Length; i++)
//        //    {
//        //        for (int j = i + 1; j < numbers.Length; j++)
//        //        {
//        //            if (numbers[i].Count < numbers[j].Count)
//        //            {
//        //                Number tmp = numbers[i];
//        //                numbers[i] = numbers[j];
//        //                numbers[j] = tmp;
//        //            }
//        //        }
//        //    }
//        //}
//        //static void ShowArray(Number[] numbers)
//        //{
//        //    for (int i = 0; i < numbers.Length; i++)
//        //    {
//        //        if (CheckNumber(numbers, i, numbers[i].Numb))
//        //        {
//        //            Console.WriteLine($"{numbers[i].Numb} : {numbers[i].Count}");
//        //        }
//        //    }
//        //}
//        //static bool CheckNumber(Number[] numbers, int current, int numb)
//        //{
//        //    for (int i = 0; i < current; i++)
//        //    {
//        //        if (numbers[i].Numb == numb)
//        //        {
//        //            return false;
//        //        }
//        //    }
//        //    return true;
//        //}

//        //static void Main(string[] args)
//        //{
//        //    CountNumb(out Number[] numbers);
//        //    ReverseSort(numbers);
//        //    ShowArray(numbers);

//        //}
//        #endregion
//        #region Bài 10:
//        //struct Function
//        //{
//        //    public Function(int a, int b, int c)
//        //    {
//        //        A = a;
//        //        B = b;
//        //        C = c;
//        //    }
//        //    public int A { get; set; }
//        //    public int B { get; set; }
//        //    public int C { get; set; }
//        //}
//        //static int Delta(Function number)
//        //{
//        //    int delta = (number.B * number.B) - 4 * (number.A * number.C);
//        //    return delta;
//        //}
//        //static void Main(string[] args)
//        //{
//        //    Console.Write("Nhap 3 so a , b , c : ");

//        //    var element = Console.ReadLine().Split(' ');
//        //    int a = int.Parse(element[0]);
//        //    int b = int.Parse(element[1]);
//        //    int c = int.Parse(element[2]);

//        //    Function function = new Function(a, b, c);

//        //    double delta = Delta(function);

//        //    if(delta < 0 )
//        //    {
//        //        Console.WriteLine("Phuong trinh vo nghiem : ");
//        //    }
//        //    else if(delta == 0)
//        //    {
//        //        int x = -function.B / (2 * function.A);
//        //        Console.Write($"Phuong trinh co nghiem kep : {x} ");
//        //    }
//        //    else
//        //    {
//        //        double x1 = (-function.B + Math.Sqrt(delta)) / (2 * function.A);
//        //        double x2 = (-function.B - Math.Sqrt(delta)) / (2 * function.A);
//        //        Console.Write($"2 nghiem cua phuong trinh la : {x1} , {x2}");
//        //    }
//        //    Console.WriteLine();
//        //}
//        #endregion
//        #region Bài 11:
//        //struct BankAccount
//        //{
//        //    public BankAccount(long cardId, double balance, string status)
//        //    {
//        //        CardId = cardId;
//        //        Balance = balance;
//        //        Status = status;
//        //        MainTainFee = 50000;
//        //        WithDrawFee = 1100;
//        //    }
//        //    public long CardId { get; set; }
//        //    public double Balance { get; set; }
//        //    public string Status { get; set; }
//        //    public int MainTainFee;
//        //    public int WithDrawFee;
//        //}
//        //static void Main(string[] args)
//        //{
//        //    BankAccount[] bankAccount = new BankAccount[100];
//        //    int accountIndex = 0;
//        //    bool end = true;
//        //    while (end)
//        //    {
//        //        Console.WriteLine("-----------------------------------------------");
//        //        Console.WriteLine("1: Tao tai khoan");
//        //        Console.WriteLine("2: Nap tien");
//        //        Console.WriteLine("3: Truy van so du");
//        //        Console.WriteLine("4: Rut tien");
//        //        Console.WriteLine("5: Chuyen tien");
//        //        Console.WriteLine("6: Hien thi danh sach tai khoan");
//        //        Console.WriteLine("7: Ket Thuc");
//        //        Console.WriteLine("-----------------------------------------------");

//        //        Console.Write("Nhap lua chon : ");
//        //        string key = Console.ReadLine();
//        //        if (int.TryParse(key, out int newKey) == false)
//        //        {
//        //            Console.WriteLine("Nhap sai dinh dang");
//        //            continue;
//        //        }
//        //        switch (newKey)
//        //        {
//        //            case 1:
//        //                bankAccount[accountIndex++] = CreatAccount();
//        //                break;
//        //            case 2:
//        //                if (accountIndex > 0)
//        //                {
//        //                    Deposit(bankAccount, accountIndex);
                            
//        //                }
//        //                Console.WriteLine("Khong ton tai tai khoan");
//        //                break;
//        //            case 3:
//        //                if (accountIndex > 0)
//        //                {
//        //                    ViewBalance(bankAccount, accountIndex);
                            
//        //                }
//        //                Console.WriteLine("Khong ton tai tai khoan");
//        //                break;
//        //            case 4:
//        //                if (accountIndex > 0)
//        //                {
//        //                    WithdrawBalance(bankAccount, accountIndex);
                            
//        //                }
//        //                Console.WriteLine("Khong ton tai tai khoan");
//        //                break;
//        //            case 5:
//        //                if (accountIndex > 0)
//        //                {
//        //                    TransferMoney(bankAccount, accountIndex);
//        //                }
//        //                Console.WriteLine("Khong ton tai tai khoan");
//        //                break;
//        //            case 6:
//        //                if (accountIndex > 0)
//        //                {
//        //                    ShowBankAccout(bankAccount, accountIndex);
//        //                }
//        //                Console.WriteLine("Khong ton tai tai khoan");
//        //                break;
//        //            case 7:
//        //                end = false;
//        //                break;
//        //            default:
//        //                Console.WriteLine("Nhap sai lua chon");
//        //                break;
//        //        }
//        //    }
//        //}

//        //static void TransferMoney(BankAccount[] bankAccount, int accountIndex)
//        //{
//        //    Console.Write("Nhap So Tai Khoan Cua Ban : ");
//        //    long searchId = long.Parse(Console.ReadLine());
//        //    Console.Write("Nhap so tien muon chuyen : ");
//        //    double amount = double.Parse(Console.ReadLine());

//        //    for (int i = 0; i < accountIndex; i++)
//        //    {

//        //        if (CheckID(searchId, bankAccount))
//        //        {
//        //            if (bankAccount[i].Status == "lock" || bankAccount[i].Balance <= amount || bankAccount[i].Balance - amount <= bankAccount[i].MainTainFee)
//        //            {
//        //                Console.WriteLine("Khong the thuc hien chuyen khoan");
//        //                break;
//        //            }
//        //            else
//        //            {
//        //                bankAccount[i].Balance -= amount;
//        //                Console.Write("Nhap So Tai Khoan Muon Chuyen : ");
//        //                long searchTransferId = long.Parse(Console.ReadLine());
//        //                if (CheckID(searchTransferId, bankAccount))
//        //                {
//        //                    if (searchTransferId == bankAccount[i].CardId)
//        //                    {
//        //                        bankAccount[i].Balance += amount;
//        //                    }
//        //                }
//        //                else
//        //                {
//        //                    Console.WriteLine("Nguoi nhan khong ton tai");
//        //                    break;
//        //                }
//        //            }
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine("Nguoi chuyen khong ton tai");
//        //            break;
//        //        }
//        //    }

//        //}

//        //private static bool CheckID(long searchId, BankAccount[] bankAccounts)
//        //{
//        //    for (int i = 0; i < bankAccounts.Length; i++)
//        //    {
//        //        if (searchId == bankAccounts[i].CardId)
//        //        {
//        //            return true;
//        //        }
//        //    }
//        //    return false;
//        //}

//        //private static void WithdrawBalance(BankAccount[] bankAccount, int accountIndex)
//        //{
//        //    Console.Write("Nhap So Tai Khoan Cua Ban : ");
//        //    long searchId = long.Parse(Console.ReadLine());

//        //    Console.Write("Nhap so tien ban muon rut : ");
//        //    double amount = double.Parse(Console.ReadLine());

//        //    for (int i = 0; i < accountIndex; i++)
//        //    {
//        //        if (amount < 0)
//        //        {
//        //            Console.Write("So tien rut khong dung : ");

//        //            break;
//        //        }

//        //        if (CheckID(searchId,bankAccount))
//        //        {
//        //            if (bankAccount[i].Balance <= amount + bankAccount[i].WithDrawFee || bankAccount[i].Balance - amount < bankAccount[i].MainTainFee || bankAccount[i].Status == "lock")
//        //            {
//        //                Console.Write("Khong Du So Du : ");

//        //                break;
//        //            }
//        //            else
//        //            {
//        //                bankAccount[i].Balance -= amount + bankAccount[i].WithDrawFee;

//        //                Console.WriteLine("Rut tien thanh cong ");

//        //                Console.Write($"So du moi cua ban la : {bankAccount[i].Balance}");
//        //            }
//        //        }
//        //    }
//        //    Console.WriteLine();
//        //}

//        //private static void ViewBalance(BankAccount[] bankAccount, int accountIndex)
//        //{
//        //    while (true)
//        //    {
//        //        Console.Write("Nhap So Tai Khoan Cua Ban : ");
//        //        string searchId = Console.ReadLine();

//        //        if (long.TryParse(searchId, out long balance) == false)
//        //        {
//        //            Console.WriteLine("Nhap sai dinh dang");
//        //            break;
//        //        }

//        //        Console.Write("So du cua ban la : ");
//        //        for (int i = 0; i < accountIndex; i++)
//        //        {
//        //            if (balance == bankAccount[i].CardId)
//        //            {
//        //                Console.WriteLine(bankAccount[i].Balance);
//        //            }
//        //        }
//        //    }

//        //}

//        //private static void Deposit(BankAccount[] bankAccount, int accountIndex)
//        //{

//        //    Console.Write("Nhap So Tai Khoan Cua Ban : ");
//        //    long searchId = long.Parse(Console.ReadLine());

//        //    Console.Write("Nhap So Tien Muon Gui : ");
//        //    double deposit = double.Parse(Console.ReadLine());

//        //    for (int i = 0; i < accountIndex; i++)
//        //    {
//        //        if (bankAccount[i].CardId == searchId)
//        //        {
//        //            bankAccount[i].Balance += deposit;
//        //        }
//        //    }
//        //}

//        //private static void ShowBankAccout(BankAccount[] bankAccount, int index)
//        //{

//        //    var titleCardId = "So Tai Khoan";
//        //    var titleBalance = "So Du";
//        //    var titleStatus = "Trang Thai";

//        //    Console.WriteLine($"{titleCardId,-15} {titleBalance,-20} {titleStatus,-25} ");

//        //    for (int i = 0; i < index; i++)
//        //    {
//        //        for (int j = i + 1; j < index; j++)
//        //        {
//        //            if (bankAccount[i].Balance < bankAccount[j].Balance)
//        //            {
//        //                BankAccount tmp = bankAccount[i];
//        //                bankAccount[i] = bankAccount[j];
//        //                bankAccount[j] = tmp;
//        //            }
//        //        }
//        //    }
//        //    for (int i = 0; i < index; i++)
//        //    {
//        //        Console.WriteLine($"{bankAccount[i].CardId,-15} {bankAccount[i].Balance,-20} {bankAccount[i].Status,-25}");
//        //    }
//        //}

//        //static BankAccount CreatAccount()
//        //{
            
//        //    while (true)
//        //    {
//        //        Console.Write("Nhap so tai khoan : ");
//        //        string accountNumb = Console.ReadLine();

//        //        Console.Write("Nhap so du : ");
//        //        string balance = Console.ReadLine();
              
//        //        if (long.TryParse(accountNumb, out long stk) == false || double.TryParse(balance, out double soDu) == false)
//        //        {
//        //            Console.WriteLine("Nhap sai dinh dang");
//        //            continue;
//        //        }
//        //        if (soDu < 50000)
//        //        {
//        //            Console.WriteLine("Nhap so du qua it");
//        //            continue;
//        //        }

//        //        Console.Write("Nhap trang thai the : ");
//        //        string status = Console.ReadLine().ToLower();

//        //        return new BankAccount(stk, soDu, status);
//        //    }

//        //}
//        #endregion
//    }
//}



