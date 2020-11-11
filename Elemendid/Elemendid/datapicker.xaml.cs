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
    public partial class datapicker : ContentPage
    {
        Label label;
        DatePicker datePicker;

        public datapicker()
        {
            label = new Label { Text = "Select Date" };
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };
            datePicker.DateSelected += datePicker_DateSelected;
            StackLayout stack = new StackLayout { Children = { label, datePicker } };
            this.Content = stack;
        }

        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = "You selcted " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}