using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocios
{
    public class APagar
    {
        private DateTime fecha;
        private int montoTotal;
        private bool pago;

       /* public int MontoTotal //esto modificarlo para que sea recorrer el array de activs del socio y guardar el valor en la var
        {
            set
            {
                nota2 = value;
            }
            get
            {
                return nota2;
            }
        }
        */
        public bool Pago
        {
            set
            {
                pago = value;
            }
            get
            {
                return pago;
            }
        }

        public DateTime Fecha
        {
            set
            {
                fecha = value;
            }
            get
            {
                return fecha;
            }
        }



    }
}
