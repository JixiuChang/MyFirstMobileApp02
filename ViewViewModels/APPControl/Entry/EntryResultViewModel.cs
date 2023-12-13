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
        private string _entryText;

        public EntryResultViewModel(string entryText)
        {
            Title = TitleAPPControl.myEntryResultViewTitle;

            _entryText = entryText;
        }

        public string EntryValueText
        {
            get
            {
                return _entryText;
            }
            set
            {
                if (_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }
            }
        }
    }
}
