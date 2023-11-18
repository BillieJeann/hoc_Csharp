using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass.Student
{
    class StudentFunc
    {
        public static Studentproperties AddStudent()
        {
            while (true)
            {
                Console.Write("Nhập họ sinh viên : ");
                string firstName = Console.ReadLine();

                Console.Write("Nhập tên đệm sinh viên : ");
                string midnName = Console.ReadLine();

                Console.Write("Nhập tên sinh viên : ");
                string lastName = Console.ReadLine();

                Console.Write("Nhập địa chỉ sinh viên : ");
                string addr = Console.ReadLine();

                Console.Write("Nhập điểm trung bình sinh viên : ");
                string gpa = Console.ReadLine();

                Console.Write("Nhập chuyên ngành sinh viên : ");
                string major = Console.ReadLine();

                if (double.TryParse(gpa, out double newGpa) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                Console.WriteLine("Thêm sinh viên thành công");
                return new Studentproperties(null, firstName, midnName, lastName, addr, newGpa, major);
            }
        }

        public static void ShowStudentsList(Studentproperties[] students)
        {
            var titleId = "MÃ SINH VIÊN";
            var titleFullName = "HỌ VÀ TÊN";
            var titleAddress = "ĐỊA CHỈ";
            var titleGpa = "ĐIỂM TRUNG BÌNH";
            var titleMajor = "CHUYÊN NGÀNH";
            Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titleAddress,-20} {titleGpa,-20} {titleMajor,-20}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-20} {item.FirstName + " " + item.MiddleName + " " + item.LastName,-20} {item.Address,-20} {item.Gpa,-20} {item.Major,-20}");
                }
            }
        }

        public static void SortGpa(Studentproperties[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckGpa(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
            Console.WriteLine("Săp xếp thành công.");
        }

        public static void Swap(ref Studentproperties student1, ref Studentproperties student2)
        {
            Studentproperties tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        public static int CheckGpa(Studentproperties student1, Studentproperties student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpa < student2.Gpa)
            {
                return 1;
            }
            return -1;
        }

        public static void SortLastName(Studentproperties[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckLastName(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
            Console.WriteLine("Săp xếp thành công.");
        }

        public static int CheckLastName(Studentproperties student1, Studentproperties student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.LastName.CompareTo(student2.LastName) > 0)
            {
                return 1;
            }
            return -1;
        }

        public static void SortAll(Studentproperties[] students)
        {
            SortGpa(students);
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (SortIfEqual(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
        }

        public static int SortIfEqual(Studentproperties student1, Studentproperties student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.Gpa == student2.Gpa && student1.LastName.CompareTo(student2.LastName) > 0 || student1.Gpa == student2.Gpa && student1.FirstName.CompareTo(student2.FirstName) > 0)
            {
                return 1;
            }
            return -1;
        }

        public static void FindStudentsByName(Studentproperties[] students)
        {
            Studentproperties[] searchedStudents = new Studentproperties[students.Length];
            int index = 0;
            Console.Write("Nhập tên sinh viên cần tìm : ");
            string lastName = Console.ReadLine();
            foreach (var item in students)
            {
                if (item != null && item.LastName == lastName)
                {
                    searchedStudents[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowStudentsList(searchedStudents);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tên sinh viên.");
            }
        }

        public static void FindStudentsByAddress(Studentproperties[] students)
        {
            Studentproperties[] searchedStudents = new Studentproperties[students.Length];
            int index = 0;
            Console.Write("Nhập địa chỉ sinh viên cần tìm : ");
            string addr = Console.ReadLine();
            foreach (var item in students)
            {
                if (item != null && item.Address == addr)
                {
                    searchedStudents[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowStudentsList(searchedStudents);
            }
            else
            {
                Console.WriteLine("Không tìm thấy địa chỉ.");
            }
        }

        public static void DeleteStudentById(Studentproperties[] students, ref int index)
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
                            students[j] = students[j + 1];
                        }
                    }
                }
            }
        }

        public static Studentproperties CheckId(Studentproperties[] students, string id)
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

        public static void ListedByAddress(Studentproperties[] students)
        {
            ListStudentAddress[] addrs = new ListStudentAddress[students.Length];
            int index = 0;
            int Check(ListStudentAddress[] addr, string address)
            {
                for (int i = 0; i < addr.Length; i++)
                {
                    if (addr[i] != null && addr[i].Address.CompareTo(address) == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    var result = Check(addrs, students[i].Address);
                    if (result != -1)
                    {
                        addrs[result].Count++;
                        continue;
                    }
                    else
                    {
                        addrs[index] = new ListStudentAddress();
                        addrs[index].Address = students[i].Address;
                        addrs[index].Count = 1;
                        index++;
                    }
                }

            }
            foreach (var item in addrs)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Address} : {item.Count}");
                }
            }
        }
        public static void FixStudentGpa(Studentproperties[] students)
        {
            Console.Write("Nhập mã sinh viên cần sửa điểm : ");
            string id = Console.ReadLine();
            var searched = CheckId(students, id);
            if (searched != null)
            {
                Console.Write("Nhập điểm mới cho sinh viên : ");
                double newGpa = double.Parse(Console.ReadLine());
                searched.Gpa = newGpa;
                Console.WriteLine("Sửa điểm thành công ");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sinh viên");
            }
        }
        class ListStudentAddress
        {
            public string Address { get; set; }
            public int Count { get; set; }
            public ListStudentAddress()
            {

            }
            public ListStudentAddress(string addr, int count)
            {
                Address = addr;
                Count = count;
            }
        }
    }
    class Programm
    {
        /*static void Main()
        {
            Studentproperties[] students = new Studentproperties[10];
            int index = 0;
            string key;
            bool end = true;
            Console.OutputEncoding = Encoding.UTF8;

            while (end)
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
                    "10) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
                    "11) Kết thúc chương trình.");

                Console.Write("Nhập lựa chọn của bạn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập lựa chọn sai định dạng !");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        students[index++] = StudentFunc.AddStudent();
                        break;
                    case 2:
                        StudentFunc.ShowStudentsList(students);
                        break;
                    case 3:
                        StudentFunc.SortGpa(students);
                        break;
                    case 4:
                        StudentFunc.SortLastName(students);
                        break;
                    case 5:
                        StudentFunc.SortAll(students);
                        break;
                    case 6:
                        StudentFunc.FindStudentsByName(students);
                        break;
                    case 7:
                        StudentFunc.FindStudentsByAddress(students);
                        break;
                    case 8:
                        StudentFunc.DeleteStudentById(students, ref index);
                        break;
                    case 9:
                        StudentFunc.ListedByAddress(students);
                        break;
                    case 10:
                        StudentFunc.FixStudentGpa(students);
                        break;
                    case 11:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn.");
                        break;
                }
            }
        }*/
    }
}
