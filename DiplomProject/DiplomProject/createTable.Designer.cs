namespace DiplomProject
{
    partial class createTable
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
            createButton = new Button();
            tableTb = new TextBox();
            tablesLb = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите название таблицы";
            label1.Click += label1_Click;
            // 
            // createButton
            // 
            createButton.BackgroundImage = Properties.Resources._22222;
            createButton.Location = new Point(109, 132);
            createButton.Name = "createButton";
            createButton.Size = new Size(130, 40);
            createButton.TabIndex = 1;
            createButton.Text = "Создать таблицу";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // tableTb
            // 
            tableTb.Location = new Point(75, 76);
            tableTb.Name = "tableTb";
            tableTb.Size = new Size(204, 23);
            tableTb.TabIndex = 2;
            tableTb.TextChanged += tableTb_TextChanged;
            // 
            // tablesLb
            // 
            tablesLb.FormattingEnabled = true;
            tablesLb.ItemHeight = 15;
            tablesLb.Location = new Point(323, 30);
            tablesLb.Name = "tablesLb";
            tablesLb.Size = new Size(197, 139);
            tablesLb.TabIndex = 6;
            tablesLb.SelectedIndexChanged += tablesLb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(323, 6);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 5;
            label2.Text = "Список доступных таблиц";
            // 
            // createTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 181);
            Controls.Add(tablesLb);
            Controls.Add(label2);
            Controls.Add(tableTb);
            Controls.Add(createButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "createTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создать таблицу";
            Load += createTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button createButton;
        private TextBox tableTb;
        private ListBox tablesLb;
        private Label label2;
    }
}