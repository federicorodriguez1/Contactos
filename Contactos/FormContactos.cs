using BA;
using Contactos; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado
{
    public partial class FormContactos : Form
    {
        
        private ListaDeContactos  contactos = new ListaDeContactos();

        public FormContactos()
        {
            InitializeComponent();
        
            DGV.DataSource = contactos.Lista;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(txtLlamadas.Text, out int numeroLlamadas))
            {
                
                Contacto nuevoContacto = new Contacto(
                                                     txtCelu.Text,
                                                     txtNombre.Text,
                                                     txtApellido.Text,
                                                     numeroLlamadas
                                                     );

               
                contactos.InsertContacto(nuevoContacto);

               
                DGV.DataSource = null;
                DGV.DataSource = contactos.Lista;

              

                txtCelu.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtLlamadas.Clear();
            }
            else
            {
                
                MessageBox.Show("Por favor, introduce un número válido para el campo 'Llamadas'.",
                                "Error de Entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAceptar_Click_(object sender, EventArgs e)
        {
            if (txtCelu.Text == "" || txtNombre.Text == "" ||
    txtApellido.Text == "" || txtLlamadas.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Atención");
                return;
            }

            
            if (DGV.Columns.Count == 0)
            {
                DGV.Columns.Add("Celular", "Celular");
                DGV.Columns.Add("Nombre", "Nombre");
                DGV.Columns.Add("Apellido", "Apellido");
                DGV.Columns.Add("Llamadas", "N° Llamadas");
            }

            
            DGV.Rows.Add(
                txtCelu.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtLlamadas.Text
            );

          
            txtCelu.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtLlamadas.Clear();
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}