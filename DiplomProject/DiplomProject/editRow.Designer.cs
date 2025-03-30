namespace DiplomProject
{
    partial class editRow
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
            rowTable = new Label();
            labelTable = new Label();
            saveButton = new Button();
            nameTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupTb = new TextBox();
            label3 = new Label();
            themeTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTb = new TextBox();
            label6 = new Label();
            statusCb = new ComboBox();
            gradeCb = new ComboBox();
            clrButton = new Button();
            SuspendLayout();
            // 
            // rowTable
            // 
            rowTable.AutoSize = true;
            rowTable.BackColor = Color.Transparent;
            rowTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rowTable.Location = new Point(12, 9);
            rowTable.Name = "rowTable";
            rowTable.Size = new Size(190, 21);
            rowTable.TabIndex = 0;
            rowTable.Text = "Редактируемая строка  - ";
            rowTable.Click += rowTable_Click;
            // 
            // labelTable
            // 
            labelTable.AutoSize = true;
            labelTable.BackColor = Color.Transparent;
            labelTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTable.Location = new Point(12, 44);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(88, 21);
            labelTable.TabIndex = 1;
            labelTable.Text = "Таблица  - ";
            // 
            // saveButton
            // 
            saveButton.BackgroundImage = Properties.Resources._22222;
            saveButton.Location = new Point(630, 392);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(158, 46);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить изменения";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(24, 120);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(260, 23);
            nameTb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 102);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО Студента ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 146);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Группа";
            // 
            // groupTb
            // 
            groupTb.Location = new Point(24, 164);
            groupTb.Name = "groupTb";
            groupTb.Size = new Size(100, 23);
            groupTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(24, 190);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Тема проекта";
            // 
            // themeTb
            // 
            themeTb.Location = new Point(24, 208);
            themeTb.Name = "themeTb";
            themeTb.Size = new Size(260, 23);
            themeTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(347, 102);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 10;
            label4.Text = "Статус приемки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(347, 146);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата сдачи проекта";
            // 
            // dateTb
            // 
            dateTb.Location = new Point(347, 164);
            dateTb.Name = "dateTb";
            dateTb.Size = new Size(178, 23);
            dateTb.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(347, 190);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 14;
            label6.Text = "Оценка за проект";
            // 
            // statusCb
            // 
            statusCb.FormattingEnabled = true;
            statusCb.Location = new Point(347, 120);
            statusCb.Name = "statusCb";
            statusCb.Size = new Size(121, 23);
            statusCb.TabIndex = 15;
            // 
            // gradeCb
            // 
            gradeCb.FormattingEnabled = true;
            gradeCb.Location = new Point(347, 208);
            gradeCb.Name = "gradeCb";
            gradeCb.Size = new Size(121, 23);
            gradeCb.TabIndex = 16;
            // 
            // clrButton
            // 
            clrButton.BackgroundImage = Properties.Resources._22222;
            clrButton.Font = new Font("Tempus Sans ITC", 12F);
            clrButton.Location = new Point(655, 12);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(142, 35);
            clrButton.TabIndex = 17;
            clrButton.Text = "Очистить поля";
            clrButton.UseVisualStyleBackColor = true;
            clrButton.Click += clrButton_Click;
            // 
            // editRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            ClientSize = new Size(800, 450);
            Controls.Add(clrButton);
            Controls.Add(gradeCb);
            Controls.Add(statusCb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(themeTb);
            Controls.Add(label2);
            Controls.Add(groupTb);
            Controls.Add(label1);
            Controls.Add(nameTb);
            Controls.Add(saveButton);
            Controls.Add(labelTable);
            Controls.Add(rowTable);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "editRow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать строку";
            Load += editRow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rowTable;
        private Label labelTable;
        private Button saveButton;
        private TextBox nameTb;
        private Label label1;
        private Label label2;
        private TextBox groupTb;
        private Label label3;
        private TextBox themeTb;
        private Label label4;
        private Label label5;
        private TextBox dateTb;
        private Label label6;
        private ComboBox statusCb;
        private ComboBox gradeCb;
        private Button clrButton;
    }
}