using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Services
{
    class DataService 
    {

        public static List<IssueReportModel> Issues { get; } = new List<IssueReportModel>();

        public static void AddIssue(IssueReportModel issue)
        {
            
            Issues.Add((IssueReportModel)issue.Clone());
        }
    }
}
