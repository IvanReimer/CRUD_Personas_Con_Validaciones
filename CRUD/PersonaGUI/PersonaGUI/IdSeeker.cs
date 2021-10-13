using System;
using System.Windows.Forms;
using Entidades.LogicaContrato;
namespace PersonaGUI
{
    public partial class IdSeeker : Form
    {
        API api;
        bool isDeletion;
        private IdSeeker()
        {
            InitializeComponent();
        }
        public IdSeeker(string btnText, string lblText, string formText, bool isDeletion) : this()
        {
            api = new API();
            this.seekBtn.Text = btnText;
            this.idLbl.Text = lblText;
            this.isDeletion = isDeletion;
        }
        private void seekBtn_Click(object sender, EventArgs e)
        {
            double dni;
            if (isDeletion)
            {
                if (double.TryParse(this.idTxtBox.Text, out dni))
                {
                    try
                    {
                        if (api.Delete(dni))
                        {
                            MessageBox.Show("Persona de DNI: " + dni + " eliminada", "Operacion exitosa", MessageBoxButtons.OK);
                            api.CloseDataBase();
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI debe tener numeros mayores que el 0");
                }
            }
            else
            {
                if (double.TryParse(this.idTxtBox.Text, out dni) && this.api.IdIsCreated(dni))
                {
                    CreateOrModify modify = new CreateOrModify("Modificar Persona", "Modificar", false, dni);
                    if (modify.ShowDialog() == DialogResult.OK)
                    {
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("El DNI debe ser nro mayor a 0 y estar en la base de datos para mostrarse");
                    this.Dispose();
                }
            }

        }
    }
}
