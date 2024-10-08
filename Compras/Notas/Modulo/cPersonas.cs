using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notas.Modulo
{
    class cPersonas
    {
        private string Productos;

        public string pProductos
        {
            get { return Productos; }
            set { Productos = value; }
        }
        private int PrecioUnitario;

        public int pPrecioUnitario
        {
            get { return PrecioUnitario; }
            set { PrecioUnitario = value; }
        }
        private int Cantidad;

        public int pCantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        private int total;

        public int pTotal
        {
            get { return total; }
            set { total = value; }
        }
         public cPersonas() 
        {
        }
            public int Total ()
            {
                int total = this.PrecioUnitario * this.Cantidad;
                return total;
           }
        }
    }