using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Progra3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboBoxDPI();
            CargarComboBoxCodigo();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void CargarComboBoxDPI()
        {
            if (File.Exists("Alumnos.txt"))
            {
                comboBoxDPI.Items.Clear();
                string[] lineas = File.ReadAllLines("Alumnos.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length > 0)
                    {
                        comboBoxDPI.Items.Add(campos[0]);
                    }
                }
            }
        }

        private void CargarComboBoxCodigo()
        {
            if (File.Exists("Talleres.txt"))
            {
                comboBoxCodigo.Items.Clear();
                string[] lineas = File.ReadAllLines("Talleres.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length > 0)
                    {
                        comboBoxCodigo.Items.Add(campos[0]);
                    }
                }
            }
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            string dpi = textBoxDPI.Text.Trim();
            string nombre = textBoxNombreAlumno.Text.Trim();
            string direccion = textBoxDireccion.Text.Trim();

            if (DPIExistente(dpi))
            {
                MessageBox.Show("El DPI ingresado ya existe para otro alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("Alumnos.txt", true))
                {
                    writer.WriteLine($"{dpi},{nombre},{direccion}");
                }

                MessageBox.Show("Alumno guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarComboBoxDPI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DPIExistente(string dpi)
        {
            if (File.Exists("Alumnos.txt"))
            {
                string[] lineas = File.ReadAllLines("Alumnos.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length > 0 && campos[0] == dpi)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnGuardarTaller_Click(object sender, EventArgs e)
        {
            string codigoTaller = textBoxCodigoTaller.Text.Trim();
            string nombreTaller = textBoxNombreTaller.Text.Trim();
            string costoTallerText = textBoxCosto.Text.Trim();

            if (CodigoTallerExistente(codigoTaller))
            {
                MessageBox.Show("El código de taller ingresado ya existe para otro taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int costoTaller;
            if (!int.TryParse(costoTallerText, out costoTaller))
            {
                MessageBox.Show("El costo del taller debe ser un número entero y solo valida numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (StreamWriter writer = new StreamWriter("Talleres.txt", true))
                {
                    writer.WriteLine($"{codigoTaller},{nombreTaller},{costoTaller}");
                }

                MessageBox.Show("Taller guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarComboBoxCodigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CodigoTallerExistente(string codigoTaller)
        {
            if (File.Exists("Talleres.txt"))
            {
                string[] lineas = File.ReadAllLines("Talleres.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length > 0 && campos[0] == codigoTaller)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnGuardarInscripcion_Click(object sender, EventArgs e)
        {
            string dpiSeleccionado = comboBoxDPI.SelectedItem?.ToString();
            string codigoTallerSeleccionado = comboBoxCodigo.SelectedItem?.ToString();
            string fechaInscripcion = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(dpiSeleccionado) || string.IsNullOrEmpty(codigoTallerSeleccionado))
            {
                MessageBox.Show("Debe seleccionar un DPI y un código de taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("Inscripciones.txt", true))
                {
                    writer.WriteLine($"{dpiSeleccionado},{codigoTallerSeleccionado},{fechaInscripcion}");
                }

                MessageBox.Show("Inscripción guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos de la inscripción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewReporte.Rows.Clear();

                string[] inscripciones = File.ReadAllLines("Inscripciones.txt");

                foreach (string inscripcion in inscripciones)
                {
                    string[] campos = inscripcion.Split(',');

                    if (campos.Length >= 2)
                    {
                        string nombreEstudiante = ObtenerNombreEstudiante(campos[0]);

                        string nombreTaller = ObtenerNombreTaller(campos[1]);

                        dataGridViewReporte.Rows.Add(nombreEstudiante, nombreTaller);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerNombreEstudiante(string dpi)
        {
            string nombreEstudiante = "";
            if (File.Exists("Alumnos.txt"))
            {
                string[] lineas = File.ReadAllLines("Alumnos.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length >= 3 && campos[0] == dpi)
                    {
                        nombreEstudiante = campos[1];
                        break;
                    }
                }
            }
            return nombreEstudiante;
        }

        private string ObtenerNombreTaller(string codigoTaller)
        {
            string nombreTaller = "";
            if (File.Exists("Talleres.txt"))
            {
                string[] lineas = File.ReadAllLines("Talleres.txt");
                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(',');
                    if (campos.Length >= 3 && campos[0] == codigoTaller)
                    {
                        nombreTaller = campos[1];
                        break;
                    }
                }
            }
            return nombreTaller;
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inscripciones = File.ReadAllLines("Inscripciones.txt");

                List<Inscripcion> listaInscripciones = new List<Inscripcion>();

                foreach (string inscripcion in inscripciones)
                {
                    string[] campos = inscripcion.Split(',');

                    if (campos.Length >= 2)
                    {
                        string nombreEstudiante = ObtenerNombreEstudiante(campos[0]);

                        string nombreTaller = ObtenerNombreTaller(campos[1]);

                        listaInscripciones.Add(new Inscripcion(nombreEstudiante, nombreTaller));
                    }
                }
                listaInscripciones = listaInscripciones.OrderBy(x => x.NombreTaller).ToList();

                dataGridViewReporte.Rows.Clear();

                foreach (Inscripcion inscripcion in listaInscripciones)
                {
                    dataGridViewReporte.Rows.Add(inscripcion.NombreEstudiante, inscripcion.NombreTaller);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ordenar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Inscripcion
        {
            public string NombreEstudiante { get; set; }
            public string NombreTaller { get; set; }

            public Inscripcion(string nombreEstudiante, string nombreTaller)
            {
                NombreEstudiante = nombreEstudiante;
                NombreTaller = nombreTaller;
            }
        }

    }
}
