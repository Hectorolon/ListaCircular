using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCirculares
{
    public partial class Form1 : Form
    {
        Base estacion = new Base();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int inicio = Convert.ToInt32(txtInicio.Text);
            int fin = Convert.ToInt32(txtFin.Text);
            estacion.agregar(new Ruta(txtNombre.Text, inicio, fin));
            txtNombre.Clear();
            txtInicio.Clear();
            txtFin.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = estacion.listar();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            Ruta buscar = estacion.buscar(txtBuscar.Text);
            if (buscar != null)
                txtMostrar.Text = buscar.ToString();
            else
                txtMostrar.Text = "Base no encontrada";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ruta eliminar = estacion.eliminar(txtEliminar.Text);
            if (eliminar != null)
                txtMostrar.Text = eliminar.ToString();
            else
                txtMostrar.Text = "Base no encontrada";
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {

            txtMostrar.Text = estacion.eliminarInicio().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = estacion.eliminarUltimo().ToString();
        }
    }
}
