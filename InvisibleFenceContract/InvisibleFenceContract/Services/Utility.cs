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
        static Order order = new Order();
        
        public static Order GetOrder()
        {
            return order;
        }

        public static void SetOrder(Order o)
        {
            order = o;
        }

        public static void InitialLoadOrderData()
        {
            //load all initial order details
            order.Balance = 0;
        }
    }
}
