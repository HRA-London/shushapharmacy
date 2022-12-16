using ShushaPharmacy.Data;
using ShushaPharmacy.Enums;
using ShushaPharmacy.Models;
using System.Security.Cryptography;
using System.Text;

namespace ShushaPharmacy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {    // SEED


            User user = new User(1,"Terlan","Usubov",(int)UserRole.Employee,"terlanusubov");
            string pass = "12345678";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(pass);

                byte[] hashed =  sha256.ComputeHash(buffer);

                user.Password = hashed;
            }

            ApplicationDbContext.Users.Add(user);



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}