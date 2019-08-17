using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using fotisPhysio.Models;
using SQLite;
using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Register : ContentPage
    {
        FirebaseClient firebase = new FirebaseClient("https://fotisphysio-db71e.firebaseio.com/");
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        public Register()
        {
            InitializeComponent();
        }

        

        private async void Register_Clicked(object sender, EventArgs e)
        {
            if((FirstName.Text != null && LastName.Text != null && Email.Text != null
                && Password.Text != null && ConfirmPassword.Text != null) && (Password.Text == ConfirmPassword.Text)) 
            {
                var firstName = FirstName.Text;
                var lastName = LastName.Text;
                var email = Email.Text;
                var password = Password.Text;

                await firebaseHelper.AddUser(firstName, lastName, email, password);


                await DisplayAlert("Success", "User Added Successfully", "OK");
                var newPage = new Login();
                await Navigation.PushAsync(newPage);
            }
            else
            {
                await DisplayAlert("Error", "Please Enter valid Data and check passwords", "OK");
            }
            
        }


        /*async void Register_Clicked(object sender, System.EventArgs e)
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


        }*/
    }
}


//reference for firebase connection: https://www.c-sharpcorner.com/article/xamarin-forms-working-with-firebase-realtime-database-crud-operations/