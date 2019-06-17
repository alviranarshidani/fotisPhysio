using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Bookmyappointment : ContentPage
    {
        public Bookmyappointment()
        {
            InitializeComponent();
        }
        async void Submit_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new MyHomePage();
            await Navigation.PushAsync(newPage);
        }
    }
}
