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
        public EntryViewModel() 
        {
            Title = TitleAPPControl.myEntryViewTitle;

            Clicked = new Command(ClickedAsync);
        }

        public async void ClickedAsync()
        {   
            await Application.Current.MainPage.Navigation.PushAsync(new EntryResultView());
        }
    }
}
