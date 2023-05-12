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
            label_name = new Label();
            comboBox_name = new ComboBox();
            panel_address.SuspendLayout();
            SuspendLayout();
            // 
            // panel_address
            // 
            panel_address.Controls.Add(comboBox_name);
            panel_address.Controls.Add(label_paymentType);
            panel_address.Controls.Add(domainUpDown_paymentType);
            panel_address.Controls.Add(dateTimePicker_date);
            panel_address.Controls.Add(checkBox_sent);
            panel_address.Controls.Add(checkBox_prepayment);
            panel_address.Controls.Add(label_address);
            panel_address.Controls.Add(button_cancel);
            panel_address.Controls.Add(button_action);
            panel_address.Controls.Add(label_name);
            panel_address.Location = new Point(10, 10);
            panel_address.Name = "panel_address";
            panel_address.Size = new Size(360, 237);
            panel_address.TabIndex = 4;
            // 
            // label_paymentType
            // 
            label_paymentType.AutoSize = true;
            label_paymentType.Location = new Point(176, 120);
            label_paymentType.Name = "label_paymentType";
            label_paymentType.Size = new Size(71, 15);
            label_paymentType.TabIndex = 8;
            label_paymentType.Text = "Тип оплаты";
            // 
            // domainUpDown_paymentType
            // 
            domainUpDown_paymentType.Items.Add("Наличные");
            domainUpDown_paymentType.Items.Add("Внесение в кассу");
            domainUpDown_paymentType.Location = new Point(176, 148);
            domainUpDown_paymentType.Margin = new Padding(3, 2, 3, 2);
            domainUpDown_paymentType.Name = "domainUpDown_paymentType";
            domainUpDown_paymentType.Size = new Size(131, 23);
            domainUpDown_paymentType.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            dateTimePicker_date.Location = new Point(109, 72);
            dateTimePicker_date.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker_date.Name = "dateTimePicker_date";
            dateTimePicker_date.Size = new Size(219, 23);
            dateTimePicker_date.TabIndex = 1;
            // 
            // checkBox_sent
            // 
            checkBox_sent.AutoSize = true;
            checkBox_sent.Location = new Point(38, 150);
            checkBox_sent.Margin = new Padding(3, 2, 3, 2);
            checkBox_sent.Name = "checkBox_sent";
            checkBox_sent.Size = new Size(98, 19);
            checkBox_sent.TabIndex = 3;
            checkBox_sent.Text = "отправленно";
            checkBox_sent.UseVisualStyleBackColor = true;
            // 
            // checkBox_prepayment
            // 
            checkBox_prepayment.AutoSize = true;
            checkBox_prepayment.Location = new Point(38, 119);
            checkBox_prepayment.Margin = new Padding(3, 2, 3, 2);
            checkBox_prepayment.Name = "checkBox_prepayment";
            checkBox_prepayment.Size = new Size(90, 19);
            checkBox_prepayment.TabIndex = 2;
            checkBox_prepayment.Text = "предоплата";
            checkBox_prepayment.UseVisualStyleBackColor = true;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(29, 72);
            label_address.Name = "label_address";
            label_address.Size = new Size(35, 15);
            label_address.TabIndex = 3;
            label_address.Text = "Дата:";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(228, 190);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 30);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_action
            // 
            button_action.Location = new Point(28, 190);
            button_action.Name = "button_action";
            button_action.Size = new Size(100, 30);
            button_action.TabIndex = 6;
            button_action.Text = "Добавить";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(28, 33);
            label_name.Name = "label_name";
            label_name.Size = new Size(64, 15);
            label_name.TabIndex = 0;
            label_name.Text = "Заказщик:";
            // 
            // comboBox_name
            // 
            comboBox_name.FormattingEnabled = true;
            comboBox_name.Location = new Point(109, 30);
            comboBox_name.Name = "comboBox_name";
            comboBox_name.Size = new Size(219, 23);
            comboBox_name.TabIndex = 0;
            // 
            // AEFuturaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(panel_address);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox comboBox_name;
    }
}