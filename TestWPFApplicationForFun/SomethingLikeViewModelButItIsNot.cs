using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApplicationForFun
{
    public class SomethingLikeViewModelButItIsNot
    {
        public ObservableCollection<employee> EmployeeList { get; set; }

        public SomethingLikeViewModelButItIsNot()
        {
            EmployeeList = new ObservableCollection<employee>();
        }

    }
}
