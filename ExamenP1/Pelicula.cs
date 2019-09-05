using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    class Pelicula
    {
        public string Titulo { get; set; }

        private int _Año;

        public int Año
        {
            get
            {
                return _Año;
            }
            set
            {
                if (value >= 2019 )
                {
                    _Año = value;

                }
                else
                {
                    throw new Exception("El valor tiene que ser mayor a 2019");
                }

            }
        }











    }
}
