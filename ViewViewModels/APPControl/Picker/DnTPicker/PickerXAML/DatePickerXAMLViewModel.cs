using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Picker.DnTPicker.PickerXAML
{
    public class DatePickerXAMLViewModel : BaseViewModel
    {
        public DatePickerXAMLViewModel() 
        {
            Title = TitleControl.myDnTPickerXAMLTitle;
        }
    }
}
