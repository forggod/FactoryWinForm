using Npgsql;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace FactoryWinForm
{
    public partial class ReportForm : Form
    {
        private NpgsqlConnection _connection = new NpgsqlConnection();
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        private string[] _columnsRU;
        public ReportForm()
        {
            _columnsRU = new string[] {
                "Клиент",
            };
            InitializeComponent();
            this.Show();
            initConnection();
            updateDataGridView();
        }

        private void initConnection()
        {
            _connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=sitnikov342");
        }
        private void updateDataGridView()
        {
            _connection.Open();
            string sql = $"SELECT id, name FROM customers;";

            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }

            _dataTable = _dataSet.Tables[0];
            dataGridView_clients.DataSource = _dataTable;
            for (int i = 0; i < _columnsRU.Length; i++)
                dataGridView_clients.Columns[i + 1].HeaderText = _columnsRU[i];

            _connection.Close();
        }

        private void exportToExcel(DataTable table)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            application.Columns.AutoFit();
            application.Visible = true;
        }

        private DataTable answerDB()
        {
            DataTable table = new DataTable();

            return table;
        }

        private void button_action_Click(object sender, EventArgs e)
        {

        }
    }
}
