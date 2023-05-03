using Microsoft.VisualBasic;
using Npgsql;
using System.Data;
using System.Security.Cryptography;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FactoryWinForm
{
    public partial class DataForm : Form
    {
        private string _table;
        private string[] _namesTables;
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        private NpgsqlConnection _connection = new NpgsqlConnection();

        public DataForm(string table, string[] namesTables)
        {
            _table = table;
            _namesTables = namesTables;
            InitializeComponent();
            initConnection();
            this.Show();
            timer_update.Enabled = true;
        }

        private void initConnection()
        {
            _connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=sitnikov342");
            npgsqlAnswer();
        }

        private void updateDateGridView()
        {
            npgsqlAnswer();
        }

        private void npgsqlAnswer()
        {
            _connection.Open();

            string sql = $"SELECT * FROM {_table};";

            if (_table == "futura")
            {
                sql = $"SELECT f.id, c.name as customer, f.date, f.payment_type, f.prepayment, f.sent, f.total_sum FROM futura f, customers c;";

            }
            else if (_table == "futura_info")
            {
                sql = $"SELECT f.id, f.id_futura, p.name, f.quantity, f.price FROM futura_info f, products p;";
            }

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }

            _dataTable = _dataSet.Tables[0];
            dataGridView_Data.DataSource = _dataTable;
            for (int i = 0; i < _namesTables.Length; i++)
                dataGridView_Data.Columns[i + 1].HeaderText = _namesTables[i];

            _connection.Close();
        }

        private void deleteData(int id)
        {
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"DELETE FROM {_table} WHERE id = '{id}';", _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            if (_table == "products")
            {
                AEProductForm aeProductForm = new AEProductForm(_connection, 0, null);
            }
            if (_table == "customers")
            {
                AECustomers aECustomers = new AECustomers(_connection, 0, null);
            }
            if (_table == "futura")
            {
                AEFuturaForm aEFuturaForm = new AEFuturaForm(_connection, 0, null);
            }
            if (_table == "futura_info")
            {

            }
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            if (_table == "products")
            {
                string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                };
                AEProductForm aeProductForm = new AEProductForm(_connection, sId, attributes);
            }
            if (_table == "customers")
            {
                string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                };
                AECustomers aECustomers = new AECustomers(_connection, sId, attributes);
            }
            if (_table == "futura")
            {
                string[] attributes =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                };
                AEFuturaForm aEFuturaForm = new AEFuturaForm(_connection, sId, attributes);
            }
            if (_table == "futura_info")
            {

            }
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Data.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_Data.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            deleteData(sId);
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            npgsqlAnswer();
        }
    }
}
