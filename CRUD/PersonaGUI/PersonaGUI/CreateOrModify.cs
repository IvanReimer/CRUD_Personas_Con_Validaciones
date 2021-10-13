using Entidades.LogicaContrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PersonaGUI
{
    public partial class CreateOrModify : Form
    {
        bool isCreate;
        API api;
        double id;
        private CreateOrModify()
        {
            InitializeComponent();
            api = new API();
        }
        public CreateOrModify(string frmTxt, string btnTxt, bool isCreate, double id) : this()
        {
            this.BirthTxtBox.Text = "dd/mm/aaaa";
            this.CreateOrMofifyBtn.Text = btnTxt;
            this.Text = frmTxt;
            this.isCreate = isCreate;
            this.id = id;
        }

        private void CreateOrMofifyBtn_Click(object sender, EventArgs e)
        {
            if (isCreate)
            {
                try
                {
                    api.CreateOrModify(this.idTxtBox.Text, this.nameTxtBox.Text, this.surNameTxtBox.Text, this.BirthTxtBox.Text, this.GenderTxtBox.Text,true);
                    MessageBox.Show("Persona creada con éxito", "Alta creada", MessageBoxButtons.OK);
                    api.CloseDataBase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al crear persona", MessageBoxButtons.OK);
                }
                finally
                {
                    api.CloseDataBase();
                    this.Dispose();
                }
            }
            else
            {
                try
                {
                    api.CreateOrModify(this.id.ToString(), this.nameTxtBox.Text, this.surNameTxtBox.Text, this.BirthTxtBox.Text, this.GenderTxtBox.Text, false);
                    MessageBox.Show("Persona modificada con éxito", "Alta creada", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al crear persona", MessageBoxButtons.OK);
                }
                finally
                {
                    api.CloseDataBase();
                }
            }

        }
        private void CreateOrModify_Load(object sender, EventArgs e)
        {
            if (!this.isCreate)
            {
                this.idTxtBox.Hide();
                this.dniLbl.Text = this.id.ToString();
                //this.surNameTxtBox.Text = api.TakeOut("apellido", this.id);
                //this.nameTxtBox.Text = api.TakeOut("nombre", this.id);
                //this.BirthTxtBox.Text = api.TakeOut("nacimiento", this.id);
                //this.GenderTxtBox.Text = api.TakeOut("genero", this.id);
            }
        }
    }
}
