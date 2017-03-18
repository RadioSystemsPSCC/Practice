using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace InvisibleFenceContract.Models
{
    class Customer : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string referredBy;
        /// <summary>
        /// Initiates a new instance of the customer class
        /// , String lastName, String address, String
        /// </summary>

        public Customer()
        {
            {
                this.FirstName = "David";
                this.LastName = "Dog";
                this.ReferredBy = "";
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

        /// <summary>
        /// Implementation of event for INotifyPropertyChanged
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
