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
    public partial class webv : ContentPage
    {

        WebView webView;
        Entry urlEntry;
        public webv()

        {
            urlEntry = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            Button button = new Button { Text = "Go" };
            button.Clicked += button_Clicked;
            StackLayout stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button, urlEntry }
            };
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = "https://www.tthk.ee/" },

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout { Children = { stack, webView } };
        }

        void button_Clicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = urlEntry.Text };

        }
    }
}
