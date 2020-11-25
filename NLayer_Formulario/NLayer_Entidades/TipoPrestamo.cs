using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class TipoPrestamo
    {
        private int _tna;

        public int Tna
        {
            get { return _tna; }
            set { _tna = value; }
        }

        private string _linea;

        public string Linea
        {
            get { return _linea; }
            set { _linea = value; }
        }


    }
}
