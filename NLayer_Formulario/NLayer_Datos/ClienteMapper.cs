using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLayer_Entidades;

namespace NLayer_Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TrarTodos()
        {
            string json = WebHelper.Get("/cliente");
            List<Cliente> resultado = MapList(json);
            return resultado;
        }

        public List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("cliente", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        // completado mayuscula minuscula segun el swagger
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("DNI",cliente.Dni.ToString()); //es un int
            n.Add("Nombre",cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion",cliente.Direccion);
            n.Add("Email",cliente.Email);
            n.Add("Telefono",cliente.Telefono);
            n.Add("FechaNacimiento",cliente.FechaNacimiento.ToString("yyyy-MM-dd")); //es una fecha
            n.Add("FechaAlta",cliente.FechaAlta.ToString("yyyy-MM-dd")); // es una fecha
            n.Add("Activo",cliente.Activo.ToString()); // es un bool
            n.Add("id",cliente.Id.ToString()); //es un int
            n.Add("Usuario",ConfigurationManager.AppSettings["Legajo"]);
            return n;
        }



        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }

}
