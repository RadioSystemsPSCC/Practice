using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels.Commands
{
    class RadioCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public RadioCommand(Object parameter) { }


        public bool CanExecute(Object parameter)
        {
            return true;
        }

        public void Execute(Object parameter)
        {
            //if(parameter == "GPSPackage")
            //{
            // BoundaryPackage
            //    DigitalTechPackage
            //}

        }





    }
}