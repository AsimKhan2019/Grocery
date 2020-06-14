namespace GroceryStore
{
    partial class PurchaseForm
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
            this.components = new System.ComponentModel.Container();
            this.groceryStoreDataSet = new GroceryStore.GroceryStoreDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GroceryStore.GroceryStoreDataSetTableAdapters.ProductsTableAdapter();
            this.productsBtn = new System.Windows.Forms.Button();
            this.productsList = new System.Windows.Forms.ListView();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.qtySelector = new System.Windows.Forms.NumericUpDown();
            this.upcTxt = new System.Windows.Forms.TextBox();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.upcLbl = new System.Windows.Forms.Label();
            this.balBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySelector)).BeginInit();
            this.SuspendLayout();
            // 
            // groceryStoreDataSet
            // 
            this.groceryStoreDataSet.DataSetName = "GroceryStoreDataSet";
            this.groceryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.groceryStoreDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(31, 12);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(125, 41);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Our Products:";
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // productsList
            // 
            this.productsList.HideSelection = false;
            this.productsList.Location = new System.Drawing.Point(31, 62);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(336, 355);
            this.productsList.TabIndex = 1;
            this.productsList.UseCompatibleStateImageBehavior = false;
            this.productsList.View = System.Windows.Forms.View.Tile;
            this.productsList.Visible = false;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(500, 140);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(111, 35);
            this.purchaseBtn.TabIndex = 2;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // qtySelector
            // 
            this.qtySelector.Location = new System.Drawing.Point(590, 98);
            this.qtySelector.Name = "qtySelector";
            this.qtySelector.Size = new System.Drawing.Size(45, 26);
            this.qtySelector.TabIndex = 3;
            // 
            // upcTxt
            // 
            this.upcTxt.Location = new System.Drawing.Point(590, 62);
            this.upcTxt.Name = "upcTxt";
            this.upcTxt.Size = new System.Drawing.Size(120, 26);
            this.upcTxt.TabIndex = 4;
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Location = new System.Drawing.Point(496, 100);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(37, 20);
            this.qtyLbl.TabIndex = 5;
            this.qtyLbl.Text = "Qty:";
            // 
            // upcLbl
            // 
            this.upcLbl.AutoSize = true;
            this.upcLbl.Location = new System.Drawing.Point(496, 65);
            this.upcLbl.Name = "upcLbl";
            this.upcLbl.Size = new System.Drawing.Size(82, 20);
            this.upcLbl.TabIndex = 6;
            this.upcLbl.Text = "Item UPC:";
            // 
            // balBtn
            // 
            this.balBtn.Location = new System.Drawing.Point(584, 343);
            this.balBtn.Name = "balBtn";
            this.balBtn.Size = new System.Drawing.Size(204, 74);
            this.balBtn.TabIndex = 7;
            this.balBtn.Text = "Check Account Balance/ Make Payment";
            this.balBtn.UseVisualStyleBackColor = true;
            this.balBtn.Click += new System.EventHandler(this.balBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(378, 343);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(200, 74);
            this.historyBtn.TabIndex = 8;
            this.historyBtn.Text = "Purchase History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.balBtn);
            this.Controls.Add(this.upcLbl);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.upcTxt);
            this.Controls.Add(this.qtySelector);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.productsList);
            this.Controls.Add(this.productsBtn);
            this.Name = "PurchaseForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtySelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroceryStoreDataSet groceryStoreDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private GroceryStoreDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.ListView productsList;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.NumericUpDown qtySelector;
        private System.Windows.Forms.TextBox upcTxt;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Label upcLbl;
        private System.Windows.Forms.Button balBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}