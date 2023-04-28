using Microsoft.VisualBasic;
using Npgsql;
using System.Data;
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
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand($"DELETE FROM {_table} WHERE id = '{id}';"))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Data.SelectedRows[0].Index;
            AddFieldForm addFieldForm = new AddFieldForm();
        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            EditFieldForm editFieldForm = new EditFieldForm();
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            deleteData(1);
        }
    }
}
