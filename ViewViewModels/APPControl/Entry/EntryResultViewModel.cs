using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry
{
    internal class EntryResultViewModel : BaseViewModel
    {
        public string EntryValueText { get; set; }
        public EntryResultViewModel()
        {
            Title = TitleAPPControl.myEntryResultViewTitle;
        }
    }
}
