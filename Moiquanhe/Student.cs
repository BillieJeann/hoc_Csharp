//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Moiquanhe
//{
//    internal class Student
//    {
//        public int subjectindex = 0;
//        public static int idindex = 1000;
//        public string Id = "STU" + idindex++;
//        class Name
//        {
//            public string FirstName;
//            public string MiddleName;
//            public string LastName;
//        }

//        private Name fullname;
//        public string WholeName
//        {
//            get => $"{fullname.FirstName} {fullname.MiddleName} {fullname.LastName}";
//            set
//            {
//                var name = value.Split(' ');
//                fullname.FirstName = name[0];
//                fullname.LastName = name[name.Length - 1];
//                var mid = "";
//                for (int i = 1; i < name.Length - 1; i++)
//                {
//                    mid += name[i];
//                }
//                fullname.MiddleName = mid + " ";
//            }
//        }
//        public string FirstName => fullname.FirstName;
//        public string MiddleName => fullname.MiddleName;
//        public string LastName => fullname.LastName;
//        public string Major { get; set; }
//        public Student()
//        {

//        }
//        public Student(string name, string major)
//        {
//            fullname = new Name();
//            WholeName = name;
//            Major = major;
//        }
//    }
//    internal class Subject
//    {
//        public static int idindex = 10000;
//        public int Id = idindex++;
//        public string Subjectname { get; set; }
//        public int Sotinchi { get; set; }
//        public int Period { get; set; }
//        public Subject()
//        {

//        }
//        public Subject(string subjectname, int sotinchi, int period)
//        {
//            Subjectname = subjectname;
//            Sotinchi = sotinchi;
//            Period = period;
//        }
//    }
//    internal class Registertable
//    {
//        public int Registercod { get; set; }
//        public Student Student { get; set; }
//        public Subject Subject { get; set; }
//        public DateTime DateTime { get; set; }
//        public Registertable(Student student, Subject subject, DateTime dateTime, int regiscode)
//        {
//            Student = student;
//            Subject = subject;
//            DateTime = dateTime;
//            Registercod = regiscode;
//        }
//    }
//    class Programm
//    {
//        static void Main()
//        {
//            Student[] students = new Student[10];          
//            Subject[] subjects = new Subject[10];
//            Registertable[] registertables = new Registertable[10];

