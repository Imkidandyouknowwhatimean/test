namespace Kursovaya
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoginTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AuthButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(194, 28);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // LoginTb
            // 
            LoginTb.Location = new Point(150, 152);
            LoginTb.Name = "LoginTb";
            LoginTb.Size = new Size(224, 23);
            LoginTb.TabIndex = 1;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(151, 214);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(224, 23);
            PasswordTb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 134);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 196);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(203, 304);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(130, 43);
            AuthButton.TabIndex = 5;
            AuthButton.Text = "Авторизироваться";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(AuthButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(LoginTb);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTb;
        private TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Button AuthButton;
    }
}
