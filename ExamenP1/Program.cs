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

            Playlist Accion =
            new Playlist();
            Accion.TituloPlay = "Accion";
            Accion.Descripcion = "Balas,autos,policia";

            Accion.Peliculas.Add(
                new Pelicula("JohnWick_Otro_dia_para_matar", 2007));
            Accion.Peliculas.Add(
                new Pelicula("Johnwick_2", 2009));
            Accion.Peliculas.Add(
                new Pelicula("Johnwick_Paravellum", 2019));
            Accion.Peliculas.Add(
                new Pelicula("Rapido_Y_furioso1", 2001));
            Accion.Peliculas.Add(
                new Pelicula("Reto_TOKIO", 2004));
            Accion.Peliculas.Add(
                new Pelicula("Rapido_Y_furioso5incontrol", 1950));
            Accion.Peliculas.Add(
                 new Pelicula("LondresBajoFuego", 2012));

            Playlist Terror =
                new Playlist();
            Terror.TituloPlay = "Terror";
            Terror.Descripcion = "Mucho_Miedo";

            Terror.Peliculas.Add(
                 new Pelicula("Anabelle", 2013));
            Terror.Peliculas.Add(
                new Pelicula("El_niño", 2014));
            Terror.Peliculas.Add(
                new Pelicula("El_despertar_del_diablo", 2000));
            Terror.Peliculas.Add(
                 new Pelicula("Masacre_En_Texas", 2005));
            Terror.Peliculas.Add(
                new Pelicula("pelicula5", 1987));
            Terror.Peliculas.Add(
                new Pelicula("Lo_que_la_gente_cuenta", 1988));
            Terror.Peliculas.Add(
                new Pelicula("Terror_en_la_ciudad", 2000));

            playlists.Add(Accion);
            playlists.Add(Terror);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist: ");
                Console.WriteLine("Titulo: " +
                    playlist.TituloPlay);
                Console.WriteLine("Descripcion: " +
                    playlist.Descripcion);
                foreach (Pelicula pelicula in playlist.Peliculas)
                {
                    Console.WriteLine("-" +
                        pelicula.Titulo + ", " +
                        pelicula.Año);
                }

                
                    Console.Read();
                

            }

        }
    }
}
