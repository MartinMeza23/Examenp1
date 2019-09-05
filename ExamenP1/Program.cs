using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist LosAngeles = new Playlist("LosAngeles", "1");
            Equipo NewYork = new Equipo("NewYork", "2");






            foreach (Playlist playlist in playlists)
            {

                Console.WriteLine("Playlist: " + playlists.Año);
                Console.WriteLine("Playlists: " + playlists.Pelis);
                Console.WriteLine("Lista de Peliculas:");

                foreach (Pelicula jugador in playlists.Pelis)
                {
                    Console.WriteLine("*" + jugador.Nombre);
                }

            }

            Console.Read();
        }
    }
    }
}
