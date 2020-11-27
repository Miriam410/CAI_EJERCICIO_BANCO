using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NLayer_Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int _nroCuenta;
        [DataMember]
        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }

        private string _descripcion;
        [DataMember]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private float _saldo;
        [DataMember]
        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private DateTime _fechaApertura;
        [DataMember]
        public DateTime FechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }

        private DateTime _fechaModificacion;
        [DataMember]
        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        private bool _activo;
        [DataMember]
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        private int _idCliente;
        [DataMember]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public override string ToString()
        {
            return string.Format("({0}) Cuenta Nro{1} / Saldo {2}", this.IdCliente, this.NroCuenta, this.Saldo.ToString("0.00"));
        }
    }
}
