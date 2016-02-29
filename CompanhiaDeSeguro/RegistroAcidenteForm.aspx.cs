using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using ClassLibrary;

namespace CompanhiaDeSeguro
{
    public partial class RegistroAcidenteForm : System.Web.UI.Page
    {
        RegistroAcidenteClass registro = new RegistroAcidenteClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (CarroClass item in BancoDeDados.carros)
                {
                    ddlCarro.Items.Add("renavam "+item.Renavam);
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            registro.Local = txtLocal.Text;
            registro.Data = txtData.Text;
            registro.Valor = txtValor.Text;
            registro.Cliente = BancoDeDados.CarroCliente(ddlCarro.Text);
            registro.Carro = ddlCarro.Text;
            BancoDeDados.setRegistro(registro);
            txtValor.Text = "";
            txtData.Text = "";
            txtLocal.Text = "";
            UpdatePanel2.Update();
        }
    }
}
