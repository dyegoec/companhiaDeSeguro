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
    public partial class VisualizarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BancoDeDados.clientes.Count; i++)
            {
                string nome = BancoDeDados.ListarClientes(i).Nome;
                string endereco = BancoDeDados.ListarClientes(i).Endereco;
                string carteira = BancoDeDados.ListarClientes(i).CarteiraMotorista;
                Label1.Text += "<br/><br/>Nome: " + nome + "<br/>Endereco: " + endereco
                    + "<br/>Carteira de motorista: " + carteira;
            }
        }
    }
}
