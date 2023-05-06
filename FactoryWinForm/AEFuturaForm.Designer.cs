namespace FactoryWinForm
{
    partial class AEFuturaForm
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
            panel_address = new Panel();
            label_paymentType = new Label();
            domainUpDown_paymentType = new DomainUpDown();
            dateTimePicker_date = new DateTimePicker();
            checkBox_sent = new CheckBox();
            checkBox_prepayment = new CheckBox();
            label_address = new Label();
            button_cancel = new Button();
            button_action = new Button();
            textBox_name = new TextBox();
            label_name = new Label();
            panel_address.SuspendLayout();
            SuspendLayout();
            // 
            // panel_address
            // 
            panel_address.Controls.Add(label_paymentType);
            panel_address.Controls.Add(domainUpDown_paymentType);
            panel_address.Controls.Add(dateTimePicker_date);
            panel_address.Controls.Add(checkBox_sent);
            panel_address.Controls.Add(checkBox_prepayment);
            panel_address.Controls.Add(label_address);
            panel_address.Controls.Add(button_cancel);
            panel_address.Controls.Add(button_action);
            panel_address.Controls.Add(textBox_name);
            panel_address.Controls.Add(label_name);
            panel_address.Location = new Point(12, 13);
            panel_address.Margin = new Padding(3, 4, 3, 4);
            panel_address.Name = "panel_address";
            panel_address.Size = new Size(411, 316);
            panel_address.TabIndex = 4;
            // 
            // label_paymentType
            // 
            label_paymentType.AutoSize = true;
            label_paymentType.Location = new Point(201, 160);
            label_paymentType.Name = "label_paymentType";
            label_paymentType.Size = new Size(90, 20);
            label_paymentType.TabIndex = 8;
            label_paymentType.Text = "Тип оплаты";
            // 
            // domainUpDown_paymentType
            // 
            domainUpDown_paymentType.Items.Add("Наличные");
            domainUpDown_paymentType.Items.Add("Внесение в кассу");
            domainUpDown_paymentType.Location = new Point(201, 197);
            domainUpDown_paymentType.Name = "domainUpDown_paymentType";
            domainUpDown_paymentType.Size = new Size(150, 27);
            domainUpDown_paymentType.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            dateTimePicker_date.Location = new Point(125, 96);
            dateTimePicker_date.Name = "dateTimePicker_date";
            dateTimePicker_date.Size = new Size(250, 27);
            dateTimePicker_date.TabIndex = 1;
            // 
            // checkBox_sent
            // 
            checkBox_sent.AutoSize = true;
            checkBox_sent.Location = new Point(44, 200);
            checkBox_sent.Name = "checkBox_sent";
            checkBox_sent.Size = new Size(123, 24);
            checkBox_sent.TabIndex = 3;
            checkBox_sent.Text = "отправленно";
            checkBox_sent.UseVisualStyleBackColor = true;
            // 
            // checkBox_prepayment
            // 
            checkBox_prepayment.AutoSize = true;
            checkBox_prepayment.Location = new Point(44, 159);
            checkBox_prepayment.Name = "checkBox_prepayment";
            checkBox_prepayment.Size = new Size(113, 24);
            checkBox_prepayment.TabIndex = 2;
            checkBox_prepayment.Text = "предоплата";
            checkBox_prepayment.UseVisualStyleBackColor = true;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(33, 96);
            label_address.Name = "label_address";
            label_address.Size = new Size(44, 20);
            label_address.TabIndex = 3;
            label_address.Text = "Дата:";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(260, 253);
            button_cancel.Margin = new Padding(3, 4, 3, 4);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(114, 40);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_action
            // 
            button_action.Location = new Point(32, 253);
            button_action.Margin = new Padding(3, 4, 3, 4);
            button_action.Name = "button_action";
            button_action.Size = new Size(114, 40);
            button_action.TabIndex = 6;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(145, 40);
            textBox_name.Margin = new Padding(3, 4, 3, 4);
            textBox_name.MaxLength = 200;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(229, 27);
            textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(32, 44);
            label_name.Name = "label_name";
            label_name.Size = new Size(78, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Заказщик:";
            // 
            // AEFuturaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(panel_address);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AEFuturaForm";
            Text = "AEFuturaForm";
            panel_address.ResumeLayout(false);
            panel_address.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_address;
        private Label label_address;
        private Button button_cancel;
        private Button button_action;
        private TextBox textBox_name;
        private Label label_name;
        private Label label_paymentType;
        private DomainUpDown domainUpDown_paymentType;
        private DateTimePicker dateTimePicker_date;
        private CheckBox checkBox_sent;
        private CheckBox checkBox_prepayment;
    }
}