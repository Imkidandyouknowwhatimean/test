namespace DiplomProject
{
    partial class deleteTable
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
            delButton = new Button();
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
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите название таблицы";
            // 
            // delButton
            // 
            delButton.BackgroundImage = Properties.Resources._22222;
            delButton.Location = new Point(130, 132);
            delButton.Name = "delButton";
            delButton.Size = new Size(108, 37);
            delButton.TabIndex = 1;
            delButton.Text = "Удалить таблицу";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // tableTb
            // 
            tableTb.Location = new Point(88, 60);
            tableTb.Name = "tableTb";
            tableTb.Size = new Size(204, 23);
            tableTb.TabIndex = 2;
            // 
            // tablesLb
            // 
            tablesLb.FormattingEnabled = true;
            tablesLb.ItemHeight = 15;
            tablesLb.Location = new Point(323, 33);
            tablesLb.Name = "tablesLb";
            tablesLb.Size = new Size(197, 124);
            tablesLb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(323, 9);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 5;
            label2.Text = "Список доступных таблиц";
            // 
            // deleteTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 181);
            Controls.Add(tablesLb);
            Controls.Add(label2);
            Controls.Add(tableTb);
            Controls.Add(delButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "deleteTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Удалить таблицу";
            Load += deleteTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button delButton;
        private TextBox tableTb;
        private ListBox tablesLb;
        private Label label2;
    }
}