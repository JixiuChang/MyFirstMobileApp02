using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.ActivityIndicator
{
    class ActivityIndicatorViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        private ImageSource _getImageSource;
        private bool _isImageVisible;
        private bool _isLoading;

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }        
        }
        public bool IsImageVisible
        {
            get => _isImageVisible;
            set
            {
                _isImageVisible = value;
                OnPropertyChanged(nameof(IsImageVisible));
            }
        }

        public ActivityIndicatorViewModel()
        {
            Title = TitleAPPImages.myTitleIndicator;
            IsLoading = true;
            IsImageVisible = false;
            LoadImageAsync();
        }

        public ImageSource GetImageSource
        {
            get => _getImageSource;
            set
            {
                _getImageSource = value;
                OnPropertyChanged(nameof(GetImageSource));
            }
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(TitleAPPImages.myURIImageURL);

                    if (response.IsSuccessStatusCode)
                    {
                        var stream = await response.Content.ReadAsStreamAsync();
                        GetImageSource = ImageSource.FromStream(() => stream);
                        IsImageVisible = true;
                    } 
                    else
                    {
                        //Handle error if necessary
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Image: {ex}");
            }
            finally
            {
                IsLoading = false;
            }
        }

    }
}
