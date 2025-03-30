namespace DiplomProject
{
    partial class DelProject
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
            numTb = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 0;
            label1.Text = "Введите номер проекта";
            // 
            // delButton
            // 
            delButton.BackgroundImage = Properties.Resources._22222;
            delButton.Location = new Point(90, 94);
            delButton.Name = "delButton";
            delButton.Size = new Size(180, 30);
            delButton.TabIndex = 1;
            delButton.Text = "Удалить проект";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // numTb
            // 
            numTb.Location = new Point(88, 33);
            numTb.Name = "numTb";
            numTb.Size = new Size(182, 23);
            numTb.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numTb);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 141);
            panel1.TabIndex = 3;
            // 
            // DelProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(357, 136);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DelProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Удалить проект";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button delButton;
        private TextBox numTb;
        private Panel panel1;
    }
}