using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        async void Register_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Login();
            await Navigation.PushAsync(newPage);
        }
    }
}
