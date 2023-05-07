﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryWinForm
{
    public partial class AEFuturaInfoForm : Form
    {
        NpgsqlConnection _connection;
        private int _id;
        public AEFuturaInfoForm(string conn, int id, string?[] attributes)
        {
            _connection = new NpgsqlConnection(conn);
            _id = id;

            InitializeComponent();

            if (id == 0)
            {
                this.Text = "Добавить запись";
                button_action.Text = "Добавить";
                numericUpDown_nounce.Value = 0;
            }
            else
            {
                this.Text = "Изменить запись";
                button_action.Text = "Изменить";
                textBox_futura.Text = attributes[0];
                textBox_product.Text = attributes[1];
                numericUpDown_nounce.Value = Convert.ToInt32(attributes[3]);
                if (attributes[4] != "")
                    numericUpDown_totalSum.Value = Convert.ToInt32(attributes[4].Substring(0, attributes[4].Length - 3));
            }
            this.Show();
        }
        private bool addNote(string futura, string product, int nounce, int sum)
        {
            _connection.Open();
            int idFutura = searchFutura(futura);
            int idProduct = searchProduct(product);
            if (idFutura == 0)
            {
                MessageBox.Show("Накладная не найдена");
                return false;
            }
            else if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"INSERT INTO futura_info (id_futura, id_product, quantity, price) " +
                    $"VALUES ('{idFutura}', '{idProduct}', '{nounce}', '{sum}')", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
            return true;
        }
        private bool editNote(string futura, string product, int nounce, int sum)
        {
            _connection.Open();
            int idFutura = searchFutura(futura);
            int idProduct = searchProduct(product);
            if (idFutura == 0)
            {
                MessageBox.Show("Накладная не найдена");
                return false;
            }
            else if (idProduct == 0)
            {
                MessageBox.Show("Товар не найден");
                return false;
            }
            else
            {
                using (NpgsqlCommand npgsqlCommand = new
                    NpgsqlCommand($"UPDATE futura_info SET id_futura = '{idFutura}', id_product = '{idProduct}', " +
                    $"quantity = '{nounce}', price = '{sum}';", _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            _connection.Close();
            return true;
        }
        private void button_action_Click(object sender, EventArgs e)
        {
            string futura = textBox_futura.Text;
            string product = textBox_product.Text;
            int nounce = Convert.ToInt32(numericUpDown_nounce.Value);
            int sum = Convert.ToInt32(numericUpDown_totalSum.Value);
            if (futura == "")
            {
                MessageBox.Show("Заполните поле накладная");
                return;
            }
            if (product == "")
            {
                MessageBox.Show("Заполните поле товар");
                return;
            }
            if (_id == 0)
            {
                if (!addNote(futura, product, nounce, sum))
                    return;
            }
            else
            {
                if (!editNote(futura, product, nounce, sum))
                    return;
            }
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int searchFutura(string id)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM futura WHERE id = '{id}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
        private int searchProduct(string product)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlDataAdapter dataAdapter = new
                NpgsqlDataAdapter($"SELECT id FROM products WHERE name = '{product}';", _connection))
            {
                dataAdapter.Fill(dataSet);
            }
            if (dataSet.Tables[0].Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[0]);
        }
    }
}