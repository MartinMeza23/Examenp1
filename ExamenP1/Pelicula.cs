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
        private int _año;
        public int Año
        {
            get
            {
                return _año;
            }
            set
            {
                if (value >= 1800 & value <= 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("El año no debe ser mayor a 2019");
                }
            }
        }

        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisDeOrigen { get; set; }
        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("El numero debe ser mayor de 0");
                }
            }
        }

        private double _ratingimdb;
        public double RatingImdb
        {
            get
            {
                return _ratingimdb;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _ratingimdb = value;
                }
                else
                {
                    throw new Exception("El numero esta fuera del rango");
                }
            }
        }

        public string Sinopsis { get; set; }


        public Pelicula()
        {
            Titulo = "Asignar";
            Año = 0;
            Director = "Asignar";
            Genero = "Asignar";
            PaisDeOrigen = "Asignar";
            Duracion = 2;
            RatingImdb = 0.00;
            Sinopsis = "Asignar";
        }

        public Pelicula(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
            Director = "Asignar";
            Genero = "Asignar";
            PaisDeOrigen = "Asignar";
            Duracion = 2;
            RatingImdb = 0.00;
            Sinopsis = "Asignar";


        }
    }
}
