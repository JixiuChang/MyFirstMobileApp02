using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    internal class MainViewModel : BaseViewModel {
        public ICommand LayoutButtonClicked { get; set; }

        public MainViewModel() {
            Title = TitleMain.myTitle;
            LayoutButton = TitleMain.myLayoutButtonText;

            LayoutButtonClicked = new Command(LayoutClickedAsync);
        }

        private async void LayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
        }
    }
}
