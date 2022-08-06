using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

        public Course()
        {
            Console.WriteLine("Course added");
        }
        public Course(string name, string code, int credit)
        {
            CourseName=name;
            CourseCode=code;
            CourseCredit=credit;
        
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Course Code: " + CourseCode);
            Console.WriteLine("Course Credit: " + CourseCredit);
        }


           
    }
}
