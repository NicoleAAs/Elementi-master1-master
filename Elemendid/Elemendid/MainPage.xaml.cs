using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Tbl_btn = new Button { Text = "Entry/Editorr" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Tbl_btn.Clicked += Tbl_btn_Clicked;
            Button Tbl_btn1 = new Button { Text = "ListView" };
            Tbl_btn1.Clicked += Tbl_btn_Clicked1;
            Button Tbl_btn2 = new Button { Text = "DataPicker" };
            Tbl_btn2.Clicked += Tbl_btn_Clicked2;
            Button Tbl_btn3 = new Button { Text = "TableView" };
            Tbl_btn3.Clicked += Tbl_btn3_Clicked;
            Button Tbl_btn5 = new Button { Text = "WebView" };
            Tbl_btn5.Clicked += Tbl_btn5_Clicked;
            Button Tbl_btn6 = new Button { Text = "timerPicker" };
            Tbl_btn6.Clicked += Tbl_btn6_Clicked;
            Button Tbl_btn7 = new Button { Text = "picker" };
            Tbl_btn7.Clicked += Tbl_btn_Clicked7;

            st.Children.Add(Tbl_btn1);
            st.Children.Add(Tbl_btn2);
            st.Children.Add(Tbl_btn3);
            st.Children.Add(Tbl_btn5);
            st.Children.Add(Tbl_btn6);
            st.Children.Add(Tbl_btn7);
            Content = st;
        }

        private async void Tbl_btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new timerPicker());
        }

        private async void Tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webv());
        }


        private async void Tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tablevv());
        }

        private async void Tbl_btn_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new datapicker());
        }

        private async void Tbl_btn_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryEdit());
        }

        private async void Tbl_btn_Clicked7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new picker());
        }
    }
}

