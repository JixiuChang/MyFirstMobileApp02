﻿using MyFirstMobileApp.ViewViewModels.Main;
using MyFirstMobileApp.ViewViewModels.Layout.LayoutContent.StackLayout;

namespace MyFirstMobileApp{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new MainView();
            MainPage = new NavigationPage(new MainView());
        }
    }
}