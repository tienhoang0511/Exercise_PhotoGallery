﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise_PhotoGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GalleryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
