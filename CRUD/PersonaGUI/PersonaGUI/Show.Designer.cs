
namespace PersonaGUI
{
    partial class Show
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
            this.PersonaDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaDataGrid
            // 
            this.PersonaDataGrid.AllowUserToAddRows = false;
            this.PersonaDataGrid.AllowUserToDeleteRows = false;
            this.PersonaDataGrid.AllowUserToOrderColumns = true;
            this.PersonaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.PersonaDataGrid.Name = "PersonaDataGrid";
            this.PersonaDataGrid.ReadOnly = true;
            this.PersonaDataGrid.RowHeadersWidth = 51;
            this.PersonaDataGrid.RowTemplate.Height = 24;
            this.PersonaDataGrid.Size = new System.Drawing.Size(800, 450);
            this.PersonaDataGrid.TabIndex = 0;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonaDataGrid);
            this.Name = "Show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonaDataGrid;
    }
}