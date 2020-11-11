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
    public partial class picker : ContentPage
    {
        Label header;
        Picker Picker;
        public picker()
        {
            header = new Label
            {
                Text = "Choose language",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Picker = new Picker
            {
                Title = "Language"
            };
            Picker.Items.Add("C#");
            Picker.Items.Add("JavaScript");
            Picker.Items.Add("Java");
            Picker.Items.Add("C--");
            Picker.Items.Add("CDuce");
            Picker.Items.Add("Phyton");

            Picker.SelectedIndexChanged += picker_SelectedIndexChanged;

            this.Content = new StackLayout { Children = { header, Picker } };
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "You selected: " + Picker.Items[Picker.SelectedIndex];
        }
    }
}