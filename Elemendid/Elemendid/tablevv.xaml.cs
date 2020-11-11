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
    public partial class tablevv : ContentPage
    {
        public tablevv()
        {
            this.Content = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Ввод данных")
            {
                new TableSection ("Персональные данные")
                {
                    new EntryCell
                    {
                        Label = "Логин:",
                        Placeholder = "введите логин",
                        Keyboard = Keyboard.Default
                    },
                    new SwitchCell { Text = "Сохранить"}
                },
                new TableSection ("Контакты")
                {
                    new EntryCell
                    {
                        Label = "Телефон:",
                        Placeholder = "введите телефон",
                        Keyboard = Keyboard.Telephone
                    },
                    new EntryCell
                    {
                        Label = "Email:",
                        Placeholder = "введите email",
                        Keyboard = Keyboard.Email
                    }
                }
            }
            };
        }
    }
}