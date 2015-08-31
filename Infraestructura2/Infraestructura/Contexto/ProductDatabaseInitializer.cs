using System.Collections.Generic;
using System.Data.Entity;

namespace Dominio.Entidades
{
  public class ProductoDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductoContext>
  {
    protected override void Seed(ProductoContext context)
    {
      GetCategories().ForEach(c => context.Categorias.Add(c));
      GetProductos().ForEach(p => context.Productos.Add(p));
    }

    private static List<Categoria> GetCategories()
    {
      var categories = new List<Categoria> {
                new Categoria
                {
                    CategoriaID = 1,
                    CategoriaNombre = "Cars"
                },
                new Categoria
                {
                    CategoriaID = 2,
                    CategoriaNombre = "Planes"
                },
                new Categoria
                {
                    CategoriaID = 3,
                    CategoriaNombre = "Trucks"
                },
                new Categoria
                {
                    CategoriaID = 4,
                    CategoriaNombre = "Boats"
                },
                new Categoria
                {
                    CategoriaID = 5,
                    CategoriaNombre = "Rockets"
                },
            };

      return categories;
    }

    private static List<Producto> GetProductos()
    {
      var Productos = new List<Producto> {
                new Producto
                {
                    ProductoID = 1,
                    ProductoNombre = "Convertible Car",
                    Descripcion = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + 
                                  "Power it up and let it go!", 
                    ImagenUbicacion="carconvert.png",
                    PrecioUnitario = 22.50,
                    CategoriaID = 1
               },
                new Producto 
                {
                    ProductoID = 2,
                    ProductoNombre = "Old-time Car",
                    Descripcion = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagenUbicacion="carearly.png",
                    PrecioUnitario = 15.95,
                     CategoriaID = 1
               },
                new Producto
                {
                    ProductoID = 3,
                    ProductoNombre = "Fast Car",
                    Descripcion = "Yes this car is fast, but it also floats in water.",
                    ImagenUbicacion="carfast.png",
                    PrecioUnitario = 32.99,
                    CategoriaID = 1
                },
                new Producto
                {
                    ProductoID = 4,
                    ProductoNombre = "Super Fast Car",
                    Descripcion = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagenUbicacion="carfaster.png",
                    PrecioUnitario = 8.95,
                    CategoriaID = 1
                },
                new Producto
                {
                    ProductoID = 5,
                    ProductoNombre = "Old Style Racer",
                    Descripcion = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    ImagenUbicacion="carracer.png",
                    PrecioUnitario = 34.95,
                    CategoriaID = 1
                },
                new Producto
                {
                    ProductoID = 6,
                    ProductoNombre = "Ace Plane",
                    Descripcion = "Authentic airplane toy. Features realistic color and details.",
                    ImagenUbicacion="planeace.png",
                    PrecioUnitario = 95.00,
                    CategoriaID = 2
                },
                new Producto
                {
                    ProductoID = 7,
                    ProductoNombre = "Glider",
                    Descripcion = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagenUbicacion="planeglider.png",
                    PrecioUnitario = 4.95,
                    CategoriaID = 2
                },
                new Producto
                {
                    ProductoID = 8,
                    ProductoNombre = "Paper Plane",
                    Descripcion = "This paper plane is like no other paper plane. Some folding required.",
                    ImagenUbicacion="planepaper.png",
                    PrecioUnitario = 2.95,
                    CategoriaID = 2
                },
                new Producto
                {
                    ProductoID = 9,
                    ProductoNombre = "Propeller Plane",
                    Descripcion = "Rubber band powered plane features two wheels.",
                    ImagenUbicacion="planeprop.png",
                    PrecioUnitario = 32.95,
                    CategoriaID = 2
                },
                new Producto
                {
                    ProductoID = 10,
                    ProductoNombre = "Early Truck",
                    Descripcion = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagenUbicacion="truckearly.png",
                    PrecioUnitario = 15.00,
                    CategoriaID = 3
                },
                new Producto
                {
                    ProductoID = 11,
                    ProductoNombre = "Fire Truck",
                    Descripcion = "You will have endless fun with this one quarter sized fire truck.",
                    ImagenUbicacion="truckfire.png",
                    PrecioUnitario = 26.00,
                    CategoriaID = 3
                },
                new Producto
                {
                    ProductoID = 12,
                    ProductoNombre = "Big Truck",
                    Descripcion = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagenUbicacion="truckbig.png",
                    PrecioUnitario = 29.00,
                    CategoriaID = 3
                },
                new Producto
                {
                    ProductoID = 13,
                    ProductoNombre = "Big Ship",
                    Descripcion = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagenUbicacion="boatbig.png",
                    PrecioUnitario = 95.00,
                    CategoriaID = 4
                },
                new Producto
                {
                    ProductoID = 14,
                    ProductoNombre = "Paper Boat",
                    Descripcion = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    ImagenUbicacion="boatpaper.png",
                    PrecioUnitario = 4.95,
                    CategoriaID = 4
                },
                new Producto
                {
                    ProductoID = 15,
                    ProductoNombre = "Sail Boat",
                    Descripcion = "Put this fun toy sail boat in the water and let it go!",
                    ImagenUbicacion="boatsail.png",
                    PrecioUnitario = 42.95,
                    CategoriaID = 4
                },
                new Producto
                {
                    ProductoID = 16,
                    ProductoNombre = "Rocket",
                    Descripcion = "This fun rocket will travel up to a height of 200 feet.",
                    ImagenUbicacion="rocket.png",
                    PrecioUnitario = 122.95,
                    CategoriaID = 5
                }
            };

      return Productos;
    }
  }
}