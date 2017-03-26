using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Views;
using InvisibleFenceContract.Viewmodels.Commands;

namespace InvisibleFenceContract.Viewmodels
{
    class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private Contact1ViewModel contact1ViewModel = new Contact1ViewModel();

        private Safety2ViewModel safety2ViewModel = new Safety2ViewModel();

        private Protection3ViewModel protection3ViewModel = new Protection3ViewModel();
        private Freedom4ViewModel freedom4ViewModel = new Freedom4ViewModel();
        private Solutions5ViewModel solution5ViewModel = new Solutions5ViewModel();
        private Installation6ViewModel installation6ViewModel = new Installation6ViewModel();
        private Signature7ViewModel signature7ViewModel = new Signature7ViewModel();

        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "signature":
                    CurrentViewModel = signature7ViewModel;
                    break;
                case "installation":
                    CurrentViewModel = installation6ViewModel;
                    break;
                case "solutions":
                    CurrentViewModel = solution5ViewModel;
                    break;
                case "freedom":
                    CurrentViewModel = freedom4ViewModel;
                    break;
                case "protection":
                    CurrentViewModel = protection3ViewModel;
                    break;
                case "safety":
                    CurrentViewModel = safety2ViewModel;
                    break;
                case "contact":
                default:
                    CurrentViewModel = contact1ViewModel;
                    break;
            }
            if (destination.Length < 1)
                CurrentViewModel = contact1ViewModel;
        }
    }
}
