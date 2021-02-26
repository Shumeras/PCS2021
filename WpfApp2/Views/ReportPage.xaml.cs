using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Commands;
using WpfApp2.Services;
using WpfApp2.ViewModels;

namespace WpfApp2.Views
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        ReportPageViewModel vm = new ReportPageViewModel();

        public ReportPage()
        {
            vm.Data = new Models.IssueReportModel();
            vm.ClearCommand = new RelayCommand((obj) => Clear());
            vm.SubmitCommand = new RelayCommand((obj) => Submit());

            InitializeComponent();

            DataContext = vm;

            Clear();
        }
        private void Clear()
        {
            vm.IssueId = Guid.NewGuid().ToString();
            vm.RegisteringUser = "Some user";
            vm.Title = "Some title";
            vm.Description = "desc";

            vm.RegistrationDate = DateTime.Now;
            vm.IsUrgent = false;
        }

        private void Submit()
        {
            DataService.AddIssue(vm.Data);
            Clear();
        }
    }
}
