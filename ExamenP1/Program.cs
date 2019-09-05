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

            Playlist Accion = new Playlist();
            
            Accion.TituloPeliculas = "Accion";
            Accion.Descripcion = "Balas, autos, policia";

            Accion.Peliculas.Add(new Pelicula("JohnWick Otro dia para matar", 2007));               
            Accion.Peliculas.Add(new Pelicula("Johnwick 2", 2009));              
            Accion.Peliculas.Add(new Pelicula("Johnwick Paravellum", 2019));              
            Accion.Peliculas.Add(new Pelicula("Rapido Y furioso1", 2001));               
            Accion.Peliculas.Add( new Pelicula("Reto TOKIO", 2004));            
            Accion.Peliculas.Add(new Pelicula("Rapido Y furioso 5incontrol", 2002));               
            Accion.Peliculas.Add(new Pelicula("Londres Bajo Fuego", 2012));

            playlists.Add(Accion);

            Playlist Terror = new Playlist();

            Terror.TituloPeliculas = "Terror";
            Terror.Descripcion = "Mucho Miedo";

            Terror.Peliculas.Add(new Pelicula("Anabelle", 2013));
            Terror.Peliculas.Add(new Pelicula("El niño", 2014));
            Terror.Peliculas.Add(new Pelicula("El despertar del diablo", 2000));
            Terror.Peliculas.Add(new Pelicula("Masacre En Texas", 2005));
            Terror.Peliculas.Add(new Pelicula("pelicula5", 1987));
            Terror.Peliculas.Add(new Pelicula("Lo que la gente cuenta", 1988));
            Terror.Peliculas.Add(new Pelicula("Terror en la ciudad", 2000));

            playlists.Add(Terror);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist: ");
                Console.WriteLine("Titulo: " + playlist.TituloPeliculas);
                    
                Console.WriteLine("Descripcion: " + playlist.Descripcion);
                   
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("-" + pelicula.Titulo + ", " +  pelicula.Año);
                        
                }

                
                    Console.Read();
                

            }

        }
    }
}
