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
    public partial class VisualizarCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BancoDeDados.carros.Count; i++)
            {
                string marca = BancoDeDados.ListarCarros(i).Marca;
                string modelo = BancoDeDados.ListarCarros(i).Modelo;
                string ano = BancoDeDados.ListarCarros(i).Ano;
                string cor = BancoDeDados.ListarCarros(i).Cor;
                string renavam = BancoDeDados.ListarCarros(i).Renavam;
                string cliente = BancoDeDados.ListarCarros(i).Cliente;
                Label1.Text += "<br/><br/>Marca: " + marca + "<br/>Modelo: " + modelo
                    + "<br/>Ano: " + ano + "<br/>Cor: " + cor + "<br/>Renavam: " + renavam
                    + "<br/>Cliente: " + cliente;
            }
        }
    }
}
