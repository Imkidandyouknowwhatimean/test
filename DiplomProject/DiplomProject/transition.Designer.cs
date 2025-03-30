namespace DiplomProject
{
    partial class transition
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
            tableTb = new TextBox();
            transitButton = new Button();
            label2 = new Label();
            tablesLb = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите название таблицы";
            // 
            // tableTb
            // 
            tableTb.Location = new Point(62, 44);
            tableTb.Name = "tableTb";
            tableTb.Size = new Size(204, 23);
            tableTb.TabIndex = 1;
            // 
            // transitButton
            // 
            transitButton.BackgroundImage = Properties.Resources._22222;
            transitButton.Location = new Point(112, 122);
            transitButton.Name = "transitButton";
            transitButton.Size = new Size(95, 35);
            transitButton.TabIndex = 2;
            transitButton.Text = "Перейти";
            transitButton.UseVisualStyleBackColor = true;
            transitButton.Click += transitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(310, 9);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 3;
            label2.Text = "Список доступных таблиц";
            // 
            // tablesLb
            // 
            tablesLb.FormattingEnabled = true;
            tablesLb.ItemHeight = 15;
            tablesLb.Location = new Point(310, 33);
            tablesLb.Name = "tablesLb";
            tablesLb.Size = new Size(200, 124);
            tablesLb.TabIndex = 4;
            // 
            // transition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.i;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(554, 181);
            Controls.Add(tablesLb);
            Controls.Add(label2);
            Controls.Add(transitButton);
            Controls.Add(tableTb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "transition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Перейти к таблице";
            Load += transition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tableTb;
        private Button transitButton;
        private Label label2;
        private ListBox tablesLb;
    }
}