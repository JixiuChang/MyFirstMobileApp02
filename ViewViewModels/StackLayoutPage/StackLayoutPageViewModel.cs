﻿using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutPage
{
    internal class StackLayoutPageViewModel : BaseViewModel
    {
        public string TitleLayout { get; set; } = string.Empty;
        public StackLayoutPageViewModel() {
            TitleLayout = TitleStackLayoutPage.myTitle;
        }
    }
}