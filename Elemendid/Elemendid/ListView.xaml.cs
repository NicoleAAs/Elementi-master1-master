using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
         
        public ListView()
        {
            InitializeComponent();
        }
        private async void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((string)e.SelectedItem == "Google Pixel 4a")
            {
                await Navigation.PushAsync(new pixel4());
            }
            if ((string)e.SelectedItem == "Samsung Galaxy Note 20 Ultra")
            {
                await Navigation.PushAsync(new note20());
            }
            if ((string)e.SelectedItem == "OnePlus 8 Pro")
            {
                await Navigation.PushAsync(new oneplus());
            }

        }
    }
}