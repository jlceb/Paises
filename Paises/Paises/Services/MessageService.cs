using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Services
{
    public class MessageService
    {
        public async Task SendMessage(string title, string message)
        {
            await Paises.App.Current.MainPage.DisplayAlert(title, message, "Accept");
        }
    }
}
