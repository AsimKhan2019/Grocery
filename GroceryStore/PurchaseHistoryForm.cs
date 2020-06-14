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
    public partial class PurchaseHistoryForm : Form
    {
        public PurchaseHistoryForm()
        {
            InitializeComponent();
        }

        private void allPurchasesBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases.Where(p => p.Username == LoginForm.username);
                foreach (var purchase in purchases)
                {
                    allPurchasesList.Items.Add(purchase.Date.ToShortDateString() + " - UPC:" + purchase.UPC + ", Qty:" + purchase.Qty + ", Total:$" + purchase.Total);

                }
                allPurchasesList.Visible = true;
            }
        }

        private void dateHistoryBtn_Click(object sender, EventArgs e)
        {
            startLbl.Visible = true;
            startDate.Visible = true;
            endLbl.Visible = true;
            endDate.Visible = true;
            searchBtn.Visible = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases.Where(p => p.Username == LoginForm.username && p.Date >= startDate.Value && p.Date <= endDate.Value);

                foreach (var purchase in purchases)
                {
                    dateHistoryList.Items.Add(purchase.Date.ToShortDateString() + " - UPC:" + purchase.UPC + ", Qty:" + purchase.Qty + ", Total:$" + purchase.Total);
                }
                dateHistoryList.Visible = true;
            }
        }

        private void priceHistoryBtn_Click(object sender, EventArgs e)
        {
            minLbl.Visible = true;
            minTxt.Visible = true;
            maxLbl.Visible = true;
            maxTxt.Visible = true;
            search2Btn.Visible = true;
        }

        private void search2Btn_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var purchases = db.Purchases.Where(p => p.Username == LoginForm.username && p.Total >= Convert.ToInt32(minTxt.Text) && p.Total <= Convert.ToInt32(maxTxt.Text));
                foreach (var purchase in purchases)
                {
                    priceHistoryList.Items.Add(purchase.Date.ToShortDateString() + " - UPC:" + purchase.UPC + ", Qty:" + purchase.Qty + ", Total:$" + purchase.Total);
                }
                priceHistoryList.Visible = true;
            }
        }
    }
}
