using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.FlexLayout
{
    internal class FlexLayoutViewModel : BaseViewModel
    {

        public FlexLayoutViewModel()
        {
            Title = TitleStackLayout.myTitleFlex;
        }
    }
}
