using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp2.ViewModels;
using WpfApp2.Views;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Page currentPage = new ReportPage();

        private ReportPage reportPage = new ReportPage();
        private DataPage dataPage = new DataPage();

        //public string Temp { get; set; } = "this";

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentPage"));
            }
        } 

        public event PropertyChangedEventHandler PropertyChanged = (c, o) => {};

        private void ReportPageButtonClicked(object sender, RoutedEventArgs e)
        {
            CurrentPage = reportPage;
        }

        private void DataPageButtonClicked(object sender, RoutedEventArgs e)
        {
            dataPage.UpdateData();
            CurrentPage = dataPage;
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }



    }
}
