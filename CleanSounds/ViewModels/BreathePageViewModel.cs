using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanSounds.ViewModels
{
    public class BreathePageViewModel : ViewModelBase
    {
        public BreathePageViewModel(INavigationService navigationService):
            base(navigationService)
        {
            Title = "Breathe Page";
        }
    }
}
