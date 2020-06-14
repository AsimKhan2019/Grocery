namespace GroceryStore
{
    partial class PurchaseHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allPurchasesBtn = new System.Windows.Forms.Button();
            this.dateHistoryBtn = new System.Windows.Forms.Button();
            this.priceHistoryBtn = new System.Windows.Forms.Button();
            this.allPurchasesList = new System.Windows.Forms.ListView();
            this.dateHistoryList = new System.Windows.Forms.ListView();
            this.priceHistoryList = new System.Windows.Forms.ListView();
            this.startLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.searchBtn = new System.Windows.Forms.Button();
            this.search2Btn = new System.Windows.Forms.Button();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.maxTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allPurchasesBtn
            // 
            this.allPurchasesBtn.Location = new System.Drawing.Point(113, 47);
            this.allPurchasesBtn.Name = "allPurchasesBtn";
            this.allPurchasesBtn.Size = new System.Drawing.Size(173, 38);
            this.allPurchasesBtn.TabIndex = 0;
            this.allPurchasesBtn.Text = "See All Purchases";
            this.allPurchasesBtn.UseVisualStyleBackColor = true;
            this.allPurchasesBtn.Click += new System.EventHandler(this.allPurchasesBtn_Click);
            // 
            // dateHistoryBtn
            // 
            this.dateHistoryBtn.Location = new System.Drawing.Point(459, 47);
            this.dateHistoryBtn.Name = "dateHistoryBtn";
            this.dateHistoryBtn.Size = new System.Drawing.Size(179, 38);
            this.dateHistoryBtn.TabIndex = 1;
            this.dateHistoryBtn.Text = "Purchases by Date";
            this.dateHistoryBtn.UseVisualStyleBackColor = true;
            this.dateHistoryBtn.Click += new System.EventHandler(this.dateHistoryBtn_Click);
            // 
            // priceHistoryBtn
            // 
            this.priceHistoryBtn.Location = new System.Drawing.Point(791, 47);
            this.priceHistoryBtn.Name = "priceHistoryBtn";
            this.priceHistoryBtn.Size = new System.Drawing.Size(176, 38);
            this.priceHistoryBtn.TabIndex = 2;
            this.priceHistoryBtn.Text = "Purchases by Price";
            this.priceHistoryBtn.UseVisualStyleBackColor = true;
            this.priceHistoryBtn.Click += new System.EventHandler(this.priceHistoryBtn_Click);
            // 
            // allPurchasesList
            // 
            this.allPurchasesList.HideSelection = false;
            this.allPurchasesList.Location = new System.Drawing.Point(42, 122);
            this.allPurchasesList.Name = "allPurchasesList";
            this.allPurchasesList.Size = new System.Drawing.Size(314, 316);
            this.allPurchasesList.TabIndex = 3;
            this.allPurchasesList.UseCompatibleStateImageBehavior = false;
            this.allPurchasesList.View = System.Windows.Forms.View.List;
            this.allPurchasesList.Visible = false;
            // 
            // dateHistoryList
            // 
            this.dateHistoryList.HideSelection = false;
            this.dateHistoryList.Location = new System.Drawing.Point(385, 219);
            this.dateHistoryList.Name = "dateHistoryList";
            this.dateHistoryList.Size = new System.Drawing.Size(314, 219);
            this.dateHistoryList.TabIndex = 4;
            this.dateHistoryList.UseCompatibleStateImageBehavior = false;
            this.dateHistoryList.View = System.Windows.Forms.View.List;
            this.dateHistoryList.Visible = false;
            // 
            // priceHistoryList
            // 
            this.priceHistoryList.HideSelection = false;
            this.priceHistoryList.Location = new System.Drawing.Point(729, 219);
            this.priceHistoryList.Name = "priceHistoryList";
            this.priceHistoryList.Size = new System.Drawing.Size(314, 219);
            this.priceHistoryList.TabIndex = 5;
            this.priceHistoryList.UseCompatibleStateImageBehavior = false;
            this.priceHistoryList.View = System.Windows.Forms.View.List;
            this.priceHistoryList.Visible = false;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(463, 99);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(50, 20);
            this.startLbl.TabIndex = 6;
            this.startLbl.Text = "From:";
            this.startLbl.Visible = false;
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Location = new System.Drawing.Point(463, 126);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(31, 20);
            this.endLbl.TabIndex = 7;
            this.endLbl.Text = "To:";
            this.endLbl.Visible = false;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(514, 99);
            this.startDate.MaxDate = new System.DateTime(2020, 5, 27, 21, 38, 9, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(111, 26);
            this.startDate.TabIndex = 8;
            this.startDate.Value = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            this.startDate.Visible = false;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(514, 126);
            this.endDate.MaxDate = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(111, 26);
            this.endDate.TabIndex = 9;
            this.endDate.Value = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            this.endDate.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(500, 160);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 32);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // search2Btn
            // 
            this.search2Btn.Location = new System.Drawing.Point(836, 169);
            this.search2Btn.Name = "search2Btn";
            this.search2Btn.Size = new System.Drawing.Size(85, 32);
            this.search2Btn.TabIndex = 15;
            this.search2Btn.Text = "Search";
            this.search2Btn.UseVisualStyleBackColor = true;
            this.search2Btn.Visible = false;
            this.search2Btn.Click += new System.EventHandler(this.search2Btn_Click);
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(799, 135);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(59, 20);
            this.maxLbl.TabIndex = 12;
            this.maxLbl.Text = "Max:  $";
            this.maxLbl.Visible = false;
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(799, 108);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(59, 20);
            this.minLbl.TabIndex = 11;
            this.minLbl.Text = "Min:   $";
            this.minLbl.Visible = false;
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(862, 108);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(100, 26);
            this.minTxt.TabIndex = 16;
            this.minTxt.Visible = false;
            // 
            // maxTxt
            // 
            this.maxTxt.Location = new System.Drawing.Point(862, 135);
            this.maxTxt.Name = "maxTxt";
            this.maxTxt.Size = new System.Drawing.Size(100, 26);
            this.maxTxt.TabIndex = 17;
            this.maxTxt.Visible = false;
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.maxTxt);
            this.Controls.Add(this.minTxt);
            this.Controls.Add(this.search2Btn);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.priceHistoryList);
            this.Controls.Add(this.dateHistoryList);
            this.Controls.Add(this.allPurchasesList);
            this.Controls.Add(this.priceHistoryBtn);
            this.Controls.Add(this.dateHistoryBtn);
            this.Controls.Add(this.allPurchasesBtn);
            this.Name = "PurchaseHistoryForm";
            this.Text = "PurchaseHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allPurchasesBtn;
        private System.Windows.Forms.Button dateHistoryBtn;
        private System.Windows.Forms.Button priceHistoryBtn;
        private System.Windows.Forms.ListView allPurchasesList;
        private System.Windows.Forms.ListView dateHistoryList;
        private System.Windows.Forms.ListView priceHistoryList;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button search2Btn;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.TextBox maxTxt;
    }
}