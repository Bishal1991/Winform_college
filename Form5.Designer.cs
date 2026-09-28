namespace WinFormsApp1
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            RightShiftButton = new Button();
            LeftShiftButton = new Button();
            label4 = new Label();
            label5 = new Label();
            letterLbl = new TextBox();
            numberLbl = new TextBox();
            AddLetterButton = new Button();
            addNumberLetter = new Button();
            SortLetterButton = new Button();
            ExitButton = new Button();
            SortNumberBUtton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "List Box Exercise";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "list of letters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 78);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "List of numbers";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(49, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(177, 204);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(254, 110);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(177, 204);
            listBox2.TabIndex = 4;
            // 
            // RightShiftButton
            // 
            RightShiftButton.Location = new Point(49, 320);
            RightShiftButton.Name = "RightShiftButton";
            RightShiftButton.Size = new Size(94, 29);
            RightShiftButton.TabIndex = 5;
            RightShiftButton.Text = "Right Shift";
            RightShiftButton.UseVisualStyleBackColor = true;
            // 
            // LeftShiftButton
            // 
            LeftShiftButton.Location = new Point(254, 320);
            LeftShiftButton.Name = "LeftShiftButton";
            LeftShiftButton.Size = new Size(94, 29);
            LeftShiftButton.TabIndex = 6;
            LeftShiftButton.Text = "Left Shift";
            LeftShiftButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 387);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 7;
            label4.Text = "Enter Letter to add";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 387);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 8;
            label5.Text = "Enter Number to add";
            // 
            // letterLbl
            // 
            letterLbl.Location = new Point(49, 410);
            letterLbl.Name = "letterLbl";
            letterLbl.Size = new Size(177, 27);
            letterLbl.TabIndex = 9;
            letterLbl.TextChanged += letterLbl_TextChanged;
            // 
            // numberLbl
            // 
            numberLbl.Location = new Point(254, 410);
            numberLbl.Name = "numberLbl";
            numberLbl.Size = new Size(177, 27);
            numberLbl.TabIndex = 10;
            // 
            // AddLetterButton
            // 
            AddLetterButton.Location = new Point(49, 463);
            AddLetterButton.Name = "AddLetterButton";
            AddLetterButton.Size = new Size(94, 29);
            AddLetterButton.TabIndex = 12;
            AddLetterButton.Text = "Add letter";
            AddLetterButton.UseVisualStyleBackColor = true;
            AddLetterButton.Click += AddLetterButton_Click;
            // 
            // addNumberLetter
            // 
            addNumberLetter.Location = new Point(254, 463);
            addNumberLetter.Name = "addNumberLetter";
            addNumberLetter.Size = new Size(110, 29);
            addNumberLetter.TabIndex = 13;
            addNumberLetter.Text = "Add Number";
            addNumberLetter.UseVisualStyleBackColor = true;
            // 
            // SortLetterButton
            // 
            SortLetterButton.Location = new Point(49, 516);
            SortLetterButton.Name = "SortLetterButton";
            SortLetterButton.Size = new Size(94, 29);
            SortLetterButton.TabIndex = 14;
            SortLetterButton.Text = "Sort Letter";
            SortLetterButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(151, 557);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SortNumberBUtton
            // 
            SortNumberBUtton.Location = new Point(254, 516);
            SortNumberBUtton.Name = "SortNumberBUtton";
            SortNumberBUtton.Size = new Size(110, 29);
            SortNumberBUtton.TabIndex = 16;
            SortNumberBUtton.Text = "Sort Number";
            SortNumberBUtton.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(SortNumberBUtton);
            Controls.Add(ExitButton);
            Controls.Add(SortLetterButton);
            Controls.Add(addNumberLetter);
            Controls.Add(AddLetterButton);
            Controls.Add(numberLbl);
            Controls.Add(letterLbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LeftShiftButton);
            Controls.Add(RightShiftButton);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button RightShiftButton;
        private Button LeftShiftButton;
        private Label label4;
        private Label label5;
        private TextBox letterLbl;
        private TextBox numberLbl;
        private Button AddLetterButton;
        private Button addNumberLetter;
        private Button SortLetterButton;
        private Button ExitButton;
        private Button SortNumberBUtton;
    }
}