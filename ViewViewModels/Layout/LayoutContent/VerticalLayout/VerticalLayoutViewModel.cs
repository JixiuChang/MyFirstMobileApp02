using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.VerticalLayout
{
    internal class VerticalLayoutViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        public VerticalLayoutViewModel() {
            Title = TitleStackLayout.myTitleVertical;
        }
    }
}
