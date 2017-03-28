using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Models
{
    class Pet : BindableBase
    {
        private string customerID;
        private string petName;
        private string petBreed;
        private string petBirthday;

        public String CustomerID
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

        public String PetBirthday
        {
            get
            {
                return petBirthday;
            }
            set
            {
                petBirthday = value;
                OnPropertyChanged("PetBirthday");
            }
        }
    }
}
