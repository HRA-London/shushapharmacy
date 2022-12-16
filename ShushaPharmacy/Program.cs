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

            User adminUser = new User(2, "Isa", "Medetov", (int)UserRole.Admin, "isamedetov");
            string adminUserPassword = "1235678";

            User user = new User(1, "Terlan", "Usubov", (int)UserRole.Employee, "terlanusubov");
            string pass = "12345678";

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(pass);

                byte[] hashed = sha256.ComputeHash(buffer);

                user.Password = hashed;
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(adminUserPassword);

                byte[] hashed = sha256.ComputeHash(buffer);

                adminUser.Password = hashed;
            }

            ApplicationDbContext.Users.Add(user);
            ApplicationDbContext.Users.Add(adminUser);



            Product product1 = new Product();

            product1.Name = "Aspirin";
            product1.Price = 2;
            product1.Description = "Lazimli dermandi";
            product1.ProductType = (int)ProductType.Tabletka;
            product1.PublishDate = DateTime.Now;
            product1.ExpirationDate = DateTime.Now.AddYears(2);
            product1.ListCount = 4;
            product1.CountInList = 10;
            product1.HasSaleAsList = true;
            product1.HasSaleAsOne = false;
            product1.Id = 1;


            Product product2 = new Product();

            product2.Name = "Ketanol";
            product2.Price = 2;
            product2.Description = "Lazimli dermandi";
            product2.ProductType = (int)ProductType.Tabletka;
            product2.PublishDate = DateTime.Now;
            product2.ExpirationDate = DateTime.Now.AddYears(1);
            product2.ListCount = 4;
            product2.CountInList = 10;
            product2.HasSaleAsList = true;
            product2.HasSaleAsOne = false;
            product2.Id = 2;

            ApplicationDbContext.Products.Add(product1);
            ApplicationDbContext.Products.Add(product2);






            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}