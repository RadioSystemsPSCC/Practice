using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Viewmodels
{
    class Installation6ViewModel : BindableBase
    {
        public Installation6ViewModel()
        {
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
