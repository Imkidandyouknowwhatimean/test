namespace Kursovaya
{
    partial class EditForm
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
            button1 = new Button();
            GroupCb = new ComboBox();
            TeacherCb = new ComboBox();
            GradeCb = new ComboBox();
            DateTb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            StatusCb = new ComboBox();
            ThemeCb = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            StudentCb = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(563, 6);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 33;
            button1.Text = "Очистить поля";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GroupCb
            // 
            GroupCb.FormattingEnabled = true;
            GroupCb.Location = new Point(385, 84);
            GroupCb.Name = "GroupCb";
            GroupCb.Size = new Size(114, 23);
            GroupCb.TabIndex = 32;
            // 
            // TeacherCb
            // 
            TeacherCb.FormattingEnabled = true;
            TeacherCb.Location = new Point(246, 193);
            TeacherCb.Name = "TeacherCb";
            TeacherCb.Size = new Size(253, 23);
            TeacherCb.TabIndex = 31;
            // 
            // GradeCb
            // 
            GradeCb.FormattingEnabled = true;
            GradeCb.Location = new Point(526, 83);
            GradeCb.Name = "GradeCb";
            GradeCb.Size = new Size(114, 23);
            GradeCb.TabIndex = 30;
            // 
            // DateTb
            // 
            DateTb.Location = new Point(246, 84);
            DateTb.Name = "DateTb";
            DateTb.Size = new Size(114, 23);
            DateTb.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 66);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 28;
            label8.Text = "Группа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 175);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 27;
            label7.Text = "Преподаватель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 66);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 26;
            label6.Text = "Оценка за проек";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 66);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 25;
            label5.Text = "Дата сдачи проекта";
            // 
            // StatusCb
            // 
            StatusCb.FormattingEnabled = true;
            StatusCb.Location = new Point(12, 193);
            StatusCb.Name = "StatusCb";
            StatusCb.Size = new Size(211, 23);
            StatusCb.TabIndex = 24;
            // 
            // ThemeCb
            // 
            ThemeCb.FormattingEnabled = true;
            ThemeCb.Location = new Point(12, 136);
            ThemeCb.Name = "ThemeCb";
            ThemeCb.Size = new Size(628, 23);
            ThemeCb.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 22;
            label4.Text = "Статус проекта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 21;
            label3.Text = "Тема проекта";
            // 
            // StudentCb
            // 
            StudentCb.FormattingEnabled = true;
            StudentCb.Location = new Point(12, 84);
            StudentCb.Name = "StudentCb";
            StudentCb.Size = new Size(211, 23);
            StudentCb.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 19;
            label2.Text = "Студент";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 18;
            label1.Text = "Редактировать запись - ";
            label1.Click += label1_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(505, 290);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(161, 49);
            AddButton.TabIndex = 17;
            AddButton.Text = "Отредактировать запись";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 349);
            Controls.Add(button1);
            Controls.Add(GroupCb);
            Controls.Add(TeacherCb);
            Controls.Add(GradeCb);
            Controls.Add(DateTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(StatusCb);
            Controls.Add(ThemeCb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StudentCb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отредактировать строку";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox GroupCb;
        private ComboBox TeacherCb;
        private ComboBox GradeCb;
        private TextBox DateTb;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox StatusCb;
        private ComboBox ThemeCb;
        private Label label4;
        private Label label3;
        private ComboBox StudentCb;
        private Label label2;
        private Label label1;
        private Button AddButton;
    }
}