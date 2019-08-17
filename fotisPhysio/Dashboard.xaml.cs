using System;
using System.Collections.Generic;
using fotisPhysio.Models;
using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Dashboard : ContentPage
    {
        Users user;
        public Dashboard()
        {
            InitializeComponent();
            
            
        }
        public Dashboard(Users u)
        {
            InitializeComponent();
            user = u;

        }

        async void btnProfile_Clicked(object sender, System.EventArgs e)
        {
            if (user != null)
            {
                var newPage = new Profile(user);
                await Navigation.PushAsync(newPage);
            }
            else
            {
                var newPage = new Profile();
                await Navigation.PushAsync(newPage);
            }
            

            
        }

        async void btnAppointments_ClickedAsync(object sender, System.EventArgs e)
        {
            var newPage = new AppointmentHistory();
            await Navigation.PushAsync(newPage);
        }
        
    }
}
