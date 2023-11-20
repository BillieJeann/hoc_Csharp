using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NestedClass.Student
{
    internal class Student
    {
        private static int idindex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "ST" + idindex++;
                }
                else
                {
                    _id = "ST" + value;
                }
            }
        }
        private class FullName
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }

        }
        private FullName _fullName;
        public string WholeName
        {
            get => $"{_fullName.FirstName} {_fullName.MiddleName} {_fullName.LastName}";
            set
            {
                _fullName = new FullName();
                var name = value.Split(' ');
                _fullName.FirstName = name[0];
                _fullName.LastName = name[name.Length - 1];
                var midName = "";
                for (int i = 1; i < name.Length - 1; i++)
                {
                    midName += name[i] + " ";
                }
                _fullName.MiddleName = midName;
            }
        }
        private class Address
        {
            public string City { get; set; }
            public string District { get; set; }
            public string Ward { get; set; }
        }
        private Address _address;
        public string FullAddress
        {
            get => $"{_address.City} / {_address.District} / {_address.Ward}";
            set
            {
                _address = new Address();
                var addr = value.Split(" ");
                _address.City = addr[0];
                _address.District = addr[1];
                _address.Ward = addr[2];
            }
        }
        public class StudentGrade
        {
            public double C;
            public double Eng;
            public double Math;
            public double Gpa;
        }
        public StudentGrade _studentGrade;
        public double Cgrade
        {
            get => _studentGrade.C;
            set => _studentGrade.C = value;

        }
        public double EngGrade
        {
            get => _studentGrade.Eng;
            set => _studentGrade.Eng = value;
        }
        public double MathGrade
        {
            get => _studentGrade.Math;
            set => _studentGrade.Math = value;
        }
        public double Gpagrade
        {
            get => _studentGrade.Gpa;
            set => _studentGrade.Gpa = value;
        }

        public string GetLastName => _fullName.LastName;
        public string GetFirstName => _fullName.FirstName;
        public string GetCity => _address.City;
        public Student(string id)
        {
            Id = id;
        }
        public Student(string id, string fullName, string address, double cgrade, double eng, double math) : this(id) 
        {
            _studentGrade = new StudentGrade();
            WholeName = fullName;
            FullAddress = address;
            Cgrade = cgrade;
            EngGrade = eng;
            MathGrade = math;
            Gpagrade = Math.Round((cgrade + eng + math) / 3, 2);
        }
    }
    class Programm
    {
        static void Main()
        {
            Student[] students = new Student[5];
            int index = 0;
            string key;
            bool run = true;
            Console.OutputEncoding = Encoding.UTF8;
            while (run)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một sinh viên vào danh sách.\r\n" +
                    "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
                    "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
                    "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
                    "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
                    "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
                    "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
                    "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
                    "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
                    "10) Liệt kê các sinh viên có điểm TB ở hệ 4 từ 3.20 trở lên.\r\n" +
                    "11) Sửa điểm lập trình cho sinh viên theo mã sinh viên.\r\n" +
                    "12) Kết thúc chương trình.");

                Console.Write("Nhập lựa chọn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        students[index++] = CreatStudent();
                        break;
                    case 2:
                        ShowStudents(students);
                        break;
                    case 3:
                        SortStudentsByGpa(students);
                        break;
                    case 4:
                        SortStudentsByLastName(students);
                        break;
                    case 5:
                        SortAll(students);
                        break;
                    case 6:
                        FindStudentByLastName(students);
                        break;
                    case 7:
                        FindStudentByCity(students);
                        break;
                    case 8:
                        DeleteStudent(students, ref index);
                        break;
                    case 9:
                        ListofCity(students);
                        break;
                    case 10:
                        ListofGpaOver3point2(students);
                        break;
                    case 11:
                        UpdateStudentCgrade(students);
                        break;
                    case 12:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }
            }
        }

        private static void UpdateStudentCgrade(Student[] students)
        {
            Console.Write("Nhập mã sinh viên : ");
            string id = Console.ReadLine();

            var searched = CheckId(students, id);
            if (searched != null)
            {
                Console.Write("Nhập điểm mới cho sinh viên : ");
                double newCgrade = double.Parse(Console.ReadLine());
                searched.Cgrade = newCgrade;
                Console.WriteLine("Sửa điểm thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sinh viên");
            }
        }

        private static void ListofGpaOver3point2(Student[] students)
        {
            ListStudentByGpa[] gpas = new ListStudentByGpa[students.Length];
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    var gpa = students[i].Gpagrade;
                    var pos = Check(gpas, gpa);
                    if (pos != -1)
                    {
                        gpas[pos].Count++;
                        continue;
                    }
                    else
                    {
                        gpas[index] = new ListStudentByGpa();
                        gpas[index].Gpa = gpa;
                        gpas[index].Count = 1;
                        index++;
                    }
                }
            }
            foreach (var item in gpas)
            {
                if (item != null && item.Gpa >= 3.2)
                {
                    Console.WriteLine($"{item.Gpa} : {item.Count}");
                }
            }
        }

        private static void ListofCity(Student[] students)
        {
            ListStudentByCity[] cities = new ListStudentByCity[students.Length];
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    var city = students[i].GetCity;
                    var pos = Check(cities, city);
                    if (pos != -1)
                    {
                        cities[pos].Count++;
                        continue;
                    }
                    else
                    {
                        cities[index] = new ListStudentByCity();
                        cities[index].City = city;
                        cities[index].Count = 1;
                        index++;
                    }
                }
            }
            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int j = i + 1; j < cities.Length; j++)
                {
                    if (cities[i] != null && cities[j] != null && cities[i].Count < cities[j].Count)
                    {
                        Swap(ref cities[i], ref cities[j]);
                    }
                }
            }
            foreach (var item in cities)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.City} : {item.Count}");
                }
            }
        }
        private static void Swap(ref ListStudentByCity listStudentByCity1, ref ListStudentByCity listStudentByCity2)
        {
            ListStudentByCity tmp = listStudentByCity1;
            listStudentByCity1 = listStudentByCity2;
            listStudentByCity2 = tmp;
        }
        private static int Check(ListStudentByGpa[] gpas, double gpa)
        {
            for (int i = 0; i < gpas.Length; i++)
            {
                if (gpas[i] != null && gpas[i].Gpa.CompareTo(gpa) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        private static int Check(ListStudentByCity[] cities, string city)
        {
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i] != null && cities[i].City.CompareTo(city) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        class ListStudentByGpa
        {
            public double Gpa { get; set; }
            public int Count { get; set; }
            public ListStudentByGpa()
            {

            }
            public ListStudentByGpa(double gpa, int count)
            {
                Gpa = gpa;
                Count = count;
            }
        }

        class ListStudentByCity
        {
            public string City { get; set; }
            public int Count { get; set; }
            public ListStudentByCity()
            {

            }
            public ListStudentByCity(string city, int count)
            {
                City = city;
                Count = count;
            }
        }

        private static void DeleteStudent(Student[] students, ref int index)
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
                            students[j] = students[i + 1];
                        }
                        index--;
                    }
                }
                Console.WriteLine("Xóa sinh viên thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sinh viên");
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

        private static void FindStudentByCity(Student[] students)
        {
            Student[] searchedStudents = new Student[students.Length];
            int index = 0;
            Console.Write("Nhập tỉnh thành sinh viên : ");
            string city = Console.ReadLine();
            foreach (var item in students)
            {
                if (FindCity(item, city) > 0)
                {
                    searchedStudents[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowStudents(searchedStudents);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tỉnh thành");
            }
        }

        private static int FindCity(Student student, string city)
        {
            if (student != null && student.GetCity.CompareTo(city) == 0)
            {
                return 1;
            }
            return 0;
        }

        private static void FindStudentByLastName(Student[] students)
        {
            Student[] searchedStudents = new Student[students.Length];
            int index = 0;
            Console.Write("Nhập tên sinh viên : ");
            string lastName = Console.ReadLine();
            foreach (var item in students)
            {
                if (FindLastName(item, lastName) > 0)
                {
                    searchedStudents[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowStudents(searchedStudents);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tên sinh viên");
            }
        }

        private static int FindLastName(Student student, string lastName)
        {
            if (student != null && student.GetLastName.CompareTo(lastName) == 0)
            {
                return 1;
            }
            return 0;
        }

        private static void SortAll(Student[] students)
        {
            SortStudentsByGpa(students);

            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (ChecAll(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        private static int ChecAll(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpagrade == student2.Gpagrade && student1.GetLastName.CompareTo(student2.GetLastName) > 0 || student1.Gpagrade == student2.Gpagrade && student1.GetFirstName.CompareTo(student2.GetFirstName) > 0)
            {
                return 1;
            }
            return 0;
        }

        private static void SortStudentsByLastName(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStuLastName(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        private static void SortStudentsByGpa(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStuGpa(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        private static int CheckStuLastName(Student student1, Student student2)
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

        private static void Swap(ref Student student1, ref Student student2)
        {
            Student tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        private static int CheckStuGpa(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpagrade.CompareTo(student2.Gpagrade) < 0)
            {
                return 1;
            }
            return 0;
        }

        private static void ShowStudents(Student[] students)
        {
            var titleId = "MÃ SINH VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titleAddress = "ĐỊA CHỈ";
            var titleGpa = "ĐIỂM SINH VIÊN (C/ENGLISH/MATH/GPA)";
            Console.WriteLine($"{titleId,-30} {titleFullname,-30} {titleAddress,-30} {titleGpa,-30}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-30} {item.WholeName,-30} {item.FullAddress,-30} {item.Cgrade + " " + item.EngGrade + " " + item.MathGrade + " " + item.Gpagrade,-30}");
                }
            }
        }

        private static Student CreatStudent()
        {
            while (true)
            {
                Console.Write("Nhập tên sinh viên (Họ/Tên Đệm/Tên) : ");
                string fullName = Console.ReadLine();

                Console.Write("Nhập địa chỉ sinh viên (Thành Phố/Quận/Phường) : ");
                string addr = Console.ReadLine();

                Console.Write("Nhập điểm môn C : ");
                string Cgrade = Console.ReadLine();

                Console.Write("Nhập điểm môn Tiếng Anh : ");
                string engGrade = Console.ReadLine();

                Console.Write("Nhập điểm môn Toán : ");
                string mathGrade = Console.ReadLine();

                if (double.TryParse(Cgrade, out var cgrade) == false || double.TryParse(engGrade, out var eng) == false || double.TryParse(mathGrade, out var math) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                Console.Write("Thêm Sinh Viên Thành Công");
                return new Student(null, fullName, addr, cgrade,eng,math);
            }
        }
    }
}