//            int registertalbeIndex = 0;
//            int studentindex = 0;
//            int subjectindex = 0;
//            string key;
//            bool run = true;
//            Console.OutputEncoding = Encoding.UTF8;
//            while (run)
//            {
//                Console.WriteLine("" +
//                    "1) Thêm mới sinh viên vào danh sách sinh viên.\r\n" +
//                    "2) Thêm mới môn học vào danh sách môn học.\r\n" +
//                    "3) Thêm mới bản đăng ký môn học cho sinh viên bằng cách nhập mã sinh viên và mã môn\r\nhọc cần đăng ký. Mỗi sinh viên với 1 môn học không được xuất hiện quá 1 lần trong danh\r\nsách bản đăng ký. Mỗi sinh viên chỉ được đăng ký không quá 8 môn học.\r\n" +
//                    "4) Hiển thị danh sách sinh viên ra màn hình dạng bảng gồm các hàng, cột ngay ngắn.\r\n" +
//                    "5) Hiển thị danh sách môn học ra màn hình dạng bảng gồm các hàng, cột ngay ngắn.\r\n" +
//                    "6) Hiển thị danh sách đăng ký môn học ra màn hình dạng bảng gồm các hàng cột ngay ngắn.\r\nThông tin hiển thị bao gồm: mã đăng ký, mã sinh viên, họ tên sinh viên, mã môn, tên môn,\r\nthời gian đăng ký.\r\n" +
//                    "7) Sắp xếp danh sách sinh viên theo tên a-z. Nếu tên trùng nhau thì sắp xếp theo họ a-z.\r\n" +
//                    "8) Sắp xếp danh sách môn học theo số tín chỉ giảm dần.\r\n" +
//                    "9) Sắp xếp danh sách đăng ký môn học theo thời gian đăng ký từ sớm nhất đến muộn nhất.\r\n" +
//                    "10) Sắp xếp danh sách đăng ký môn học theo mã sinh viên tăng dần.\r\n" +
//                    "11) Sắp xếp danh sách đăng ký môn học theo mã môn học tăng dần.\r\n" +
//                    "12) Tìm danh sách đăng ký theo mã môn học.\r\n" +
//                    "13) Tìm danh sách đăng ký theo mã sinh viên.\r\n" +
//                    "14) Sửa thông tin tên sinh viên theo mã sinh viên cho trước.\r\n" +
//                    "15) Sửa thông tin số tiết học theo mã môn học cho trước.\r\n" +
//                    "16) Xóa môn học khỏi danh sách môn học theo mã môn học.\r\n" +
//                    "17) Xóa sinh viên khỏi danh sách sinh viên theo mã sinh viên.\r\n" +
//                    "18) Xóa bản đăng ký theo mã đăng ký.\r\n" +
//                    "19) Thoát chương trình");
//                Console.Write("Nhap lua chon : ");
//                key = Console.ReadLine();
//                if (int.TryParse(key, out int newKey) == false)
//                {
//                    Console.WriteLine("Khong phu hop");
//                    continue;
//                }
//                switch (newKey)
//                {
//                    case 1:
//                        students[studentindex++] = CreateNewStudent();
//                        break;
//                    case 2:
//                        subjects[subjectindex++] = CreateNewSubject();
//                        break;
//                    case 3:
//                        var regis = CreateNewResgisterTable(registertables, students, subjects);
//                        if (regis != null)
//                        {
//                            registertables[registertalbeIndex++] = regis;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Khong the dang ky");
//                        }
//                        break;
//                    case 4:
//                        ShowStudentList(students);
//                        break;
//                    case 5:
//                        ShowSubjectlist(subjects);
//                        break;
//                    case 6:
//                        ShowResgisterlist(registertables);
//                        break;
//                    case 7:
//                        SortStudentByName(students);
//                        break;
//                    case 8:
//                        SortSubject(subjects);
//                        break;
//                    case 9:
//                        SortResgister(registertables);
//                        break;
//                    case 10:
//                        SortRegistertableByStudentid(registertables);
//                        break;
//                    case 11:
//                        SortRegistertableBySubjectid(registertables);
//                        break;
//                    case 12:
//                        FindRegisterListBySubjectName(registertables);
//                        break;
//                    case 13:
//                        FindRegisterListByStudentId(registertables);
//                        break;
//                    case 14:
//                        ChangeStudentInfoById(students);
//                        break;
//                    case 15:
//                        ChangePeriodBySubjectId(subjects);
//                        break;
//                    case 16:
//                        DeleteSubjectById(subjects,ref subjectindex);
//                        break;
//                    case 17:
//                        DeleteStudentById(students, ref studentindex);
//                        break;
//                    case 18:
//                        DeleteRegisterById(registertables, ref registertalbeIndex);
//                        break;
//                    case 19:
//                        run = false;
//                        break;
//                    default:
//                        Console.WriteLine("Nhập sai lựa chọn");
//                        break;
//                }
//            }
//        }

//        private static void DeleteRegisterById(Registertable[] registertables, ref int registertalbeIndex)
//        {
//            Console.Write("Nhập mã bản đăng ký : ");
//            int id = int.Parse(Console.ReadLine());
//            var searched = CheckRegisterId(registertables, id);
//            if (searched == null)
//            {
//                Console.WriteLine("Không tìm thấy bản đăng ký ! ");
//                return;
//            }
//            for (int i = 0; i < registertables.Length; i++)
//            {
//                if (registertables[i] != null && registertables[i] == searched)
//                {
//                    for (int j = i; j < registertables.Length - 1; j++)
//                    {
//                        Swap(ref registertables[j], ref registertables[j + 1]);
//                    }
//                    registertalbeIndex--;
//                }
//            }
//        }

//        private static Registertable CheckRegisterId(Registertable[] registertables, int id)
//        {
//            foreach (var item in registertables)
//            {
//                if (item != null && item.Registercod == id)
//                {
//                    return item;
//                }
//            }
//            return null;
//        }

