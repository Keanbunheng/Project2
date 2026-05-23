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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewUser));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnInfoInput = new Panel();
            dtpBD = new DateTimePicker();
            pnPicture = new Panel();
            btnUpload = new Button();
            picUrl = new PictureBox();
            btnDownload = new Button();
            txtPhotoUrl = new TextBox();
            label10 = new Label();
            label9 = new Label();
            gbGender = new GroupBox();
            pnGender = new Panel();
            rbtnFemale = new RadioButton();
            rbtnMale = new RadioButton();
            label4 = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnClear = new Button();
            btnAddNew = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            panel5 = new Panel();
            pnDataGrid = new Panel();
            panel6 = new Panel();
            lbStuCount = new Label();
            label12 = new Label();
            dgvStudentListRegister = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnFirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDOB = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            Pictures = new DataGridViewImageColumn();
            panel7 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            pnInfoInput.SuspendLayout();
            pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUrl).BeginInit();
            gbGender.SuspendLayout();
            pnGender.SuspendLayout();
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
            pnInfoInput.Controls.Add(dtpBD);
            pnInfoInput.Controls.Add(pnPicture);
            pnInfoInput.Controls.Add(txtPhotoUrl);
            pnInfoInput.Controls.Add(label10);
            pnInfoInput.Controls.Add(label9);
            pnInfoInput.Controls.Add(gbGender);
            pnInfoInput.Controls.Add(label4);
            pnInfoInput.Controls.Add(txtAddress);
            pnInfoInput.Controls.Add(txtPhone);
            pnInfoInput.Controls.Add(label5);
            pnInfoInput.Controls.Add(txtLastName);
            pnInfoInput.Controls.Add(label3);
            pnInfoInput.Controls.Add(txtFirstName);
            pnInfoInput.Controls.Add(label2);
            pnInfoInput.Controls.Add(txtId);
            pnInfoInput.Dock = DockStyle.Fill;
            pnInfoInput.Location = new Point(3, 3);
            pnInfoInput.Name = "pnInfoInput";
            pnInfoInput.Size = new Size(655, 833);
            pnInfoInput.TabIndex = 4;
            pnInfoInput.SizeChanged += pnInfoInput_SizeChanged;
            // 
            // dtpBD
            // 
            dtpBD.CalendarTrailingForeColor = Color.LightGray;
            dtpBD.CustomFormat = "dd/mm/yyyy";
            dtpBD.Format = DateTimePickerFormat.Custom;
            dtpBD.Location = new Point(359, 102);
            dtpBD.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpBD.MinDate = new DateTime(2000, 12, 1, 0, 0, 0, 0);
            dtpBD.Name = "dtpBD";
            dtpBD.Size = new Size(268, 40);
            dtpBD.TabIndex = 28;
            // 
            // pnPicture
            // 
            pnPicture.Anchor = AnchorStyles.Top;
            pnPicture.Controls.Add(btnUpload);
            pnPicture.Controls.Add(picUrl);
            pnPicture.Controls.Add(btnDownload);
            pnPicture.Location = new Point(21, 15);
            pnPicture.Name = "pnPicture";
            pnPicture.Size = new Size(218, 247);
            pnPicture.TabIndex = 27;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpload.Location = new Point(4, 207);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(95, 35);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // picUrl
            // 
            picUrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picUrl.Image = Properties.Resources.Group;
            picUrl.Location = new Point(4, 3);
            picUrl.Name = "picUrl";
            picUrl.Size = new Size(208, 198);
            picUrl.SizeMode = PictureBoxSizeMode.StretchImage;
            picUrl.TabIndex = 26;
            picUrl.TabStop = false;
            picUrl.Click += picUrl_Click;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDownload.Location = new Point(105, 207);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(107, 35);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += button5_Click;
            // 
            // txtPhotoUrl
            // 
            txtPhotoUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhotoUrl.Location = new Point(22, 787);
            txtPhotoUrl.Name = "txtPhotoUrl";
            txtPhotoUrl.PlaceholderText = "ImageURl";
            txtPhotoUrl.Size = new Size(268, 40);
            txtPhotoUrl.TabIndex = 5;
            txtPhotoUrl.Visible = false;
            txtPhotoUrl.TextChanged += txtPhotoUrl_TextChanged;
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
            // gbGender
            // 
            gbGender.Controls.Add(pnGender);
            gbGender.Location = new Point(255, 159);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(372, 57);
            gbGender.TabIndex = 17;
            gbGender.TabStop = false;
            gbGender.Text = "Gender";
            gbGender.Enter += gbGender_Enter;
            // 
            // pnGender
            // 
            pnGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnGender.Controls.Add(rbtnFemale);
            pnGender.Controls.Add(rbtnMale);
            pnGender.Location = new Point(183, 19);
            pnGender.Name = "pnGender";
            pnGender.Size = new Size(183, 32);
            pnGender.TabIndex = 2;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Dock = DockStyle.Right;
            rbtnFemale.Location = new Point(13, 0);
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
            rbtnMale.Location = new Point(109, 0);
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
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(22, 501);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "    Character range allow (8 ~ 255)";
            txtAddress.Size = new Size(605, 287);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(173, 406);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+855 0********";
            txtPhone.Size = new Size(454, 40);
            txtPhone.TabIndex = 9;
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
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(173, 351);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "(5 ~ 50 characters at least)";
            txtLastName.Size = new Size(454, 40);
            txtLastName.TabIndex = 7;
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
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(175, 296);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "(2 ~ 20 characters at least)";
            txtFirstName.Size = new Size(452, 40);
            txtFirstName.TabIndex = 5;
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
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtId.Location = new Point(359, 42);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "User ID";
            txtId.Size = new Size(268, 40);
            txtId.TabIndex = 3;
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
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(btnEdit);
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
            btnClear.Text = "Reset";
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
            btnAddNew.Text = "Add";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRemove.Location = new Point(310, 17);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(137, 57);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnUpdate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEdit.Location = new Point(165, 17);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 57);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
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
            panel6.Controls.Add(lbStuCount);
            panel6.Controls.Add(label12);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 712);
            panel6.Name = "panel6";
            panel6.Size = new Size(825, 44);
            panel6.TabIndex = 3;
            // 
            // lbStuCount
            // 
            lbStuCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbStuCount.BackColor = Color.DarkMagenta;
            lbStuCount.Font = new Font("Khmer OS Siemreap", 12.8F);
            lbStuCount.ForeColor = SystemColors.ControlLightLight;
            lbStuCount.Location = new Point(761, 3);
            lbStuCount.Name = "lbStuCount";
            lbStuCount.Size = new Size(44, 37);
            lbStuCount.TabIndex = 24;
            lbStuCount.Text = "00";
            lbStuCount.TextAlign = ContentAlignment.MiddleLeft;
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
            // dgvStudentListRegister
            // 
            dgvStudentListRegister.AllowUserToAddRows = false;
            dgvStudentListRegister.AllowUserToDeleteRows = false;
            dgvStudentListRegister.AllowUserToResizeColumns = false;
            dgvStudentListRegister.AllowUserToResizeRows = false;
            dgvStudentListRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentListRegister.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.HotPink;
            dataGridViewCellStyle16.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvStudentListRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvStudentListRegister.ColumnHeadersHeight = 45;
            dgvStudentListRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudentListRegister.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnFirstName, ColumnLastName, ColumnDOB, ColumnGender, ColumnPhone, ColumnAddress, Pictures });
            dgvStudentListRegister.Dock = DockStyle.Fill;
            dgvStudentListRegister.EnableHeadersVisualStyles = false;
            dgvStudentListRegister.Location = new Point(0, 2);
            dgvStudentListRegister.MultiSelect = false;
            dgvStudentListRegister.Name = "dgvStudentListRegister";
            dgvStudentListRegister.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvStudentListRegister.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvStudentListRegister.RowHeadersVisible = false;
            dgvStudentListRegister.RowHeadersWidth = 51;
            dgvStudentListRegister.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dgvStudentListRegister.RowsDefaultCellStyle = dataGridViewCellStyle18;
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
            // ColumnFirstName
            // 
            ColumnFirstName.HeaderText = "First Name";
            ColumnFirstName.MinimumWidth = 140;
            ColumnFirstName.Name = "ColumnFirstName";
            ColumnFirstName.ReadOnly = true;
            ColumnFirstName.Visible = false;
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Last Name";
            ColumnLastName.MinimumWidth = 6;
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            ColumnLastName.Visible = false;
            // 
            // ColumnDOB
            // 
            ColumnDOB.HeaderText = "Birth Date";
            ColumnDOB.MinimumWidth = 6;
            ColumnDOB.Name = "ColumnDOB";
            ColumnDOB.ReadOnly = true;
            ColumnDOB.Visible = false;
            // 
            // ColumnGender
            // 
            ColumnGender.HeaderText = "Gender";
            ColumnGender.MinimumWidth = 6;
            ColumnGender.Name = "ColumnGender";
            ColumnGender.ReadOnly = true;
            ColumnGender.Visible = false;
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Phone";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.ReadOnly = true;
            ColumnPhone.Visible = false;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Address";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.ReadOnly = true;
            ColumnAddress.Visible = false;
            // 
            // Pictures
            // 
            Pictures.HeaderText = "ColumnPicture";
            Pictures.Image = (Image)resources.GetObject("Pictures.Image");
            Pictures.MinimumWidth = 6;
            Pictures.Name = "Pictures";
            Pictures.ReadOnly = true;
            Pictures.Resizable = DataGridViewTriState.False;
            Pictures.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(txtSearch);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(835, 75);
            panel7.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(661, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 40);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(369, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "    Search bar";
            txtSearch.Size = new Size(275, 40);
            txtSearch.TabIndex = 3;
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
            gbGender.ResumeLayout(false);
            pnGender.ResumeLayout(false);
            pnGender.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnDataGrid.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
        private Button btnRemove;
        private Button btnEdit;
        private Button btnClear;
        private Panel pnInfoInput;
        private PictureBox picUrl;
        private Label label10;
        private Label label9;
        private GroupBox gbGender;
        private Panel pnGender;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label label4;
        private Label label5;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhotoUrl;
        private TextBox txtFirstName;
        private Panel panel5;
        private Panel pnDataGrid;
        private Panel panel7;
        private DataGridView dgvStudentListRegister;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel6;
        private Label label12;
        private Label lbStuCount;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Panel pnPicture;
        private Button btnUpload;
        private Button btnDownload;
        private DateTimePicker dtpBD;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnDOB;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewImageColumn Pictures;
        private Label label2;
        private TextBox txtId;
    }
}