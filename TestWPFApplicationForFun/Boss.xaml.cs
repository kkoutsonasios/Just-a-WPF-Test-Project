using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace TestWPFApplicationForFun
{
    /// <summary>
    /// Interaction logic for Boss.xaml
    /// </summary>
    public partial class Boss : Window
    {
        private ObservableCollection<employee> EmployeeList;

        public Boss()
        {
            InitializeComponent();
            try
            {
                EmployeeList = new ObservableCollection<employee>();
                listView.ItemsSource = EmployeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int salary = 0;
                if (!Int32.TryParse(SalaryTxtBox.Text, out salary))
                    throw new Exception("ARE YOU NUTS?");
                EmployeeList.Add(new employee(NameTxtBox.Text, salary));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
