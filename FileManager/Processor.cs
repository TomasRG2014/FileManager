using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public static class Processor : Object
    {
        public static DataTable ProcesaTodo(string ruta, bool chkCarpetas, bool chkSubCarpetas, bool chkFicheros, String[] filtros,String[] exclusiones,  String[] extensiones)
        {
            //Se crea la tabla y se le añaden columnas
            DataTable table = new DataTable();
            table.Columns.Add("Ruta");
            table.Columns.Add("Nombre");
            table.Columns.Add("Atributo");
            table.Columns.Add("Extensión");
            table.Columns.Add("Fecha Creación");
            //Se añaden los archivos de la ruta raiz
            //Si chkficheros está chequeado
            Console.WriteLine("Chequea Ficheros es : " + chkFicheros.ToString());
            Console.WriteLine(ruta);
            if (chkFicheros)
            {
                Console.WriteLine("llamando a procesar ficheros");
                table.Merge(ProcesaFicheros(ruta, table, filtros, exclusiones ,extensiones));
            }

            //Si carpetas está chequeao
            //Se añaden las carpetas
            if (chkCarpetas)
            {
                table.Merge(ProcesaCarpetas(ruta, chkSubCarpetas, chkFicheros, table, filtros, exclusiones,extensiones));
            }

            return table;
        }

        /* Se procesan las carpetas recursivamente
         * Se parte de la carpeta raiz seleccionada por el usuario
         * y se llaman recursivamente las carpetas dentro de cada carpeta
        */

        public static DataTable ProcesaCarpetas(String ruta, bool chkSubCarpetas, bool chkFicheros, DataTable table, String[] filtros, String[] exclusiones, String[] extensiones)
        {
            var SubCarpetas = Directory.EnumerateDirectories(ruta);

            foreach (String c in SubCarpetas)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(c);
                String nombreRuta = directoryInfo.FullName;
                String nombre = directoryInfo.Name;
                DateTime fechaCreacion = directoryInfo.CreationTime;
                FileAttributes tipoFichero = directoryInfo.Attributes;
                String ext = directoryInfo.Extension;
                //Se excluyen las carpetas ocultas
                if (!((tipoFichero & FileAttributes.Hidden) == FileAttributes.Hidden))
                {
                    String[] fila = new string[5];
                    fila[0] = nombreRuta;
                    fila[1] = nombre.ToString();
                    fila[2] = tipoFichero.ToString();
                    fila[3] = ext;
                    fila[4] = fechaCreacion.ToString();

                    table.Rows.Add(fila);
                }
                //Se ejecuta si la casilla está chequeada
                if (chkFicheros)
                {
                    table.Merge(ProcesaFicheros(c, table, filtros, exclusiones,extensiones));
                }
                //Se ejecuta si se ha escogido esa opción
                if (chkSubCarpetas)
                {
                    table.Merge(ProcesaCarpetas(c, chkSubCarpetas, chkFicheros, table, filtros, exclusiones, extensiones));
                }
            }
            return table;
        }

        public static DataTable ProcesaFicheros(String ruta, DataTable table, 
                                        String[] filtros, String[] exclusiones, String[] extensiones)
        {
            
            var ficheros = Directory.EnumerateFiles(ruta);
            //Para cada fichero en la carpeta
            foreach (String f in ficheros)
            {
                //Se extrae la información de cada fichero
                FileInfo fileInfo = new FileInfo(f);
                String nombreFichero = fileInfo.FullName;
                String nombre = fileInfo.Name;
                String soloNombre = fileInfo.Name.ToLower();
                FileAttributes tipoFichero = fileInfo.Attributes;
                DateTime fechaCreacion = fileInfo.CreationTime;
                String ext = fileInfo.Extension;

                //Determinar si se incluye el fichero en función de los tres parámetros
                bool contieneTexto = ContieneCadena(soloNombre, filtros);
                bool contieneExtension = ContieneCadena(soloNombre, extensiones);
                bool contieneExclusion = ContieneCadena(soloNombre, exclusiones);
                bool seProcesa = false;
                Console.WriteLine("filtros.Length " + filtros.Length);
                Console.WriteLine("extensiones.Length " + extensiones.Length);
                Console.WriteLine("exclusiones.Length " + exclusiones.Length);

                if (filtros.Length > 1 && extensiones.Length > 1 && exclusiones.Length > 1)
                {
                    seProcesa = true;
                    
                }
                //if ((((ContieneCadena(soloNombre, filtros)) && (ContieneCadena(soloNombre, extensiones))) &&(!(ContieneCadena(soloNombre,exclusiones)))))



                if (!((tipoFichero & FileAttributes.Hidden) == FileAttributes.Hidden))
                {
                    //buscar cadenas que coincidan con los filtros de texto y las extensiones
                    if (seProcesa)
                    {
                        Console.WriteLine("Se procesa");
                        Console.WriteLine("Nombre del fichero" + soloNombre);
                        Console.WriteLine("Contiene filtro" + (ContieneCadena(soloNombre, filtros)));
                        Console.WriteLine("Contiene extension" + (ContieneCadena(soloNombre, extensiones)));
                        Console.WriteLine("Contiene exclusiones" + (ContieneCadena(soloNombre, exclusiones)));

                        //Se añaden los datos a la matriz y se le pasa a la table
                        String[] fila = new string[5];
                        fila[0] = nombreFichero;
                        fila[1] = nombre.ToString();
                        fila[2] = tipoFichero.ToString();
                        fila[3] = ext;
                        fila[4] = fechaCreacion.ToString();

                        table.Rows.Add(fila);
                    }
                }
            }
            return table;
        }
        //Función que busca una cadena dentro de un array de cadenas y devuelve true si la encuentra
        public static bool ContieneCadena(String cadena, String[] aBuscar)
        {
            //Este StringComparison es una mierda, mejor convertir a minúsculas las dos cadenas
            StringComparison comp = StringComparison.CurrentCultureIgnoreCase;
            for (int i = 0; i < aBuscar.Length; i++)
            {
                Console.WriteLine("Cadena a buscar " + aBuscar[i], comp);
                if (cadena.Contains(aBuscar[i].ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        //Exportar a un fichero el contenido de table
        public static void ExportarCSV(DataTable table)
        {
            SaveFileDialog escogeFichero = new SaveFileDialog
            {
                InitialDirectory = @"Documentos",
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                AddExtension = true,
                DefaultExt = "csv"
            };
            string fichero = "";
            System.IO.FileInfo file = null;

            if (escogeFichero.ShowDialog() == DialogResult.OK)
            {
                if (escogeFichero.FileName != "")
                {
                    fichero = escogeFichero.FileName;
                    file = new System.IO.FileInfo(fichero);
                    Console.WriteLine("fichero seleccionado : " + fichero);
                }
            }

            /*File.Create("D:\\Fichero.txt");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\\FicheroLog.csv", true);
            */

            foreach (DataRow row in table.Rows)
            {
                string texto = "";
                foreach (DataColumn column in table.Columns)
                {
                    texto = texto + row[column] + ",";
                }
                Console.WriteLine(texto);

                //Create a file to write to.
                using (StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine(texto);
                }
            }
        }
    }

}