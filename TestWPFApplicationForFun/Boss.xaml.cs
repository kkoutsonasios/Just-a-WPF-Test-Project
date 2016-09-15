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
        private SomethingLikeViewModelButItIsNot DtCntx;

        public Boss()
        {
            InitializeComponent();
            try
            {
                DtCntx = (SomethingLikeViewModelButItIsNot)this.DataContext;
            }
            catch (Exception ex)
            {
                Tools.ShowMessage(ex);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int salary = 0;
                if (!Int32.TryParse(SalaryTxtBox.Text, out salary))
                    throw new Exception("ARE YOU NUTS?");
                if (NameTxtBox.Text == string.Empty)
                    throw new Exception("You don't have a name?");
                
                DtCntx.EmployeeList.Add(new employee(NameTxtBox.Text, salary));
            }
            catch (Exception ex)
            {
                Tools.ShowMessage(ex);
            }
        }

        private void GetARaise_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               ((employee)((System.Windows.Controls.Button)e.OriginalSource).DataContext).GetARaise();  
            }
            catch (Exception ex)
            {
                Tools.ShowMessage(ex);
            }
        }

        private void SalaryTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                    AddBtn_Click(this, e);
            }
            catch (Exception ex)
            {
                Tools.ShowMessage(ex);
            }
        }
    }
}
