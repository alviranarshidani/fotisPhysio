using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        async void Login_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Dashboard();
            await Navigation.PushAsync(newPage);
        }
        async void Forgot_Password_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new ForgetPassword();
            await Navigation.PushAsync(newPage);
        }
        async void NewUser_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Register();
            await Navigation.PushAsync(newPage);
        }
    }
}
