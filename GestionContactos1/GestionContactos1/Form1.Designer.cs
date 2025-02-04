namespace GestionContactos1
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
            this.btnAñadirCont = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.btnMostrarContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAñadirCont
            // 
            this.btnAñadirCont.Location = new System.Drawing.Point(45, 53);
            this.btnAñadirCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirCont.Name = "btnAñadirCont";
            this.btnAñadirCont.Size = new System.Drawing.Size(211, 80);
            this.btnAñadirCont.TabIndex = 1;
            this.btnAñadirCont.Text = "Añadir contacto";
            this.btnAñadirCont.UseVisualStyleBackColor = true;
            this.btnAñadirCont.Click += new System.EventHandler(this.btnAñadirCont_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Location = new System.Drawing.Point(45, 177);
            this.btnEliminarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(211, 78);
            this.btnEliminarContacto.TabIndex = 2;
            this.btnEliminarContacto.Text = "Eliminar contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(47, 302);
            this.btnModificarContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(209, 84);
            this.btnModificarContacto.TabIndex = 3;
            this.btnModificarContacto.Text = "Modificar teléfono";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // btnMostrarContacto
            // 
            this.btnMostrarContacto.Location = new System.Drawing.Point(530, 168);
            this.btnMostrarContacto.Name = "btnMostrarContacto";
            this.btnMostrarContacto.Size = new System.Drawing.Size(240, 97);
            this.btnMostrarContacto.TabIndex = 4;
            this.btnMostrarContacto.Text = "Mostrar Contacto";
            this.btnMostrarContacto.UseVisualStyleBackColor = true;
            this.btnMostrarContacto.Click += new System.EventHandler(this.btnMostrarContacto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 554);
            this.Controls.Add(this.btnMostrarContacto);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.btnEliminarContacto);
            this.Controls.Add(this.btnAñadirCont);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadirCont;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.Button btnMostrarContacto;
    }
}

