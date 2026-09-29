namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
<<<<<<< HEAD
            label2 = new Label();
            comboCountry = new ComboBox();
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            lbl_ID = new Label();
            lblGender = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblCountry = new Label();
            ClearBtn = new Button();
            AddBtn = new Button();
            OtherRadioButton = new RadioButton();
            FemaleradioButton = new RadioButton();
            MaleradioButton = new RadioButton();
            EmailField = new TextBox();
            ContactField = new TextBox();
            NameField = new TextBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
<<<<<<< HEAD
            UpdateBtn = new Button();
            DeleteBtn = new Button();
=======
            comboCountry = new ComboBox();
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
<<<<<<< HEAD
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 96);
=======
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 94);
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 32);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 2;
            label1.Text = "Welcome to User profile info";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 357);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
<<<<<<< HEAD
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(UpdateBtn);
            panel3.Controls.Add(label2);
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            panel3.Controls.Add(comboCountry);
            panel3.Controls.Add(lbl_ID);
            panel3.Controls.Add(lblGender);
            panel3.Controls.Add(lblContact);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblCountry);
            panel3.Controls.Add(ClearBtn);
            panel3.Controls.Add(AddBtn);
            panel3.Controls.Add(OtherRadioButton);
            panel3.Controls.Add(FemaleradioButton);
            panel3.Controls.Add(MaleradioButton);
            panel3.Controls.Add(EmailField);
            panel3.Controls.Add(ContactField);
            panel3.Controls.Add(NameField);
            panel3.Location = new Point(-1, 95);
            panel3.Name = "panel3";
<<<<<<< HEAD
            panel3.Size = new Size(456, 430);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 57);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 17;
            label2.Text = "ID :";
            // 
            // comboCountry
            // 
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(128, 264);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(214, 28);
            comboCountry.TabIndex = 16;
            comboCountry.SelectedIndexChanged += UserINfo_Load;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(128, 57);
=======
            panel3.Size = new Size(408, 357);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(88, 50);
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(31, 20);
            lbl_ID.TabIndex = 15;
            lbl_ID.Text = "ID :";
            lbl_ID.Click += lbl_ID_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(55, 227);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender :";
            lblGender.Click += lblGender_Click;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(28, 193);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(91, 20);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact no. :";
            lblContact.Click += lblContact_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(66, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email :";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Name :";
            lblName.Click += lblName_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(52, 262);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(67, 20);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "Country :";
            lblCountry.Click += label2_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(259, 309);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(94, 29);
            ClearBtn.TabIndex = 8;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(117, 309);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // OtherRadioButton
            // 
            OtherRadioButton.AutoSize = true;
            OtherRadioButton.Location = new Point(286, 223);
            OtherRadioButton.Name = "OtherRadioButton";
            OtherRadioButton.Size = new Size(67, 24);
            OtherRadioButton.TabIndex = 5;
            OtherRadioButton.Text = "Other";
            OtherRadioButton.UseVisualStyleBackColor = true;
            OtherRadioButton.CheckedChanged += OtherRadioButton_CheckedChanged;
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(197, 225);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(78, 24);
            FemaleradioButton.TabIndex = 4;
            FemaleradioButton.Text = "Female";
            FemaleradioButton.UseVisualStyleBackColor = true;
            FemaleradioButton.CheckedChanged += FemaleradioButton_CheckedChanged;
            // 
            // MaleradioButton
            // 
            MaleradioButton.AutoSize = true;
            MaleradioButton.Checked = true;
            MaleradioButton.Location = new Point(128, 227);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(63, 24);
            MaleradioButton.TabIndex = 3;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "Male";
            MaleradioButton.UseVisualStyleBackColor = true;
            MaleradioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // EmailField
            // 
            EmailField.Location = new Point(128, 141);
            EmailField.Name = "EmailField";
            EmailField.Size = new Size(214, 27);
            EmailField.TabIndex = 2;
            EmailField.TextChanged += EmailField_TextChanged;
            // 
            // ContactField
            // 
            ContactField.Location = new Point(128, 190);
            ContactField.Name = "ContactField";
            ContactField.Size = new Size(214, 27);
            ContactField.TabIndex = 1;
            ContactField.TextChanged += ContactField_TextChanged;
            // 
            // NameField
            // 
            NameField.Location = new Point(128, 95);
            NameField.Name = "NameField";
            NameField.Size = new Size(214, 27);
            NameField.TabIndex = 0;
            NameField.TextChanged += NameField_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(dataGridView1);
            panel4.ForeColor = SystemColors.ActiveBorder;
<<<<<<< HEAD
            panel4.Location = new Point(454, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 430);
=======
            panel4.Location = new Point(407, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(394, 357);
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(406, 430);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(117, 361);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(259, 361);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 18;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
=======
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(394, 354);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboCountry
            // 
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(128, 264);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(214, 28);
            comboCountry.TabIndex = 16;
            comboCountry.SelectedIndexChanged += comboCountry_SelectedIndexChanged;
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(858, 524);
=======
            ClientSize = new Size(800, 450);
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
<<<<<<< HEAD
            Load += UserINfo_Load;
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox NameField;
        private Panel panel4;
        private RadioButton MaleradioButton;
        private TextBox EmailField;
        private TextBox ContactField;
        private Label lblCountry;
        private Button ClearBtn;
        private Button AddBtn;
        private RadioButton OtherRadioButton;
        private RadioButton FemaleradioButton;
        private Label lblGender;
        private Label lblContact;
        private Label lblEmail;
        private Label lblName;
        private Label lbl_ID;
        private DataGridView dataGridView1;
        private ComboBox comboCountry;
<<<<<<< HEAD
        private Label label2;
        private Button DeleteBtn;
        private Button UpdateBtn;
=======
>>>>>>> 0cf19bd14cb7479ec016ce3ee7f1476ae95b5503
    }
}