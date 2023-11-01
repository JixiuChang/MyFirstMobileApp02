using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsImageCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableButtonCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableIconCollection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.APPCollections
{
    internal class APPCollectionViewModel : BaseViewModel
    {
        public ICommand CollectionButtonPressed { get; set; }
        public ICommand ImageCollectionButtonPressed { get; set; }
        public ICommand ButtonCollectionButtonPressed { get; set; }
        public ICommand IconCollectionButtonPressed { get; set; }

        public string CollectionButton { get; set; } = TitleCollections.myCollectionButtonText;
        public string ImageCollectionButton { get; set; } = TitleCollections.myImageCollectionButtonText;
        public string ButtonCollectionButton { get; set; } = TitleCollections.myButtonCollectionButtonText;
        public string IconCollectionButton { get; set; } = TitleCollections.myIconCollectionButtonText;

        public APPCollectionViewModel() {
            Title = TitleCollections.myTitle;

            CollectionButtonPressed = new Command(CollectionPressedAsync);
            ImageCollectionButtonPressed = new Command(ImageCollectionPressedAsync);
            ButtonCollectionButtonPressed = new Command(ButtonCollectionPressedAsync);
            IconCollectionButtonPressed = new Command(IconCollectionPressedAsync);
        }

        public async void CollectionPressedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ArknightsCollectionView());
        }

        public async void ImageCollectionPressedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ArknightsImageCollectionView());
        }

        public async void ButtonCollectionPressedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UpdateableButtonCollectionView());
        }

        public async void IconCollectionPressedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UpdateableIconCollectionView());
        }
    }
}
