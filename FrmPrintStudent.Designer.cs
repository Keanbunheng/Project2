namespace Project2
{
    partial class FrmPrintStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintStudent));
            panel1 = new Panel();
            btnGo = new Button();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            dgvStudentListRegister = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnFirstName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDOB = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            Pictures = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(16, 12);
            panel1.Margin = new Padding(3, 7, 3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 7, 0, 0);
            panel1.Size = new Size(914, 106);
            panel1.TabIndex = 4;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGo.BackColor = Color.Firebrick;
            btnGo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnGo.FlatAppearance.BorderSize = 2;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.ForeColor = Color.White;
            btnGo.Location = new Point(704, 21);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(206, 62);
            btnGo.TabIndex = 6;
            btnGo.Text = "GO";
            btnGo.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(radioButton4);
            panel4.Controls.Add(radioButton5);
            panel4.Location = new Point(246, 7);
            panel4.Margin = new Padding(3, 7, 3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 7, 0, 0);
            panel4.Size = new Size(453, 92);
            panel4.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 7.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(322, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(123, 24);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 7.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(123, 24);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(273, 48);
            label3.Name = "label3";
            label3.Size = new Size(42, 31);
            label3.TabIndex = 0;
            label3.Text = "and";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 0;
            label2.Text = "Use Date Range:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 0;
            label1.Text = "Use Date Range:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(219, 12);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 20);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "NO";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(158, 12);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(58, 20);
            radioButton5.TabIndex = 3;
            radioButton5.TabStop = true;
            radioButton5.Text = "YES";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(147, 35);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(96, 37);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Female";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(67, 35);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 37);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(6, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 37);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(dgvStudentListRegister);
            panel2.Location = new Point(16, 128);
            panel2.Margin = new Padding(3, 7, 3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 7, 0, 0);
            panel2.Size = new Size(914, 348);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(16, 486);
            panel3.Margin = new Padding(3, 7, 3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 7, 0, 0);
            panel3.Size = new Size(914, 67);
            panel3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 7);
            button1.Name = "button1";
            button1.Size = new Size(914, 60);
            button1.TabIndex = 7;
            button1.Text = "Print To Text File";
            button1.UseVisualStyleBackColor = false;
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
            dgvStudentListRegister.Location = new Point(0, 7);
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
            dgvStudentListRegister.RowTemplate.Height = 80;
            dgvStudentListRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentListRegister.Size = new Size(914, 341);
            dgvStudentListRegister.TabIndex = 9;
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
            // FrmPrintStudent
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DarkGray;
            ClientSize = new Size(946, 565);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Khmer OS Siemreap", 10.8F);
            Name = "FrmPrintStudent";
            Padding = new Padding(16, 12, 16, 12);
            Text = "FrmPrintStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentListRegister).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private Panel panel3;
        private Button btnGo;
        private Label label1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Button button1;
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