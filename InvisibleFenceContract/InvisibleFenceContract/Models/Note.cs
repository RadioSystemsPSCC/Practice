using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Models
{
    class Note : BindableBase
    {
        private string customerID;
        private string referralNoteType = "28";
        private string referralNote;
        private string lightingNoteType = "33";
        private string lightingNote;
        private string sprinklerNoteType = "33";
        private string sprinklerNote;
        private string presensitivitiesExistType = "33";
        private string presensitivitesExist;
        private string presensitivitiesNoteType = "33";
        private string presensitivitesNotes;

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

        public String ReferralNote
        {
            get
            {
                return referralNote;
            }
            set
            {
                referralNote = value;
                OnPropertyChanged("ReferralNote");
            }
        }

        public String LightingNote
        {
            get
            {
                return lightingNote;
            }
            set
            {
                lightingNote = value;
                OnPropertyChanged("LightingNote");
            }
        }

        public String SprinklerNote
        {
            get
            {
                return sprinklerNote;
            }
            set
            {
                sprinklerNote = value;
                OnPropertyChanged("SprinklerNote");
            }
        }

        public String PresensitivitesExist
        {
            get
            {
                return presensitivitesExist;
            }
            set
            {
                presensitivitesExist = value;
                OnPropertyChanged("PresensitivitesExist");
            }
        }

        public String PresensitivitesNotes
        {
            get
            {
                return presensitivitesNotes;
            }
            set
            {
                presensitivitesNotes = value;
                OnPropertyChanged("PetBirthday");
            }
        }
    }
}