//        private static void DeleteStudentById(Student[] students, ref int studentindex)
//        {
//            Console.Write("Nhập mã sinh viên : ");
//            string id = Console.ReadLine();
//            var searched = CheckId(students, id);
//            if (searched == null)
//            {
//                Console.WriteLine("Không tìm thấy sinh viên ! ");
//                return;
//            }
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null && students[i] == searched)
//                {
//                    for (int j = i; j < students.Length - 1; j++)
//                    {
//                        Swap(ref students[j], ref students[j + 1]);
//                    }
//                    studentindex--;
//                }
//            }
//        }

//        private static void DeleteSubjectById(Subject[] subjects , ref int index)
//        {
//            Console.Write("Nhập mã môn học : ");
//            int id = int.Parse(Console.ReadLine());
//            var searched = Checksubject(subjects, id);
//            if (searched == null)
//            {
//                Console.WriteLine("Không tìm thấy môn học ! ");
//                return;
//            }
//            for (int i = 0; i < subjects.Length; i++)
//            {
//                if (subjects[i] != null && subjects[i] == searched)
//                {
//                    for (int j = i; j < subjects.Length - 1; j++)
//                    {
//                        Swap(ref subjects[j], ref subjects[j + 1]);
//                    }
//                    index--;
//                }
//            }
//        }

//        private static void ChangePeriodBySubjectId(Subject[] subjects)
//        {
//            Console.Write("Nhập mã môn học : ");
//            int id = int.Parse(Console.ReadLine());
//            var searched = Checksubject(subjects, id);
//            if (searched == null)
//            {
//                Console.WriteLine("Không tìm thấy môn học !");
//                return;
//            }
//            Console.Write("Nhập số tiết mới : ");
//            int period = int.Parse(Console.ReadLine());
//            searched.Period = period;
//            Console.WriteLine("Sửa số tiết học thành công");
//        }

//        private static void ChangeStudentInfoById(Student[] students)
//        {
//            Console.Write("Nhập mã sinh viên : ");
//            string id = Console.ReadLine();
//            var searched = CheckId(students, id);
//            if (searched == null)
//            {
//                Console.WriteLine("Không tìm thấy sinh viên!");
//                return;
//            }
//            Console.Write("Nhập họ tên sinh viên : ");
//            string fullname = Console.ReadLine();
//            Console.Write("Nhập chuyên ngành sinh viên : ");
//            string major = Console.ReadLine();
//            searched.WholeName = fullname;
//            searched.Major = major;
//            Console.WriteLine("Sửa thông tin cho sinh viên thành công");
//        }

//        private static void FindRegisterListByStudentId(Registertable[] registertables)
//        {
//            Console.Write("Nhập mã sinh viên : ");
//            string id = Console.ReadLine();
//            Registertable[] searched = new Registertable[registertables.Length];
//            int index = 0;
//            foreach (var item in registertables)
//            {
//                if (item != null && item.Subject.Subjectname.CompareTo(id) == 0)
//                {
//                    searched[index] = item;
//                    index++;
//                }
//            }
//            ShowResgisterlist(searched);
//        }

//        private static void FindRegisterListBySubjectName(Registertable[] registertables)
//        {
//            Console.Write("Nhập tên môn học : ");
//            string subjectName = Console.ReadLine();
//            Registertable[] searched = new Registertable[registertables.Length];
//            int index = 0;
//            foreach (var item in registertables)
//            {
//                if (item != null && item.Subject.Subjectname.CompareTo(subjectName) == 0)
//                {
//                    searched[index] = item;
//                    index++;
//                }
//            }
//            ShowResgisterlist(searched);
//        }

//        private static void SortRegistertableBySubjectid(Registertable[] registertables)
//        {
//            for (int i = 0; i < registertables.Length - 1; i++)
//            {
//                for (int j = i + 1; j < registertables.Length; j++)
//                {
//                    if (CheckSubjectId(registertables[i], registertables[j]) > 0)
//                    {
//                        Swap(ref registertables[i], ref registertables[j]);
//                    }
//                }
//            }
//        }

