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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Person();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            p.Salary++;
            p.Name = p.Salary.ToString();
            lblProp.Content = p.Salary.ToString();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblScore.DataContext = p;
        }
    }

    public class Person : INotifyPropertyChanged
    {
        int salary;
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; OnPropertyChanged("Salary"); }
        }
        public string Name { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
   
}
