namespace Project2
{
    partial class FrmLogin
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
            panel1 = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnInfo = new Button();
            btnCancel = new Button();
            btnLogin = new Button();
            lblFail = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.logo_15_11_23__1;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 7, 3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 7, 0, 0);
            panel1.Size = new Size(407, 109);
            panel1.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Khmer OS Siemreap", 13.8F);
            txtUsername.Location = new Point(25, 148);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Email";
            txtUsername.Size = new Size(353, 42);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Khmer OS Siemreap", 13.8F);
            txtPassword.Location = new Point(25, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "  Password";
            txtPassword.Size = new Size(353, 42);
            txtPassword.TabIndex = 1;
            // 
            // btnInfo
            // 
            btnInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInfo.Image = Properties.Resources.info_24dp_1F1F1F_FILL0_wght400_GRAD0_opsz24;
            btnInfo.Location = new Point(348, 381);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(47, 39);
            btnInfo.TabIndex = 3;
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnCancel.Location = new Point(25, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnLogin.Location = new Point(158, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblFail
            // 
            lblFail.AutoSize = true;
            lblFail.ForeColor = Color.Red;
            lblFail.Location = new Point(25, 390);
            lblFail.Name = "lblFail";
            lblFail.Size = new Size(309, 33);
            lblFail.TabIndex = 5;
            lblFail.Text = "This form has been locked for 5mins!";
            lblFail.Visible = false;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(407, 432);
            Controls.Add(lblFail);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(btnInfo);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnInfo;
        private Button btnCancel;
        private Button btnLogin;
        private Label lblFail;
    }
}