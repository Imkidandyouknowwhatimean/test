namespace Kursovaya
{
    partial class AddForm
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
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            StudentCb = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ThemeCb = new ComboBox();
            StatusCb = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DateTb = new TextBox();
            GradeCb = new ComboBox();
            TeacherCb = new ComboBox();
            GroupCb = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(505, 290);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(161, 49);
            AddButton.TabIndex = 0;
            AddButton.Text = "Создать запись";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 1;
            label1.Text = "Добавить запись";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Студент";
            // 
            // StudentCb
            // 
            StudentCb.FormattingEnabled = true;
            StudentCb.Location = new Point(12, 84);
            StudentCb.Name = "StudentCb";
            StudentCb.Size = new Size(211, 23);
            StudentCb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Тема проекта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Статус проекта";
            label4.Click += label4_Click;
            // 
            // ThemeCb
            // 
            ThemeCb.FormattingEnabled = true;
            ThemeCb.Location = new Point(12, 136);
            ThemeCb.Name = "ThemeCb";
            ThemeCb.Size = new Size(628, 23);
            ThemeCb.TabIndex = 6;
            // 
            // StatusCb
            // 
            StatusCb.FormattingEnabled = true;
            StatusCb.Location = new Point(12, 193);
            StatusCb.Name = "StatusCb";
            StatusCb.Size = new Size(211, 23);
            StatusCb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 66);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 8;
            label5.Text = "Дата сдачи проекта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 66);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 9;
            label6.Text = "Оценка за проек";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 175);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 10;
            label7.Text = "Преподаватель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 66);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 11;
            label8.Text = "Группа";
            // 
            // DateTb
            // 
            DateTb.Location = new Point(246, 84);
            DateTb.Name = "DateTb";
            DateTb.Size = new Size(114, 23);
            DateTb.TabIndex = 12;
            // 
            // GradeCb
            // 
            GradeCb.FormattingEnabled = true;
            GradeCb.Location = new Point(526, 83);
            GradeCb.Name = "GradeCb";
            GradeCb.Size = new Size(114, 23);
            GradeCb.TabIndex = 13;
            // 
            // TeacherCb
            // 
            TeacherCb.FormattingEnabled = true;
            TeacherCb.Location = new Point(246, 193);
            TeacherCb.Name = "TeacherCb";
            TeacherCb.Size = new Size(253, 23);
            TeacherCb.TabIndex = 14;
            // 
            // GroupCb
            // 
            GroupCb.FormattingEnabled = true;
            GroupCb.Location = new Point(385, 84);
            GroupCb.Name = "GroupCb";
            GroupCb.Size = new Size(114, 23);
            GroupCb.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(563, 6);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 16;
            button1.Text = "Очистить поля";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 351);
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
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private Label label2;
        private ComboBox StudentCb;
        private Label label3;
        private Label label4;
        private ComboBox ThemeCb;
        private ComboBox StatusCb;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox DateTb;
        private ComboBox GradeCb;
        private ComboBox TeacherCb;
        private ComboBox GroupCb;
        private Button button1;
    }
}