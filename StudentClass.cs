using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Student
    {
        // Encapsulation: private fields
        private int studentId;
        private string studentName;
        private string department;
        private int semester;
        private string phoneNumber;

        // Encapsulation: public properties for access to private fields
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }

}
