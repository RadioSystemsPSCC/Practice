using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace InvisibleFenceContract.Models
{
    class Customer : BindableBase
    {
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
        private string petName;
        private string petBreed;
        private string petAge;

        /// <summary>
        /// Initiates a new instance of the customer class
        /// , String lastName, String address, String
        /// </summary>



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

        public String PetName
        {
            get
            {
                return petName;
            }
            set
            {
                petName = value;
                OnPropertyChanged("PetName");
            }
        }

        public String PetBreed
        {
            get
            {
                return petBreed;
            }
            set
            {
                petBreed = value;
                OnPropertyChanged("PetBreed");
            }
        }

        public String PetAge
        {
            get
            {
                return petAge;
            }
            set
            {
                petAge = value;
                OnPropertyChanged("PetAge");
            }

        }
    }
}

