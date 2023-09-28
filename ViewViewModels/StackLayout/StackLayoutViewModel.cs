using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.StackLayout
{
    internal class StackLayoutViewModel : BaseViewModel {
        public string TitleLayout { get; set; } = string.Empty;
        public string StackLayoutButton { get; set; } = string.Empty;
        public string HorizontalLayoutButton { get; set; } = string.Empty;
        public string VerticalLayoutButton { get; set; } = string.Empty;
        public string AbsoluteLayoutButton { get; set; } = string.Empty;

        public StackLayoutViewModel() {
            TitleLayout = TitleStackLayout.myTitle;
            StackLayoutButton = TitleStackLayout.myButtonStack;
            HorizontalLayoutButton = TitleStackLayout.myButtonHorizontal;
            VerticalLayoutButton = TitleStackLayout.myButtonVertical;
            AbsoluteLayoutButton = TitleStackLayout.myButtonAbsolute;
        }
    }
}
