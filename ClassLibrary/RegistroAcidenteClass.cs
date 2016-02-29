using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class RegistroAcidenteClass
    {
        #region atributos

        string local;
        string data;
        string valor;
        string carro;
        string cliente;

        #endregion

        #region propriedades

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Carro
        {
            get { return carro; }
            set { carro = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        #endregion
    }
}
