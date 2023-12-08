using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IRepositoryProjects
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositoryProjects: IRepositoryProjects
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Proyecto 1",
                    Descripcion = "descripcion Proyecto 1",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/amazon.PNG"
                },
                 new Proyecto
                {
                    Titulo = "Proyecto 2",
                    Descripcion = "descripcion Proyecto 2",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/nyt.PNG"
                },
                  new Proyecto
                {
                    Titulo = "Proyecto 3",
                    Descripcion = "descripcion Proyecto 3",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/reddit.PNG"
                },
                   new Proyecto
                {
                    Titulo = "Proyecto 4",
                    Descripcion = "descripcion Proyecto 4",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/steam.PNG"
                },
            };
        }
    }
}
