namespace drugstoreapp
{
    partial class auth
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
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.passwdtbox = new System.Windows.Forms.TextBox();
            this.logintbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_btn.Location = new System.Drawing.Point(12, 67);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(75, 23);
            this.sign_in_btn.TabIndex = 1;
            this.sign_in_btn.Text = "Sign in";
            this.sign_in_btn.UseVisualStyleBackColor = true;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(105, 67);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // passwdtbox
            // 
            this.passwdtbox.Location = new System.Drawing.Point(47, 39);
            this.passwdtbox.Name = "passwdtbox";
            this.passwdtbox.Size = new System.Drawing.Size(100, 20);
            this.passwdtbox.TabIndex = 3;
            // 
            // logintbox
            // 
            this.logintbox.Location = new System.Drawing.Point(47, 12);
            this.logintbox.Name = "logintbox";
            this.logintbox.Size = new System.Drawing.Size(100, 20);
            this.logintbox.TabIndex = 4;
            // 
            // auth
            // 
            this.AcceptButton = this.sign_in_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(192, 102);
            this.Controls.Add(this.logintbox);
            this.Controls.Add(this.passwdtbox);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.sign_in_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox passwdtbox;
        private System.Windows.Forms.TextBox logintbox;
    }
}