//        private static int CheckSubjectId(Registertable registertable1, Registertable registertable2)
//        {
//            if (registertable1 == null || registertable2 == null)
//            {
//                return 0;
//            }
//            if (registertable1.Subject.Id.CompareTo(registertable2.Subject.Id) < 0)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void SortRegistertableByStudentid(Registertable[] registertables)
//        {
//            for (int i = 0; i < registertables.Length - 1; i++)
//            {
//                for (int j = i + 1; j < registertables.Length; j++)
//                {
//                    if (CheckStudentId(registertables[i], registertables[j]) > 0)
//                    {
//                        Swap(ref registertables[i], ref registertables[j]);
//                    }
//                }
//            }
//        }

//        private static int CheckStudentId(Registertable registertable1, Registertable registertable2)
//        {
//            if (registertable1 == null || registertable2 == null)
//            {
//                return 0;
//            }
//            if (registertable1.Student.Id.CompareTo(registertable2.Student.Id) > 0)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void SortResgister(Registertable[] registertables)
//        {
//            for (int i = 0; i < registertables.Length - 1; i++)
//            {
//                for (int j = i + 1; j < registertables.Length; j++)
//                {
//                    if (CheckRegisterDate(registertables[i], registertables[j]) > 0)
//                    {
//                        Swap(ref registertables[i], ref registertables[j]);
//                    }
//                }
//            }
//        }

//        private static int CheckRegisterDate(Registertable registertable1, Registertable registertable2)
//        {
//            if (registertable1 == null || registertable2 == null)
//            {
//                return 0;
//            }
//            if (registertable1.DateTime > registertable2.DateTime)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void SortSubject(Subject[] subjects)
//        {
//            for (int i = 0; i < subjects.Length - 1; i++)
//            {
//                for (int j = i + 1; j < subjects.Length; j++)
//                {
//                    if (CheckSubject(subjects[i], subjects[j]) > 0)
//                    {
//                        Swap(ref subjects[i], ref subjects[j]);
//                    }
//                }
//            }
//        }

//        private static int CheckSubject(Subject subject1, Subject subject2)
//        {
//            if (subject1 == null || subject2 == null)
//            {
//                return 0;
//            }
//            if (subject1.Sotinchi < subject2.Sotinchi)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void SortStudentByName(Student[] students)
//        {
//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                for (int j = i + 1; j < students.Length; j++)
//                {
//                    if (CheckName(students[i], students[j]) > 0)
//                    {
//                        Swap(ref students[i], ref students[j]);
//                    }
//                }
//            }
//        }
//        private static void Swap(ref Registertable student1, ref Registertable student2)
//        {
//            Registertable tmp = student1;
//            student1 = student2;
//            student2 = tmp;
//        }
//        private static void Swap(ref Subject student1, ref Subject student2)
//        {
//            Subject tmp = student1;
//            student1 = student2;
//            student2 = tmp;
//        }

//        private static void Swap(ref Student student1, ref Student student2)
//        {
//            Student tmp = student1;
//            student1 = student2;
//            student2 = tmp;
//        }

//        private static int CheckName(Student student1, Student student2)
//        {
//            if (student1 == null || student2 == null)
//            {
//                return 0;
//            }
//            if (student1.LastName.CompareTo(student2.LastName) > 0 || student1.LastName.CompareTo(student2.LastName) == 0 && student1.FirstName.CompareTo(student2.FirstName) > 0)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void ShowResgisterlist(Registertable[] registertables)
//        {
//            var titleRegisternumber = "MÃ ĐĂNG KÝ";
//            var titleStudentId = "MÃ SINH VIÊN";
//            var titleFullname = "HỌ VÀ TÊN";
//            var titleSubjectid = "MÃ MÔN HỌC";
//            var titleSubjectname = "TÊN MÔN HỌC";
//            var titleRegistertime = "THỜI GIAN ĐĂNG KÝ";
//            Console.WriteLine($"{titleRegisternumber,-15} {titleStudentId,-15} {titleFullname,-15} {titleSubjectid,-15} {titleSubjectname,-15} {titleRegistertime,-15}");
//            foreach (var item in registertables)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Registercod,-15} {item.Student.Id,-15} {item.Student.WholeName,-15} {item.Subject.Id,-15} {item.Subject.Subjectname,-15} {item.DateTime,-15}");
//                }
//            }
//        }

