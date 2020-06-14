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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (var item in db.Products)
                {
                    productsList.Items.Add(item.UPC + ": " + item.ProductDesc + ", $" + item.Price);
                }
                productsList.Visible = true;
            }
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var user = db.Users.First(u => u.Username == LoginForm.username);
                if (user.Balance > 100)
                {
                    MessageBox.Show("Account balance exceeds limit. Purchase not processed.");
                } 
                else
                {
                    var product = db.Products.First(p1 => p1.UPC == Convert.ToInt32(upcTxt.Text));
                    decimal total = qtySelector.Value * product.Price;
                    string id = "";
                    id += DateTime.Now.Millisecond + product.UPC;
                    Purchase purchase = new Purchase
                    {
                        PurchaseID = Convert.ToInt32(id),
                        Username = LoginForm.username,
                        UPC = product.UPC,
                        Date = DateTime.Now,
                        Qty = Convert.ToInt32(qtySelector.Value),
                        Total = total
                    };
                    db.Purchases.InsertOnSubmit(purchase);
                    db.SubmitChanges();

                    user.Balance += total;
                    db.SubmitChanges();

                    MessageBox.Show("Purchase Processed");
                }
            }
        }

        private void balBtn_Click(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm();
            pf.ShowDialog();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            PurchaseHistoryForm hf = new PurchaseHistoryForm();
            hf.ShowDialog();
        }
    }
}
