using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Notas.Modulo;
using System.Collections;

namespace Notas
{
    public partial class Form1 : Form
    {
        List<cPersonas> lista = new List<cPersonas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cPersonas p = new cPersonas();
            try
            {
                p.pProductos = txtproducto.Text.Trim();
                p.pPrecioUnitario = (int.Parse(txtpreciounitario.Text.Trim()));
                p.pCantidad = (int.Parse(txtcantidad.Text.Trim()));
                txttotal.Text = "" + p.Total();
                p.pTotal = (int.Parse(txttotal.Text.Trim()));
                lista.Add(p);

                groupBox3.Text = "Registros Agregados: " + lista.Count;
                dgvRegistro.DataSource = lista.ToArray();
            }
            catch (Exeption ex) { }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = dgvRegistro.CurrentRow.Index;
                lista.RemoveAt(posicion);
                dgvRegistro.DataSource = lista.ToArray();
            }
            catch (Exception ex) { }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
