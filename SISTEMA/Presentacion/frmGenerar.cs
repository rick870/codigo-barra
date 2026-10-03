using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SISTEMA.Presentacion
{
    public partial class frmGenerar : Form
    {
        public frmGenerar()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (txtTexto.Text!= "")
            {
                BarcodeWriter Bwriter = new BarcodeWriter();
                Bwriter.Format = BarcodeFormat.QR_CODE;
                
                Bitmap bm = new Bitmap(Bwriter.Write(txtTexto.Text), 300, 300);
                pctImagen.Image = bm;
            }
            else
            {
                pctImagen.Image = null;
            }
           
        }

        private void btnAbrirarchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\Gepar\Desktop\Codigos barra"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctImagen2.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                
                string texto = br.Decode((Bitmap)pctImagen2.Image).ToString();                
                txtTexto2.Text = texto;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\SysDeVito\LEERGENERAR_QRBARRA\Imagenes"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pctImagen.Image.Save(sfd.FileName);
            }
        }
    }
}
