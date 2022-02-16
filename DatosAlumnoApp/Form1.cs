using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DatosAlumnoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpNuevoAlumno.Enabled = true;
        }

        private void LimpiarControles()
        {
            
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtNombrePadre.Clear();
            txtNombreMadre.Clear();
            txtTelMadre.Clear();
            txtTelPadre.Clear();
            dtpNacimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno nuevo = new Alumno();
            nuevo.Padre = new Persona();
            nuevo.Madre = new Persona();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Domicilio = txtDomicilio.Text;
            nuevo.FechaNacimiento = dtpNacimiento.Value;
            nuevo.Padre.Nombre = txtNombrePadre.Text;
            nuevo.Padre.Telefono = txtTelPadre.Text;
            nuevo.Madre.Nombre = txtNombreMadre.Text;
            nuevo.Madre.Telefono = txtTelMadre.Text;

            Serializador<Alumno> ser = new Serializador<Alumno>();
            string ruta = Path.Combine
                (Environment.CurrentDirectory,"alumnos", nuevo.Nombre + ".dat");
            ser.Guardar(ruta, nuevo);
            LimpiarControles();
            grpNuevoAlumno.Enabled = false;
        }
    }
}
