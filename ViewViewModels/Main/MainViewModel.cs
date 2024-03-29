﻿using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPCollections;
using MyFirstMobileApp.ViewViewModels.APPControl;
using MyFirstMobileApp.ViewViewModels.APPImages;
using MyFirstMobileApp.ViewViewModels.Layout;
using MyFirstMobileApp.ViewViewModels.SQLite;
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
        public ICommand CollectionsButtonClicked { get; set; }
        public ICommand ControlsButtonClicked { get; set; }
        public ICommand SQLLiteButtonClicked { get; set; }

        public string LayoutButton { get; set; } = TitleMain.myLayoutButtonText;
        public string ImagesButton { get; set; } = TitleMain.myImageButtonText;
        public string CollectionsButton { get; set; } = TitleMain.myCollectionButtonText;
        public string ControlsButton { get; set; } = TitleMain.myControlsButtonText;
        public string SQLLiteButton { get; set; } = TitleMain.mySQLLiteButtonText;

        public MainViewModel() {
            Title = TitleMain.myTitle;

            LayoutButtonClicked = new Command(LayoutClickedAsync);
            ImagesButtonClicked = new Command(ImagesClickedAsync);
            CollectionsButtonClicked = new Command(CollectionsClickedAsync);
            ControlsButtonClicked = new Command(ControlsClickedAsync);
            SQLLiteButtonClicked = new Command(SQLLiteClickedAsync);
        }

        private async void LayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
        }

        private async void ImagesClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new APPImageView());
        }

        private async void CollectionsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new APPCollectionView());
        }

        private async void ControlsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new APPControlView());
        }
        private async void SQLLiteClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ArknightView());
        }
    }
}
