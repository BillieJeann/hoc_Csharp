using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Moiquanhe
{
    internal class Student2 : Person
    {
        public static int idindex = 1000;
        public string Id = "ST" + idindex++;
        public string Major { get; set; }
        public Student2()
        {

        }
        public Student2(string firstname, string midname, string lastname, string addr, int age, string major) : base(firstname, midname, lastname, addr, age)
        {
            Major = major;
        }
    }
    class Subject
    {
        public static int subjectidindex = 1000;
        public int Subjectid = subjectidindex++;
        public string SubjectName { get; set; }
        public int CrediNumber { get; set; }
        public Subject()
        {

        }
        public Subject(string subjectName, int creditNumber)
        {
            SubjectName = subjectName;
            CrediNumber = creditNumber;
        }
    }
    class Course
    {
        public static int courseidindex = 1000;
        public int Courseid = courseidindex++;
        public Subject Subject { get; set; }
        public int StudentQuantity { get; set; }
        public string Teacher { get; set; }
        public GradeTable[] GradeTable { get; set; }
        public int IndexGradeTable { get; set; }
        public Course()
        {

        }
        public Course(Subject subject, int quantity, string teacher)
        {
            Subject = subject;
            StudentQuantity = quantity;
            IndexGradeTable = 0;
            Teacher = teacher;
            GradeTable = new GradeTable[quantity];
        }
    }
    class GradeTable
    {
        public static int _gradeidindex = 10000;
        public int GradeId = _gradeidindex++;
        public Student2 Student { get; set; }
        public double FirstGrade { get; set; }
        public double SecondGrade { get; set; }
        public double ThirdGrade { get; set; }
        public double Gpa { get; set; }
        public GradeTable()
        {

        }
        public GradeTable(Student2 student, double first, double second, double third)
        {
            Student = student;
            FirstGrade = first;
            SecondGrade = second;
            ThirdGrade = third;
            Gpa = FirstGrade * 0.1 + SecondGrade * 0.3 + ThirdGrade * 0.6;
        }
    }
    class Programm
    {
        static void Main()
        {
            Student2[] students = new Student2[10];
            Subject[] subjects = new Subject[10];
            Course[] courses = new Course[10];

            int studentindex = 0;
            int subjectindex = 0;
            int courseindex = 0;

            bool run = true;
            string key;
            Console.OutputEncoding = Encoding.UTF8;

            while (run)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một sinh viên vào danh sách.\r\n" +
                    "2) Thêm mới môn học vào danh sách.\r\n" +
                    "3) Thêm mới lớp học phần vào danh sách các lớp học phần.\r\n" +
                    "4) Nhập bảng điểm cho các sinh viên trong một lớp học phần bằng cách nhập mã lớp, mã sinh viên và các đầu điểm hệ số 1, 2. 3. Bảng điểm của mỗi sinh viên với 1 môn học chỉ xuất hiện 1 lần trong danh sách bảng điểm.\r\n" +
                    "5) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông tin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
                    "6) Hiển thị danh sách môn học ra màn hình.\r\n" +
                    "7) Hiển thị danh sách bảng điểm của từng lớp học phần\r\n" +
                    "8) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
                    "9) Tìm sinh viên theo mã sinh viên cho trước.\r\n" +
                    "10) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
                    "11) Sắp xếp danh sách bảng điểm của một lớp học phần theo thứ tự điểm TB môn giảm dần.\r\n" +
                    "12) Liệt kê số lượng sinh viên đạt điểm TB loại giỏi(>= 8.0 ở hệ 10) trong các lớp học phần theo thứ tự giảm dần.\r\n" +
                    "13) Liệt kê số lượng sinh viên trượt môn trong từng lớp học phần(điểm TB < 4) theo thứ tự số lượng sinh viên giảm dần.\r\n" +
                    "14) Sửa điểm cho sinh viên theo mã lớp học phần và mã sinh viên.\r\n" +
                    "15) Tìm các sinh viên có điểm >= x trong lớp học phần khi biết mã lớp.\r\n" +
                    "16) Xóa bảng điểm của sinh viên có mã x trong lớp học phần mã p nào đó.\r\n" +
                    "17) Kết thúc chương trình");
                Console.Write("Nhập lựa chọn của bạn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        students[studentindex++] = CreatNewStudent();
                        break;
                    case 2:
                        subjects[subjectindex++] = CreatNewSubject();
                        break;
                    case 3:
                        courses[courseindex++] = CreatNewCourse(courses, subjects);
                        break;
                    case 4:
                        CreatNewGradeTable(courses, students);
                        break;
                    case 5:
                        ShowStudentsList(students);
                        break;
                    case 6:
                        ShowSubjectList(subjects);
                        break;
                    case 7:
                        ShowGradeTablesList(courses);
                        break;
                    case 8:
                        SortStudentByLastName(students);
                        break;
                    case 9:
                        FindStudentById(courses);
                        break;
                    case 10:
                        DeleteStudent(students, ref studentindex);
                        break;
                    case 11:
                        SortGradeTable(courses);
                        break;
                    case 12:
                        ListPassedStudent(courses);
                        break;
                    case 13:
                        ListFailedStudent(courses);
                        break;
                    case 14:
                        ChangStudentGpa(courses,students);
                        break;
                    case 15:
                        ShowStudentHasGpaX(courses);
                        break;
                    case 16:
                        DeleteGradeTable(courses);
                        break;
                    case 17:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }
            }
        }

        private static void DeleteGradeTable(Course[] courses)
        {
            Console.Write("Nhập mã học phần : ");
            int courseId = int.Parse(Console.ReadLine());
            var searchedCourse = CheckCourses(courses, courseId);
            if (searchedCourse == null)
            {
                Console.WriteLine("Không tìm thấy học phần");
                return;
            }
            Console.Write("Nhập mã sinh viên : ");
            string studentId = Console.ReadLine();
            for (int i = 0; i < searchedCourse.GradeTable.Length; i++)
            {
                if (searchedCourse.GradeTable[i] != null && searchedCourse.GradeTable[i].Student.Id.CompareTo(studentId) == 0)
                {
                    searchedCourse.GradeTable[i] = null;
                    for (int j = i; j < searchedCourse.GradeTable.Length - 1; j++)
                    {
                       
                        Swap<GradeTable>(ref searchedCourse.GradeTable[j], ref searchedCourse.GradeTable[j + 1]);
                    }
                    searchedCourse.IndexGradeTable--;
                }
            }
        }

        private static void ShowStudentHasGpaX(Course[] courses)
        {
            Console.Write("Nhập mã học phần : ");
            int courseId = int.Parse(Console.ReadLine());
            var searchedCourse = CheckCourses(courses, courseId);
            if (searchedCourse == null)
            {
                Console.Write("Không tìm thấy học phần");
                return;
            }
            Console.Write("Nhập số điểm cần tìm : ");
            double target = double.Parse(Console.ReadLine());
            for (int i = 0; i < searchedCourse.GradeTable.Length; i++)
            {
                if (searchedCourse.GradeTable[i] != null && searchedCourse.GradeTable[i].Gpa >= target)
                {
                    Console.WriteLine($"Sinh viên {searchedCourse.GradeTable[i].Student.Id} : {searchedCourse.GradeTable[i].Gpa}");
                }
            }
        }

        private static void ChangStudentGpa(Course[] courses, Student2[] students)
        {
            Console.Write("Nhập mã học phần : ");
            int id = int.Parse(Console.ReadLine());
            var searched = CheckCourses(courses, id);
            if (searched == null)
            {
                Console.WriteLine("Không tìm thấy học phần");
                return;
            }
            Console.Write("Nhập mã sinh viên : ");
            string studentId = Console.ReadLine();
            var searchedStudent = CheckInCourseStudent(searched.GradeTable, studentId);
            if (searchedStudent == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên");
                return;
            }
            Console.Write("Nhập điểm mới cho sinh viên : ");
            double newGrade = double.Parse(Console.ReadLine());
            searched.GradeTable[searchedStudent].Gpa = newGrade;
            Console.WriteLine("Sửa điểm thành công");
        }

        private static int CheckInCourseStudent(GradeTable[] gradeTable, string id)
        {
            for (int i = 0; i < gradeTable.Length; i++)
            {
                if (gradeTable[i] != null && gradeTable[i].Student.Id.CompareTo(id) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void ListFailedStudent(Course[] courses)
        {
            Listgradestudent[] list = new Listgradestudent[courses.Length];
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    list[i] = new Listgradestudent();
                    for (int j = 0; j < courses[i].GradeTable.Length; j++)
                    {
                        if (courses[i].GradeTable[j] != null && courses[i].GradeTable[j].Gpa < 4)
                        {
                            list[i].Id = courses[i].Courseid;
                            list[i].Count++;
                        }
                    }
                }
            }
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (ChecListQuantity(list[i], list[j]) > 0)
                    {
                        Swap<Listgradestudent>(ref list[i], ref list[j]);
                    }
                }
            }
            foreach (var item in list)
            {
                if (item != null)
                {
                    Console.WriteLine($"Lớp {item.Id} có {item.Count} học sinh đạt điểm trung bình kém");
                }
            }
        }
        private static void ListPassedStudent(Course[] courses)
        {
            Listgradestudent[] list = new Listgradestudent[courses.Length];
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    list[i] = new Listgradestudent();
                    for (int j = 0; j < courses[i].GradeTable.Length; j++)
                    {
                        if (courses[i].GradeTable[j] != null && courses[i].GradeTable[j].Gpa >= 8)
                        {
                            list[i].Id = courses[i].Courseid;
                            list[i].Count++;
                        }
                    }
                }
            }
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (ChecListQuantity(list[i], list[j]) > 0)
                    {
                        Swap<Listgradestudent>(ref list[i], ref list[j]);
                    }
                }
            }
            foreach (var item in list)
            {
                if (item != null)
                {
                    Console.WriteLine($"Lớp {item.Id} có {item.Count} học sinh đạt điểm trung bình giỏi");
                }
            }
        }

        private static void Swap<T>(ref T listgradestudent1, ref T listgradestudent2)
        {
            T tmp = listgradestudent1;
            listgradestudent1 = listgradestudent2;
            listgradestudent2 = tmp;
        }

        private static int ChecListQuantity(Listgradestudent listgradestudent1, Listgradestudent listgradestudent2)
        {
            if (listgradestudent1 == null || listgradestudent2 == null)
            {
                return 0;
            }
            if (listgradestudent1.Count < listgradestudent2.Count)
            {
                return 1;
            }
            return 0;
        }

        class Listgradestudent
        {

            public int Id { get; set; }
            public int Count { get; set; }
            public Listgradestudent()
            {

            }
            public Listgradestudent(int id)
            {
                Id = id;
            }
        }

        private static void SortGradeTable(Course[] courses)
        {
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    for (int j = 0; j < courses[i].GradeTable.Length - 1; j++)
                    {
                        for (int k = j + 1; k < courses[i].GradeTable.Length; k++)
                        {
                            if (CheckGradeTable(courses[i].GradeTable[j], courses[i].GradeTable[k]))
                            {
                                Swap<GradeTable>(ref courses[i].GradeTable[j], ref courses[i].GradeTable[k]);
                            }
                        }
                    }
                }
            }
        }
      
        private static bool CheckGradeTable(GradeTable gradeTable1, GradeTable gradeTable2)
        {
            if (gradeTable1 == null || gradeTable2 == null)
            {
                return false;
            }
            if (gradeTable1.Gpa < gradeTable2.Gpa)
            {
                return true;
            }
            return false;
        }

        private static void DeleteStudent(Student2[] students, ref int studentindex)
        {
            Console.Write("Nhập mã sinh viên : ");
            string id = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Id.CompareTo(id) == 0)
                {
                    students[i] = null;
                    for (int j = i; j < students.Length - 1; j++)
                    {
                        Swap<Student2>(ref students[j], ref students[j + 1]);
                    }
                }
            }
        }

        private static void FindStudentById(Course[] students)
        {
            Student2[] searchedStudent = new Student2[1];
            Course[] searchedCourse = new Course[students.Length];
            Console.Write("Nhập mã sinh viên : ");
            string id = Console.ReadLine();
            var searched = CheckId(students, id);
            if (searched == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên");
                return;
            }
            if (!CheckGradeTable(searched.GradeTable, searched.GradeTable[searched.IndexGradeTable].Student.Id))
            {
                Console.WriteLine("Sinh viên chưa đăng ký bảng điểm");
                return;
            }
            searchedStudent[0] = searched.GradeTable[searched.IndexGradeTable].Student;
            ShowStudentsList(searchedStudent);
            ShowGradeTablesList(searchedCourse);
        }

        private static Course CheckId(Course[] students, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    foreach (var item in students[i].GradeTable)
                    {
                        if (item != null && item.Student.Id.CompareTo(id) == 0)
                        {
                            return students[i];
                        }
                    }
                }
            }
            return null;
        }

        private static void SortStudentByLastName(Student2[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CheckStudentName(students[i], students[j]) > 0)
                    {
                        Swap<Student2>(ref students[i], ref students[j]);
                    }
                }
            }
        }
        private static int CheckStudentName(Student2 student1, Student2 student2)
        {
            if (student1 == null || student2 == null)
            {
                return 0;
            }
            if (student1.LastName.CompareTo(student2.LastName) > 0)
            {
                return 1;
            }
            return 0;
        }

        private static void ShowGradeTablesList(Course[] courses)
        {
            var titleCourseId = "MÃ LỚP HỌC";
            var titleStudentName = "TÊN SINH VIÊN";
            var titleFirst = "ĐIỂM HỆ SỐ 1|2|3";
            var titleGpa = "ĐIỂM TRUNG BÌNH";
            
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null)
                {
                    Console.Write($"{titleCourseId} : ");
                    Console.WriteLine($"{courses[i].Courseid,-30} ");
                    Console.WriteLine($"{titleStudentName,-30} {titleFirst,-30} {titleGpa,-30}");
                    foreach (var item in courses[i].GradeTable)
                    {                      
                        if (item != null)
                        {                          
                            Console.WriteLine($"{item.Student.FirsName + " " + item.Student.MiddleName + " " + item.Student.LastName,-30} {item.FirstGrade + " " + item.SecondGrade + " " + item.ThirdGrade,-30} {item.Gpa,-30}");
                        }
                    }

                }
            }
        }
        private static void ShowSubjectList(Subject[] subjects)
        {
            var titleId = "MÃ MÔN";
            var titleSubjectName = "TÊN MÔN";
            var titleCredit = "SỐ TÍN CHỈ";
            Console.WriteLine($"{titleId,-30} {titleSubjectName,-30} {titleCredit,-30}");

            foreach (var item in subjects)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Subjectid,-30} {item.SubjectName,-30} {item.CrediNumber,-30}");
                }
            }
        }

        private static void ShowStudentsList(Student2[] students)
        {
            var titleId = "MÃ SINH VIÊN";
            var titleFullName = "HỌ VÀ TÊN";
            var titleAddr = "ĐỊA CHỈ";
            var titleMajor = "CHUYÊN NGÀNH";
            var titleAge = "TUỔI";
            Console.WriteLine($"{titleId,-30} {titleFullName,-30} {titleAddr,-30} {titleMajor,-30} {titleAge,-30}");
            foreach (var item in students)
            {
                if (item != null && item is Student2)
                {
                    Student2 student = item;
                    Console.WriteLine($"{student.Id,-30} {student.FirsName + " " + student.MiddleName + " " + student.LastName,-30} {student.Address,-30} {student.Major,-30} {student.Age,-30}");
                }
            }
        }

        private static void CreatNewGradeTable(Course[] courses, Student2[] students)
        {
            Console.Write("Nhập ID lớp học : ");
            int id = int.Parse(Console.ReadLine());
            var searchedCourse = CheckCourses(courses, id);
            if (searchedCourse == null)
            {
                Console.WriteLine("Không tìm thấy lớp học");
                return;
            }
            Console.Write("Nhập mã sinh viên : ");
            string studentId = Console.ReadLine();
            var student = CheckStudent(students, studentId);
            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên");
                return;
            }
            if (CheckGradeTable(searchedCourse.GradeTable, student.Id))
            {
                Console.WriteLine("Sinh viên đã đăng ký bảng điểm");
                return;
            }
            if (searchedCourse.IndexGradeTable >= searchedCourse.StudentQuantity)
            {
                Console.WriteLine("Quá giới hạn");
                return;
            }
            Console.Write("Nhập điểm hệ số 1 : ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hệ số 2 : ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hệ số 3 : ");
            double third = double.Parse(Console.ReadLine());

            searchedCourse.GradeTable[searchedCourse.IndexGradeTable] = new GradeTable(student, first, second, third);
            searchedCourse.IndexGradeTable++;
            Console.WriteLine("Thêm bảng điểm thành công");
        }


        private static bool CheckGradeTable(GradeTable[] gradeTables, string id)
        {
            foreach (var item in gradeTables)
            {
                if (item != null && item.Student.Id.CompareTo(id) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static Student2 CheckStudent(Student2[] students, string studentId)
        {
            foreach (var item in students)
            {
                if (item != null && item.Id.CompareTo(studentId) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        private static Course CheckCourses(Course[] courses, int id)
        {
            foreach (var item in courses)
            {
                if (item != null && item.Courseid == id)
                {
                    return item;
                }
            }
            return null;
        }

        private static Course CreatNewCourse(Course[] courses, Subject[] subjects)
        {
            Console.Write("Chọn môn học : ");
            string subjectname = Console.ReadLine();
            var searched = CheckSubjectName(subjects, subjectname);
            if (searched == null)
            {
                Console.WriteLine("Không tìm thấy môn học");
                return null;
            }
            if (CheckSubjectInCourse(courses, subjectname))
            {
                Console.WriteLine("Đã tồn tại lớp học");
                return null;

            }
            Console.Write("Nhập số lượng sinh viên : ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên giáo viên : ");
            string name = Console.ReadLine();
            return new Course(searched, quantity, name);
        }
        private static bool CheckSubjectInCourse(Course[] courses, string subjectname)
        {
            foreach (var item in courses)
            {
                if (item != null && item.Subject.SubjectName == subjectname)
                {
                    return true;
                }
            }
            return false;
        }

        private static Subject CheckSubjectName(Subject[] subjects, string subjectname)
        {
            foreach (Subject item in subjects)
            {
                if (item != null && item.SubjectName == subjectname)
                {
                    return item;
                }
            }
            return null;
        }

        private static Subject CreatNewSubject()
        {
            Console.Write("Nhập tên môn học : ");
            string subjectName = Console.ReadLine();
            Console.Write("Nhập số tín chỉ của môn : ");
            int credit = int.Parse(Console.ReadLine());
            return new Subject(subjectName, credit);
        }

        private static Student2 CreatNewStudent()
        {
            while (true)
            {
                Console.Write("Nhập họ : ");
                string firstName = Console.ReadLine();
                Console.Write("Nhập tên đệm : ");
                string midName = Console.ReadLine();
                Console.Write("Nhập tên : ");
                string lastName = Console.ReadLine();
                Console.Write("Nhập địa chỉ : ");
                string addr = Console.ReadLine();
                Console.Write("Nhập tuổi : ");
                string age = Console.ReadLine();
                Console.Write("Nhập chuyên ngành : ");
                string major = Console.ReadLine();
                if (int.TryParse(age, out int studentAge) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                return new Student2(firstName, midName, lastName, addr, studentAge, major);
            }
        }
    }
}
