using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPControl.DnTPicker
{
    internal class DnTPickerViewModel : BaseViewModel
    {
        public DnTPickerViewModel() 
        {
            Title = TitleAPPControl.myDnTPickerViewTitle;
        }
    }
}
