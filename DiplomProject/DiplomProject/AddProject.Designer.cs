namespace DiplomProject
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            statusCb = new ComboBox();
            gradeCb = new ComboBox();
            studentTb = new TextBox();
            groupTb = new TextBox();
            themeTb = new TextBox();
            dateTb = new TextBox();
            addButton = new Button();
            clrButton = new Button();
            label8 = new Label();
            numberTb = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 0;
            label1.Text = "Добавить проект";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tempus Sans ITC", 9F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(36, 79);
            label2.Name = "label2";
            label2.Size = new Size(94, 16);
            label2.TabIndex = 1;
            label2.Text = "ФИО Студента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tempus Sans ITC", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(36, 141);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 2;
            label3.Text = "Группа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tempus Sans ITC", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(36, 206);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 3;
            label4.Text = "Тема проекта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tempus Sans ITC", 9F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(339, 79);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 4;
            label5.Text = "Статус приемки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tempus Sans ITC", 9F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(339, 141);
            label6.Name = "label6";
            label6.Size = new Size(124, 16);
            label6.TabIndex = 5;
            label6.Text = "Дата сдачи проекта";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tempus Sans ITC", 9F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(339, 206);
            label7.Name = "label7";
            label7.Size = new Size(110, 16);
            label7.TabIndex = 6;
            label7.Text = "Оценка за проект";
            // 
            // statusCb
            // 
            statusCb.FormattingEnabled = true;
            statusCb.Location = new Point(339, 97);
            statusCb.Name = "statusCb";
            statusCb.Size = new Size(121, 23);
            statusCb.TabIndex = 7;
            // 
            // gradeCb
            // 
            gradeCb.FormattingEnabled = true;
            gradeCb.Location = new Point(339, 224);
            gradeCb.Name = "gradeCb";
            gradeCb.Size = new Size(121, 23);
            gradeCb.TabIndex = 8;
            gradeCb.SelectedIndexChanged += gradeCb_SelectedIndexChanged;
            // 
            // studentTb
            // 
            studentTb.Location = new Point(36, 97);
            studentTb.Name = "studentTb";
            studentTb.Size = new Size(286, 23);
            studentTb.TabIndex = 9;
            // 
            // groupTb
            // 
            groupTb.Location = new Point(36, 159);
            groupTb.Name = "groupTb";
            groupTb.Size = new Size(86, 23);
            groupTb.TabIndex = 10;
            // 
            // themeTb
            // 
            themeTb.Location = new Point(36, 224);
            themeTb.Name = "themeTb";
            themeTb.Size = new Size(286, 23);
            themeTb.TabIndex = 11;
            // 
            // dateTb
            // 
            dateTb.Location = new Point(339, 159);
            dateTb.Name = "dateTb";
            dateTb.Size = new Size(121, 23);
            dateTb.TabIndex = 12;
            // 
            // addButton
            // 
            addButton.BackgroundImage = Properties.Resources._22222;
            addButton.Font = new Font("Viner Hand ITC", 12F);
            addButton.Location = new Point(621, 385);
            addButton.Name = "addButton";
            addButton.Size = new Size(167, 53);
            addButton.TabIndex = 13;
            addButton.Text = "Добавить поле";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clrButton
            // 
            clrButton.BackgroundImage = Properties.Resources._22222;
            clrButton.Font = new Font("Viner Hand ITC", 12F);
            clrButton.Location = new Point(621, 12);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(167, 39);
            clrButton.TabIndex = 14;
            clrButton.Text = "Очистить поля";
            clrButton.UseVisualStyleBackColor = true;
            clrButton.Click += clrButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tempus Sans ITC", 9F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(490, 78);
            label8.Name = "label8";
            label8.Size = new Size(148, 16);
            label8.TabIndex = 15;
            label8.Text = "Введите номер проекта";
            // 
            // numberTb
            // 
            numberTb.Location = new Point(490, 97);
            numberTb.Name = "numberTb";
            numberTb.Size = new Size(148, 23);
            numberTb.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tempus Sans ITC", 9F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(508, 123);
            label9.Name = "label9";
            label9.Size = new Size(97, 16);
            label9.TabIndex = 17;
            label9.Text = "Введите число!";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(numberTb);
            Controls.Add(label8);
            Controls.Add(clrButton);
            Controls.Add(addButton);
            Controls.Add(dateTb);
            Controls.Add(themeTb);
            Controls.Add(groupTb);
            Controls.Add(studentTb);
            Controls.Add(gradeCb);
            Controls.Add(statusCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить проект";
            Load += AddProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox statusCb;
        private ComboBox gradeCb;
        private TextBox studentTb;
        private TextBox groupTb;
        private TextBox themeTb;
        private TextBox dateTb;
        private Button addButton;
        private Button clrButton;
        private Label label8;
        private TextBox numberTb;
        private Label label9;
    }
}