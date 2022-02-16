
namespace DatosAlumnoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpNuevoAlumno = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombrePadre = new System.Windows.Forms.TextBox();
            this.txtTelPadre = new System.Windows.Forms.TextBox();
            this.txtNombreMadre = new System.Windows.Forms.TextBox();
            this.txtTelMadre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombrePadre = new System.Windows.Forms.Label();
            this.lblTelPadre = new System.Windows.Forms.Label();
            this.lblNombreMadre = new System.Windows.Forms.Label();
            this.lblTelMadre = new System.Windows.Forms.Label();
            this.grpNuevoAlumno.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(112, 12);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 29);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // grpNuevoAlumno
            // 
            this.grpNuevoAlumno.Controls.Add(this.label7);
            this.grpNuevoAlumno.Controls.Add(this.label6);
            this.grpNuevoAlumno.Controls.Add(this.label5);
            this.grpNuevoAlumno.Controls.Add(this.label4);
            this.grpNuevoAlumno.Controls.Add(this.label3);
            this.grpNuevoAlumno.Controls.Add(this.label2);
            this.grpNuevoAlumno.Controls.Add(this.label1);
            this.grpNuevoAlumno.Controls.Add(this.btnGuardar);
            this.grpNuevoAlumno.Controls.Add(this.btnCancelar);
            this.grpNuevoAlumno.Controls.Add(this.txtTelMadre);
            this.grpNuevoAlumno.Controls.Add(this.txtNombreMadre);
            this.grpNuevoAlumno.Controls.Add(this.txtTelPadre);
            this.grpNuevoAlumno.Controls.Add(this.txtNombrePadre);
            this.grpNuevoAlumno.Controls.Add(this.txtDomicilio);
            this.grpNuevoAlumno.Controls.Add(this.dtpNacimiento);
            this.grpNuevoAlumno.Controls.Add(this.txtNombre);
            this.grpNuevoAlumno.Enabled = false;
            this.grpNuevoAlumno.Location = new System.Drawing.Point(30, 86);
            this.grpNuevoAlumno.Name = "grpNuevoAlumno";
            this.grpNuevoAlumno.Size = new System.Drawing.Size(485, 313);
            this.grpNuevoAlumno.TabIndex = 2;
            this.grpNuevoAlumno.TabStop = false;
            this.grpNuevoAlumno.Text = "Nuevo Alumno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(311, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(168, 59);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(311, 27);
            this.dtpNacimiento.TabIndex = 1;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(168, 92);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(311, 27);
            this.txtDomicilio.TabIndex = 2;
            // 
            // txtNombrePadre
            // 
            this.txtNombrePadre.Location = new System.Drawing.Point(168, 125);
            this.txtNombrePadre.Name = "txtNombrePadre";
            this.txtNombrePadre.Size = new System.Drawing.Size(311, 27);
            this.txtNombrePadre.TabIndex = 3;
            // 
            // txtTelPadre
            // 
            this.txtTelPadre.Location = new System.Drawing.Point(168, 158);
            this.txtTelPadre.Name = "txtTelPadre";
            this.txtTelPadre.Size = new System.Drawing.Size(311, 27);
            this.txtTelPadre.TabIndex = 4;
            // 
            // txtNombreMadre
            // 
            this.txtNombreMadre.Location = new System.Drawing.Point(168, 191);
            this.txtNombreMadre.Name = "txtNombreMadre";
            this.txtNombreMadre.Size = new System.Drawing.Size(311, 27);
            this.txtNombreMadre.TabIndex = 5;
            // 
            // txtTelMadre
            // 
            this.txtTelMadre.Location = new System.Drawing.Point(168, 224);
            this.txtTelMadre.Name = "txtTelMadre";
            this.txtTelMadre.Size = new System.Drawing.Size(311, 27);
            this.txtTelMadre.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(385, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(285, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre del padre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tel. del padre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre de la madre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tel. de la madre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTelMadre);
            this.groupBox2.Controls.Add(this.lblNombreMadre);
            this.groupBox2.Controls.Add(this.lblTelPadre);
            this.groupBox2.Controls.Add(this.lblNombrePadre);
            this.groupBox2.Controls.Add(this.lblDomicilio);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Location = new System.Drawing.Point(531, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 307);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(11, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(482, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = " ";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(11, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(482, 25);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = " ";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(11, 95);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(482, 25);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = " ";
            // 
            // lblNombrePadre
            // 
            this.lblNombrePadre.Location = new System.Drawing.Point(11, 128);
            this.lblNombrePadre.Name = "lblNombrePadre";
            this.lblNombrePadre.Size = new System.Drawing.Size(482, 25);
            this.lblNombrePadre.TabIndex = 3;
            this.lblNombrePadre.Text = " ";
            // 
            // lblTelPadre
            // 
            this.lblTelPadre.Location = new System.Drawing.Point(11, 158);
            this.lblTelPadre.Name = "lblTelPadre";
            this.lblTelPadre.Size = new System.Drawing.Size(482, 25);
            this.lblTelPadre.TabIndex = 4;
            this.lblTelPadre.Text = " ";
            // 
            // lblNombreMadre
            // 
            this.lblNombreMadre.Location = new System.Drawing.Point(11, 194);
            this.lblNombreMadre.Name = "lblNombreMadre";
            this.lblNombreMadre.Size = new System.Drawing.Size(482, 25);
            this.lblNombreMadre.TabIndex = 5;
            this.lblNombreMadre.Text = " ";
            // 
            // lblTelMadre
            // 
            this.lblTelMadre.Location = new System.Drawing.Point(11, 231);
            this.lblTelMadre.Name = "lblTelMadre";
            this.lblTelMadre.Size = new System.Drawing.Size(482, 25);
            this.lblTelMadre.TabIndex = 6;
            this.lblTelMadre.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpNuevoAlumno);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpNuevoAlumno.ResumeLayout(false);
            this.grpNuevoAlumno.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox grpNuevoAlumno;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelMadre;
        private System.Windows.Forms.TextBox txtNombreMadre;
        private System.Windows.Forms.TextBox txtTelPadre;
        private System.Windows.Forms.TextBox txtNombrePadre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTelMadre;
        private System.Windows.Forms.Label lblNombreMadre;
        private System.Windows.Forms.Label lblTelPadre;
        private System.Windows.Forms.Label lblNombrePadre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lbl;
    }
}

