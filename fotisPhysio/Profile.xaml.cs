using System;
using System.Collections.Generic;
using fotisPhysio.Models;
using SQLite;
using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.DatabasePath))
            {
                
                var user = db.Find<Users>(1);
                lblFirstName.Text = user.FirstName;
                lblLastName.Text = user.LastName;
                lblEmail.Text = user.Email;

            }

            }

        }

    }
