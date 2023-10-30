using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPImages.APPImagesContent.EmbeddedImage
{
    class EmbeddedImageViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;

        public EmbeddedImageViewModel()
        {
            Title = TitleAPPImages.myTitleEmbedded;
        }

        public ImageSource GetImageSource
        {
            get
            {
                return ImageSource.FromFile("Images/eyjafjalla.jpg");
            }
        }
    }
}
