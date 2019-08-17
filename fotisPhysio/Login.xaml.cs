using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using fotisPhysio.Models;
using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Login : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        FirebaseClient firebase = new FirebaseClient("https://fotisphysio-db71e.firebaseio.com/");
        
        public Login()
        {
            InitializeComponent();
            

        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allUsers = await firebaseHelper.GetAllUsers();
            lstUsers.ItemsSource = allUsers;
        }


        async void Login_Clicked(object sender, System.EventArgs e)
        {
            //public static string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\\+/=\?\^`\{\}\|~\w]))(?<=[0-9a-z])@))" +
            //@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w][0-9a-z]\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            var emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            //Minimum eight characters, at least one letter, one number and one special character:

            //var passwordRegex = "^(?=.*[A-Za-z])(?=.*d)(?=.*[@$!%*#?&])[A-Za-z d@$!%*#?&]{8,}$";

           var passwordRegex = "^(?=.[a-z])(?=.[A-Z])(?=.\\d)(?=.[@$!%?&])[A-Za-z\\d@$!%?&]{8,}$";

            var email = Email.Text;
            var password  = Password.Text;

            if (email != null && password != null)
            {
                if (((Regex.IsMatch(email, emailPattern)) || (Regex.IsMatch(password,passwordRegex))))
                {

                    //await DisplayAlert("Messagae", "Login Successfully", "ok");


                    //var newPage = new Dashboard();
                    //await Navigation.PushAsync(newPage);

                    var user = await firebaseHelper.GetUser(email, password);
                    if (user != null)
                    {
                        //await DisplayAlert("Found", "User Found", "ok");
                        var newPage = new Dashboard(user);
                        await Navigation.PushAsync(newPage);

                        

                    }
                }
                else
                {

                    await DisplayAlert("Error", "Please enter Valid email and password", "ok");
                }
            }

            else
            {
                await DisplayAlert("error", "enter email and password", "ok");
            }

            


        }
        async void Forgot_Password_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new ForgetPassword();
            await Navigation.PushAsync(newPage);
        }
        async void NewUser_Clicked(object sender, System.EventArgs e)
        {
            var newPage = new Register();
            await Navigation.PushAsync(newPage);
        }

       
    }
}
