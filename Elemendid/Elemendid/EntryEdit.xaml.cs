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
    public partial class EntryEdit : ContentPage
    {

        Button btn;
        public EntryEdit()
        {
            StackLayout stack = new StackLayout();
            btn = new Button { Text = "Забыли пароль?", BackgroundColor = Color.LightGoldenrodYellow };
            btn.Clicked += Btn_Clicked;
            Entry entry = new Entry
            {
                MaxLength = 10,
                CharacterSpacing = 5,
                IsPassword = true,
                Placeholder = "Пароль",
                PlaceholderColor = Color.DarkMagenta,
            };
            Editor editor = new Editor
            {
                CharacterSpacing = 5,
                Placeholder = "Имя",
                PlaceholderColor = Color.DarkMagenta,
                MaxLength = 10
            };
            stack.Children.Add(editor);
            stack.Children.Add(entry);
            stack.Children.Add(btn);
            Content = stack;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {

            bool answer = await DisplayAlert(" ", "Хотите создать новый пароль?", "Да", "Нет");
            if (answer == true)
            {
                await Navigation.PushAsync(new password());
            }
        }
    }
}