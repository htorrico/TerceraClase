using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace TerceraClaseWindows
{
    public partial class Form1 : Form
    {

        Empleado empleado = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleado.PrimerApellido = txtPrimerApellido.Text;
            empleado.SegundoApellido = txtSegundoApellido.Text;
            empleado.PrimerNombre = txtPrimerNombre.Text;
            empleado.SegundoNombre = txtSegundoNombre.Text;
            empleado.SueldoBruto = Convert.ToDecimal(txtSueldoBruto.Text);

            string NombresCompletos = empleado.RetornarNombreCompleto();

            MessageBox.Show(Convert.ToString(NombresCompletos));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            empleado.PrimerApellido = txtPrimerApellido.Text;
            empleado.SegundoApellido = txtSegundoApellido.Text;
            empleado.PrimerNombre = txtPrimerNombre.Text;
            empleado.SegundoNombre = txtSegundoNombre.Text;
            empleado.SueldoBruto = Convert.ToDecimal(txtSueldoBruto.Text);

            decimal sueldoNeto = empleado.RetornarSueldoNeto();

            MessageBox.Show(Convert.ToString(sueldoNeto));
        }
    }
}
