using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.FlexLayout
{
    internal class FlexLayoutViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;

        public FlexLayoutViewModel()
        {
            Title = TitleStackLayout.myTitleFlex;
        }
    }
}
