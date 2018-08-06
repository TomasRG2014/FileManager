namespace FileManager
{
    partial class MostrarFicheros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAlFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAlInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSustitucion = new System.Windows.Forms.TextBox();
            this.textBoxSustituir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filtro = new System.Windows.Forms.TextBox();
            this.exportarResultados = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.labelExtensiones = new System.Windows.Forms.Label();
            this.chequeaSubcarpetas = new System.Windows.Forms.CheckBox();
            this.archivos = new System.Windows.Forms.CheckBox();
            this.extensionesTextbox = new System.Windows.Forms.TextBox();
            this.carpetas = new System.Windows.Forms.CheckBox();
            this.labelTextoABuscar = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.textoExcluir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOperaciones);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridView);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 808);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxOperaciones.Controls.Add(this.label6);
            this.groupBoxOperaciones.Controls.Add(this.textAlFinal);
            this.groupBoxOperaciones.Controls.Add(this.label5);
            this.groupBoxOperaciones.Controls.Add(this.textAlInicio);
            this.groupBoxOperaciones.Controls.Add(this.label4);
            this.groupBoxOperaciones.Controls.Add(this.label3);
            this.groupBoxOperaciones.Controls.Add(this.label2);
            this.groupBoxOperaciones.Controls.Add(this.label1);
            this.groupBoxOperaciones.Controls.Add(this.textBoxSustitucion);
            this.groupBoxOperaciones.Controls.Add(this.textBoxSustituir);
            this.groupBoxOperaciones.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOperaciones.Location = new System.Drawing.Point(13, 401);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(305, 334);
            this.groupBoxOperaciones.TabIndex = 10;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Al final";
            // 
            // textAlFinal
            // 
            this.textAlFinal.Location = new System.Drawing.Point(103, 163);
            this.textAlFinal.Name = "textAlFinal";
            this.textAlFinal.Size = new System.Drawing.Size(189, 24);
            this.textAlFinal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Al Inicio";
            // 
            // textAlInicio
            // 
            this.textAlInicio.Location = new System.Drawing.Point(103, 133);
            this.textAlInicio.Name = "textAlInicio";
            this.textAlInicio.Size = new System.Drawing.Size(189, 24);
            this.textAlInicio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Incluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Por Este";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Este";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sustituir Texto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSustitucion
            // 
            this.textBoxSustitucion.Location = new System.Drawing.Point(103, 74);
            this.textBoxSustitucion.Name = "textBoxSustitucion";
            this.textBoxSustitucion.Size = new System.Drawing.Size(190, 24);
            this.textBoxSustitucion.TabIndex = 1;
            // 
            // textBoxSustituir
            // 
            this.textBoxSustituir.Location = new System.Drawing.Point(103, 45);
            this.textBoxSustituir.Name = "textBoxSustituir";
            this.textBoxSustituir.Size = new System.Drawing.Size(190, 24);
            this.textBoxSustituir.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textoExcluir);
            this.groupBox1.Controls.Add(this.Filtro);
            this.groupBox1.Controls.Add(this.exportarResultados);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.labelExtensiones);
            this.groupBox1.Controls.Add(this.chequeaSubcarpetas);
            this.groupBox1.Controls.Add(this.archivos);
            this.groupBox1.Controls.Add(this.extensionesTextbox);
            this.groupBox1.Controls.Add(this.carpetas);
            this.groupBox1.Controls.Add(this.labelTextoABuscar);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 377);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // Filtro
            // 
            this.Filtro.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Location = new System.Drawing.Point(15, 128);
            this.Filtro.Multiline = true;
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(277, 83);
            this.Filtro.TabIndex = 5;
            // 
            // exportarResultados
            // 
            this.exportarResultados.Location = new System.Drawing.Point(16, 340);
            this.exportarResultados.Name = "exportarResultados";
            this.exportarResultados.Size = new System.Drawing.Size(175, 23);
            this.exportarResultados.TabIndex = 7;
            this.exportarResultados.Text = "Exportar Resultados";
            this.exportarResultados.UseVisualStyleBackColor = true;
            this.exportarResultados.Click += new System.EventHandler(this.exportarResultados_Click);
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(14, 40);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // labelExtensiones
            // 
            this.labelExtensiones.AutoSize = true;
            this.labelExtensiones.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtensiones.Location = new System.Drawing.Point(13, 287);
            this.labelExtensiones.Name = "labelExtensiones";
            this.labelExtensiones.Size = new System.Drawing.Size(96, 16);
            this.labelExtensiones.TabIndex = 7;
            this.labelExtensiones.Text = "Extensiones";
            this.labelExtensiones.Click += new System.EventHandler(this.label2_Click);
            // 
            // chequeaSubcarpetas
            // 
            this.chequeaSubcarpetas.AutoSize = true;
            this.chequeaSubcarpetas.Checked = true;
            this.chequeaSubcarpetas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chequeaSubcarpetas.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeaSubcarpetas.Location = new System.Drawing.Point(159, 74);
            this.chequeaSubcarpetas.Name = "chequeaSubcarpetas";
            this.chequeaSubcarpetas.Size = new System.Drawing.Size(115, 20);
            this.chequeaSubcarpetas.TabIndex = 4;
            this.chequeaSubcarpetas.Text = "Subcarpetas";
            this.chequeaSubcarpetas.UseVisualStyleBackColor = true;
            this.chequeaSubcarpetas.CheckedChanged += new System.EventHandler(this.chequeaSubcarpetas_CheckedChanged);
            // 
            // archivos
            // 
            this.archivos.AutoSize = true;
            this.archivos.Checked = true;
            this.archivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.archivos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivos.Location = new System.Drawing.Point(159, 44);
            this.archivos.Name = "archivos";
            this.archivos.Size = new System.Drawing.Size(91, 20);
            this.archivos.TabIndex = 2;
            this.archivos.Text = "Archivos";
            this.archivos.UseVisualStyleBackColor = true;
            // 
            // extensionesTextbox
            // 
            this.extensionesTextbox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionesTextbox.Location = new System.Drawing.Point(16, 308);
            this.extensionesTextbox.Name = "extensionesTextbox";
            this.extensionesTextbox.Size = new System.Drawing.Size(276, 24);
            this.extensionesTextbox.TabIndex = 6;
            // 
            // carpetas
            // 
            this.carpetas.AutoSize = true;
            this.carpetas.Checked = true;
            this.carpetas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.carpetas.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetas.Location = new System.Drawing.Point(24, 74);
            this.carpetas.Name = "carpetas";
            this.carpetas.Size = new System.Drawing.Size(91, 20);
            this.carpetas.TabIndex = 3;
            this.carpetas.Text = "Carpetas";
            this.carpetas.UseVisualStyleBackColor = true;
            this.carpetas.CheckedChanged += new System.EventHandler(this.carpetas_CheckedChanged);
            // 
            // labelTextoABuscar
            // 
            this.labelTextoABuscar.AutoSize = true;
            this.labelTextoABuscar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoABuscar.Location = new System.Drawing.Point(13, 108);
            this.labelTextoABuscar.Name = "labelTextoABuscar";
            this.labelTextoABuscar.Size = new System.Drawing.Size(120, 16);
            this.labelTextoABuscar.TabIndex = 4;
            this.labelTextoABuscar.Text = "Texto a buscar";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridView.Size = new System.Drawing.Size(671, 808);
            this.GridView.StandardTab = true;
            this.GridView.TabIndex = 0;
            // 
            // textoExcluir
            // 
            this.textoExcluir.Location = new System.Drawing.Point(16, 233);
            this.textoExcluir.Multiline = true;
            this.textoExcluir.Name = "textoExcluir";
            this.textoExcluir.Size = new System.Drawing.Size(276, 51);
            this.textoExcluir.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Texto a excluir";
            // 
            // MostrarFicheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 808);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MostrarFicheros";
            this.Text = "MostrarFicheros";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxOperaciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Filtro;
        private System.Windows.Forms.CheckBox chequeaSubcarpetas;
        private System.Windows.Forms.Label labelTextoABuscar;
        private System.Windows.Forms.TextBox extensionesTextbox;
        private System.Windows.Forms.CheckBox archivos;
        private System.Windows.Forms.CheckBox carpetas;
        private System.Windows.Forms.Label labelExtensiones;
        private System.Windows.Forms.Button exportarResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.TextBox textBoxSustitucion;
        private System.Windows.Forms.TextBox textBoxSustituir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAlFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAlInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoExcluir;
    }
}