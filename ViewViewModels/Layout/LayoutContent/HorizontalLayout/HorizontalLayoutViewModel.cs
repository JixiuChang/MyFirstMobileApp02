using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.HorizontalLayout
{
    internal class HorizontalLayoutViewModel : BaseViewModel
    {

        public HorizontalLayoutViewModel()
        {
            Title = TitleStackLayout.myTitleHorizontal;
        }
    }
}
