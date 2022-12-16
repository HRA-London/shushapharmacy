using ShushaPharmacy.Data;
using ShushaPharmacy.Models;
using System.Security.Cryptography;
using System.Text;

namespace ShushaPharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbx_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txbx_username.Text;
            string password = txbx_password.Text;


            List<User> users = ApplicationDbContext.Users;

            User loggedUser = null;
            foreach (User user in users)
            {
                if(user.UserName == username)
                {
                    loggedUser = user;
                    break;
                }
            }

            if(loggedUser == null)
            {
                MessageBox.Show("Istifadeci adi ve ya sifre yanlisdir.");
                return;
            }


            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(password);
                byte[] hashed = sha256.ComputeHash(buffer);

                if (loggedUser.Password.SequenceEqual(hashed) != true)
                {
                    MessageBox.Show("Istifadeci adi ve ya sifre yanlisdir.");
                    return;
                }

                MessageBox.Show("Xosgeldin!");

            }
        }
    }
}