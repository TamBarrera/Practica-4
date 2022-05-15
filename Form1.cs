using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         }


        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string user, pass;
            pass = txtBoxcontraseña.Text;
            user = txtbox1.Text;
            if (user == "equipo3" && pass == "1234") 
            {
                MessageBox.Show("Bienvenido");
            }
            else 
            {
                errorProvider1.SetError(txtbox1, "usuario incorrecto");
                txtbox1.Text = "";
                txtBoxcontraseña.Text = "";
            }

            using (Form2 ventanaForm2 = new Form2())
                ventanaForm2.ShowDialog();

            this.Close();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
