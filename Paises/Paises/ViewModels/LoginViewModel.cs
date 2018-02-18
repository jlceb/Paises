using Paises.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Paises.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                this.Notify("Password");
            }
        }

        bool isremembered;
        public bool IsRemembered
        {
            get
            {
                return isremembered;
            }
            set
            {
                isremembered = value;
                this.Notify("IsRemembered");
            }
        }

        bool isrunning;
        public bool IsRunning
        {
            get
            {
                return isrunning;
            }
            set
            {
                isrunning = value;
                this.Notify("IsRunning");
            }
        }

        bool isenabled;
        public bool IsEnabled
        {
            get
            {
                return isenabled;
            }
            set
            {
                isenabled = value;
                this.Notify("IsEnabled");
            }
        }

        MessageService messageService;

        public LoginViewModel()
        {
            messageService = new MessageService();
            this.IsRemembered = true;
            this.IsEnabled = true;
        }

        public ICommand AccederCommand
        {
            get;
            set;
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        async void Acceder()
        {
            if (string.IsNullOrEmpty(Email))
            {
                await messageService.SendMessage("Error", "You must enter an email.");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await messageService.SendMessage("Error", "You must enter an password.");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            if (this.Email != "luis" || this.Password != "1234")
            {
                await messageService.SendMessage("Error", "Email or password incorrect.");
                this.IsRunning = false;
                this.IsEnabled = true;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;
            this.Email = string.Empty;
            this.Password = string.Empty;

        }
    }
}
