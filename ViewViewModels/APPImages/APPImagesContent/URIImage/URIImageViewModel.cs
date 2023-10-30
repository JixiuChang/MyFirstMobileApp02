using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.URIImage
{
    class URIImageViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        private ImageSource _getImageSource;
        public string ImageURL { get; set; } = TitleAPPImages.myURIImageURL;

        public URIImageViewModel()
        {
            Title = TitleAPPImages.myTitleURI;
        }

        public ImageSource GetImageSource
        {
            get
            {
                if (_getImageSource == null)
                {
                    _getImageSource = GetImage();
                }
                return _getImageSource;
            }
        }

        private ImageSource GetImage()
        {
            var imgsrc = new UriImageSource { Uri = new Uri(ImageURL) };
            imgsrc.CachingEnabled = false;
            imgsrc.CacheValidity = TimeSpan.FromHours(1);

            return imgsrc;
        }
    }
}
