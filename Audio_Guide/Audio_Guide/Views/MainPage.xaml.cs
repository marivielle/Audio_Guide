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

using System.Text;
using System.Threading.Tasks;



namespace Audio_Guide.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public Func<MapView, MapClickedEventArgs, bool> Clicker { get; set; }


        public MainPage()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            var USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36 OPR/66.0.3515.115";
            httpClient.DefaultRequestHeaders.Add("User-Agent", USER_AGENT);

            var osmAttribution = new Attribution("© OpenStreetMap contributors", "https://www.openstreetmap.org/copyright");
            var osmSource = new HttpClientTileSource(httpClient, new GlobalSphericalMercator(), "https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", new[] { "a", "b", "c" }, name: "OpenStreetMap", attribution: osmAttribution);
            var osmLayer = new TileLayer(osmSource) { Name = "OpenStreetMap" };

            var mapControl = new MapView();
            //var map = new Mapsui.Map();
            //new Mapsui.Map()
           //mapControl.NativeMap.Layers.Add(OpenStreetMap.CreateTileLayer());
            mapControl.Map.Layers.Add(osmLayer);
            //var map = new Mapsui.Map();
            //map.Layers.Add(osmLayer);


            //mapControl.Map.NavigateTo(mapControl.Map.Resolutions[9]);
            //mapControl.Map.Resolutions[9];
            
            //var bbox = new Mapsui.Geometries.BoundingBox(-116.210927, 43.617908, -116.195544, 43.623198);
            mapControl.Map.Layers.Add(OpenStreetMap.CreateTileLayer());


            //mapControl.Navigator.NavigateTo(bbox, ScaleMethod.Fit);
            //var layer = mapControl.Map.
            mapControl.Map.Limiter = new ViewportLimiterKeepWithin();

            //mapControl.Map = map;
            ContentGrid.Children.Add(mapControl);



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
