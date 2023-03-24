// See https://aka.ms/new-console-template for more information

#region

//using Almacen.Models;


//using (AlmacenContext db = new AlmacenContext())

//    Producto producto = new Producto();

//    Console.WriteLine("Ingrese nombre del producto");
//    producto.Nombre = Console.ReadLine();

//    Console.WriteLine("");

//    Console.WriteLine("Ingrese descripcion del producto");
//    producto.Descripcion = Console.ReadLine();

//    Console.WriteLine("");

//    Console.WriteLine("Ingrese precio del producto");
//    producto.Precio = Convert.ToDecimal(Console.ReadLine());

//    Console.WriteLine("");

//    Console.WriteLine("Ingrese el Stock");
//    producto.Stock = Convert.ToInt32(Console.ReadLine());

//    db.Productos.Add(producto);
//    db.SaveChanges();



//}

#endregion


using Almacen.DAO;
using Almacen.Models;
using System;
using System.Xml;

CrudProductos crudProductos = new CrudProductos();
Producto Producto = new Producto();

Console.WriteLine("Menu\n");
Console.WriteLine("Seleccione el #1 para  insertar productos\n");
Console.WriteLine("Seleccione el #2 para salir\n ");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 1:
        bool bucle = true;
        while (bucle == true)
        {
            Console.WriteLine("Favor Ingresar el nombre del producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("Favor Ingresar la descripcion del producto");
            Producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Favor Ingresar el precio del producto");
            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Favor Ingrese la cantidad de prodcuto");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());

            crudProductos.AgregarProducto(Producto);

            Console.WriteLine("El Producto ha sido ingresado\n");
            Console.WriteLine("Seleccione #1 para seguir insertando productos\n");
            Console.WriteLine("Seleccione #2 para salir\n");


            var Menu2 = Convert.ToInt32(Console.ReadLine());

            switch (Menu2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    Console.Write("El programa se ha cerrado");
                    bucle = false;
                    break;

                default:
                    Console.Write("Favor Ingrese una opcion del menu");
                    break;


            }

        }
        break;

    case 2:
        Console.Write("El programa se ha cerrado");
        break;

    default:
        Console.Write("La opcion ingresada no es valida");
        break;

}

