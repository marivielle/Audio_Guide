using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mapsui.Projection;
using BruTile.Predefined;

using System.Diagnostics;
using Mapsui.Geometries;
using Mapsui.Layers;
using Mapsui.Providers;
using Mapsui.Styles;
using Mapsui.Utilities;
using Mapsui;
using Mapsui.UI;

using Mapsui.Rendering.Skia;

using Mapsui.UI.Forms;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http;
using BruTile;
using BruTile.Web;


namespace Audio_Guide.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            var mapControl = new MapsUIView();
            mapControl.NativeMap.Layers.Add(OpenStreetMap.CreateTileLayer());
            

            //mapControl.NativeMap.NavigateTo(mapControl.NativeMap.Resolutions[9]);

            ContentGrid.Children.Add(mapControl);
            mapControl.NativeMap.Limiter = new ViewportLimiterKeepWithin();

        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }


    }
}
