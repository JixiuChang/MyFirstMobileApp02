﻿using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.StackLayout
{
    internal class StackLayoutViewModel : BaseViewModel 
    {
        public StackLayoutViewModel() {
            TitleLayout = TitleStackLayout.myTitle;
        }
    }
}
