using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Viewmodels
{
    class SelectCustomerViewModel : BindableBase 
    {
        public SelectCustomerViewModel()
        {
            App.Current.Properties["custID"] = 23;
        }
    }
}
