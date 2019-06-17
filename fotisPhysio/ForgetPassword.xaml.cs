using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class ForgetPassword : ContentPage
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        async void get_OTP(object sender, System.EventArgs e)
        {
            var newPage = new OTP();
            await Navigation.PushAsync(newPage);
        }
    }
}
