using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Stepper
{
    internal class StepperViewModel : BaseViewModel
    {
        public StepperViewModel()
        {
            Title = TitleAPPControl.myStepperViewTitle;
        }
    }
}
