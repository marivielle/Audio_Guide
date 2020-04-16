using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Audio_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Directions : ContentPage
    {
        public Directions()
        {
            InitializeComponent();
            Drctns();
        }

       void DrcntsFunc()
        {
            Drctns.GestureRecognizers.Add(
                new TapGestureRecognizer()
                {
                Command = new Command(() =>
                 {
                     DisplayAlert("Directions", "1. Turn Right \n2. Turn Left\n3. Go Straight Ahead", "Back");
                 })

                }
            );
        }
      
      
    }
}
