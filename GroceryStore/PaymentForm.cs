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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void chkBalBtn_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var user = db.Users.First(u => u.Username == LoginForm.username);
                balLbl.Text = "$" + user.Balance.ToString();
                balLbl.Visible = true;
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            balLbl.Visible = false;
            paymentLbl.Visible = true;
            paymentTxt.Visible = true;
            submitBtn.Visible = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var user = db.Users.First(u => u.Username == LoginForm.username);
                user.Balance -= Convert.ToDecimal(paymentTxt.Text);
                db.SubmitChanges();
                MessageBox.Show("Payment Processed");
                paymentLbl.Visible = false;
                paymentTxt.Visible = false;
                submitBtn.Visible = false;
            }
        }
    }
}
