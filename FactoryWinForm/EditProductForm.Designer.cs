﻿namespace FactoryWinForm
{
    partial class EditProductForm
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
            panel1 = new Panel();
            numericUpDown_nounce = new NumericUpDown();
            button_cancel = new Button();
            button_edit = new Button();
            label_nounce = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown_nounce);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_edit);
            panel1.Controls.Add(label_nounce);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(label_name);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 316);
            panel1.TabIndex = 2;
            // 
            // numericUpDown_nounce
            // 
            numericUpDown_nounce.Location = new Point(145, 120);
            numericUpDown_nounce.Margin = new Padding(3, 4, 3, 4);
            numericUpDown_nounce.Name = "numericUpDown_nounce";
            numericUpDown_nounce.Size = new Size(230, 27);
            numericUpDown_nounce.TabIndex = 3;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(261, 213);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(114, 40);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_edit
            // 
            button_edit.Location = new Point(35, 213);
            button_edit.Margin = new Padding(3, 4, 3, 4);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(114, 40);
            button_edit.TabIndex = 2;
            button_edit.Text = "Добавить";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // label_nounce
            // 
            label_nounce.AutoSize = true;
            label_nounce.Location = new Point(35, 120);
            label_nounce.Name = "label_nounce";
            label_nounce.Size = new Size(90, 20);
            label_nounce.TabIndex = 0;
            label_nounce.Text = "Количество";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(145, 40);
            textBox_name.Margin = new Padding(3, 4, 3, 4);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(229, 27);
            textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(32, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(119, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Наименование:";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "EditProductForm";
            Text = "EditFieldForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDown_nounce;
        private Button button_cancel;
        private Button button_edit;
        private Label label_nounce;
        private TextBox textBox_name;
        private Label label_name;
    }
}