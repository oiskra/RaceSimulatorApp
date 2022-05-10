﻿using ProjektSemestralnyOOP.Commands;
using System;
using System.Windows.Input;
using ProjektSemestralnyOOP.Interfaces;
using ProjektSemestralnyOOP.Services;
using ProjektSemestralnyOOP.DBcontext;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektSemestralnyOOP.MVVM.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            { 
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public LoginWindow Window { get; }

        public ICommand SubmitButton { get; }
        public ICommand CancelButton { get; }

        public LoginViewModel(LoginWindow window)
        {
            SubmitButton = new RelayCommand(SubmitLoginCommand);
            CancelButton = new RelayCommand(CancelLoginCommand);
            Window = window;
        }

        private void CancelLoginCommand()
        {
            Window.Close();
        }

        private async void SubmitLoginCommand()
        {
            IUserService service = new UserService(new RacingDBContextFactory());
            bool isLogged = await service.LoginUserAsync(Login, Password);

            if (isLogged) 
            { 
                MessageBox.Show("True", "islogged?");
                Window.Close();
                return;
            }

            MessageBox.Show("False", "islogged?");
        }
    }
}