//        private static void ShowSubjectlist(Subject[] subjects)
//        {
//            var titleId = "MÃ MÔN HỌC";
//            var titleSubjectname = "TÊN MÔN HỌC";
//            var titleSotinchi = "SỐ TÍN CHỈ";
//            var titlePeriod = "SỐ TIẾT";
//            Console.WriteLine($"{titleId,-15} {titleSubjectname,-15} {titleSotinchi,-15} {titlePeriod,-15}");
//            foreach (var item in subjects)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Id,-15} {item.Subjectname,-15} {item.Sotinchi,-15} {item.Period,-15}");
//                }
//            }
//        }

//        private static void ShowStudentList(Student[] students)
//        {
//            var titleId = "MÃ SINH VIÊN";
//            var titleFullname = "HỌ VÀ TÊN";
//            var titleMajor = "CHUYÊN NGÀNH";
//            Console.WriteLine($"{titleId,-15} {titleFullname,-15} {titleMajor,-15}");
//            foreach (var item in students)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Id,-15} {item.WholeName,-15} {item.Major,-15}");
//                }
//            }
//        }

//        private static Registertable CreateNewResgisterTable(Registertable[] registertables, Student[] students, Subject[] subject)
//        {
//            Console.Write("Nhap ma sinh vien : ");
//            string id = Console.ReadLine();
//            var searchedstudent = CheckId(students, id);
//            Console.Write("Nhap ma mon hoc : ");
//            int subjectid = int.Parse(Console.ReadLine());
//            var searchedsubjeect = Checksubject(subject, subjectid);
//            if (searchedstudent == null || searchedsubjeect == null)
//            {
//                Console.WriteLine("Khong tim thay sv or subject");
//                return null;
//            }
//            if (!CheckStudent(registertables, searchedstudent.Id, searchedsubjeect.Id))
//            {
//                if (searchedstudent.subjectindex > 8)
//                {
//                    Console.WriteLine("Da dang ky qua 8 mon");
//                    return null;
//                }
//                Console.Write("Nhập mã đăng ký : ");
//                int madangky = int.Parse(Console.ReadLine());
//                searchedstudent.subjectindex++;
//                return new Registertable(searchedstudent, searchedsubjeect, DateTime.Now, madangky);
//            }
//            else
//            {
//                Console.WriteLine($"Sinh vien da dang ky mon hoc");
//            }
//            return null;

//        }
//        private static bool CheckStudent(Registertable[] registertables, string id, int subjectids)
//        {
//            for (int i = 0; i < registertables.Length; i++)
//            {
//                if (registertables[i] != null && registertables[i].Student.Id == id && registertables[i].Subject.Id == subjectids)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private static Subject Checksubject(Subject[] subject, int subj)
//        {
//            foreach (var item in subject)
//            {
//                if (item != null && item.Id == subj)
//                {
//                    return item;
//                }
//            }
//            return null;
//        }

//        private static Student CheckId(Student[] students, string id)
//        {
//            foreach (var item in students)
//            {
//                if (item != null && item.Id.CompareTo(id) == 0)
//                {
//                    return item;
//                }
//            }
//            return null;
//        }

//        private static Subject CreateNewSubject()
//        {
//            while (true)
//            {
//                Console.Write("Nhap ten mon hoc : ");
//                string subjectname = Console.ReadLine();
//                Console.Write("Nhap so tin chi : ");
//                string tin = Console.ReadLine();
//                Console.Write("Nhap so tiet hoc cua mon : ");
//                string tiet = Console.ReadLine();
//                if (int.TryParse(tin, out int tinchi) == false || int.TryParse(tiet, out int sotiet) == false)
//                {
//                    Console.WriteLine("Nhap sai");
//                    continue;
//                }
//                Console.WriteLine("Them mon hoc thanh cong");
//                return new Subject(subjectname, tinchi, sotiet);
//            }

//        }
//        private static Student CreateNewStudent()
//        {
//            Console.Write("Nhap ten sinh vien : ");
//            string fullname = Console.ReadLine();
//            Console.Write("Nhap chuyen nganh : ");
//            string major = Console.ReadLine();
//            Console.WriteLine("Tao sinh vien thanh cong");
//            return new Student(fullname, major);
//        }
//    }
//}
