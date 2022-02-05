using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_Visual
{
    public partial class Visual : Form
    {
        public Visual()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirFormEnPanel(new home());
            Login login = new Login();
            login.ShowDialog();
        }

        private void abrirFormEnPanel(Object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            fh.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new home());
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new home());
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new ClientesMain());
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
