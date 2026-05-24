namespace Project2
{
    partial class FrmStudentList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentList));
            panel7 = new Panel();
            dgvStudentListRegister = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnFirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDOB = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            Pictures = new DataGridViewImageColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvStudentListRegister);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(txtSearch);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(12, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(910, 472);
            panel7.TabIndex = 1;
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
            dataGridViewCellStyle1.Font = new Font("Khmer OS Siemreap", 10.8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudentListRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudentListRegister.ColumnHeadersHeight = 45;
            dgvStudentListRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudentListRegister.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnFirstName, ColumnLastName, ColumnDOB, ColumnGender, ColumnPhone, ColumnAddress, Pictures });
            dgvStudentListRegister.Dock = DockStyle.Fill;
            dgvStudentListRegister.EnableHeadersVisualStyles = false;
            dgvStudentListRegister.Location = new Point(0, 0);
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
            dgvStudentListRegister.Size = new Size(910, 472);
            dgvStudentListRegister.TabIndex = 8;
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
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(1371, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 412);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(1079, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "    Search bar";
            txtSearch.Size = new Size(275, 40);
            txtSearch.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 52);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Dock = DockStyle.Fill;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(910, 52);
            button2.TabIndex = 8;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(2081, 15);
            button1.Name = "button1";
            button1.Size = new Size(142, 330);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(1789, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "    Search bar";
            textBox1.Size = new Size(275, 40);
            textBox1.TabIndex = 3;
            // 
            // FrmStudentList
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(934, 567);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Font = new Font("Khmer OS Siemreap", 10.8F);
            Name = "FrmStudentList";
            Padding = new Padding(12);
            Text = "FrmStudentList";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dgvStudentListRegister;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnDOB;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewImageColumn Pictures;
    }
}