namespace GestionTareasPendiente
{
    partial class GestionTareasPendientes
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTarea.Location = new System.Drawing.Point(127, 17);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(100, 20);
            this.txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTarea.Location = new System.Drawing.Point(101, 43);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.Red;
            this.btnEliminarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTarea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTarea.Location = new System.Drawing.Point(32, 173);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(144, 23);
            this.btnEliminarTarea.TabIndex = 2;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(117, 72);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(120, 95);
            this.lstTareas.TabIndex = 4;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarLista.Location = new System.Drawing.Point(182, 173);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(119, 23);
            this.btnLimpiarLista.TabIndex = 5;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // GestionTareasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.txtTarea);
            this.Name = "GestionTareasPendientes";
            this.Text = "Gestion Tareas Pendientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}

