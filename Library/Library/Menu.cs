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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ClassConnect.Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigatorMeny(new FormBook());
        }
        void NavigatorMeny(Form form)
        {
            panel2.Controls.Clear();
            form.TopLevel = false;
            form.Anchor = AnchorStyles.Top;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigatorMeny(new FormHall());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
