using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLayer_Entidades;

namespace NLayer_Datos
{
    public class CuentaMapper
    {
        public Cuenta Traer(int idCliente)
        {
            string json = WebHelper.Get("/cuenta"+ idCliente.ToString());
            Cuenta resultado = Map(json);
            return resultado;
        }

        private Cuenta Map(string json)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json);
            return lst;
        }

        // insertar
        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "insert");
            string result = WebHelper.Post("/cuenta",obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        // actualizar
        public TransactionResult Update(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta, "update");
            string result = WebHelper.Post("/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        // inserta o actualiza
        private NameValueCollection ReverseMap(Cuenta cuenta, string tipo)
        {
            NameValueCollection n = new NameValueCollection();
            if (tipo == "insert")
            {
                n.Add("idCliente", cuenta.IdCliente.ToString()); // es un int
                n.Add("Descripcion", cuenta.Descripcion);
            }
            else if (tipo == "update")
            {
                n.Add("id", cuenta.IdCliente.ToString()); // es un int
                n.Add("Descripcion", cuenta.Saldo.ToString()); //es float o double
            }
            return n;
        }


        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
