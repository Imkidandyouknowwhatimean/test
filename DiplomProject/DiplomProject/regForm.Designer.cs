namespace DiplomProject
{
    partial class regForm
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
            nameTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            loginTb = new TextBox();
            passwordTb = new TextBox();
            button1 = new Button();
            idTb = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 30);
            label1.TabIndex = 0;
            label1.Text = "Регистрация нового пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 9F);
            label2.Location = new Point(140, 64);
            label2.Name = "label2";
            label2.Size = new Size(175, 16);
            label2.TabIndex = 1;
            label2.Text = "Введите ФИО пользователя";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(140, 82);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(197, 23);
            nameTb.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Tai Le", 9F);
            label3.Location = new Point(140, 134);
            label3.Name = "label3";
            label3.Size = new Size(179, 16);
            label3.TabIndex = 3;
            label3.Text = "Введите логин пользователя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Tai Le", 9F);
            label4.Location = new Point(140, 200);
            label4.Name = "label4";
            label4.Size = new Size(188, 16);
            label4.TabIndex = 4;
            label4.Text = "Введите пароль пользователя";
            // 
            // loginTb
            // 
            loginTb.Location = new Point(140, 152);
            loginTb.Name = "loginTb";
            loginTb.Size = new Size(197, 23);
            loginTb.TabIndex = 5;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(140, 218);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(197, 23);
            passwordTb.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._22222;
            button1.Font = new Font("Microsoft Tai Le", 9F);
            button1.Location = new Point(158, 393);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 7;
            button1.Text = "Зарегистрировать";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // idTb
            // 
            idTb.Location = new Point(184, 280);
            idTb.Name = "idTb";
            idTb.Size = new Size(94, 23);
            idTb.TabIndex = 8;
            idTb.KeyPress += idTb_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Tai Le", 9F);
            label5.Location = new Point(163, 262);
            label5.Name = "label5";
            label5.Size = new Size(156, 16);
            label5.TabIndex = 9;
            label5.Text = "Введите id пользователя";
            // 
            // regForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.squareButtonsBG;
            ClientSize = new Size(451, 450);
            Controls.Add(label5);
            Controls.Add(idTb);
            Controls.Add(button1);
            Controls.Add(passwordTb);
            Controls.Add(loginTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "regForm";
            Text = "Регистрация нового пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTb;
        private Label label3;
        private Label label4;
        private TextBox loginTb;
        private TextBox passwordTb;
        private Button button1;
        private TextBox idTb;
        private Label label5;
    }
}