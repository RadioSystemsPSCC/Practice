using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ProjectPrototype.Model
{
    public class ClientModel { }

    public class Clients : INotifyPropertyChanged
    {
        

        private string firstName;
        private string referredBy;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string homePhone;
        private string cellPhone;
        private string email;
        private string petName1;
        private string petBreed1;
        private string petAge1;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    //RaisePropertyChanged("FullName");
                }
            }
        }

        public string ReferredBy
        {
            get { return referredBy; }

            set
            {
                if (referredBy != value)
                {
                    referredBy = value;
                    RaisePropertyChanged("ReferredBy");
                   // RaisePropertyChanged("FullName");
                }
            }
        }

        public string Address
        {
            get { return address; }

            set
            {
                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged("Address");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string City
        {
            get { return city; }

            set
            {
                if (city != value)
                {
                    city = value;
                    RaisePropertyChanged("City");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string State
        {
            get { return state; }

            set
            {
                if (state != value)
                {
                    state = value;
                    RaisePropertyChanged("State");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string Zip
        {
            get { return zip; }

            set
            {
                if (zip != value)
                {
                    zip = value;
                    RaisePropertyChanged("Zip");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string HomePhone
        {
            get { return homePhone; }

            set
            {
                if (homePhone != value)
                {
                    homePhone = value;
                    RaisePropertyChanged("HomePhone");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string CellPhone
        {
            get { return cellPhone; }

            set
            {
                if (cellPhone != value)
                {
                    cellPhone = value;
                    RaisePropertyChanged("CellPhone");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string Email
        {
            get { return email; }

            set
            {
                if (email != value)
                {
                    email = value;
                    RaisePropertyChanged("Email");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string PetName1
        {
            get { return petName1; }

            set
            {
                if (petName1 != value)
                {
                    petName1 = value;
                    RaisePropertyChanged("PetName1");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string PetBreed1
        {
            get { return petBreed1; }

            set
            {
                if (petBreed1 != value)
                {
                    petBreed1 = value;
                    RaisePropertyChanged("PetBreed1");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string PetAge1
        {
            get { return petAge1; }

            set
            {
                if (petAge1 != value)
                {
                    petAge1 = value;
                    RaisePropertyChanged("PetAge1");
                    // RaisePropertyChanged("FullName");
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
