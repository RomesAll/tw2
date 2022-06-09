using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            ClassBook.SelectBook();
            dataGridView1.DataSource = ClassBook.dataTable;
            ClassBook.SelectClient();
            comboBox1.DataSource = ClassBook.dataTableClient;
            comboBox1.ValueMember = "idreader";
            comboBox1.DisplayMember = "familia";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassBook.SelectBookAvtor(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView2.DataSource = ClassBook.dataTableAvtor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClassBook.FiltrBookShifr(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ClassBook.FiltrBookName(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassBook.SelectBookClient(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = ClassBook.dataTable;
        }
    }
}
