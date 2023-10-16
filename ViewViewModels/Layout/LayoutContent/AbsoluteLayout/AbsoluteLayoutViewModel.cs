using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.AbsoluteLayout
{
    internal class AbsoluteLayoutViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;

        public AbsoluteLayoutViewModel()
        {
            Title = TitleStackLayout.myTitleAbsolute;
        }
    }
}
