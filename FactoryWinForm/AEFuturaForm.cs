using Npgsql;
using System.Data;

namespace FactoryWinForm
{
    public partial class AEFuturaForm : Form
    {
        private NpgsqlConnection _connection;
        private int _id;
        public AEFuturaForm(string con, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(con);
            InitializeComponent();
            if (id < 1)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
                domainUpDown_paymentType.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                textBox_name.Text = attributes[0];
                string[] dateSt = attributes[1].Split('.');
                dateSt[2] = dateSt[2].Split(' ')[0];
                dateTimePicker_date.Value = new
                    DateTime(Convert.ToInt32(dateSt[2]), Convert.ToInt32(dateSt[1]), Convert.ToInt32(dateSt[0]));
                if (attributes[2] == "Наличные")
                    domainUpDown_paymentType.SelectedIndex = 0;
                else
                    domainUpDown_paymentType.SelectedIndex = 1;
                checkBox_prepayment.Checked = Convert.ToBoolean(attributes[3]);
                checkBox_sent.Checked = Convert.ToBoolean(attributes[4]);
            }
            this.Show();
            _id = id;
        }
        private void addNote(string name, string date, string paymentType, string prepayment, string sent)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Заказшик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura (id_customer, date, payment_type, prepayment, sent)" +
                    $" VALUES ('{idCustomer}', '{date}', '{paymentType}', '{prepayment}', '{sent})", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void editNote(string name, string date, string paymentType, string prepayment, string sent)
        {
            _connection.Open();
            int idCustomer = searchCustomer(name);
            if (idCustomer == 0)
                MessageBox.Show("Заказщик не найден");
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura SET id_customer = '{idCustomer}', date = '{date}', payment_type = '{paymentType}', " +
                    $"prepayment = '{prepayment}', sent = '{sent}' WHERE id = {_id}", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            DateTime dateTime = dateTimePicker_date.Value;
            string date = $"{dateTime.Year}-{dateTime.Month}-{dateTime.Day}";
            string? paymentType = domainUpDown_paymentType.SelectedItem.ToString();
            string prepayment = checkBox_prepayment.Checked.ToString();
            string sent = checkBox_sent.Checked.ToString();
            if (name == "")
            {
                MessageBox.Show("Заполните поле заказщик");
                return;
            }
            if (paymentType == null)
            {
                MessageBox.Show("Выберите тип оплаты");
                return;
            }
            if (_id == 0)
            {
                addNote(name, date, paymentType, prepayment, sent);
            }
            else
            {
                editNote(name, date, paymentType, prepayment, sent);
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int searchCustomer(string name)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM customers WHERE name = '{name}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
    }
}
