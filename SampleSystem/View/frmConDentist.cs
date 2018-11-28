using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using WcfService;

namespace SampleSystem
{
    public partial class frmConDentist : MetroFramework.Forms.MetroForm
    {
        DentistService service = new DentistService();

        public frmConDentist()
        {
            InitializeComponent();
            IniciarForm();
        }

        public void IniciarForm()
        {
            var lista = service.Listar();
            if(lista == null)
            {
                MessageBox.Show("Não existem Dentists cadastrados");
            }
            else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach(var dado in lista)
                {
                    char primeiraLetra = dado.Name.Trim()[0]; 
                    if(primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela = numTabela + 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }

                    letraAnterior = primeiraLetra;
                }
               
            }
        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Name";

            link.Name = "Name";
            dg.Columns.Add(link);

            dg.Columns.Add("Phone", "Phone");
            dg.Columns.Add("Cellphone", "Cellphone");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tb_click);
            
        }

       

        private void GerarLinha(DataGridView data, Dentist dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.Id;
            data.Rows[linhaAtual].Cells[1].Value = dado.Name;
            data.Rows[linhaAtual].Cells[2].Value = dado.Phone.ToString("(00) 0000-0000");
            data.Rows[linhaAtual].Cells[3].Value = dado.Cellphone.ToString("(00) 00000-0000");
        }



        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if(e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    Dentist obj = service.Buscar(Convert.ToInt32(id));

                    var form = new frmEditDentist(obj);
                    form.ShowDialog();
                    
                    if(form.status == "apagado")
                    {
                        this.Close();
                        frmConDentist frm = new frmConDentist();
                        frm.ShowDialog();
                    }
                    if(form.status == "editado")
                    {
                        dg.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dg, obj);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao selecionar o Dentist " + ex.Message);
            }
        }
    }
}
