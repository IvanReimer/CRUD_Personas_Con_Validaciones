using Entidades.DAL.DataProvider;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PersonaGUI
{
    public partial class PersonaGUI : Form
    {
        
        public PersonaGUI()
        {
            InitializeComponent();
        }
        private void MostrarBtn_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            show.ShowDialog();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IdSeeker delete = new IdSeeker("Eliminar", "DNI a eliminar", "Eliminacion", true);
                delete.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar persona", MessageBoxButtons.OK);
            }            
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            CreateOrModify create = new CreateOrModify("Alta","Crear",true,0);
            create.ShowDialog();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IdSeeker delete = new IdSeeker("Modificar", "DNI a modificar", "Modificación",false);
                delete.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al encontrar el DNI de la persona", MessageBoxButtons.OK);
            }
        }
    }
}
