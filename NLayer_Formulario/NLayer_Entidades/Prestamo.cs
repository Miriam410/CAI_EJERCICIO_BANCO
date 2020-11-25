using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class Prestamo
    {
        private double _tna;

        public  double Tna
        {
            get { return _tna; }
            set { _tna = value; }
        }

        private string _linea

        public string _linea Linea
        {
            get { return _linea; }
            set { _linea = value; }
        }

        private int _plazo;

        public int Plazo
        {
            get { return _plazo; }
            set { _plazo = value; }
        }

        private double _monto;

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }


    }
}
