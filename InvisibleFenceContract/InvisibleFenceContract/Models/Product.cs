using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Models
{
    class Product
    {
        private int partID;
        private string partNumber;
        private string partName;
        private double partPrice;
        private int isTaxable;

        public int PartID
        {
            get
            {
                return partID;
            }
            set
            {
                partID = value;
            }
        }

        public String PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
            }
        }

        public String PartName
        {
            get
            {
                return partName;
            }
            set
            {
                partName = value;
            }
        }

        public double PartPrice
        {
            get
            {
                return partPrice;
            }
            set
            {
                partPrice = value;
            }
        }

        public int IsTaxable
        {
            get
            {
                return isTaxable;
            }
            set
            {
                isTaxable = value;
            }
        }
    }
}
