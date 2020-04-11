using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Audio_Guide.Services;
using Audio_Guide.Views;
using Mapsui.Styles;

using System.Collections.Generic;
using System.Linq;

namespace Audio_Guide

{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new SplashScreen());
            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new MainPage());
            carouselPage.Children.Add(new Explore());
            carouselPage.Children.Add(new Settings());
            carouselPage.Children.Add(new Directions());
            MainPage = carouselPage;
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
