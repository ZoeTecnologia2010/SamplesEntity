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
    public partial class frmCadDentist : MetroFramework.Forms.MetroForm
    {

        DentistService service = new DentistService();


        public frmCadDentist()
        {
            InitializeComponent();
            txtName.Text = txtCellphone.Text;
        }

        private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if(txtName.Text == string.Empty)
            {
                return "Input Name!";
            }else if(txtCellphone.Text == string.Empty)
            {
                return "Input Cellphone";
            }
            else if (txtPhone.Text == string.Empty)
            {
                return "Input Phone";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Input Email";
            }
            else if (txtNumber.Text == string.Empty)
            {
                return "Input Number";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tsNenhuma.Text = "";
            try
            {
                ts.Text = ValidarCad();
                if(ts.Text == "Success")
                {
                    service.Cadastrar(objGerado());
                    MessageBox.Show("Record salved!");
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public Dentist objGerado()
        {
            Dentist obj = new Dentist();
            obj.Name = txtName.Text;
            obj.Email = txtEmail.Text;
            obj.Phone = txtPhone.Text != "" ? Convert.ToInt64(txtPhone.Text) : 0;
            obj.Cellphone = txtCellphone.Text != "" ? Convert.ToInt64(txtCellphone.Text) : 0;
            obj.Number = txtNumber.Text;

            return obj;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            frmConDentist frm = new frmConDentist();
            frm.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCellphone.Text = string.Empty;
        }
    }
}
