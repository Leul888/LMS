using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class IssueData
    {
        public int issueId { get; set; }
        public string studentId { get; set; }
        public string studentName { get; set; }
        public string studentDept { get; set; }
        public string studentPhone { get; set; }
        public string bookIssued { get; set; }
        public string issueDate { get; set; }
        
        public IssueData(int issueId, string studentId, string studentName, string studentDept, string studentPhone, string bookIssued, string issueDate)
        {
            this.issueId = issueId;
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentDept = studentDept;
            this.studentPhone = studentPhone;
            this.bookIssued = bookIssued;
            this.issueDate = issueDate;
        }
        
    }
}
