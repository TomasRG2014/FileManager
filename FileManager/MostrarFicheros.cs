using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class MostrarFicheros : Form
    {
        private DataTable table = new DataTable();

        public MostrarFicheros()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.splitContainer1.SplitterDistance = 200;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String rutaOrigen = "";
            String rutaDestino = "";
            String[] palabras;
            String[] exclusiones;
            String[] extensiones;
            bool chkCarpetas;
            bool chkFicheros;
            bool chkSubCarpetas;

            palabras = Filtro.Text.Split(' ');
            exclusiones = textoExcluir.Text.Split(' ');
            extensiones = extensionesTextbox.Text.Split(' ');
            chkSubCarpetas = chequeaSubcarpetas.Checked;
            chkCarpetas = carpetas.Checked;
            chkFicheros = archivos.Checked;

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i].ToString());
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                rutaOrigen = folderBrowserDialog.SelectedPath;

                //DataTable table = new DataTable();

                table = Processor.ProcesaTodo(rutaOrigen, chkCarpetas, chkSubCarpetas, chkFicheros, palabras, exclusiones, extensiones);

                GridView.DataSource = table;
                GridView.PerformLayout();
            }
        }

        private void carpetas_CheckedChanged(object sender, EventArgs e)
        {
            if (!carpetas.Checked)
            {
                chequeaSubcarpetas.Checked = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        //Exportar a un fichero el contenido de table
        private void exportarResultados_Click(object sender, EventArgs e)
        {
            Processor.ExportarCSV(table);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chequeaSubcarpetas_CheckedChanged(object sender, EventArgs e)
        {
            if (chequeaSubcarpetas.Checked == true)
            {
                carpetas.Checked = true;
            }
        }
    }
}