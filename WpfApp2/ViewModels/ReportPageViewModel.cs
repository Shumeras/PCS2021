using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp2.Models;

namespace WpfApp2.ViewModels
{
    class ReportPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (o, e) => 
        {
#if DEBUG
            Console.WriteLine("Property change event called");
#endif
        };

        public IssueReportModel Data { get; set; }

        public string IssueId
        {
            get => Data.IssueId;
            set
            {
                Data.IssueId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IssueId"));
            }
        }
        public string RegisteringUser
        {
            get => Data.RegisteringUser;
            set
            {
                Data.RegisteringUser = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RegisteringUser"));
            }
        }
        public DateTime RegistrationDate
        {
            get => Data.RegistrationDate;
            set
            {
                Data.RegistrationDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RegistrationDate"));
            }
        }
        public string Title
        {
            get => Data.Title;
            set
            {
                Data.Title = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }
        public string Description
        {
            get => Data.Decription;
            set
            {
                Data.Decription = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public IssueType IssueType
        {
            get => Data.IssueType;
            set
            {
                Data.IssueType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IssueId"));
            }
        }
        public bool IsUrgent 
        { 
            get => Data.IsUrgent; 
            set 
            {
                Data.IsUrgent = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsUrgent"));
            } 
        }

        public ICommand ClearCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

    }
}
