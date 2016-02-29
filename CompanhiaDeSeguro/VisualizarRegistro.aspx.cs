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
    public partial class VisualizarRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BancoDeDados.registros.Count; i++)
            {
                string local = BancoDeDados.ListarRegistros(i).Local;
                string data = BancoDeDados.ListarRegistros(i).Data;
                string valor = BancoDeDados.ListarRegistros(i).Valor;
                string carro = BancoDeDados.ListarRegistros(i).Carro;
                string cliente = BancoDeDados.ListarRegistros(i).Cliente;
                Label1.Text += "<br/><br/>Local: " + local + "<br/>Data: " + data
                    + "<br/>Valor: " + valor + "<br/>Carro: " + carro
                    + "<br/>Cliente: " + cliente + "<br/>";
            }
        }
    }
}
