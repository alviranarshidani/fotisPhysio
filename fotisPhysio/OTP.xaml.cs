using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class OTP : ContentPage
    {
        public OTP()
        {
            InitializeComponent();
        }
        async void Submit_OTP(object sender, System.EventArgs e)
        {
            var newPage = new PasswordChange();
            await Navigation.PushAsync(newPage);
        }
    }
}
