using ProjetoMVCD26.BLL;
using ProjetoMVCD26.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD26.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Cpf_cliente = txtCpfD26.Text;
                cliente.Nome_cliente = txtNomeD26.Text;
                cliente.Nome_Mae = txtNomeMaeD26.Text;
                tblClienteBLL bllcliente = new tblClienteBLL();
                if(bllcliente.consultarBeneficio(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_Mae))
                {
                    lblAlertaD26.Visible = true;
                    lblAlertaD26.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    lblAlertaD26.Visible = true;
                    lblAlertaD26.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }catch (Exception ex)
            {
                lblAlertaD26.Visible = true;
                lblAlertaD26.Text = ex.Message;
            }
        }
    }
}