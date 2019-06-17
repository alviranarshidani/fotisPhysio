using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Careerform : ContentPage
    {
        public Careerform()
        {
            InitializeComponent();
        }
        async void Upload (object sender, System.EventArgs e)
        {
            var newPage = new Careers();
            await Navigation.PushAsync(newPage);
        }
    }
}
