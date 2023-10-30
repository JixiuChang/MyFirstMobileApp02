using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.ArknightsImageCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableButtonCollection;
using MyFirstMobileApp.ViewViewModels.APPCollections.UpdateableIconCollection;
using System;
using System.Collections.Generic;
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

        public string Title { get; set; } = string.Empty;
        public string CollectionButton { get; set; } = string.Empty;
        public string ImageCollectionButton { get; set; } = string.Empty;
        public string ButtonCollectionButton { get; set; } = string.Empty;
        public string IconCollectionButton { get; set; } = string.Empty;

        public APPCollectionViewModel() {
            Title = TitleCollections.myTitle;
            CollectionButton = TitleCollections.myCollectionButtonText;
            ImageCollectionButton = TitleCollections.myImageCollectionButtonText;
            ButtonCollectionButton = TitleCollections.myButtonCollectionButtonText;
            IconCollectionButton = TitleCollections.myIconCollectionButtonText;

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
