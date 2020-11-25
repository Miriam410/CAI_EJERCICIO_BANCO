using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class Cuenta
    {
        private int _nroCuenta;

        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private float _saldo;

        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private DateTime _fechaApertura;

        public DateTime FechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }

        private DateTime _fechaModificacion;

        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        private bool _activo;

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        private int _idCliente;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

       
    }
}
