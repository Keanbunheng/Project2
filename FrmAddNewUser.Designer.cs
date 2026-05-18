namespace Project2
{
    partial class FrmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewUser));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnInfoInput = new Panel();
            pnPicture = new Panel();
            button3 = new Button();
            picUrl = new PictureBox();
            button5 = new Button();
            label10 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            txtPassCf = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnClear = new Button();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnGetData = new Button();
            panel5 = new Panel();
            pnDataGrid = new Panel();
            panel6 = new Panel();
            label13 = new Label();
            label12 = new Label();
            txtPhotoUrl = new TextBox();
            dgvStudentListRegister = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnPassword = new DataGridViewTextBoxColumn();
            ColumnDOB = new DataGridViewTextBoxColumn();
            ColumnActive = new DataGridViewTextBoxColumn();
            ColumnScore = new DataGridViewTextBoxColumn();
            ColumnSession = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            button2 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            pnInfoInput.SuspendLayout();
            pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUrl).BeginInit();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            pnDataGrid.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Khmer OS Siemreap", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1502, 83);
            label1.TabIndex = 0;
            label1.Text = "Student Register BMU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.007988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.992012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(pnInfoInput, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.21277F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.787234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1502, 931);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.SizeChanged += tableLayoutPanel1_SizeChanged;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pnInfoInput
            // 
            pnInfoInput.Controls.Add(pnPicture);
            pnInfoInput.Controls.Add(label10);
            pnInfoInput.Controls.Add(label9);
            pnInfoInput.Controls.Add(groupBox1);
            pnInfoInput.Controls.Add(label4);
            pnInfoInput.Controls.Add(textBox4);
            pnInfoInput.Controls.Add(textBox3);
            pnInfoInput.Controls.Add(txtName);
            pnInfoInput.Controls.Add(label5);
            pnInfoInput.Controls.Add(txtPassCf);
            pnInfoInput.Controls.Add(label3);
            pnInfoInput.Controls.Add(txtPassword);
            pnInfoInput.Controls.Add(label2);
            pnInfoInput.Controls.Add(txtEmail);
            pnInfoInput.Dock = DockStyle.Fill;
            pnInfoInput.Location = new Point(3, 3);
            pnInfoInput.Name = "pnInfoInput";
            pnInfoInput.Size = new Size(655, 833);
            pnInfoInput.TabIndex = 4;
            pnInfoInput.SizeChanged += pnInfoInput_SizeChanged;
            // 
            // pnPicture
            // 
            pnPicture.Anchor = AnchorStyles.Top;
            pnPicture.Controls.Add(button3);
            pnPicture.Controls.Add(picUrl);
            pnPicture.Controls.Add(button5);
            pnPicture.Location = new Point(18, 15);
            pnPicture.Name = "pnPicture";
            pnPicture.Size = new Size(203, 247);
            pnPicture.TabIndex = 27;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Location = new Point(4, 207);
            button3.Name = "button3";
            button3.Size = new Size(95, 35);
            button3.TabIndex = 0;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            // 
            // picUrl
            // 
            picUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picUrl.Image = (Image)resources.GetObject("picUrl.Image");
            picUrl.Location = new Point(4, 3);
            picUrl.Name = "picUrl";
            picUrl.Size = new Size(193, 198);
            picUrl.SizeMode = PictureBoxSizeMode.StretchImage;
            picUrl.TabIndex = 26;
            picUrl.TabStop = false;
            picUrl.Click += picUrl_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(105, 207);
            button5.Name = "button5";
            button5.Size = new Size(92, 35);
            button5.TabIndex = 1;
            button5.Text = "Get Data";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 465);
            label10.Name = "label10";
            label10.Size = new Size(85, 33);
            label10.TabIndex = 21;
            label10.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 406);
            label9.Name = "label9";
            label9.Size = new Size(71, 33);
            label9.TabIndex = 19;
            label9.Text = "Phone:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(panel4);
            groupBox1.Location = new Point(255, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 57);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(rbtnFemale);
            panel4.Controls.Add(rbtnMale);
            panel4.Location = new Point(194, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 32);
            panel4.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Dock = DockStyle.Right;
            rbtnFemale.Location = new Point(76, 0);
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
            rbtnMale.Dock = DockStyle.Left;
            rbtnMale.Location = new Point(0, 0);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(74, 32);
            rbtnMale.TabIndex = 0;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(255, 105);
            label4.Name = "label4";
            label4.Size = new Size(88, 33);
            label4.TabIndex = 10;
            label4.Text = "BirthDate";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(22, 501);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "username";
            textBox4.Size = new Size(605, 287);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(173, 406);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "username";
            textBox3.Size = new Size(454, 40);
            textBox3.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(359, 102);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "username";
            txtName.Size = new Size(268, 40);
            txtName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 351);
            label5.Name = "label5";
            label5.Size = new Size(100, 33);
            label5.TabIndex = 8;
            label5.Text = "LastName:";
            // 
            // txtPassCf
            // 
            txtPassCf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassCf.Location = new Point(173, 351);
            txtPassCf.Name = "txtPassCf";
            txtPassCf.Size = new Size(454, 40);
            txtPassCf.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 296);
            label3.Name = "label3";
            label3.Size = new Size(102, 33);
            label3.TabIndex = 6;
            label3.Text = "FirstName:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(175, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "(8 ~ 20 characters at least)";
            txtPassword.Size = new Size(452, 40);
            txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(255, 49);
            label2.Name = "label2";
            label2.Size = new Size(38, 33);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(359, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(268, 40);
            txtEmail.TabIndex = 3;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 842);
            panel1.Name = "panel1";
            panel1.Size = new Size(1496, 86);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnAddNew);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnGetData);
            panel3.Location = new Point(452, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 80);
            panel3.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnClear.Location = new Point(455, 17);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 57);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAddNew.Location = new Point(20, 17);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(137, 57);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Submit";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnUpdate.Location = new Point(310, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 57);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetData
            // 
            btnGetData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGetData.Location = new Point(165, 17);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(137, 57);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "Get Data";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pnDataGrid);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(664, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(835, 833);
            panel5.TabIndex = 5;
            // 
            // pnDataGrid
            // 
            pnDataGrid.Controls.Add(panel6);
            pnDataGrid.Controls.Add(dgvStudentListRegister);
            pnDataGrid.Dock = DockStyle.Fill;
            pnDataGrid.Location = new Point(0, 75);
            pnDataGrid.Name = "pnDataGrid";
            pnDataGrid.Padding = new Padding(0, 2, 10, 2);
            pnDataGrid.Size = new Size(835, 758);
            pnDataGrid.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(txtPhotoUrl);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 712);
            panel6.Name = "panel6";
            panel6.Size = new Size(825, 44);
            panel6.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label13.BackColor = Color.DarkMagenta;
            label13.Font = new Font("Khmer OS Siemreap", 12.8F);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(761, 3);
            label13.Name = "label13";
            label13.Size = new Size(44, 37);
            label13.TabIndex = 24;
            label13.Text = "00";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.BackColor = Color.DarkMagenta;
            label12.Font = new Font("Khmer OS Siemreap", 12.8F);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(569, 3);
            label12.Name = "label12";
            label12.Size = new Size(255, 41);
            label12.TabIndex = 24;
            label12.Text = "     Total Students:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhotoUrl
            // 
            txtPhotoUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhotoUrl.Location = new Point(45, 5);
            txtPhotoUrl.Name = "txtPhotoUrl";
            txtPhotoUrl.PlaceholderText = "ImageURl";
            txtPhotoUrl.Size = new Size(268, 40);
            txtPhotoUrl.TabIndex = 5;
            txtPhotoUrl.Visible = false;
            txtPhotoUrl.TextChanged += txtPhotoUrl_TextChanged;
            // 
            // dgvStudentListRegister
            // 
            dgvStudentListRegister.AllowUserToAddRows = false;
            dgvStudentListRegister.AllowUserToDeleteRows = false;
            dgvStudentListRegister.AllowUserToResizeColumns = false;
            dgvStudentListRegister.AllowUserToResizeRows = false;
            dgvStudentListRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentListRegister.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.HotPink;
            dataGridViewCellStyle1.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudentListRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudentListRegister.ColumnHeadersHeight = 45;
            dgvStudentListRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudentListRegister.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnGender, ColumnEmail, ColumnPassword, ColumnDOB, ColumnActive, ColumnScore, ColumnSession, ColumnStatus });
            dgvStudentListRegister.Dock = DockStyle.Fill;
            dgvStudentListRegister.EnableHeadersVisualStyles = false;
            dgvStudentListRegister.Location = new Point(0, 2);
            dgvStudentListRegister.MultiSelect = false;
            dgvStudentListRegister.Name = "dgvStudentListRegister";
            dgvStudentListRegister.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStudentListRegister.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStudentListRegister.RowHeadersVisible = false;
            dgvStudentListRegister.RowHeadersWidth = 51;
            dgvStudentListRegister.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvStudentListRegister.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudentListRegister.RowTemplate.Height = 40;
            dgvStudentListRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentListRegister.Size = new Size(825, 754);
            dgvStudentListRegister.TabIndex = 2;
            dgvStudentListRegister.CellContentClick += dgvStudentListRegister_CellContentClick_1;
            // 
            // ColumnID
            // 
            ColumnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Visible = false;
            ColumnID.Width = 40;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 140;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Visible = false;
            // 
            // ColumnGender
            // 
            ColumnGender.HeaderText = "Gender";
            ColumnGender.MinimumWidth = 6;
            ColumnGender.Name = "ColumnGender";
            ColumnGender.ReadOnly = true;
            ColumnGender.Visible = false;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 160;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            ColumnEmail.Visible = false;
            // 
            // ColumnPassword
            // 
            ColumnPassword.HeaderText = "Password";
            ColumnPassword.MinimumWidth = 140;
            ColumnPassword.Name = "ColumnPassword";
            ColumnPassword.ReadOnly = true;
            ColumnPassword.Visible = false;
            // 
            // ColumnDOB
            // 
            ColumnDOB.HeaderText = "DOB";
            ColumnDOB.MinimumWidth = 6;
            ColumnDOB.Name = "ColumnDOB";
            ColumnDOB.ReadOnly = true;
            ColumnDOB.Visible = false;
            // 
            // ColumnActive
            // 
            ColumnActive.HeaderText = "Active";
            ColumnActive.MinimumWidth = 6;
            ColumnActive.Name = "ColumnActive";
            ColumnActive.ReadOnly = true;
            ColumnActive.Visible = false;
            // 
            // ColumnScore
            // 
            ColumnScore.HeaderText = "Score";
            ColumnScore.MinimumWidth = 6;
            ColumnScore.Name = "ColumnScore";
            ColumnScore.ReadOnly = true;
            ColumnScore.Visible = false;
            // 
            // ColumnSession
            // 
            ColumnSession.HeaderText = "Session";
            ColumnSession.MinimumWidth = 6;
            ColumnSession.Name = "ColumnSession";
            ColumnSession.ReadOnly = true;
            ColumnSession.Visible = false;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.Visible = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button2);
            panel7.Controls.Add(textBox1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(835, 75);
            panel7.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(661, 15);
            button2.Name = "button2";
            button2.Size = new Size(142, 40);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(369, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "    Search bar";
            textBox1.Size = new Size(275, 40);
            textBox1.TabIndex = 3;
            // 
            // FrmAddNewUser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1502, 1014);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmAddNewUser";
            Text = "FrmAddNewUser";
            Load += FrmAddNewUser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnInfoInput.ResumeLayout(false);
            pnInfoInput.PerformLayout();
            pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUrl).EndInit();
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnDataGrid.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnGetData;
        private Button btnClear;
        private Panel pnInfoInput;
        private PictureBox picUrl;
        private Label label10;
        private Label label9;
        private GroupBox groupBox1;
        private Panel panel4;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtPassCf;
        private Label label3;
        private TextBox txtPhotoUrl;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Panel panel5;
        private Panel pnDataGrid;
        private Panel panel7;
        private DataGridView dgvStudentListRegister;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPassword;
        private DataGridViewTextBoxColumn ColumnDOB;
        private DataGridViewTextBoxColumn ColumnActive;
        private DataGridViewTextBoxColumn ColumnScore;
        private DataGridViewTextBoxColumn ColumnSession;
        private DataGridViewTextBoxColumn ColumnStatus;
        private Button button2;
        private TextBox textBox1;
        private Panel panel6;
        private Label label12;
        private Label label13;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel pnPicture;
        private Button button3;
        private Button button5;
    }
}