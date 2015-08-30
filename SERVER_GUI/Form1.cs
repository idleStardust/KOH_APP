using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVER_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color c = generarColorAleatorio();
            pintarCirculo(c, 50, 300, 300);
        }

        private Color generarColorAleatorio()
        {
            // Generación de un color aleatorio
            Random randomGen = new Random();
            // Arreglo de Nombres de Colores
            KnownColor[] names = (KnownColor[]) Enum.GetValues(typeof(KnownColor));
            // Se elige un elemento aleatorio
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            // Casteo a Color
            return Color.FromKnownColor(randomColorName);
        }


        private void pintarCirculo(Color pColor, int pRadio, int pPosX, int pPoxY)
        {
            // Gestor de pintar, y elección de color
            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(pColor);
            // Gráfico de panel
            System.Drawing.Graphics formGraphics = panel1.CreateGraphics();
            // Pintado del círculo
            formGraphics.FillEllipse(brush1, 
            // Posición X, Posición Y, Elongación X, Elongación Y
                   new System.Drawing.Rectangle(pRadio + pPosX, pRadio + pPoxY, pRadio, pRadio));
            brush1.Dispose();
            formGraphics.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
