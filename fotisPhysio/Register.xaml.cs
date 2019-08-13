using System;
using System.Collections.Generic;
using fotisPhysio.Models;
using SQLite;
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
            //var newPage = new Login();
            //await Navigation.PushAsync(newPage);
            var firstName = FirstName.Text;
            var lastName = LastName.Text;
            var email = Email.Text;
            var password = Password.Text;

            Users user = new Users()
            {
                
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            using (SQLiteConnection conn=new SQLiteConnection(App.DatabasePath) )
            {
                conn.CreateTable<Users>();
                int UserRecord = conn.Insert(user);
                if(UserRecord>0)
                {
                     DisplayAlert("Done", "Register Successfully", "Ok");
                }
                else
                {
                    DisplayAlert("Error", "Try Again", "Ok");
                }
            }

        }
    }
}
