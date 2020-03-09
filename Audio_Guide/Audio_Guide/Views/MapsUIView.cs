using System;
using System.Collections.Generic;
using System.Text;
using Mapsui.Styles;

namespace Audio_Guide.Views
{
    public class MapsUIView : Xamarin.Forms.View
    {
        public Mapsui.Map NativeMap { get; }

        protected internal MapsUIView()
        {
            NativeMap = new Mapsui.Map();
            NativeMap.BackColor = Color.Black; //Colour matches map (black over white here)
        }
    }
}
