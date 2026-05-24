namespace Project2
{
    partial class AddStudentForm
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
            lb = new Label();
            txtFirstName = new TextBox();
            pnPicture = new Panel();
            btnUpload = new Button();
            picUrl = new PictureBox();
            pnBody = new Panel();
            label10 = new Label();
            label9 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            gbGender = new GroupBox();
            pnGender = new Panel();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            dtpBD = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            pnButtom = new Panel();
            btnCancel = new Button();
            btnAdd = new Button();
            pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUrl).BeginInit();
            pnBody.SuspendLayout();
            gbGender.SuspendLayout();
            pnGender.SuspendLayout();
            pnButtom.SuspendLayout();
            SuspendLayout();
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(9, 11);
            lb.Name = "lb";
            lb.Size = new Size(107, 33);
            lb.TabIndex = 6;
            lb.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Location = new Point(122, 11);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "(2 ~ 20 characters at least)";
            txtFirstName.Size = new Size(252, 40);
            txtFirstName.TabIndex = 5;
            // 
            // pnPicture
            // 
            pnPicture.Controls.Add(btnUpload);
            pnPicture.Controls.Add(picUrl);
            pnPicture.Dock = DockStyle.Top;
            pnPicture.Location = new Point(30, 0);
            pnPicture.Name = "pnPicture";
            pnPicture.Padding = new Padding(6, 30, 6, 6);
            pnPicture.Size = new Size(380, 181);
            pnPicture.TabIndex = 28;
            // 
            // btnUpload
            // 
            btnUpload.Dock = DockStyle.Bottom;
            btnUpload.Location = new Point(6, 138);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(368, 37);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // picUrl
            // 
            picUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picUrl.Image = Properties.Resources.Group;
            picUrl.Location = new Point(114, 12);
            picUrl.Name = "picUrl";
            picUrl.Size = new Size(153, 115);
            picUrl.SizeMode = PictureBoxSizeMode.StretchImage;
            picUrl.TabIndex = 26;
            picUrl.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnBody.Controls.Add(label10);
            pnBody.Controls.Add(label9);
            pnBody.Controls.Add(txtAddress);
            pnBody.Controls.Add(txtPhone);
            pnBody.Controls.Add(gbGender);
            pnBody.Controls.Add(dtpBD);
            pnBody.Controls.Add(label4);
            pnBody.Controls.Add(label1);
            pnBody.Controls.Add(txtLastName);
            pnBody.Controls.Add(lb);
            pnBody.Controls.Add(txtFirstName);
            pnBody.Location = new Point(30, 181);
            pnBody.Name = "pnBody";
            pnBody.Padding = new Padding(6, 30, 6, 6);
            pnBody.Size = new Size(380, 423);
            pnBody.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 310);
            label10.Name = "label10";
            label10.Size = new Size(85, 33);
            label10.TabIndex = 35;
            label10.Text = "Address:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 252);
            label9.Name = "label9";
            label9.Size = new Size(71, 33);
            label9.TabIndex = 34;
            label9.Text = "Phone:";
            label9.Click += label9_Click;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtAddress.Location = new Point(122, 310);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "    Character range allow (8 ~ 255)";
            txtAddress.Size = new Size(252, 104);
            txtAddress.TabIndex = 32;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Location = new Point(122, 251);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+855 0********";
            txtPhone.Size = new Size(252, 40);
            txtPhone.TabIndex = 33;
            // 
            // gbGender
            // 
            gbGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbGender.Controls.Add(pnGender);
            gbGender.Location = new Point(4, 180);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(370, 57);
            gbGender.TabIndex = 31;
            gbGender.TabStop = false;
            gbGender.Text = "Gender";
            gbGender.Enter += gbGender_Enter;
            // 
            // pnGender
            // 
            pnGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnGender.Controls.Add(rbtnFemale);
            pnGender.Controls.Add(rbtnMale);
            pnGender.Location = new Point(184, 19);
            pnGender.Name = "pnGender";
            pnGender.Size = new Size(177, 32);
            pnGender.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Dock = DockStyle.Right;
            rbtnFemale.Location = new Point(7, 0);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(96, 32);
            rbtnFemale.TabIndex = 1;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Dock = DockStyle.Right;
            rbtnMale.Location = new Point(103, 0);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(74, 32);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // dtpBD
            // 
            dtpBD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpBD.CalendarTrailingForeColor = Color.LightGray;
            dtpBD.CustomFormat = "dd/mm/yyyy";
            dtpBD.Format = DateTimePickerFormat.Custom;
            dtpBD.Location = new Point(122, 126);
            dtpBD.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpBD.MinDate = new DateTime(2000, 12, 1, 0, 0, 0, 0);
            dtpBD.Name = "dtpBD";
            dtpBD.Size = new Size(252, 40);
            dtpBD.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 126);
            label4.Name = "label4";
            label4.Size = new Size(93, 33);
            label4.TabIndex = 29;
            label4.Text = "BirthDate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 68);
            label1.Name = "label1";
            label1.Size = new Size(105, 33);
            label1.TabIndex = 8;
            label1.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Location = new Point(122, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "(5 ~ 50 characters at least)";
            txtLastName.Size = new Size(252, 40);
            txtLastName.TabIndex = 7;
            // 
            // pnButtom
            // 
            pnButtom.Controls.Add(btnCancel);
            pnButtom.Controls.Add(btnAdd);
            pnButtom.Dock = DockStyle.Bottom;
            pnButtom.Location = new Point(30, 600);
            pnButtom.Name = "pnButtom";
            pnButtom.Padding = new Padding(6, 30, 6, 6);
            pnButtom.Size = new Size(380, 62);
            pnButtom.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(49, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 39);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnAddNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(194, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // AddStudentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = btnCancel;
            ClientSize = new Size(440, 662);
            ControlBox = false;
            Controls.Add(pnButtom);
            Controls.Add(pnBody);
            Controls.Add(pnPicture);
            Font = new Font("Khmer OS Siemreap", 10.8F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddStudentForm";
            Padding = new Padding(30, 0, 30, 0);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddStudentForm";
            pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUrl).EndInit();
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            gbGender.ResumeLayout(false);
            pnGender.ResumeLayout(false);
            pnGender.PerformLayout();
            pnButtom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lb;
        private TextBox txtFirstName;
        private Panel pnPicture;
        private Button btnUpload;
        private PictureBox picUrl;
        private Panel pnBody;
        private Label label1;
        private TextBox txtLastName;
        private DateTimePicker dtpBD;
        private Label label4;
        private GroupBox gbGender;
        private Panel pnGender;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label label10;
        private Label label9;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Panel pnButtom;
        private Button btnCancel;
        private Button btnAdd;
    }
}