using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using fotisPhysio.Models;

namespace fotisPhysio
{
    public class FirebaseHelper
    {
        public FirebaseHelper()
        {
        }
        FirebaseClient firebase = new FirebaseClient("https://fotisphysio-db71e.firebaseio.com/");

        public async Task<List<Users>> GetAllUsers()
        {

            return (await firebase
              .Child("Users")
              .OnceAsync<Users>()).Select(item => new Users
              {
                  FirstName = item.Object.FirstName,
                  LastName = item.Object.LastName,
                  Email = item.Object.Email,
                  Password = item.Object.Password

              }).ToList();
        }

        public async Task AddUser(string firstname, string lastname, string email, string password)
        {

            await firebase
              .Child("Users")
              .PostAsync(new Users()
              {
                  
                  FirstName = firstname,
                  LastName = lastname,
                  Email = email,
                  Password = password
              });
        }

        public async Task<Users> GetUser(string email, string password)
        {
            var allUsers = await GetAllUsers();
            await firebase
              .Child("Users")
              .OnceAsync<Users>();
            return allUsers.Where(a => a.Email == email && a.Password == password).FirstOrDefault();
        }


    }
}
