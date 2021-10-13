
namespace PersonaGUI
{
    partial class CreateOrModify
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
            this.dniLbl = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.CreateOrMofifyBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderTxtBox = new System.Windows.Forms.TextBox();
            this.BirthTxtBox = new System.Windows.Forms.TextBox();
            this.surNameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dniLbl
            // 
            this.dniLbl.AutoSize = true;
            this.dniLbl.Location = new System.Drawing.Point(67, 70);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(31, 17);
            this.dniLbl.TabIndex = 0;
            this.dniLbl.Text = "DNI";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(34, 106);
            this.idTxtBox.Multiline = true;
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 32);
            this.idTxtBox.TabIndex = 1;
            // 
            // CreateOrMofifyBtn
            // 
            this.CreateOrMofifyBtn.Location = new System.Drawing.Point(341, 213);
            this.CreateOrMofifyBtn.Name = "CreateOrMofifyBtn";
            this.CreateOrMofifyBtn.Size = new System.Drawing.Size(109, 45);
            this.CreateOrMofifyBtn.TabIndex = 2;
            this.CreateOrMofifyBtn.Text = "Crear";
            this.CreateOrMofifyBtn.UseVisualStyleBackColor = true;
            this.CreateOrMofifyBtn.Click += new System.EventHandler(this.CreateOrMofifyBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(226, 70);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(58, 17);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Nombre";
            // 
            // surNameLbl
            // 
            this.surNameLbl.AutoSize = true;
            this.surNameLbl.Location = new System.Drawing.Point(382, 70);
            this.surNameLbl.Name = "surNameLbl";
            this.surNameLbl.Size = new System.Drawing.Size(58, 17);
            this.surNameLbl.TabIndex = 4;
            this.surNameLbl.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // GenderTxtBox
            // 
            this.GenderTxtBox.Location = new System.Drawing.Point(663, 106);
            this.GenderTxtBox.Multiline = true;
            this.GenderTxtBox.Name = "GenderTxtBox";
            this.GenderTxtBox.Size = new System.Drawing.Size(100, 32);
            this.GenderTxtBox.TabIndex = 7;
            // 
            // BirthTxtBox
            // 
            this.BirthTxtBox.Location = new System.Drawing.Point(517, 106);
            this.BirthTxtBox.Multiline = true;
            this.BirthTxtBox.Name = "BirthTxtBox";
            this.BirthTxtBox.Size = new System.Drawing.Size(100, 32);
            this.BirthTxtBox.TabIndex = 8;
            // 
            // surNameTxtBox
            // 
            this.surNameTxtBox.Location = new System.Drawing.Point(365, 106);
            this.surNameTxtBox.Multiline = true;
            this.surNameTxtBox.Name = "surNameTxtBox";
            this.surNameTxtBox.Size = new System.Drawing.Size(100, 32);
            this.surNameTxtBox.TabIndex = 9;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(205, 106);
            this.nameTxtBox.Multiline = true;
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 32);
            this.nameTxtBox.TabIndex = 10;
            // 
            // CreateOrModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 336);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.surNameTxtBox);
            this.Controls.Add(this.BirthTxtBox);
            this.Controls.Add(this.GenderTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surNameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.CreateOrMofifyBtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.dniLbl);
            this.Name = "CreateOrModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.CreateOrModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Button CreateOrMofifyBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenderTxtBox;
        private System.Windows.Forms.TextBox BirthTxtBox;
        private System.Windows.Forms.TextBox surNameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
    }
}