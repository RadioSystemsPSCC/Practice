using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using InvisibleFenceContract.Viewmodels;
using InvisibleFenceContract.Viewmodels.Commands;

namespace InvisibleFenceContract.Models
{
    public class Customer : BindableBase
    {
        //Must add CustomerID to this model to select proper client, also remove petname, pet breed and petBirthday
        //These must be fed in as a list to allow for multiple entries. Copying fields to pet. 
        private int customerID;
        private string firstName;
        private string lastName;
        private string referredBy;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string homePhone;
        private string cellPhone;
        private string email;
        public SelectCustomerViewModel Parent { get; set; }
        private System.Windows.Input.ICommand select;
        /// <summary>
        /// Initiates a new instance of the customer class
        /// , String lastName, String address, String
        /// </summary>

        public System.Windows.Input.ICommand Select
        {
            get
            {
                if (select == null)
                {
                    select = new SelectCustomer(this);
                }
                return select;
            }
        }
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
                OnPropertyChanged("CustomerID");
            }
        }

        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public String ReferredBy
        {
            get
            {
                return referredBy;
            }
            set
            {
                referredBy = value;
                OnPropertyChanged("ReferredBy");
            }
        }

        public String Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        public String City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

        public String State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
        }

        public String Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
                OnPropertyChanged("Zip");
            }
        }

        public String HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
                OnPropertyChanged("HomePhone");
            }
        }

        public String CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                cellPhone = value;
                OnPropertyChanged("CellPhone");
            }
        }

        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
    }
}


