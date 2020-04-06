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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            myPicker.SelectedItem = "6";
            Categories.SelectedItem = "General";
            dist.Text = "5";
            Distance.Value = 5;
            Star_Rating.SelectedItem = "0+";
        }
        private void Slide_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            dist.Text = Distance.Value.ToString();
        }
    }
}