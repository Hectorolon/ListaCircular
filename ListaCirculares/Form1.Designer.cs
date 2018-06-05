namespace ListaCirculares
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Fin";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(75, 54);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(55, 20);
            this.txtInicio.TabIndex = 4;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(75, 96);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(55, 20);
            this.txtFin.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(253, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(253, 100);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(75, 143);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrar.Size = new System.Drawing.Size(357, 151);
            this.txtMostrar.TabIndex = 10;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(253, 42);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bnBuscar.TabIndex = 13;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(334, 44);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(98, 20);
            this.txtBuscar.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(253, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(334, 73);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(98, 20);
            this.txtEliminar.TabIndex = 16;
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(441, 14);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarInicio.TabIndex = 17;
            this.btnEliminarInicio.Text = "Eliminar Inicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Eliminar Ultimo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button button1;
    }
}

