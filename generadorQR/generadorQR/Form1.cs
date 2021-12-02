using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generadorQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            QRCodeGenerator elQR = new QRCodeGenerator();
            QRCodeData datos = elQR.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode codigo = new QRCode(datos);
            pictureBox1.Image = codigo.GetGraphic(5);

        }
    }
}
