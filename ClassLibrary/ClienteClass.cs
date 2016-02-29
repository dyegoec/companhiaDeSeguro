using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ClienteClass
    {
        #region atributos

        string nome;
        string endereco;
        string carteiraMotorista;

        #endregion

        #region propriedades

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string CarteiraMotorista
        {
            get { return carteiraMotorista; }
            set { carteiraMotorista = value; }
        }

        #endregion
    }
}