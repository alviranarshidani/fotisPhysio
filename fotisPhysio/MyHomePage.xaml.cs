using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class MyHomePage : ContentPage
    {
        async void Book_Appointment(object sender, System.EventArgs e)
        {
            var newPage = new Bookmyappointment();
            await Navigation.PushAsync(newPage);
        }

        async void Services_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Services();
            await Navigation.PushAsync(newPage);
        }
        public MyHomePage()
        {
            InitializeComponent();
        }
    }
}
