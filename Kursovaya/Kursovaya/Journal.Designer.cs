namespace Kursovaya
{
    partial class Journal
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            AddButton = new Button();
            RefreshButton = new Button();
            DeleteButton = new Button();
            DeleteRowTb = new TextBox();
            EditButton = new Button();
            EditTb = new TextBox();
            FindButton = new Button();
            FindTb = new TextBox();
            AddUserButton = new Button();
            NewStudentTb = new TextBox();
            panel1 = new Panel();
            AddThemeButton = new Button();
            AddGroupButton = new Button();
            AddStudentButton = new Button();
            NewThemeTb = new TextBox();
            NewGroupTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SortButton = new Button();
            SortCb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(858, 469);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 1;
            label1.Text = "Проекты группы - ";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(876, 38);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(151, 43);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить запись";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(876, 464);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(151, 43);
            RefreshButton.TabIndex = 3;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(876, 87);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(111, 43);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить запись";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DeleteRowTb
            // 
            DeleteRowTb.Location = new Point(993, 98);
            DeleteRowTb.Name = "DeleteRowTb";
            DeleteRowTb.Size = new Size(34, 23);
            DeleteRowTb.TabIndex = 5;
            DeleteRowTb.KeyPress += DeleteRowTb_KeyPress;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(876, 136);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(111, 43);
            EditButton.TabIndex = 6;
            EditButton.Text = "Редактировать запись";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // EditTb
            // 
            EditTb.Location = new Point(993, 147);
            EditTb.Name = "EditTb";
            EditTb.Size = new Size(34, 23);
            EditTb.TabIndex = 7;
            EditTb.TextChanged += EditTb_TextChanged;
            EditTb.KeyPress += editTb_KeyPress;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(876, 230);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(151, 43);
            FindButton.TabIndex = 8;
            FindButton.Text = "Найти по . . .";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // FindTb
            // 
            FindTb.Location = new Point(876, 279);
            FindTb.Name = "FindTb";
            FindTb.Size = new Size(151, 23);
            FindTb.TabIndex = 9;
            FindTb.TextChanged += FindTb_TextChanged;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(12, 513);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(151, 43);
            AddUserButton.TabIndex = 10;
            AddUserButton.Text = "Создать нового пользователя";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // NewStudentTb
            // 
            NewStudentTb.Location = new Point(147, 11);
            NewStudentTb.Name = "NewStudentTb";
            NewStudentTb.Size = new Size(373, 23);
            NewStudentTb.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(AddThemeButton);
            panel1.Controls.Add(AddGroupButton);
            panel1.Controls.Add(AddStudentButton);
            panel1.Controls.Add(NewThemeTb);
            panel1.Controls.Add(NewGroupTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NewStudentTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(169, 535);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 98);
            panel1.TabIndex = 12;
            // 
            // AddThemeButton
            // 
            AddThemeButton.Location = new Point(526, 69);
            AddThemeButton.Name = "AddThemeButton";
            AddThemeButton.Size = new Size(127, 23);
            AddThemeButton.TabIndex = 15;
            AddThemeButton.Text = "Добавить";
            AddThemeButton.UseVisualStyleBackColor = true;
            AddThemeButton.Click += AddThemeButton_Click;
            // 
            // AddGroupButton
            // 
            AddGroupButton.Location = new Point(526, 40);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(127, 23);
            AddGroupButton.TabIndex = 14;
            AddGroupButton.Text = "Добавить";
            AddGroupButton.UseVisualStyleBackColor = true;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(526, 11);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(127, 23);
            AddStudentButton.TabIndex = 13;
            AddStudentButton.Text = "Добавить";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // NewThemeTb
            // 
            NewThemeTb.Location = new Point(147, 69);
            NewThemeTb.Name = "NewThemeTb";
            NewThemeTb.Size = new Size(373, 23);
            NewThemeTb.TabIndex = 13;
            // 
            // NewGroupTb
            // 
            NewGroupTb.Location = new Point(147, 40);
            NewGroupTb.Name = "NewGroupTb";
            NewGroupTb.Size = new Size(71, 23);
            NewGroupTb.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(3, 69);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 2;
            label4.Text = "Новая тема проекта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 43);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 1;
            label3.Text = "Новая группа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 14);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 0;
            label2.Text = "Добавить Студента";
            // 
            // SortButton
            // 
            SortButton.Location = new Point(903, 308);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(98, 43);
            SortButton.TabIndex = 13;
            SortButton.Text = "Отсортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // SortCb
            // 
            SortCb.FormattingEnabled = true;
            SortCb.Location = new Point(903, 357);
            SortCb.Name = "SortCb";
            SortCb.Size = new Size(98, 23);
            SortCb.TabIndex = 14;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 672);
            Controls.Add(SortCb);
            Controls.Add(SortButton);
            Controls.Add(panel1);
            Controls.Add(AddUserButton);
            Controls.Add(FindTb);
            Controls.Add(FindButton);
            Controls.Add(EditTb);
            Controls.Add(EditButton);
            Controls.Add(DeleteRowTb);
            Controls.Add(DeleteButton);
            Controls.Add(RefreshButton);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Journal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Журнал";
            Load += Journal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button AddButton;
        private Button RefreshButton;
        private Button DeleteButton;
        private TextBox DeleteRowTb;
        private Button EditButton;
        private TextBox EditTb;
        private Button FindButton;
        private TextBox FindTb;
        private Button AddUserButton;
        private TextBox NewStudentTb;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button AddGroupButton;
        private Button AddStudentButton;
        private TextBox NewThemeTb;
        private TextBox NewGroupTb;
        private Button AddThemeButton;
        private Button SortButton;
        private ComboBox SortCb;
    }
}