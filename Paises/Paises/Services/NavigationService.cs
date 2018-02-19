using Paises.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paises.Services
{
    public class NavigationService
    {
        public async void NavigateTo(string page)
        {
            switch (page)
            {
                case "PaisesView":
                    await Paises.App.Current.MainPage.Navigation.PushAsync(new PaisesView());
                    break;
                default:
                    break;
            }
        }
    }
}
