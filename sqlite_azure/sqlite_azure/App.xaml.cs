﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace sqlite_azure
{
    public partial class App : Application
    {
        //public static ISQLAzure Authenticator { get; private set; }
        //public static void  Init(ISQLAzure authenticator)
        //{
        //    Authenticator = authenticator;

        //}
        public App()
        {
            InitializeComponent();
            MainPage = new DataPage();
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
