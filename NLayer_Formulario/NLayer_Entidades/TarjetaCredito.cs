using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class TarjetaCredito
    {
        private int _tipo;

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private int _periodoVencimiento;

        public int PeriodoVencimiento
        {
            get { return _periodoVencimiento; }
            set { _periodoVencimiento = value; }
        }

        private double _limiteCompra;

        public double LimiteCompra
        {
            get { return _limiteCompra; }
            set { _limiteCompra = value; }
        }

        private string _nroPlastico;

        public string NroPlastico
        {
            get { return _nroPlastico; }
            set { _nroPlastico = value; }
        }

        private int _idCliemte;

        public int IdCliente
        {
            get { return _idCliemte; }
            set { _idCliemte = value; }
        }

    }
}
