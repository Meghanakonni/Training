using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

class CaseStudy
{
    public static SqlConnection con;
    public static SqlDataReader dr;
    public static SqlCommand cmd;
    static SqlConnection Getconnection()
    {
        con = new SqlConnection("Data Source=ICS-LT-DJK96V3;Initial Catalog=Casestudy;" +
            "integrated Security=true");
        con.Open();
        return con;
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Student(int id, string name, DateTime dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }
    }

    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Date of Birth: {student.DOB}");
        }

        public void DisplayStudentDetails(Student student)
        {
            Console.WriteLine($"Student ID:{student.Id}, Name: {student.Name}, Date Of Birth: {student.DOB}");
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }

    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public Student GetStudent()
        {
            return student;
        }
        public Course GetCourse()
        {
            return course;
        }
        public DateTime GetEnrollmentDate()
        {
            return enrollmentDate;
        }
    }

    class AppEngine
    {
        List<Student> students = new List<Student>();

        List<Course> courses = new List<Course>();

        List<Enroll> enrollments = new List<Enroll>();
        public void Introduce(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"New course introduced: {course.CourseName}");
        }

        public void Register(Student Register)
        {
            con = Getconnection();
            students.Add(Register);
        }
        public Student[] ListOfStudents()
        {
            con = Getconnection();
            return students.ToArray();
        }

        public Course[] ListOfCourses()
        {
            con = Getconnection();
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            con = Getconnection();
            DateTime enrollmentDate = DateTime.Now;
            Enroll enrollment = new Enroll(student, course, enrollmentDate);
            enrollments.Add(enrollment);
            Console.WriteLine($"Student {student.Name} enrolled in course {course.CourseName} on {enrollmentDate}");
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }

        public Student GetStudentById(int studentId)
        {
            return students.FirstOrDefault(student => student.Id == studentId);
        }
        public Course GetCourseById(int courseId)
        {
            return courses.FirstOrDefault(course => course.CourseId == courseId);
        }
    }

    abstract class UserInterface
    {
        public abstract void showFirstScreen();
        public abstract void showStudentScreen();
        public abstract void showAdminScreen();
        public abstract void showAllStudentsScreen();
        public abstract void showStudentRegistrationScreen();
        public abstract void introduceNewCourseScreen();
        public abstract void showAllCoursesScreen();
    }

    class ConsoleUserInterface : UserInterface
    {
        AppEngine appEngine;
        public ConsoleUserInterface(AppEngine appEngine)
        {
            this.appEngine = appEngine;
        }
        public override void showFirstScreen()
        {
            Console.WriteLine("\nWelcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice (1 or 2): ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        public override void showStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. View All Courses");
            Console.WriteLine("2. Back to Main Menu");
            Console.WriteLine("Enter your choice (1, or 2): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    showAllCoursesScreen();
                    break;
                case 2:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public override void showAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce a New Course");
            Console.WriteLine("2. Add a Student");
            Console.WriteLine("3. Register a Student");
            Console.WriteLine("4. Back to Main Menu");
            Console.WriteLine("Enter your choice (1, 2, 3 or 4): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    showAllStudentsScreen();
                    break;
                case 3:
                    showStudentRegistrationScreen();
                    break;
                case 4:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public override void showAllStudentsScreen()
        {
            con = Getconnection();
            try
            {
                int StudentID;
                string Name;
                DateTime DOB;

                Console.WriteLine("Please Enter StudentID:");
                StudentID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  name :");
                Name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter  dob :");
                DOB = Convert.ToDateTime(Console.ReadLine());

                cmd = new SqlCommand("insert into  student values(@sid,@Name,@DOB)", con);
                cmd.Parameters.AddWithValue("@sid", StudentID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@DOB", DOB);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Student added successfully");
                else
                    Console.WriteLine("Student not added successfully");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            showAdminScreen();
        }
        public override void showStudentRegistrationScreen()
        {
            try
            {
                int StudentID, CourseID;
                DateTime RegistrationDate;

                Console.WriteLine("Please Enter StudentID:");
                StudentID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  CourseID :");
                CourseID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter  RegistrationDate :");
                RegistrationDate = Convert.ToDateTime(Console.ReadLine());

                cmd = new SqlCommand("insert into  register values(@sid,@cid,@rdate)", con);
                cmd.Parameters.AddWithValue("@sid", StudentID);
                cmd.Parameters.AddWithValue("@cid", CourseID);
                cmd.Parameters.AddWithValue("@rdate", RegistrationDate);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Registration successfull");
                else
                    Console.WriteLine("Registration not successfull");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            showAdminScreen();
        }

        public override void introduceNewCourseScreen()
        {
            try
            {
                int CourseID;
                string CourseName;
                Console.WriteLine("Please Enter CourseID:");
                CourseID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter CourseName  :");
                CourseName = Convert.ToString(Console.ReadLine());

                cmd = new SqlCommand("insert into  Course values(@cid,@cname)", con);
                cmd.Parameters.AddWithValue("@cid", CourseID);
                cmd.Parameters.AddWithValue("@cname", CourseName);
                {
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        Console.WriteLine("Course Added Successfully");
                    else
                        Console.WriteLine("Course Not Added");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            showAdminScreen();
        }

        public override void showAllCoursesScreen()
        {
            con = Getconnection();
            cmd = new SqlCommand("select * from Course");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {           
                Console.WriteLine("CourseId :" + " " + dr[0]);
                Console.WriteLine("CourseName :" + " " + dr[1]);
                Console.WriteLine("*****************************************");
            }
            showStudentScreen();
        }
    }
    class App
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            AppEngine appEngine = new AppEngine();

            Scenario1();
            Scenario2();

            Console.WriteLine("****************************************************************");

            Course newCourse = new Course(201, "C Language");
            Course newCourse1 = new Course(202, "Ms-Excel");
            Course newCourse2 = new Course(203, "Full Stack");
            Course newCourse3 = new Course(204, "Big Data");
            Course newCourse4 = new Course(205, "Web Technologies");
            Course newCourse5 = new Course(206, "Java");

            appEngine.Introduce(newCourse);
            appEngine.Introduce(newCourse1);
            appEngine.Introduce(newCourse2);
            appEngine.Introduce(newCourse3);
            appEngine.Introduce(newCourse4);
            appEngine.Introduce(newCourse5);

            Console.WriteLine("****************************************************************");

            Student newStudent = new Student(101, "Hari Priya", new DateTime(2002, 8, 30));
            Student newStudent1 = new Student(102, "Sree Nidhi", new DateTime(2005, 9, 24));
            Student newStudent2 = new Student(103, "Chaitra", new DateTime(2000, 10, 18));
            Student newStudent3 = new Student(104, "Chitra", new DateTime(2004, 1, 16));
            Student newStudent4 = new Student(105, "Mayukha", new DateTime(2001, 4, 23));
            Student newStudent5 = new Student(106, "Mona Aishwarya", new DateTime(2006, 6, 26));

            appEngine.Register(newStudent);
            appEngine.Register(newStudent1);
            appEngine.Register(newStudent2);
            appEngine.Register(newStudent3);
            appEngine.Register(newStudent4);
            appEngine.Register(newStudent5);

            Console.WriteLine("****************************************************************");

            appEngine.Enroll(newStudent, newCourse);
            appEngine.Enroll(newStudent1, newCourse3);
            appEngine.Enroll(newStudent2, newCourse5);
            appEngine.Enroll(newStudent3, newCourse3);
            appEngine.Enroll(newStudent2, newCourse5);
            appEngine.Enroll(newStudent4, newCourse5);

            Student[] studentList = appEngine.ListOfStudents();
            Course[] courseList = appEngine.ListOfCourses();
            Enroll[] enrollmentList = appEngine.ListOfEnrollments();

            Console.WriteLine("\nList of Students:");

            foreach (var student in studentList)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}");
                info.DisplayStudentDetails(student);
            }

            Console.WriteLine("\nList of Courses:");
            foreach (var course in courseList)
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
            }

            Console.WriteLine("****************************************************************");

            Console.WriteLine("\nList of Enrollments:");

            foreach (var enrollment in enrollmentList)
            {
                Student enrolledStudent = enrollment.GetStudent();
                Course enrolledCourse = enrollment.GetCourse();
                DateTime enrollmentDate = enrollment.GetEnrollmentDate();
                Console.WriteLine($"Student: {enrolledStudent.Name}, Course: {enrolledCourse.CourseName}, Enrollment Date: {enrollmentDate}");
            }

            Console.WriteLine("****************************************************************");

            ConsoleUserInterface userInterface = new ConsoleUserInterface(appEngine);
            userInterface.showFirstScreen();
            Console.Read();
        }

        static void Scenario1()
        {
            Console.WriteLine("*************  CaseStudy Project - 1  *************");
            Console.WriteLine("************* Scenario-1  *************");

            Student student1 = new Student(1, "Bhavishya", new DateTime(2001, 6, 08));
            Student student2 = new Student(2, "Sirisha", new DateTime(2004, 8, 21));
            Student student3 = new Student(3, "Pavani", new DateTime(2003, 5, 31));

            Info info = new Info();
            info.Display(student1);
            info.Display(student2);
            info.Display(student3);
        }
        static void Scenario2()
        {
            Console.WriteLine("\n*************  Scenario-2  *************");

            Student[] students = new Student[3];
            students[0] = new Student(1, "Manasa", new DateTime(2007, 10, 25));
            students[1] = new Student(2, "Alekhya", new DateTime(2006, 6, 21));
            students[2] = new Student(3, "Aadhya", new DateTime(2004, 9, 18));

            Info info = new Info();

            foreach (Student student in students)
            {
                info.Display(student);
            }
            Console.WriteLine("\n*************  CaseStudy Project-2  *************");
        }
    }
}