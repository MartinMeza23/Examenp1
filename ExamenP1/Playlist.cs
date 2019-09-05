using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    class Playlist
    {
        public string Pelis  { get; set; }
        public string Año { get; set; }

        public List<Pelicula> peliculas { get; set; }


        public Pelicula(string pelis , string año)
        {
            Pelis = pelis;
            Año = año;

            peliculas = new List<Pelicula>();

        }
    }
}
