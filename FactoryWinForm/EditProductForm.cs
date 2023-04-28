using Npgsql;

namespace FactoryWinForm
{
    public partial class EditProductForm : Form
    {
        private NpgsqlConnection _connection;
        private string _table;
        private int _id;
        public EditProductForm(NpgsqlConnection connection, string table, int id, string name, int nounce)
        {
            _connection = connection;
            _table = table;
            _id = id;
            InitializeComponent();
            textBox_name.Text = name;
            numericUpDown_nounce.Value = nounce;
        }
        private void editNote(string name, int nounce)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"UPDATE products SET name = '{name}', nounce = '{nounce}' WHERE id = '{_id}'"))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && Convert.ToInt32(numericUpDown_nounce.Value) > 0)
            {
                editNote(textBox_name.Text, Convert.ToInt32(numericUpDown_nounce.Text));
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
