using System;
using System.Collections.Generic;
using System.Text;

namespace Paises.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public PaisesViewModel Paises { get; set; }

        public MainViewModel()
        {
            instance = this;
            Login = new LoginViewModel();
        }

        //Singlenton

        static MainViewModel instance;

        public static MainViewModel GetIntance()
        {
            if (instance == null)
                return new MainViewModel();
            else
                return instance;
        }
    }
}
