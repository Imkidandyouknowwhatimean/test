namespace DiplomProject
{
    partial class Form2
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
            panel1 = new Panel();
            editTb = new TextBox();
            editButton = new Button();
            tableUpButton = new Button();
            delTableButton = new Button();
            newTableButton = new Button();
            refreshButton = new Button();
            delButton = new Button();
            addButton = new Button();
            regButton = new Button();
            tableLabel = new Label();
            clsButton = new Button();
            label2 = new Label();
            label1 = new Label();
            searchTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(806, 421);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = Properties.Resources._1575313322;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(searchTb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(editTb);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(tableUpButton);
            panel1.Controls.Add(delTableButton);
            panel1.Controls.Add(newTableButton);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(addButton);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(835, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 581);
            panel1.TabIndex = 1;
            // 
            // editTb
            // 
            editTb.Location = new Point(139, 152);
            editTb.Name = "editTb";
            editTb.Size = new Size(36, 23);
            editTb.TabIndex = 7;
            editTb.KeyPress += editTb_KeyPress;
            // 
            // editButton
            // 
            editButton.BackgroundImage = Properties.Resources._22222;
            editButton.ForeColor = SystemColors.ActiveCaptionText;
            editButton.Location = new Point(14, 138);
            editButton.Name = "editButton";
            editButton.Size = new Size(119, 49);
            editButton.TabIndex = 6;
            editButton.Text = "Редактировать. . .";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // tableUpButton
            // 
            tableUpButton.BackColor = SystemColors.Control;
            tableUpButton.BackgroundImage = Properties.Resources._22222;
            tableUpButton.BackgroundImageLayout = ImageLayout.None;
            tableUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableUpButton.ForeColor = SystemColors.ActiveCaptionText;
            tableUpButton.Location = new Point(29, 508);
            tableUpButton.Name = "tableUpButton";
            tableUpButton.Size = new Size(125, 50);
            tableUpButton.TabIndex = 5;
            tableUpButton.Text = "Перейти к таблице";
            tableUpButton.UseVisualStyleBackColor = false;
            tableUpButton.Click += tableUpButton_Click;
            // 
            // delTableButton
            // 
            delTableButton.BackColor = SystemColors.Control;
            delTableButton.BackgroundImage = Properties.Resources.squareButtonsBG;
            delTableButton.BackgroundImageLayout = ImageLayout.Stretch;
            delTableButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            delTableButton.ForeColor = SystemColors.ActiveCaptionText;
            delTableButton.Location = new Point(14, 248);
            delTableButton.Name = "delTableButton";
            delTableButton.Size = new Size(50, 50);
            delTableButton.TabIndex = 4;
            delTableButton.Text = "-";
            delTableButton.UseVisualStyleBackColor = false;
            delTableButton.Click += delTableButton_Click;
            // 
            // newTableButton
            // 
            newTableButton.BackColor = SystemColors.Control;
            newTableButton.BackgroundImage = Properties.Resources.squareButtonsBG;
            newTableButton.BackgroundImageLayout = ImageLayout.Stretch;
            newTableButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newTableButton.ForeColor = SystemColors.ActiveCaptionText;
            newTableButton.Location = new Point(124, 248);
            newTableButton.Name = "newTableButton";
            newTableButton.Size = new Size(50, 50);
            newTableButton.TabIndex = 3;
            newTableButton.Text = "+";
            newTableButton.UseVisualStyleBackColor = false;
            newTableButton.Click += newTableButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackgroundImage = Properties.Resources._22222;
            refreshButton.ForeColor = SystemColors.ActiveCaptionText;
            refreshButton.Location = new Point(14, 193);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(161, 49);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // delButton
            // 
            delButton.BackgroundImage = Properties.Resources._22222;
            delButton.ForeColor = SystemColors.ActiveCaptionText;
            delButton.Location = new Point(14, 83);
            delButton.Name = "delButton";
            delButton.Size = new Size(161, 49);
            delButton.TabIndex = 1;
            delButton.Text = "Удалить. . .";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.Control;
            addButton.BackgroundImage = Properties.Resources._22222;
            addButton.BackgroundImageLayout = ImageLayout.None;
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(14, 28);
            addButton.Name = "addButton";
            addButton.Size = new Size(161, 49);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить. . .";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // regButton
            // 
            regButton.BackgroundImage = Properties.Resources._22222;
            regButton.ForeColor = SystemColors.ActiveCaptionText;
            regButton.Location = new Point(668, 439);
            regButton.Name = "regButton";
            regButton.Size = new Size(161, 49);
            regButton.TabIndex = 3;
            regButton.Text = "Регистрация нового пользователя";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.BackColor = Color.Transparent;
            tableLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLabel.Location = new Point(12, 451);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(121, 21);
            tableLabel.TabIndex = 5;
            tableLabel.Text = "Имя таблицы - ";
            // 
            // clsButton
            // 
            clsButton.BackgroundImage = Properties.Resources.squareButtonsBG;
            clsButton.BackgroundImageLayout = ImageLayout.Stretch;
            clsButton.Location = new Point(768, 509);
            clsButton.Name = "clsButton";
            clsButton.Size = new Size(50, 50);
            clsButton.TabIndex = 6;
            clsButton.Text = "X";
            clsButton.UseVisualStyleBackColor = true;
            clsButton.Click += clsButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(755, 491);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "Закрыть все";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 360);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 8;
            label1.Text = "поиск по таблице";
            // 
            // searchTb
            // 
            searchTb.Location = new Point(14, 378);
            searchTb.Name = "searchTb";
            searchTb.Size = new Size(161, 23);
            searchTb.TabIndex = 9;
            searchTb.TextChanged += searchTb_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1575313322;
            ClientSize = new Size(1022, 568);
            Controls.Add(label2);
            Controls.Add(clsButton);
            Controls.Add(tableLabel);
            Controls.Add(regButton);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Проекты";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button delButton;
        private Button addButton;
        private Button refreshButton;
        private Button regButton;
        private Button newTableButton;
        private Button tableUpButton;
        private Button delTableButton;
        private Label tableLabel;
        private Button clsButton;
        private Label label2;
        private Button editButton;
        private TextBox editTb;
        private TextBox searchTb;
        private Label label1;
    }
}