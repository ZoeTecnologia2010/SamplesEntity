using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SampleSystem
{
    public partial class frmEditDentist : MetroFramework.Forms.MetroForm
    {
        public string status;
        Dentist obj = new Dentist();
        DentistService service = new DentistService();

        public frmEditDentist(Dentist obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Dentist objP)
        {
            this.obj = objP;
            lblCodigo.Text = this.obj.Id.ToString();
            txtName.Text = this.obj.Name;
            txtEmail.Text = this.obj.Email;
            txtPhone.Text = this.obj.Phone.ToString();
            txtCellphone.Text = this.obj.Cellphone.ToString();
            txtNumber.Text = this.obj.Number;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            ts.Text = ValidarCad();
            if(ts.Text == "Success")
            {
                if(lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "delete";
                    MessageBox.Show("This record was deleted");
                }
                else
                {
                    status = "edit";
                    this.obj.Name = txtName.Text;
                    this.obj.Email = txtEmail.Text;
                    obj.Phone = txtPhone.Text != "" ? Convert.ToInt64(txtPhone.Text) : 0;
                    obj.Cellphone = txtCellphone.Text != "" ? Convert.ToInt64(txtCellphone.Text) : 0;
                    this.obj.Number = txtNumber.Text;
                    service.Editar(this.obj);
                    this.Close();
                }
            }

        }


        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtName.Text == string.Empty)
            {
                return "Imput Name!";
            }
            else if (txtCellphone.Text == string.Empty)
            {
                return "Imput Cellphone";
            }
            else if (txtPhone.Text == string.Empty)
            {
                return "Imput Phone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Imput Email";
            }
            else if (txtNumber.Text == string.Empty)
            {
                return "Imput Number";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Success";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            if (ValidarExclusao())
            {
                service.Deletar(this.obj.Id);
                MessageBox.Show("This record was deleted!");
                status = "delete";
                this.Close();
            }
        }

        public bool ValidarExclusao()
        {
            DialogResult con = MessageBox.Show("Do you delete this record?", "Exclude", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }

    }
}
