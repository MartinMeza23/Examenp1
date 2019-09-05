using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    class Playlist
    {
        public string TituloPeliculas { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> Peliculas { get; set; }


        public Playlist()
        {
            TituloPeliculas = "asignar";
            Descripcion = "asignar";
            Peliculas = new List<Pelicula>();
        }

        public Playlist(string titulopeliculas, string descripcion)
        {
            TituloPeliculas = titulopeliculas;
            Descripcion = descripcion;
            Peliculas = new List<Pelicula>();
        }
    }
}
