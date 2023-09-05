using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sitio_para_carga_de_corriculum_y_guardar_en_un_txt
{
    public partial class CargaDeCVyLEER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string experiencia = txtExperiencia.Text;

            string rutaArchivo = @"C:/Users/Ulises/Desktop/txt para asp.net/Curriculum.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo, true))
            {
                file.WriteLine($"Nombre: {nombre}");
                file.WriteLine($"Apellido: {apellido}");
                file.WriteLine($"Experiencia Laboral:");
                file.WriteLine(experiencia);
                file.WriteLine("----------------------------------------");
            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtExperiencia.Text = "";
        }
    }
}