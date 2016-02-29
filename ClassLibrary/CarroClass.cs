using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class CarroClass
    {
        #region atributos

        string marca;
        string modelo;
        string ano;
        string cor;
        string renavam;
        string cliente;

        #endregion

        #region 

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Renavam
        {
            get { return renavam; }
            set { renavam = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        #endregion
    }
}
