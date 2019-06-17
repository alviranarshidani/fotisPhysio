using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class About_Us : ContentPage
    {
        public About_Us()
        {
            InitializeComponent();
        }

        public async void About_us(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Services());
        }
    }
}
