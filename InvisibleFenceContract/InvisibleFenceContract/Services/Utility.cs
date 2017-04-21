using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InvisibleFenceContract.Services
{
    public static class Utility
    {
        public static Order Order = new Order();

        public static void InitialLoadOrderData()
        {

            //load all initial order details
            Order.Balance = 0;
        }
    }
}
