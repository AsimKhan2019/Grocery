using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string username;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                username = userTxt.Text;
                var password = passTxt.Text;
                if (db.Users.Any(u => u.Username == username && u.Password == password))
                {
                    this.Hide();
                    PurchaseForm pf = new PurchaseForm();
                    pf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
