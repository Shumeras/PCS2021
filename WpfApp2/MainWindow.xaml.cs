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
using WpfApp2.ViewModels;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public string Temp { get; set; } = "this";

        ReportPageViewModel vm = new ReportPageViewModel();
        

        public MainWindow()
        {
            vm.Data = new Models.IssueReportModel();

            InitializeComponent();

            DataContext = vm;
            

            Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            vm.IssueId = Guid.NewGuid().ToString();
            vm.RegisteringUser = "Some user";
            vm.Title = "Some title";
            vm.Description= "desc";

            vm.RegistrationDate = DateTime.Now;
            vm.IsUrgent = false;
        }

        private void Submit()
        {

            Clear();
        }


    }
}
