﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fotisPhysio
{
    public partial class App : Application
    {
        public static string DatabasePath = string.Empty;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();


            MainPage = new NavigationPage(new MainPage());
            
        }
        public App(String databasePath)
        {
            InitializeComponent();
            DatabasePath = databasePath;
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
