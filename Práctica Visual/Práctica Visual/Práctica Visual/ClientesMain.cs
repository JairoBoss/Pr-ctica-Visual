using Práctica_Visual.Resources;
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
    public partial class ClientesMain : Form
    {
        public ClientesMain()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            AgregarCliente a = new AgregarCliente();
            a.ShowDialog();
        }
    }
}
