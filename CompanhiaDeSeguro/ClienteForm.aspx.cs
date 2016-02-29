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
using System.Collections.Generic;

namespace CompanhiaDeSeguro
{
    public partial class CarroForm : System.Web.UI.Page
    {
        ClienteClass cliente = new ClienteClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }        

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.CarteiraMotorista = txtCarteira.Text;
            BancoDeDados.setCliente(cliente);
            txtNome.Text = "";
            txtCarteira.Text = "";
            txtEndereco.Text = "";
            UpdatePanel2.Update();
        }
    }
}
