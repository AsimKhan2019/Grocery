namespace GroceryStore
{
    partial class LoginForm
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
            this.userLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(27, 25);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(87, 20);
            this.userLbl.TabIndex = 0;
            this.userLbl.Text = "Username:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(27, 61);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(82, 20);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Password:";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(131, 25);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(145, 26);
            this.userTxt.TabIndex = 2;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(131, 61);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(145, 26);
            this.passTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(31, 113);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 38);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.userLbl);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button loginBtn;
    }
}

