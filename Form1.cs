using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_editator_de_texto_forms
{
    public partial class EditorDeTexto : Form
    {
        string ruta = "",texto="";
        bool abierto = false;
        long cLineas = 0, cLongitud = 0;
        public EditorDeTexto()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (abierto == false&&TextoPantalla.Text!="")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = saveFileDialog1.FileName;

                    using(StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.Write(TextoPantalla.Text);
                    }
                    abierto = true;
                    MessageBox.Show("El archivo se a guardado en " + ruta);
                }
              
            }
            else if(abierto==true)
            {
                using(StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write(TextoPantalla.Text);
                }
                abierto = true;
            }
        }

        private void gurdarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write(TextoPantalla.Text);
                }
                MessageBox.Show("El archivo se a guardado en " + ruta);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruta = "";
            texto = "";
            TextoPantalla.Text = "";
            abierto = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextoPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {

            cLineas = TextoPantalla.Lines.Count();
            cLongitud = TextoPantalla.Text.Length;

            txtLineas.Text = cLineas.ToString();
            txtLongitud.Text = cLongitud.ToString();

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                texto = "";
                ruta = openFileDialog1.FileName;
                using(StreamReader sr = new StreamReader(ruta,Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        texto += sr.ReadLine()+"\n";
                    }
                }

                TextoPantalla.Text = texto;
                abierto = true;
            }
        }
    }
}
