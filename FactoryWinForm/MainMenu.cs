using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryWinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            string tableName = "products";
            string[] tableFields =
            {
                "Наименование",
                "Кол-во",
            };
            DataForm productsDataForm = new DataForm(tableName, tableFields);
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            string tableName = "customers";
            string[] tableFields =
            {
                "Заказщик",
                "Адрес",
                "Телефон",
            };
            DataForm customersDataForm = new DataForm(tableName, tableFields);
        }

        private void button_invoices_Click(object sender, EventArgs e)
        {
            string tableName = "futura";
            string[] tableFields =
            {
                "Заказщик",
                "Дата заказа",
                "Тип оплаты",
                "Предоплата",
                "Отгружено",
                "Сумма",
            };
            DataForm futuraDataForm = new DataForm(tableName, tableFields);
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            string tableName = "futura_info";
            string[] tableFields =
            {
                "Номер накладной",
                "Товар",
                "Кол-во",
                "Цена",
            };
            DataForm futurainfoDataForm = new DataForm(tableName, tableFields);
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT f.id, f.id_futura, p.name, f.quantity, f.price FROM futura_info f, " +
                $"products p;";
            DataSet dataSet = new DataSet();
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; " +
                "Password=postpass; Database=sitnikov342");
            connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, connection))
            {
                dataAdapter.Fill(dataSet);
            }
            connection.Close();
            ExportToExcell exportToExcell = new ExportToExcell(dataSet.Tables[0]);
        }
    }
}
