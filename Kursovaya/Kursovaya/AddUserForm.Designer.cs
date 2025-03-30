namespace Kursovaya
{
    partial class AddUserForm
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
            UserNameTb = new TextBox();
            LoginTb = new TextBox();
            PasswordTb = new TextBox();
            RoleCb = new ComboBox();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UserNameTb
            // 
            UserNameTb.Location = new Point(71, 135);
            UserNameTb.Name = "UserNameTb";
            UserNameTb.Size = new Size(264, 23);
            UserNameTb.TabIndex = 0;
            // 
            // LoginTb
            // 
            LoginTb.Location = new Point(114, 190);
            LoginTb.Name = "LoginTb";
            LoginTb.Size = new Size(182, 23);
            LoginTb.TabIndex = 1;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(114, 249);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(182, 23);
            PasswordTb.TabIndex = 2;
            // 
            // RoleCb
            // 
            RoleCb.FormattingEnabled = true;
            RoleCb.Location = new Point(142, 299);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(121, 23);
            RoleCb.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(114, 328);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(182, 42);
            AddButton.TabIndex = 4;
            AddButton.Text = "Добавить пользователя";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(50, 21);
            label1.Name = "label1";
            label1.Size = new Size(316, 30);
            label1.TabIndex = 5;
            label1.Text = "Добавить нового пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 117);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 6;
            label2.Text = "Введите ФИО пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 172);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Введите логин";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 231);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 8;
            label4.Text = "Введите пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 281);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Должность";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(524, 349);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(RoleCb);
            Controls.Add(PasswordTb);
            Controls.Add(LoginTb);
            Controls.Add(UserNameTb);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить пользователя";
            Load += AddUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTb;
        private TextBox LoginTb;
        private TextBox PasswordTb;
        private ComboBox RoleCb;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}