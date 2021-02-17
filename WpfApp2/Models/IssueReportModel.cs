using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    enum IssueType
    {
        BUG,
        DOCUMENTATION,
        PERFORMANCE,
        NOTICE
    }

    class IssueReportModel
    {
        public string IssueId { get; set; }
        public string RegisteringUser { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public IssueType IssueType { get; set; }
        public bool IsUrgent { get; set; }
    
    }
}
