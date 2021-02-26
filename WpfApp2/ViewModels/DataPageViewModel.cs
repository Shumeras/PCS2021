using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;
using WpfApp2.Services;

namespace WpfApp2.ViewModels
{
    class DataPageViewModel: INotifyPropertyChanged
    {
       
        public ObservableCollection<IssueReportModel> IssueReports 
        { 
            get 
            {
                // Not the best solution to create a new array every time, but for a demo it's ok.
                return new ObservableCollection<IssueReportModel>(DataService.Issues);
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void UpdateList()
        {
            PropertyChanged(this, new PropertyChangedEventArgs("IssueReports"));
        }
    }
}
