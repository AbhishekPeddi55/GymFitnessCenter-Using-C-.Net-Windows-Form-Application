﻿namespace GymFitnessCenter
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            NameTb = new TextBox();
            pictureBox1 = new PictureBox();
            passTb = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            login = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1016, 15);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 55);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(318, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(451, 55);
            label1.TabIndex = 3;
            label1.Text = "FITNESS CENTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(405, 105);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 55);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.AliceBlue;
            NameTb.Font = new Font("Constantia", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Crimson;
            NameTb.Location = new Point(630, 303);
            NameTb.Margin = new Padding(6, 4, 6, 4);
            NameTb.Name = "NameTb";
            NameTb.PlaceholderText = "Enter Name";
            NameTb.Size = new Size(335, 47);
            NameTb.TabIndex = 6;
            NameTb.WordWrap = false;
            NameTb.TextChanged += NameTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, 277);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // passTb
            // 
            passTb.BackColor = Color.AliceBlue;
            passTb.Font = new Font("Constantia", 12.2F, FontStyle.Regular, GraphicsUnit.Point);
            passTb.ForeColor = Color.Crimson;
            passTb.Location = new Point(630, 393);
            passTb.Margin = new Padding(6, 4, 6, 4);
            passTb.Name = "passTb";
            passTb.PlaceholderText = "Enter Password";
            passTb.Size = new Size(335, 47);
            passTb.TabIndex = 8;
            passTb.UseSystemPasswordChar = true;
            passTb.WordWrap = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(531, 367);
            pictureBox2.Margin = new Padding(6, 4, 6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 247);
            pictureBox3.Margin = new Padding(6, 4, 6, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(418, 239);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.Crimson;
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderColor = Color.Crimson;
            login.FlatAppearance.BorderSize = 2;
            login.FlatAppearance.MouseDownBackColor = Color.Crimson;
            login.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = SystemColors.ButtonHighlight;
            login.Location = new Point(568, 521);
            login.Margin = new Padding(6, 4, 6, 4);
            login.Name = "login";
            login.Size = new Size(167, 77);
            login.TabIndex = 18;
            login.Text = "Loggin";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
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
            button1.Location = new Point(799, 521);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 77);
            button1.TabIndex = 19;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Loggin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1111, 655);
            Controls.Add(button1);
            Controls.Add(login);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(passTb);
            Controls.Add(pictureBox1);
            Controls.Add(NameTb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "Loggin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loggin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox NameTb;
        private PictureBox pictureBox1;
        private TextBox passTb;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button login;
        private Button button1;
    }
}