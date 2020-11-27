using NLayer_Datos;
using NLayer_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;

        public  ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TrarTodos();
            return result;
        }

        public int InsertarCliente(string Nombre, string Apellido, string Direccion)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = Nombre;
            cliente.Apellido = Apellido;
            cliente.Direccion = Direccion;

            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un error en la peticion al servidor" + resultante.Error);
            }
        }

        internal bool Existe(int idCliente)
        {
            List<Cliente> lst = TraerClientes();
            foreach (Cliente c in lst)
            {
                if (c.Id == c.id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
