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
    public partial class FormHall : Form
    {
        public FormHall()
        {
            InitializeComponent();
            ClassHall.SelectHall();
            dataGridView1.DataSource = ClassHall.dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassHall.SelectHallReader(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataGridView2.DataSource = ClassHall.dataTableReader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < dataGridView1.RowCount; i ++)
            //{
            //    if (dataGridView1["Column2", i].Value.ToString().Contains(textBox1.Text)==true)
            //    {
            //        dataGridView1.CurrentCell = dataGridView1["Column2", i];
            //        for(int j = 0; i < dataGridView1.RowCount; i++)
            //        {
            //            if (i != j)
            //                dataGridView1.Rows.Remove(dataGridView1.Rows[j]);
            //        }
            //    }
            //}
        }
    }
}
