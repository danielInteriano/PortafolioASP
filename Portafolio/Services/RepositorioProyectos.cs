using Portafolio.Models;

namespace Portafolio.Services{

    public interface IRepositorioProyectos
    {
        List<Proyecto> obtenerProyectos();
    }
    public class RepositorioProyectos:IRepositorioProyectos{
         public List<Proyecto> obtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto {
                    titulo="Amazon",
                    descripcion="E-Commerce realizado en Angular,Sass,NodeJS.",
                    imagenUrl="/imagenes/amazon.png",
                    link="https://amazon.com"
                },
                new Proyecto
                {
                    titulo="New York",
                    descripcion="E-Commerce realizado en ASP.NET core,Boostrap, MySql.",
                    imagenUrl="/imagenes/bootstrap.png",
                    link="https://getbootstrap.com/"
                },
                new Proyecto
                {
                    titulo="Honduras",
                    descripcion="Sistema de control de consejería realizado con Angular,Angular Material,NodeJS.",
                    imagenUrl="/imagenes/angularMaterial.png",
                    link="https://material.angular.io/"
                },
                new Proyecto
                {
                    titulo="Miami",
                    descripcion="Sistema de control de inventario realizado con Angular,Angular Material,NodeJS.",
                    imagenUrl="/imagenes/figma.png",
                    link="https://www.figma.com/community"
                }
            };
        }
    }
}