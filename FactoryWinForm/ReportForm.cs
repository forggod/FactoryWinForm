using Microsoft.Office.Interop.Excel;
using Npgsql;
using System.Data;
using DataTable = System.Data.DataTable;
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
            this.Text = "Формирование отчёта";
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
            string[] dt = dateTimePicker_start.Text.Split('.');
            string dateStart = $"{dt[2]}-{dt[1]}-{dt[0]}";
            dt = dateTimePicker_end.Text.Split('.');
            string dateEnd = $"{dt[2]}-{dt[1]}-{dt[0]}";
            string selectedNames = "";
            int n = dataGridView_clients.SelectedRows.Count;
            if (n == 0)
                return;
            selectedNames += $"name = '{dataGridView_clients.SelectedRows[0].Cells[1].Value}'";
            for (int i = 2; i < n; i++)
            {
                selectedNames += $" OR name = '{dataGridView_clients.SelectedRows[i].Cells[1].Value}'";
            }

            string sql = $"SELECT fi.id, fi.name as product, f.name as customer, fi.quantity, fi.price FROM (" +
                $"SELECT f.id, c.name, f.total_sum FROM futura f JOIN(" +
                $"SELECT id, name FROM customers WHERE {selectedNames}" +
                $") c ON f.id_customer = c.id WHERE f.sent = true AND f.date >= '{dateStart}' AND f.date <= '{dateEnd}'" +
                $") f JOIN(SELECT fi.id, fi.id_futura, fi.quantity, fi.price, p.name FROM futura_info fi JOIN " +
                $"products p ON fi.id_product = p.id" +
                $") fi ON fi.id_futura = f.id;";
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; " +
                "Password=postpass; Database=sitnikov342");
            connection.Open();
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                ds.Reset();
                dataAdapter.Fill(ds);
            }
            table = ds.Tables[0];
            string[] columns = {
                "Номер отчёта",
                "Продукт",
                "Заказщик",
                "Количество",
                "Цена",
            };
            if (table.Rows.Count < 1)
            {
                MessageBox.Show("Записей не найдено");
                return;
            }
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < columns.Length + 1; i++)
            {
                application.Cells[1, i] = columns[i - 1];
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = table.Rows[i].ItemArray[j].ToString();
                }
            }
            application.Columns.AutoFit();
            application.Visible = true;
        }
    }
}
