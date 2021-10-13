
namespace PersonaGUI
{
    partial class IdSeeker
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
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.seekBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(168, 117);
            this.idTxtBox.Multiline = true;
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 30);
            this.idTxtBox.TabIndex = 0;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(172, 83);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(96, 17);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "DNI a eliminar";
            // 
            // seekBtn
            // 
            this.seekBtn.Location = new System.Drawing.Point(168, 173);
            this.seekBtn.Name = "seekBtn";
            this.seekBtn.Size = new System.Drawing.Size(100, 35);
            this.seekBtn.TabIndex = 2;
            this.seekBtn.Text = "Eliminar";
            this.seekBtn.UseVisualStyleBackColor = true;
            this.seekBtn.Click += new System.EventHandler(this.seekBtn_Click);
            // 
            // IdSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 281);
            this.Controls.Add(this.seekBtn);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBox);
            this.Name = "IdSeeker";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button seekBtn;
    }
}