using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp5
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy";
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = FormatearTexto(textBox.Text);
            textBox.SelectionStart = textBox.Text.Length;
        }
        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = FormatearTexto(textBox.Text);
            textBox.SelectionStart = textBox.Text.Length;
        }
        private string FormatearTexto(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                    input = input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
            }
            return input;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                Image imagenOriginal = Image.FromFile(rutaImagen);

        
                Image imagenRedimensionada = RedimensionarImagen(imagenOriginal, new Size(250, 250));

              
                pictureBox1.Image = imagenRedimensionada;

                textFoto.Text = rutaImagen;
            }
        }


        private Image RedimensionarImagen(Image imagenOriginal, Size nuevoTamaño)
        {
            Bitmap nuevaImagen = new Bitmap(nuevoTamaño.Width, nuevoTamaño.Height);

            using (Graphics gr = Graphics.FromImage(nuevaImagen))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(imagenOriginal, new Rectangle(Point.Empty, nuevoTamaño));
            }

            return nuevaImagen;
        }

        private void textSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;


            if (!Char.IsDigit(inputChar) && inputChar != '.' && inputChar != '\b')
            {
                e.Handled = true;
            }
            if (inputChar == '.' && textSaldo.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string saldo = textSaldo.Text;
            string fechaNacimiento = dateTimePicker1.Value.ToShortDateString();
            string rutaImagen = textFoto.Text;
            string genero = string.Empty;

            if (radioHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (radioMujer.Checked)
            {
                genero = "Mujer";
            }

    
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(saldo) || string.IsNullOrEmpty(fechaNacimiento) || string.IsNullOrEmpty(rutaImagen) || string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Por favor complete todos los campos antes de agregar una fila", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (!string.IsNullOrEmpty(rutaImagen)) 
            {
            
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = apellido });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = saldo });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = fechaNacimiento });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = genero });

          
                DataGridViewImageCell celdaImagen = new DataGridViewImageCell();

                try
                {
                    Image imagen = Image.FromFile(rutaImagen);
                    celdaImagen.Value = RedimensionarImagen(imagen, new Size(100, 100)); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                fila.Cells.Add(celdaImagen);

                 dataGridView1.Rows.Add(fila);
               
                if (decimal.TryParse(saldo, out decimal saldoDecimal) && saldoDecimal < 50)
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }

                textNombre.Clear();
                textApellido.Clear();
                textSaldo.Clear();
                textFoto.Clear();
                radioHombre.Checked = false;
                radioMujer.Checked = false;
            }
            else
            {
                MessageBox.Show("Por favor seleccione una imagen.", "Imagen no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewColumn columna = dataGridView1.Columns[e.ColumnIndex];

                if (columna.Name == "Eliminar")
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                DataGridViewColumn columna = dataGridView1.Columns[e.ColumnIndex];

              
                if (columna.Name == "Nombre" || columna.Name == "Apellido")
                {
                 
                    e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
 
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

       
    }
}
