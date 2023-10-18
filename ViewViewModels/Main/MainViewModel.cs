using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPImages;
using MyFirstMobileApp.ViewViewModels.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    internal class MainViewModel : BaseViewModel {
        public ICommand LayoutButtonClicked { get; set; }
        public ICommand ImagesButtonClicked { get; set; }

        public string Title { get; set; } = string.Empty;
        public string LayoutButton { get; set; } = string.Empty;
        public string ImagesButton { get; set; } = string.Empty;
        public string CollectionsButton { get; set; } = string.Empty;
        public string ControlsButton { get; set; } = string.Empty;
        public string SQLLiteButton { get; set; } = string.Empty;

        public MainViewModel() {
            Title = TitleMain.myTitle;
            LayoutButton = TitleMain.myLayoutButtonText;
            ImagesButton = TitleMain.myImageButtonText;
            CollectionsButton = TitleMain.myCollectionButtonText;
            ControlsButton = TitleMain.myControlsButtonText;
            SQLLiteButton = TitleMain.mySQLLiteButtonText;

            LayoutButtonClicked = new Command(LayoutClickedAsync);
            ImagesButtonClicked = new Command(ImagesClickedAsync);
        }

        private async void LayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
        }

        private async void ImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new APPImageView());
        }
    }
}
