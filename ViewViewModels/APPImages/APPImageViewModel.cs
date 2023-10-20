using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.ActivityIndicator;
using MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.EmbeddedImage;
using MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.URIImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPImages
{
    internal class APPImageViewModel : BaseViewModel {
        public ICommand IndicatorButtonPressed { get; set; }
        public ICommand EmbeddedButtonPressed { get; set; }
        public ICommand URIButtonPressed { get; set; }

        public string Title { get; set; } = string.Empty;
        public string IndicatorButton { get; set; } = string.Empty;
        public string EmbeddedButton { get; set; } = string.Empty;
        public string URIButton { get; set; } = string.Empty;

        public APPImageViewModel() {
            Title = TitleImages.myTitle;
            IndicatorButton = TitleImages.myIndicatorButtonText;
            EmbeddedButton = TitleImages.myEmbeddedButtonText;
            URIButton = TitleImages.myURIButtonText;

            IndicatorButtonPressed = new Command(IndicatorClickedAsync);
            EmbeddedButtonPressed = new Command(EmbeddedClickedAsync);
            URIButtonPressed = new Command(URIClickedAsync);
        }

        private async void IndicatorClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ActivityIndicatorView());
        }

        private async void EmbeddedClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmbeddedImageView());
        }

        private async void URIClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new URIImageView());
        }

    }
}
