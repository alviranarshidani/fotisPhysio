using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class PasswordChange : ContentPage
    {
        public PasswordChange()
        {
            InitializeComponent();
        }
        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Login();
            await Navigation.PushAsync(newPage);
        }
    }
}
