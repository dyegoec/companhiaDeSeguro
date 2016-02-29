using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class BancoDeDados
    {
        public static List<ClienteClass> clientes = new List<ClienteClass>();
            public static List<CarroClass> carros = new List<CarroClass>();
        public static List<RegistroAcidenteClass> registros = new List<RegistroAcidenteClass>();

        public static ClienteClass ListarClientes(int i)
        {
            return clientes.ElementAt(i);
        }

        public static void setCliente(ClienteClass cliente)
        {
            clientes.Add(cliente);
        }

        public static CarroClass ListarCarros(int i)
        {
            return carros.ElementAt(i);
        }

        public static void setCarro(CarroClass carro)
        {
            carros.Add(carro);
        }

        public static RegistroAcidenteClass ListarRegistros(int i)
        {
            return registros.ElementAt(i);
        }

        public static void setRegistro(RegistroAcidenteClass registro)
        {
            registros.Add(registro);
        }

        public static string CarroCliente(string renavam)
        {
            foreach (CarroClass item in BancoDeDados.carros)
	        {
                string temp = "renavam " + item.Renavam;
		        if (temp.Equals(renavam)) {
                    return item.Cliente;
                }
            }
            return null;
        }
    }
}
