namespace DiplomProject
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
            label2 = new Label();
            loginTb = new TextBox();
            passwordTb = new TextBox();
            authButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(145, 33);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "АВТОРИЗАЦИЯ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(84, 131);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // loginTb
            // 
            loginTb.Location = new Point(84, 147);
            loginTb.Name = "loginTb";
            loginTb.ScrollBars = ScrollBars.Vertical;
            loginTb.Size = new Size(296, 23);
            loginTb.TabIndex = 3;
            loginTb.TextChanged += loginTb_TextChanged;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(84, 235);
            passwordTb.Name = "passwordTb";
            passwordTb.ScrollBars = ScrollBars.Vertical;
            passwordTb.Size = new Size(296, 23);
            passwordTb.TabIndex = 4;
            // 
            // authButton
            // 
            authButton.BackColor = SystemColors.ActiveCaption;
            authButton.BackgroundImage = Properties.Resources._22222;
            authButton.BackgroundImageLayout = ImageLayout.Center;
            authButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            authButton.ForeColor = SystemColors.ActiveCaptionText;
            authButton.Location = new Point(154, 307);
            authButton.Name = "authButton";
            authButton.Size = new Size(138, 49);
            authButton.TabIndex = 5;
            authButton.Text = "Войти";
            authButton.UseVisualStyleBackColor = false;
            authButton.Click += authButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(84, 217);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._15753133221;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(437, 440);
            Controls.Add(label3);
            Controls.Add(authButton);
            Controls.Add(passwordTb);
            Controls.Add(loginTb);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginTb;
        private TextBox passwordTb;
        private Button authButton;
        private Label label3;
    }
}
