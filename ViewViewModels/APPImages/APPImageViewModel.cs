﻿using MyFirstMobileApp.Models.Titles;
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

        public string IndicatorButton { get; set; } = TitleImages.myIndicatorButtonText;
        public string EmbeddedButton { get; set; } = TitleImages.myEmbeddedButtonText;
        public string URIButton { get; set; } = TitleImages.myURIButtonText;

        public APPImageViewModel() {
            Title = TitleImages.myTitle;

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
