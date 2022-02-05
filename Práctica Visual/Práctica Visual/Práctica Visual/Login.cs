using Práctica_Visual.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_Visual
{
    public partial class Login : Form
    {
        private bool banderita = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // Enter is pressed
                ingresar();                
                return true; //return true if you want to suppress the key.
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ingresar()
        {
            string cadena = Properties.Settings.Default.clientes_JairoConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                string usuario = txtUsuario.Text;
                string contraseña = Encriptar.GetMD5(txtPassword.Text);



                SqlCommand comando = new SqlCommand("Select id from Usuario " +
                    "where nombre = @usuario and contraseña = @password", conexion);
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = contraseña;
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    banderita = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }

                conexion.Close();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (banderita == false)
            {
                Application.Exit();
            }
        }
    }
}
