using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class LibrarianItem
    {
        // Encapsulation: private fields
        private int librarianId;
        private string librarianName;
        private string librarianPassword;
        private string librarianPhone;

        // Encapsulation: public properties for access to private fields
        public int LibrarianId
        {
            get { return librarianId; }
            set { librarianId = value; }
        }

        public string LibrarianName
        {
            get { return librarianName; }
            set { librarianName = value; }
        }

        public string LibrarianPassword
        {
            get { return librarianPassword; }
            set { librarianPassword = value; }
        }

        public string LibrarianPhone
        {
            get { return librarianPhone; }
            set { librarianPhone = value; }
        }
    }

}
