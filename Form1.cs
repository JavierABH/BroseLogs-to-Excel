using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Combinador_de_datos_Brose
{
    public partial class Form1 : Form
    {
        string path = "";
        string pathExcel = "";
        DateTime FechaInicio = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;
        string[] folders;
        List<DateTime> fechas = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearchPath_Click(object sender, EventArgs e)
        {
            // Seleccionando la ruta
            FolderBrowserDialog ExplorerPathSelect = new FolderBrowserDialog();
            if (ExplorerPathSelect.ShowDialog() == DialogResult.OK)
            {
                textBoxPathFiles.Text = ExplorerPathSelect.SelectedPath;
                path = textBoxPathFiles.Text;
            }    
        }

        private void dateTimePickerFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            FechaInicio = dateTimePickerFechaInicial.Value;
        }

        private void dateTimePickerFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            FechaFinal = dateTimePickerFechaFinal.Value;
        }

        //private void buttonFolder_Click(object sender, EventArgs e)
        //{
        //    path = textBoxPathFiles.Text;
        //    progressBar1.Value = 0;
        //    string pathFile;
        //    string pathFileRename;
        //    int contador = 0;
        //    if (textBoxPathFiles.Text == "")
        //        MessageBox.Show("No ha seleccionado ninguna ruta", "Seleccione una ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    else
        //    {
        //        try
        //        {
        //            textBoxConsole.AppendText("Proceso de renombre de carpetas");
        //            textBoxConsole.AppendText(Environment.NewLine);
        //            while (true)
        //            {
        //                if (FechaInicio > FechaFinal)
        //                    break;
        //                // Se empiezan a leer las carpetas para realizar el cambio de nombre
        //                pathFile = path + "\\" + FechaInicio.ToString("dd-MMM-yy");
        //                pathFileRename = path + "\\" + FechaInicio.ToString("MM-dd-yy");
        //                try
        //                {
        //                    Directory.Move(pathFile, pathFileRename);
        //                    textBoxConsole.AppendText(pathFileRename);
        //                    textBoxConsole.AppendText(Environment.NewLine);
        //                    textBoxConsole.AppendText("Hecho");
        //                    textBoxConsole.AppendText(Environment.NewLine);
        //                    FechaInicio = FechaInicio.AddDays(1);
        //                    contador += 1;
        //                    progressBar1.Value = contador;
        //                }
        //                catch (Exception DateNotFound)
        //                {
        //                    if (DateNotFound is DirectoryNotFoundException) // Si no encuentra la carpeta, sigue
        //                    {
        //                        FechaInicio = FechaInicio.AddDays(1);
        //                        continue;   
        //                    }
        //                }
        //            }
        //            textBoxConsole.AppendText("Proceso terminado");
        //            textBoxConsole.AppendText(Environment.NewLine);
        //            MessageBox.Show("Las carpetas se han renombreado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        FechaInicio = dateTimePickerFechaInicial.Value;
        //        FechaFinal = dateTimePickerFechaFinal.Value;
        //    }
        //}

        private void buttonSaveExcel_Click(object sender, EventArgs e)
        {
            // Donde se guardara el archivo de excel
            SaveFileDialog ExplorerSaveExcel = new SaveFileDialog();
            ExplorerSaveExcel.Title = "Exportar excel...";
            if (ExplorerSaveExcel.ShowDialog() == DialogResult.OK)
            {
                textBoxPathExcel.Text = ExplorerSaveExcel.FileName;
                pathExcel = textBoxPathExcel.Text;
            }
        }

        private void buttonCombinarDatos_Click(object sender, EventArgs e)
        {
            pathExcel = textBoxPathExcel.Text;
            int contador = 0;
            progressBar1.Value = 0;
            string pathExcelFormat = pathExcel + ".xlsx";
            string PathCSV = AppDomain.CurrentDomain.BaseDirectory + "\\Template\\Datos.csv";
            string PathCSVCopy = AppDomain.CurrentDomain.BaseDirectory + "\\Template\\DatosCopy.csv";
            string FileAdd;
            StreamReader Reader;
            StreamWriter Writer;
            string array;
            string contenidodelimitado;
            if (textBoxPathExcel.Text == "" && textBoxNombreArchivo.Text == "")
                MessageBox.Show("Escriba el nombre del archivo y/o la ruta donde se guardara", "Campos no introducidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    try // Codigo que para tener una sola copia del template
                    {
                        File.Copy(PathCSV, PathCSVCopy);
                    }
                    catch (Exception CsvExist)
                    {
                        if (CsvExist is IOException)
                        {
                            File.Delete(PathCSVCopy);
                            File.Copy(PathCSV, PathCSVCopy);
                        } // Termina codigo
                    }

                    Writer = File.AppendText(PathCSVCopy);
                    string[] dato = new string[290];
                    while (true)
                    {
                        if (FechaInicio > FechaFinal)
                            break;
                        try
                        {
                            // Lectura de cada archivo
                            string Nombre_archivo = textBoxNombreArchivo.Text;
                            FileAdd = path + "\\" + FechaInicio.ToString("dd-MMM-yy") + @"\" + Nombre_archivo; // Ejemplo: 02-01-22\Ford P552 HVAC.dat
                            Reader = File.OpenText(FileAdd);
                            array = Reader.ReadLine();
                            while (array != null)
                            {
                                dato = array.Split('	');
                                contenidodelimitado = array.Replace('	', ',');
                                if (dato[0].Trim() != "Model No.")
                                {
                                    Writer.WriteLine(contenidodelimitado); // Copia solo los datos. No encabezado
                                }
                                array = Reader.ReadLine();
                            }
                            Reader.Close();
                            textBoxConsole.AppendText(FileAdd + " Add");
                            textBoxConsole.AppendText(Environment.NewLine);
                            FechaInicio = FechaInicio.AddDays(1);
                            contador += 1;
                            progressBar1.Value = contador;
                        }
                        catch (Exception DateNotFound)
                        {
                            if (DateNotFound is DirectoryNotFoundException) // Si no encuentra la carpeta, sigue
                            {
                                FechaInicio = FechaInicio.AddDays(1);
                                continue;
                            }
                        }
                    }
                    Writer.Close();
                    textBoxConsole.AppendText("Proceso completado...");
                    textBoxConsole.AppendText(Environment.NewLine);
                    textBoxConsole.AppendText("Iniciando proceso de conversion a excel...");
                    textBoxConsole.AppendText(Environment.NewLine);
                    CsvToExcel(PathCSVCopy, pathExcelFormat);
                    textBoxConsole.AppendText("Excel generado correctamente...");
                    textBoxConsole.AppendText(Environment.NewLine);
                    File.Delete(PathCSVCopy);
                    DialogResult Ir_a_Excel = MessageBox.Show("Desea ir a la ruta del archivo excel?", "Conversion a excel terminada...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Ir_a_Excel == DialogResult.Yes)
                    {
                        string argument = "/select, \"" + pathExcel + "\"";
                        System.Diagnostics.Process.Start("explorer.exe", argument + ".xlsx");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonIraExcel_Click(object sender, EventArgs e)
        {
            pathExcel = textBoxPathExcel.Text;
            try
            {
                string argument = "/select, \"" + pathExcel + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument + ".xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void CsvToExcel(string csv, string xlsx)
        {
            Excel.Application xl = new Excel.Application();
            //Open Excel Workbook for conversion.
            Excel.Workbook wb = xl.Workbooks.Open(csv);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
            //Select The UsedRange
            Excel.Range used = ws.UsedRange;
            //Autofit The Columns
            used.EntireColumn.AutoFit();
            //Save file as csv file
            wb.SaveAs(xlsx, 51);
            //Close the Workbook.
            wb.Close();
            //Quit Excel Application.
            xl.Quit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void buttonActFechas_Click(object sender, EventArgs e)
        {
            path = textBoxPathFiles.Text;
            if (textBoxPathFiles.Text == "")
                MessageBox.Show("No ha seleccionado ninguna ruta", "Seleccione una ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxConsole.AppendText("Toma de fechas");
                    textBoxConsole.AppendText(Environment.NewLine);
                    folders = Directory.GetDirectories(path);
                    progressBar1.Maximum = folders.Length;
                    foreach (string f in folders)
                    {
                        fechas.Add(DateTime.Parse(f.Split('\\').Last()));
                    }
                    textBoxConsole.AppendText("La fecha inicial es: ");
                    textBoxConsole.AppendText(fechas.Min().ToString());
                    textBoxConsole.AppendText(Environment.NewLine);
                    textBoxConsole.AppendText("La fecha final es: ");
                    textBoxConsole.AppendText(fechas.Max().ToString());
                    textBoxConsole.AppendText(Environment.NewLine);
                    // Se asigna las fechas
                    dateTimePickerFechaInicial.Value = fechas.Min();
                    dateTimePickerFechaFinal.Value = fechas.Max();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
    }
}
