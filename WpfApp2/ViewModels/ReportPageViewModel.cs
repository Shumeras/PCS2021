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
        private string issueId;
        private string registeringUser;
        private DateTime registrationDate;
        private string title = "This is a title";
        private string decription;
        private IssueType issueType;
        private bool isUrgent;

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
            get => registeringUser;
            set
            {
                registeringUser = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RegisteringUser"));
            }
        }
        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                registrationDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RegistrationDate"));
            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }
        public string Description
        {
            get => decription;
            set
            {
                decription = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public IssueType IssueType
        {
            get => issueType;
            set
            {
                issueType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IssueId"));
            }
        }
        public bool IsUrgent 
        { 
            get => isUrgent; 
            set 
            {
                isUrgent = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsUrgent"));
            } 
        }

        public ICommand ClearCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

    }
}
