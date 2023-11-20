using Record.Work1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record.Work2
{
    public record class Student2
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public double Gpa { get; init; }
        public string Major { get; init; }

    }
    class Programm
    {
        /*static void Main()
        {
            Student2[] students = new Student2[5];
            int index = 0;
            string key;
            bool end = true;
            Console.OutputEncoding = Encoding.UTF8;

            while (end)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một record vào mảng.\r\n" +
                    "2) Hiển thị danh sách các record ra màn hình.\r\n" +
                    "3) Sắp xếp các record theo thứ tự điểm giảm dần.\r\n" +
                    "4) Tìm record theo chuyên ngành.\r\n" +
                    "5) Xóa record khỏi mảng.\r\n" +
                    "6) Kết thúc chương trình.");
                Console.Write("Nhập lưa chọn : ");
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
                        DesendSort(students);
                        break;
                    case 4:
                        FindByMajor(students);
                        break;
                    case 5:
                        DeleteRec(students, ref index);
                        break;
                    case 6:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }

            }
        }

        private static void DeleteRec(Student2[] students, ref int index)
        {
            Console.Write("Nhập mã sinh viên cần xóa : ");
            int id = int.Parse(Console.ReadLine());

            var searched = CheckId(students, id);
            if (searched != null)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] != null && students[i] == searched)
                    {
                        for (int j = 0; j < students.Length - 1; j++)
                        {
                            students[j] = students[j + 1];
                        }
                        index--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên");
            }
        }

        private static Student2 CheckId(Student2[] students, int id)
        {
            foreach (var item in students)
            {
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private static void FindByMajor(Student2[] students)
        {
            Student2[] searched = new Student2[students.Length];
            int index = 0;
            Console.Write("Nhập chuyên ngành : ");
            string major = Console.ReadLine();

            foreach (var item in students)
            {
                if (CheckMajor(item, major) > 0)
                {
                    searched[index++] = item;
                }
            }
            if (index > 0)
            {
                ShowStudents(searched);
            }
            else
            {
                Console.WriteLine("Không tìm thấy chuyên ngành");
            }
        }

        private static int CheckMajor(Student2 item, string major)
        {
            if (item == null)
            {
                return 0;
            }
            if (item.Major == major)
            {
                return 1;
            }
            return 0;
        }

        private static void DesendSort(Student2[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStudents(students[i], students[j]) > 0)
                    {
                        Swap(ref students[i], ref students[j]);
                    }
                }
            }
            Console.WriteLine("Sắp xếp thành công");
        }

        private static void Swap(ref Student2 student1, ref Student2 student2)
        {
            Student2 tmp = student1;
            student1 = student2;
            student2 = tmp;
        }

        private static int CheckStudents(Student2 student1, Student2 student2)
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

        private static void ShowStudents(Student2[] students)
        {
            var titleId = "MÃ SINH VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titleGpa = "ĐIỂM TRUNG BÌNH";
            var titleMajor = "CHUYÊN NGÀNH";
            Console.WriteLine($"{titleId,-30} {titleFullname,-30} {titleGpa,-30} {titleMajor,-30}");
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-30} {item.Name,-30} {item.Gpa,-30} {item.Major,-30}");
                }
            }
        }

        private static Student2 CreatStudent()
        {           

            Console.Write("Nhập mã sinh viên : ");
            int id = int.Parse(Console.ReadLine());
            
            Console.Write("Nhập họ tên sinh viên : ");
            string fullName = Console.ReadLine();

            Console.Write("Nhập điểm trung bình sinh viên : ");
            double gpa = double.Parse(Console.ReadLine());

            Console.Write("Nhập chuyên ngành sinh viên : ");
            string major = Console.ReadLine();

            Console.WriteLine("Thêm sinh viên thành công");

            return new Student2()
            {
                Id = id,
                Name = fullName,
                Gpa = gpa,
                Major = major,
            };
        }*/
    }
}

