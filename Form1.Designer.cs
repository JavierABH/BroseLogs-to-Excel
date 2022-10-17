namespace Combinador_de_datos_Brose
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathFiles = new System.Windows.Forms.TextBox();
            this.buttonSearchPath = new System.Windows.Forms.Button();
            this.dateTimePickerFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCombinarDatos = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPathExcel = new System.Windows.Forms.TextBox();
            this.buttonSaveExcel = new System.Windows.Forms.Button();
            this.buttonIraExcel = new System.Windows.Forms.Button();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonActFechas = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta de los archivos";
            // 
            // textBoxPathFiles
            // 
            this.textBoxPathFiles.Location = new System.Drawing.Point(12, 25);
            this.textBoxPathFiles.Name = "textBoxPathFiles";
            this.textBoxPathFiles.Size = new System.Drawing.Size(415, 20);
            this.textBoxPathFiles.TabIndex = 1;
            // 
            // buttonSearchPath
            // 
            this.buttonSearchPath.AutoSize = true;
            this.buttonSearchPath.Location = new System.Drawing.Point(433, 22);
            this.buttonSearchPath.Name = "buttonSearchPath";
            this.buttonSearchPath.Size = new System.Drawing.Size(28, 23);
            this.buttonSearchPath.TabIndex = 52;
            this.buttonSearchPath.Text = "...";
            this.buttonSearchPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearchPath.UseVisualStyleBackColor = true;
            this.buttonSearchPath.Click += new System.EventHandler(this.buttonSearchPath_Click);
            // 
            // dateTimePickerFechaInicial
            // 
            this.dateTimePickerFechaInicial.CustomFormat = "dd/MMM/yy";
            this.dateTimePickerFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaInicial.Location = new System.Drawing.Point(12, 103);
            this.dateTimePickerFechaInicial.Name = "dateTimePickerFechaInicial";
            this.dateTimePickerFechaInicial.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerFechaInicial.TabIndex = 53;
            this.dateTimePickerFechaInicial.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha Final";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.CustomFormat = "MMM/dd/yyyy";
            this.dateTimePickerFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(186, 103);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerFechaFinal.TabIndex = 55;
            this.dateTimePickerFechaFinal.ValueChanged += new System.EventHandler(this.dateTimePickerFechaFinal_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 58;
            // 
            // buttonCombinarDatos
            // 
            this.buttonCombinarDatos.Location = new System.Drawing.Point(12, 171);
            this.buttonCombinarDatos.Name = "buttonCombinarDatos";
            this.buttonCombinarDatos.Size = new System.Drawing.Size(126, 26);
            this.buttonCombinarDatos.TabIndex = 59;
            this.buttonCombinarDatos.Text = "Generar Excel";
            this.buttonCombinarDatos.UseVisualStyleBackColor = true;
            this.buttonCombinarDatos.Click += new System.EventHandler(this.buttonCombinarDatos_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsole.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxConsole.Location = new System.Drawing.Point(12, 203);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConsole.Size = new System.Drawing.Size(454, 219);
            this.textBoxConsole.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ruta donde se guardara el excel";
            // 
            // textBoxPathExcel
            // 
            this.textBoxPathExcel.Location = new System.Drawing.Point(12, 146);
            this.textBoxPathExcel.Name = "textBoxPathExcel";
            this.textBoxPathExcel.Size = new System.Drawing.Size(415, 20);
            this.textBoxPathExcel.TabIndex = 63;
            // 
            // buttonSaveExcel
            // 
            this.buttonSaveExcel.AutoSize = true;
            this.buttonSaveExcel.Location = new System.Drawing.Point(435, 143);
            this.buttonSaveExcel.Name = "buttonSaveExcel";
            this.buttonSaveExcel.Size = new System.Drawing.Size(26, 23);
            this.buttonSaveExcel.TabIndex = 64;
            this.buttonSaveExcel.Text = "...";
            this.buttonSaveExcel.UseVisualStyleBackColor = true;
            this.buttonSaveExcel.Click += new System.EventHandler(this.buttonSaveExcel_Click);
            // 
            // buttonIraExcel
            // 
            this.buttonIraExcel.Location = new System.Drawing.Point(225, 171);
            this.buttonIraExcel.Name = "buttonIraExcel";
            this.buttonIraExcel.Size = new System.Drawing.Size(75, 26);
            this.buttonIraExcel.TabIndex = 65;
            this.buttonIraExcel.Text = "Ir a Excel";
            this.buttonIraExcel.UseVisualStyleBackColor = true;
            this.buttonIraExcel.Click += new System.EventHandler(this.buttonIraExcel_Click);
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(12, 64);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombreArchivo.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Nombre del archivo";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(412, 172);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(49, 26);
            this.buttonHelp.TabIndex = 68;
            this.buttonHelp.Text = "Ayuda";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonActFechas
            // 
            this.buttonActFechas.Location = new System.Drawing.Point(350, 101);
            this.buttonActFechas.Name = "buttonActFechas";
            this.buttonActFechas.Size = new System.Drawing.Size(111, 26);
            this.buttonActFechas.TabIndex = 69;
            this.buttonActFechas.Text = "Actualizar fechas";
            this.buttonActFechas.UseVisualStyleBackColor = true;
            this.buttonActFechas.Click += new System.EventHandler(this.buttonActFechas_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(451, 20);
            this.progressBar1.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(473, 456);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonActFechas);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxNombreArchivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIraExcel);
            this.Controls.Add(this.buttonSaveExcel);
            this.Controls.Add(this.textBoxPathExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.buttonCombinarDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFechaInicial);
            this.Controls.Add(this.textBoxPathFiles);
            this.Controls.Add(this.buttonSearchPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brose logs to Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathFiles;
        private System.Windows.Forms.Button buttonSearchPath;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCombinarDatos;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPathExcel;
        private System.Windows.Forms.Button buttonSaveExcel;
        private System.Windows.Forms.Button buttonIraExcel;
        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonActFechas;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

