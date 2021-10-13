
namespace PersonaGUI
{
    partial class PersonaGUI
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
            this.MostrarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MostrarBtn
            // 
            this.MostrarBtn.Location = new System.Drawing.Point(84, 21);
            this.MostrarBtn.Name = "MostrarBtn";
            this.MostrarBtn.Size = new System.Drawing.Size(81, 34);
            this.MostrarBtn.TabIndex = 0;
            this.MostrarBtn.Text = "Mostrar";
            this.MostrarBtn.UseVisualStyleBackColor = true;
            this.MostrarBtn.Click += new System.EventHandler(this.MostrarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(272, 21);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(79, 34);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(470, 21);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(79, 34);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(657, 21);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(79, 34);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // PersonaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.MostrarBtn);
            this.Name = "PersonaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button EliminarBtn;
    }
}

