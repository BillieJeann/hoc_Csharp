using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Studentfunc
    {
        internal static Student CreatStudent()
        {
            while (true)
            {
                Console.Write("" +
                    "Lựa chọn sinh viên : \r\n" +
                    "1) Sinh viên tốt nghiệp \r\n" +
                    "2) Sinh viên chưa tốt nghiệp \r\n" +
                    "Nhập lựa chọn : ");
                string key = Console.ReadLine();
                if (int.TryParse(key, out int Key) == false || Key < 0 || Key > 2)
                {
                    Console.Write("Không tồn tại lựa chọn");
                    continue;
                }
                Console.Write("Nhập họ và tên sinh viên : ");
                string fullName = Console.ReadLine();
                Console.Write("Nhập địa chỉ sinh viên : ");
                string addr = Console.ReadLine();
                Console.Write("Nhập điểm môn lập trình C : ");
                string C = Console.ReadLine();
                Console.Write("Nhập điểm môn tiếng anh : ");
                string eng = Console.ReadLine();
                Console.Write("Nhập điểm môn toán : ");
                string math = Console.ReadLine();
                Console.Write("Nhập chuyên ngành sinh viên : ");
                string major = Console.ReadLine();  
                if (double.TryParse(C, out double cgrade) == false || double.TryParse(eng, out double engGrade) == false || double.TryParse(math, out double mathGrades) == false)
                {
                    Console.Write("Nhập sai định dạng điểm");
                    continue;
                }
                if (Key == 1)
                {
                    Console.Write("Nhập mức lương của sinh viên : ");
                    string pay = Console.ReadLine();
                    Console.Write("Nhập năm tốt nghiệp : ");
                    string year  = Console.ReadLine();
                    Console.Write("Nhập bằng tốt nghiệp : ");
                    string gradClassification = Console.ReadLine();
                    if (long.TryParse(pay, out long payamount) == false || int.TryParse(year, out int gradYear) == false)
                    {
                        Console.Write("Nhập sai định dạng : ");
                        continue;
                    }
                    return new GratuatedStudent(null, fullName,addr,cgrade,engGrade,mathGrades,major,payamount,gradYear, gradClassification);
                }
                if (Key == 2)
                {
                    Console.Write("Nhập học phí mỗi tín chỉ : ");
                    string amount = Console.ReadLine();
                    Console.Write("Nhập số tín đang nợ : ");
                    string unpay = Console.ReadLine();
                    Console.Write("Nhập số tín đã hoàn thành : ");
                    string completed = Console.ReadLine();  
                    if(long.TryParse(amount, out long tuition) == false || int.TryParse(unpay , out int unpaySubject) == false || int.TryParse(completed, out int completedSubject) == false)
                    {
                        Console.WriteLine("Nhập sai định dạng : ");
                        continue;
                    }
                    return new UngratuatedStudent(null, fullName, addr, cgrade, engGrade, mathGrades, major, tuition, unpaySubject, completedSubject);
                }
            }
        }
        internal static void ShowListStudents(Student[] students)
        {
            var titleId = "MÃ SINH VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titleAdress = "ĐỊA CHỈ";
            var titleCgrade = "C";
            var titleEngGrade = "ENG";
            var titleMathGrade = "MATH";
            var titleGpa = "GPA";
            var titleMajor = "CHUYÊN NGÀNH";
            var titlePayamount = "LƯƠNG";
            var titleGradYear = "NĂM TỐT NGHIỆP";
            var titleClassification = "LOẠI BẰNG";
            var titleTuition = "PHÍ TÍN CHỈ";
            var titleUnpay = "SÔ MÔN ĐANG NỢ";
            var titleCompleted = "SỐ MÔN HOÀN THÀNH";
            string empty = "----";
            Console.WriteLine($"{titleId,-15} {titleFullname,-15} {titleAdress,-15} {titleCgrade + "/" + titleEngGrade + "/" + titleMathGrade + "/" + titleGpa,-15} {titleMajor,-15} {titlePayamount,-15} {titleGradYear,-15} {titleClassification,-15} {titleTuition,-15} {titleUnpay,-15} {titleCompleted ,-15}");
            foreach (var item in students)
            {
                if(item != null)
                {
                    if (item is GratuatedStudent)
                    {
                        var gratedStu = (GratuatedStudent)item;
                        Console.WriteLine($"{gratedStu.Id,-15} {gratedStu.WholeName,-15} {gratedStu.Adress,-15} {gratedStu.Cgrade + "/" + gratedStu.Enggrade + "/" + gratedStu.Mathgrade + "/" + gratedStu.Gpa,-15} {gratedStu.Major,-15} {gratedStu.PayAmount,-15} {gratedStu.GradYear,-15} {gratedStu.GradClassification,-15} {empty,-15} {empty,-15} {empty,-15}");
                    }
                    if (item is UngratuatedStudent)
                    {
                        var ungratedStu = (UngratuatedStudent)item;
                        Console.WriteLine($"{ungratedStu.Id,-15} {ungratedStu.WholeName,-15} {ungratedStu.Adress,-15} {ungratedStu.Cgrade + "/" + ungratedStu.Enggrade + "/" + ungratedStu.Mathgrade + "/" + ungratedStu.Gpa,-15} {ungratedStu.Major,-15} {empty,-15} {empty,-15} {empty,-15} {ungratedStu.Tuition,-15} {ungratedStu.UnpaySubject,-15} {ungratedStu.CompletedSubject,-15}");
                    }
                }               
            }
        }
        internal static void SortByGpa(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStudent(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }
        private static void Swap(ref ListEngGrade student1, ref ListEngGrade student2)
        {
            ListEngGrade tmp = student1;
            student1 = student2;
            student2 = tmp;
        }
        private static void Swap(ref ListAddress student1, ref ListAddress student2)
        {
            ListAddress tmp = student1;
            student1 = student2;
            student2 = tmp;
        }
        private static void Swap(ref Student student1, ref Student student2)
        {
            Student tmp = student1;
            student1 = student2;
            student2 = tmp;
        }
        private static int CheckStudent(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpa < student2.Gpa)
            {
                return 1;
            }
            return 0;
        }

        internal static void SortByName(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStudentName(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        private static int CheckStudentName(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.GetLastName.CompareTo(student2.GetLastName) > 0)
            {
                return 1;
            }
            return 0;
        }

        internal static void SortAll(Student[] students)
        {
            SortByGpa(students);
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckAll(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        private static int CheckAll(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpa == student2.Gpa && student1.GetLastName.CompareTo(student2.GetLastName) > 0 || student1.Gpa == student2.Gpa && student1.GetFirstName.CompareTo(student2.GetFirstName) > 0)
            {
                return 1;
            }
            return 0;
        }

        internal static void FindByName(Student[] students)
        {
            Student[] searched = new Student[students.Length];
            int index = 0;
            Console.Write("Nhập tên sinh viên cần tìm : ");
            string name = Console.ReadLine();
            foreach (var item in students)
            {
                if (item != null && item.GetLastName.CompareTo(name) == 0)
                {
                    searched[index] = item;
                    index++;
                }
            }
            if (index > 0)
            {
                ShowListStudents(searched);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên nào tên {name}");
            }
        }

        internal static void FindByCity(Student[] students)
        {
            Student[] searched = new Student[students.Length];
            int index = 0;
            Console.Write("Nhập tình thành cần tìm : ");
            string addr = Console.ReadLine();
            foreach (var item in students)
            {
                if (item != null && item.Adress.CompareTo(addr) == 0)
                {
                    searched[index] = item;
                    index++;
                }
            }
            if (index > 0)
            {
                ShowListStudents(searched);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy tỉnh thành nào tên {addr}");
            }
        }

        internal static void Delete(Student[] students,ref int index)
        {
            Console.Write("Nhập mã sinh viên cần xóa : ");
            string id = Console.ReadLine();

            var searched = CheckId(students, id);
            if (searched != null)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null && students[i] == searched)
                    {
                        for (int j = i; j < students.Length - 1; j++)
                        {
                            Swap(ref students[j], ref students[j + 1]); 
                        }
                        index--;
                    }
                }
            }
        }

        private static Student CheckId(Student[] students, string id)
        {
            foreach (var item in students)
            {
                if (item != null && item.Id.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void ListofAddress(Student[] students)
        {
            ListAddress[] addresses = new ListAddress[students.Length];
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    var city = students[i].Adress;
                    var pos = Check(addresses, city);
                    if (pos != -1)
                    {
                        addresses[pos].Count++;
                        continue;
                    }
                    else
                    {
                        addresses[index] = new ListAddress();
                        addresses[index].City = city;
                        addresses[index].Count = 1;
                        index++;
                    }
                }
            }
            for (int i = 0; i < addresses.Length - 1; i++)
            {
                for (int j = i + 1; j < addresses.Length; j++)
                {
                    if (addresses[i] != null && addresses[j] != null && addresses[i].Count < addresses[j].Count)
                    {
                        Swap(ref addresses[i], ref addresses[j]);
                    }
                }
            }
            foreach (var item in addresses)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.City} : {item.Count}");
                }
            }
        }
        private static int Check(ListEngGrade[] grades, double eng)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] != null && grades[i].EngGrade.CompareTo(eng) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        private static int Check(ListAddress[] addresses, string city)
        {
            for (int i = 0; i < addresses.Length; i++)
            {
                if (addresses[i] != null && addresses[i].City.CompareTo(city) == 0)
                {
                    return i;
                }
            }
            return -1;
        }   
        internal static void ListofEngGrade(Student[] students)
        {
            ListEngGrade[] grades = new ListEngGrade[students.Length];
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    var eng = students[i].Enggrade;
                    var pos = Check(grades, eng);
                    if (pos != -1)
                    {
                        grades[pos].Count++;
                        continue;
                    }
                    else
                    {
                        grades[index] = new ListEngGrade();
                        grades[index].EngGrade = eng;
                        grades[index].Count = 1;
                        index++;
                    }
                }
            }
            for (int i = 0; i < grades.Length - 1; i++)
            {
                for (int j = i + 1; j < grades.Length; j++)
                {
                    if (grades[i] != null && grades[j] != null && grades[i].Count < grades[j].Count)
                    {
                        Swap(ref grades[i], ref grades[j]);
                    }
                }
            }
            foreach (var item in grades)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.EngGrade} : {item.Count}");
                }
            }
        }

        internal static void FixGpa(Student[] students)
        {
            Console.Write("Nhập mã sinh viên cần sửa điểm : ");
            string id = Console.ReadLine();

            var searched = CheckId(students, id);
            if(searched != null)
            {
                Console.Write("Nhập điểm mới cho sinh viên : ");
                double newGpa = double.Parse(Console.ReadLine());
                searched.Gpa = newGpa;
                Console.WriteLine("Sửa điểm thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sinh viên");
            }
        }

        class ListAddress
        {
            public string City { get; set; }
            public int Count { get; set; }
            public ListAddress()
            {
                
            }
            public ListAddress(string city , int count)
            {
                City = city;
                Count = count;
            }
        }
        class ListEngGrade
        {
            public double EngGrade { get; set; }
            public int Count { get; set; }
            public ListEngGrade()
            {
                
            }
            public ListEngGrade(double eng , int count)
            {
                EngGrade = eng;
                Count = count;
            }
        }
    }
}
