using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPControl.Entry
{
    internal class EntryViewModel : BaseViewModel
    {
        public ICommand Clicked { get; set; }

        private string _entryText;
        public EntryViewModel() 
        {
            Title = TitleAPPControl.myEntryViewTitle;

            Clicked = new Command(ClickedAsync);
        }

        public string EntryText
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

        public async void ClickedAsync()
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleAPPControl.myEntryViewTitle, "Entry can't be empty!", "OK");
                return;
            }

            await Application.Current.MainPage.Navigation.PushAsync(new EntryResultView(_entryText));
        }
    }
}
