namespace Examen1Progra3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.textBoxNombreAlumno = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.textBoxCodigoTaller = new System.Windows.Forms.TextBox();
            this.textBoxNombreTaller = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarTaller = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDPI = new System.Windows.Forms.ComboBox();
            this.comboBoxCodigo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarInscripcion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCantidadAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Alumnos";
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(131, 47);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(279, 22);
            this.textBoxDPI.TabIndex = 1;
            // 
            // textBoxNombreAlumno
            // 
            this.textBoxNombreAlumno.Location = new System.Drawing.Point(131, 91);
            this.textBoxNombreAlumno.Name = "textBoxNombreAlumno";
            this.textBoxNombreAlumno.Size = new System.Drawing.Size(279, 22);
            this.textBoxNombreAlumno.TabIndex = 2;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(131, 131);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(279, 22);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datos Talleres";
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(436, 83);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(112, 42);
            this.btnGuardarAlumno.TabIndex = 8;
            this.btnGuardarAlumno.Text = "Guardar Datos";
            this.btnGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // textBoxCodigoTaller
            // 
            this.textBoxCodigoTaller.Location = new System.Drawing.Point(131, 235);
            this.textBoxCodigoTaller.Name = "textBoxCodigoTaller";
            this.textBoxCodigoTaller.Size = new System.Drawing.Size(279, 22);
            this.textBoxCodigoTaller.TabIndex = 9;
            // 
            // textBoxNombreTaller
            // 
            this.textBoxNombreTaller.Location = new System.Drawing.Point(131, 284);
            this.textBoxNombreTaller.Name = "textBoxNombreTaller";
            this.textBoxNombreTaller.Size = new System.Drawing.Size(279, 22);
            this.textBoxNombreTaller.TabIndex = 10;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(131, 331);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(279, 22);
            this.textBoxCosto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre Taller";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Codigo Taller";
            // 
            // btnGuardarTaller
            // 
            this.btnGuardarTaller.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGuardarTaller.Location = new System.Drawing.Point(436, 286);
            this.btnGuardarTaller.Name = "btnGuardarTaller";
            this.btnGuardarTaller.Size = new System.Drawing.Size(112, 38);
            this.btnGuardarTaller.TabIndex = 16;
            this.btnGuardarTaller.Text = "Guardar Datos";
            this.btnGuardarTaller.UseVisualStyleBackColor = false;
            this.btnGuardarTaller.Click += new System.EventHandler(this.btnGuardarTaller_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Inscripcion Taller";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "DPI Estudiante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Codigo del Taller";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha Inscripcion";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxDPI
            // 
            this.comboBoxDPI.FormattingEnabled = true;
            this.comboBoxDPI.Location = new System.Drawing.Point(152, 431);
            this.comboBoxDPI.Name = "comboBoxDPI";
            this.comboBoxDPI.Size = new System.Drawing.Size(258, 24);
            this.comboBoxDPI.TabIndex = 21;
            // 
            // comboBoxCodigo
            // 
            this.comboBoxCodigo.FormattingEnabled = true;
            this.comboBoxCodigo.Location = new System.Drawing.Point(152, 468);
            this.comboBoxCodigo.Name = "comboBoxCodigo";
            this.comboBoxCodigo.Size = new System.Drawing.Size(258, 24);
            this.comboBoxCodigo.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 505);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnGuardarInscripcion
            // 
            this.btnGuardarInscripcion.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGuardarInscripcion.Location = new System.Drawing.Point(436, 461);
            this.btnGuardarInscripcion.Name = "btnGuardarInscripcion";
            this.btnGuardarInscripcion.Size = new System.Drawing.Size(112, 41);
            this.btnGuardarInscripcion.TabIndex = 24;
            this.btnGuardarInscripcion.Text = "Guardar Datos";
            this.btnGuardarInscripcion.UseVisualStyleBackColor = false;
            this.btnGuardarInscripcion.Click += new System.EventHandler(this.btnGuardarInscripcion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(594, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Reporte Estudiantes Inscritos";
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Taller});
            this.dataGridViewReporte.Location = new System.Drawing.Point(594, 68);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(441, 153);
            this.dataGridViewReporte.TabIndex = 26;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonMostrar.Location = new System.Drawing.Point(932, 13);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(103, 36);
            this.buttonMostrar.TabIndex = 27;
            this.buttonMostrar.Text = "Mostrar Datos";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.Color.Orange;
            this.buttonOrdenar.Location = new System.Drawing.Point(594, 239);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(205, 35);
            this.buttonOrdenar.TabIndex = 28;
            this.buttonOrdenar.Text = "Ordenar Alfabeticamente";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Taller
            // 
            this.Taller.HeaderText = "Taller";
            this.Taller.MinimumWidth = 6;
            this.Taller.Name = "Taller";
            this.Taller.Width = 125;
            // 
            // btnCantidadAlumnos
            // 
            this.btnCantidadAlumnos.BackColor = System.Drawing.Color.LightCoral;
            this.btnCantidadAlumnos.Location = new System.Drawing.Point(847, 239);
            this.btnCantidadAlumnos.Name = "btnCantidadAlumnos";
            this.btnCantidadAlumnos.Size = new System.Drawing.Size(188, 35);
            this.btnCantidadAlumnos.TabIndex = 29;
            this.btnCantidadAlumnos.Text = "Cantidad Total Estudiantes";
            this.btnCantidadAlumnos.UseVisualStyleBackColor = false;
            this.btnCantidadAlumnos.Click += new System.EventHandler(this.btnCantidadAlumnos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1061, 554);
            this.Controls.Add(this.btnCantidadAlumnos);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGuardarInscripcion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxCodigo);
            this.Controls.Add(this.comboBoxDPI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardarTaller);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxNombreTaller);
            this.Controls.Add(this.textBoxCodigoTaller);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNombreAlumno);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.TextBox textBoxNombreAlumno;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.TextBox textBoxCodigoTaller;
        private System.Windows.Forms.TextBox textBoxNombreTaller;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarTaller;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDPI;
        private System.Windows.Forms.ComboBox comboBoxCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardarInscripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taller;
        private System.Windows.Forms.Button btnCantidadAlumnos;
    }
}

