namespace FactoryWinForm
{
    partial class AddFieldForm
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
            button_confirm = new Button();
            textBox2 = new TextBox();
            label_count = new Label();
            textBox1 = new TextBox();
            label_name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_cancel);
            panel1.Controls.Add(button_confirm);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label_count);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label_name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 237);
            panel1.TabIndex = 1;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(205, 168);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 2;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            button_confirm.Location = new Point(53, 168);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(100, 30);
            button_confirm.TabIndex = 2;
            button_confirm.Text = "Подтвердить";
            button_confirm.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 1;
            // 
            // label_count
            // 
            label_count.AutoSize = true;
            label_count.Location = new Point(31, 90);
            label_count.Name = "label_count";
            label_count.Size = new Size(91, 15);
            label_count.TabIndex = 0;
            label_count.Text = "Ед.  измерения:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 1;
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
            // AddFieldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(panel1);
            Name = "AddFieldForm";
            Text = "AddFieldForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_cancel;
        private Button button_confirm;
        private TextBox textBox2;
        private Label label_count;
        private TextBox textBox1;
        private Label label_name;
    }
}