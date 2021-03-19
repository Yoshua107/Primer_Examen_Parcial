
namespace Primer_Examen_Parcial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePrestamo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataNoDevueltos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.texCodigo = new System.Windows.Forms.TextBox();
            this.texCarnet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNoDevueltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo del Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Prestamo";
            // 
            // dateTimePrestamo
            // 
            this.dateTimePrestamo.Location = new System.Drawing.Point(115, 98);
            this.dateTimePrestamo.Name = "dateTimePrestamo";
            this.dateTimePrestamo.Size = new System.Drawing.Size(305, 20);
            this.dateTimePrestamo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de devolucion";
            // 
            // dateTimeDevolucion
            // 
            this.dateTimeDevolucion.Location = new System.Drawing.Point(115, 142);
            this.dateTimeDevolucion.Name = "dateTimeDevolucion";
            this.dateTimeDevolucion.Size = new System.Drawing.Size(305, 20);
            this.dateTimeDevolucion.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.texCarnet);
            this.groupBox1.Controls.Add(this.dateTimeDevolucion);
            this.groupBox1.Controls.Add(this.texCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePrestamo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lista de liros a un no devueltos";
            // 
            // dataNoDevueltos
            // 
            this.dataNoDevueltos.AllowUserToOrderColumns = true;
            this.dataNoDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNoDevueltos.Location = new System.Drawing.Point(476, 28);
            this.dataNoDevueltos.Name = "dataNoDevueltos";
            this.dataNoDevueltos.Size = new System.Drawing.Size(808, 219);
            this.dataNoDevueltos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lista de Prestamos";
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToOrderColumns = true;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Location = new System.Drawing.Point(12, 300);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.Size = new System.Drawing.Size(1058, 265);
            this.dataPrestamos.TabIndex = 14;
            // 
            // texCodigo
            // 
            this.texCodigo.Location = new System.Drawing.Point(115, 61);
            this.texCodigo.Name = "texCodigo";
            this.texCodigo.Size = new System.Drawing.Size(305, 20);
            this.texCodigo.TabIndex = 1;
            // 
            // texCarnet
            // 
            this.texCarnet.Location = new System.Drawing.Point(115, 26);
            this.texCarnet.Name = "texCarnet";
            this.texCarnet.Size = new System.Drawing.Size(305, 20);
            this.texCarnet.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 577);
            this.Controls.Add(this.dataPrestamos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataNoDevueltos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNoDevueltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataNoDevueltos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataPrestamos;
        private System.Windows.Forms.TextBox texCarnet;
        private System.Windows.Forms.TextBox texCodigo;
    }
}

