using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory4_11
{
    public partial class Form1 : Form
    {
        struct Product
        {
            public string Name;//Наименование товара
            public string Unit;//Единица измерения
            public int Quantity;//Количество на складе
            public decimal Price; //Цена за единицу
            public Product(string name, string unit, int quantity, decimal price)//конструктор
            {
                Name = name;
                Unit = unit;
                Quantity = quantity;
                Price = price;
            }
            public decimal TotalValue()
            {
                return Quantity * Price;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Наименование товара";
            dataGridView1.Columns[1].HeaderText = "Единица измерения";
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].HeaderText = "Цена за единицу";
            dataGridView1.Columns[4].HeaderText = "Общая стоимость";
        }
        Product[] products = new Product[10];
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string unit = textBoxUnit.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            products[count] = new Product(name, unit, quantity, price);
            decimal totalValue = products[count].TotalValue();

            dataGridView1.Rows.Add(name, unit, quantity, price, totalValue);
            count++;
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
