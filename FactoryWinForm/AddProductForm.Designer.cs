namespace FactoryWinForm
{
    partial class AddProductForm
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
            button_cancel = new Button();
            button_add = new Button();
            label_nounce = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            numericUpDown_nounce = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown_nounce);
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(label_nounce);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(label_name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(228, 160);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(31, 160);
            button_add.Name = "button_add";
            button_add.Size = new Size(100, 30);
            button_add.TabIndex = 2;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label_nounce
            // 
            label_nounce.AutoSize = true;
            label_nounce.Location = new Point(31, 90);
            label_nounce.Name = "label_nounce";
            label_nounce.Size = new Size(72, 15);
            label_nounce.TabIndex = 0;
            label_nounce.Text = "Количество";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(127, 30);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(201, 23);
            textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(28, 33);
            label_name.Name = "label_name";
            label_name.Size = new Size(93, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Наименование:";
            // 
            // numericUpDown_nounce
            // 
            numericUpDown_nounce.Location = new Point(127, 90);
            numericUpDown_nounce.Name = "numericUpDown_nounce";
            numericUpDown_nounce.Size = new Size(201, 23);
            numericUpDown_nounce.TabIndex = 3;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            Name = "AddProductForm";
            Text = "AddFieldForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nounce).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_cancel;
        private Button button_add;
        private Label label_nounce;
        private TextBox textBox_name;
        private Label label_name;
        private NumericUpDown numericUpDown_nounce;
    }
}