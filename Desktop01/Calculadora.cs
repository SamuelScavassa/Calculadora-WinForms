using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop01
{
    public class Calculadora
    {
        public double NumUm { get; set; }
        public double NumDois { get; set; }

     

        public Calculadora()
        {

        }

        public double Soma()
        {
            return NumUm + NumDois;
        }

        public double Sub()
        {
            return NumUm - NumDois;
        }

        public double Mult()
        {
            return NumUm * NumDois;
        }

        public double Div()
        {
            return NumUm / NumDois;
        }

    }
}
