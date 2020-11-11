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
    public partial class timerPicker : ContentPage
    {
        public timerPicker()
        {
            TimePicker timePicker = new TimePicker() { Time = new TimeSpan(22, 0, 0) };
            this.Content = timePicker;
        }
    }
}