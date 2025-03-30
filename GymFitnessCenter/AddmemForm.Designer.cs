namespace GymFitnessCenter
{
    partial class AddmemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddmemForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            PhoneTb = new TextBox();
            label6 = new Label();
            AgeTb = new TextBox();
            label7 = new Label();
            GenCb = new ComboBox();
            label8 = new Label();
            AmountTb = new TextBox();
            TimingTb = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(787, 83);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(451, 55);
            label1.TabIndex = 0;
            label1.Text = "FITNESS CENTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(732, 160);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(466, 59);
            label2.TabIndex = 1;
            label2.Text = "ADD NEW MEMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1865, 15);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 55);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.AliceBlue;
            NameTb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Crimson;
            NameTb.Location = new Point(163, 405);
            NameTb.Margin = new Padding(6, 4, 6, 4);
            NameTb.Name = "NameTb";
            NameTb.PlaceholderText = "Enter Name";
            NameTb.Size = new Size(268, 41);
            NameTb.TabIndex = 3;
            NameTb.TextChanged += NameTb_TextChanged;
            NameTb.KeyPress += NameTb_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(163, 365);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 37);
            label4.TabIndex = 4;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(804, 365);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 37);
            label5.TabIndex = 6;
            label5.Text = "Phone No";
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.AliceBlue;
            PhoneTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Crimson;
            PhoneTb.Location = new Point(804, 405);
            PhoneTb.Margin = new Padding(6, 4, 6, 4);
            PhoneTb.MaxLength = 12;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.PlaceholderText = "Enter Name";
            PhoneTb.Size = new Size(268, 41);
            PhoneTb.TabIndex = 5;
            PhoneTb.KeyPress += PhoneTb_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(1398, 365);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 37);
            label6.TabIndex = 8;
            label6.Text = "Age";
            // 
            // AgeTb
            // 
            AgeTb.BackColor = Color.AliceBlue;
            AgeTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTb.ForeColor = Color.Crimson;
            AgeTb.Location = new Point(1398, 405);
            AgeTb.Margin = new Padding(6, 4, 6, 4);
            AgeTb.MaxLength = 3;
            AgeTb.Name = "AgeTb";
            AgeTb.PlaceholderText = "Enter Name";
            AgeTb.Size = new Size(268, 41);
            AgeTb.TabIndex = 7;
            AgeTb.KeyPress += AgeTb_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(163, 606);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 37);
            label7.TabIndex = 10;
            label7.Text = "Gender";
            // 
            // GenCb
            // 
            GenCb.BackColor = Color.AliceBlue;
            GenCb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenCb.ForeColor = Color.Crimson;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(163, 646);
            GenCb.Margin = new Padding(6, 4, 6, 4);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(268, 41);
            GenCb.TabIndex = 11;
            GenCb.KeyPress += GenCb_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MediumBlue;
            label8.Location = new Point(804, 606);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(263, 37);
            label8.TabIndex = 13;
            label8.Text = "Monthly Amount";
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.AliceBlue;
            AmountTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Crimson;
            AmountTb.Location = new Point(804, 646);
            AmountTb.Margin = new Padding(6, 4, 6, 4);
            AmountTb.MaxLength = 5;
            AmountTb.Name = "AmountTb";
            AmountTb.PlaceholderText = "Enter Name";
            AmountTb.Size = new Size(275, 41);
            AmountTb.TabIndex = 12;
            AmountTb.KeyPress += AmountTb_KeyPress;
            // 
            // TimingTb
            // 
            TimingTb.BackColor = Color.AliceBlue;
            TimingTb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimingTb.ForeColor = Color.Crimson;
            TimingTb.FormattingEnabled = true;
            TimingTb.Items.AddRange(new object[] { "6Am - 8Am", "8Am - 10Am", "6Pm - 8Pm", "8Pm - 10Pm" });
            TimingTb.Location = new Point(1398, 646);
            TimingTb.Margin = new Padding(6, 4, 6, 4);
            TimingTb.Name = "TimingTb";
            TimingTb.Size = new Size(268, 41);
            TimingTb.TabIndex = 16;
            TimingTb.KeyPress += TimingTb_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(1398, 606);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 37);
            label9.TabIndex = 15;
            label9.Text = "Timing";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(834, 930);
            button2.Margin = new Padding(6, 4, 6, 4);
            button2.Name = "button2";
            button2.Size = new Size(238, 79);
            button2.TabIndex = 18;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(438, 930);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(238, 79);
            button1.TabIndex = 17;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1274, 930);
            button3.Margin = new Padding(6, 4, 6, 4);
            button3.Name = "button3";
            button3.Size = new Size(238, 79);
            button3.TabIndex = 19;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(496, 30);
            pictureBox2.Margin = new Padding(6, 4, 6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // AddmemForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1943, 1105);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TimingTb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AmountTb);
            Controls.Add(GenCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AgeTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "AddmemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddmemForm";
            Load += AddmemForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTb;
        private Label label4;
        private Label label5;
        private TextBox PhoneTb;
        private Label label6;
        private TextBox AgeTb;
        private Label label7;
        private ComboBox GenCb;
        private Label label8;
        private TextBox AmountTb;
        private ComboBox TimingTb;
        private Label label9;
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox2;
    }
}