using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.StackLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Layout
{
    internal class LayoutViewModel : BaseViewModel {
        public ICommand StackLayoutButtonClicked { get; set; }

        public string Title { get; set; } = string.Empty;
        public string StackLayoutButton { get; set; } = string.Empty;
        public string HorizontalLayoutButton { get; set; } = string.Empty;
        public string VerticalLayoutButton { get; set; } = string.Empty;
        public string AbsoluteLayoutButton { get; set; } = string.Empty;

        public LayoutViewModel() {
            Title = TitleLayout.myTitle;
            StackLayoutButton = TitleLayout.myButtonStack;
            HorizontalLayoutButton = TitleLayout.myButtonHorizontal;
            VerticalLayoutButton = TitleLayout.myButtonVertical;
            AbsoluteLayoutButton = TitleLayout.myButtonAbsolute;

            StackLayoutButtonClicked = new Command(StackLayoutClickedAsync);
        }

        private async void StackLayoutClickedAsync() {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
        }
    }
}
