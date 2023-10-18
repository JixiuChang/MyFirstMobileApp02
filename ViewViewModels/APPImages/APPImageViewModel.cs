using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.APPImages
{
    internal class APPImageViewModel : BaseViewModel {
        public string Title { get; set; } = string.Empty;
        public string IndicatorButton { get; set; } = string.Empty;
        public string EmbeddedButton { get; set; } = string.Empty;
        public string URIButton { get; set; } = string.Empty;

        public APPImageViewModel() {
            Title = TitleImages.myTitle;
            IndicatorButton = TitleImages.myIndicatorButtonText;
            EmbeddedButton = TitleImages.myEmbeddedButtonText;
            URIButton = TitleImages.myURIButtonText;
        }
    }
}
