namespace GroceryStore
{
    partial class PaymentForm
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
            this.chkBalBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.balLbl = new System.Windows.Forms.Label();
            this.paymentTxt = new System.Windows.Forms.TextBox();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBalBtn
            // 
            this.chkBalBtn.Location = new System.Drawing.Point(41, 41);
            this.chkBalBtn.Name = "chkBalBtn";
            this.chkBalBtn.Size = new System.Drawing.Size(222, 51);
            this.chkBalBtn.TabIndex = 0;
            this.chkBalBtn.Text = "Check Account Balance";
            this.chkBalBtn.UseVisualStyleBackColor = true;
            this.chkBalBtn.Click += new System.EventHandler(this.chkBalBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(41, 137);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(222, 51);
            this.payBtn.TabIndex = 1;
            this.payBtn.Text = "Make Payment";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // balLbl
            // 
            this.balLbl.AutoSize = true;
            this.balLbl.Location = new System.Drawing.Point(313, 56);
            this.balLbl.Name = "balLbl";
            this.balLbl.Size = new System.Drawing.Size(0, 20);
            this.balLbl.TabIndex = 2;
            this.balLbl.Visible = false;
            // 
            // paymentTxt
            // 
            this.paymentTxt.Location = new System.Drawing.Point(431, 149);
            this.paymentTxt.Name = "paymentTxt";
            this.paymentTxt.Size = new System.Drawing.Size(147, 26);
            this.paymentTxt.TabIndex = 3;
            this.paymentTxt.Visible = false;
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Location = new System.Drawing.Point(313, 152);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(112, 20);
            this.paymentLbl.TabIndex = 4;
            this.paymentLbl.Text = "Enter Amount:";
            this.paymentLbl.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(431, 190);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(147, 31);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Process Payment";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.paymentTxt);
            this.Controls.Add(this.balLbl);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.chkBalBtn);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chkBalBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label balLbl;
        private System.Windows.Forms.TextBox paymentTxt;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.Button submitBtn;
    }
}