using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            
            
        }

        async void btnProfile_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Profile();
            await Navigation.PushAsync(newPage);
        }

        async void btnAppointments_ClickedAsync(object sender, System.EventArgs e)
        {
            var newPage = new AppointmentHistory();
            await Navigation.PushAsync(newPage);
        }
        
    }
}
