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
    public partial class CarroForm1 : System.Web.UI.Page
    {
        CarroClass carro = new CarroClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (ClienteClass item in BancoDeDados.clientes)
                {
                    ddlCliente.Items.Add(item.Nome + " (Carteira de motorista " + item.CarteiraMotorista + ")");
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            carro.Marca = txtMarca.Text;
            carro.Modelo = txtModelo.Text;
            carro.Ano = txtAno.Text;
            carro.Cor = txtCor.Text;
            carro.Renavam = txtRenavam.Text;
            carro.Cliente = ddlCliente.Text;
            BancoDeDados.setCarro(carro);
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtCor.Text = "";
            txtRenavam.Text = "";
            UpdatePanel1.Update();


        }
    }
}
