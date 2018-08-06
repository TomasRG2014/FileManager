using System;
using System.Windows.Forms;

namespace FileManager
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BuscarArchivosMenu_Click(object sender, EventArgs e)
        {
            MostrarFicheros mostrarFicheros = new MostrarFicheros();
            mostrarFicheros.MdiParent = this;
            mostrarFicheros.Show();
        }
    }
}