using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteSpidy_Mermeladeros_21AM
{
    public class SystemClass
    {
        public void EjecutarSistema()
        {
            int otroPedido = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("FAST FOOD RESTAURANT");
                Console.WriteLine("¿Cuantos productos diferentes desea comprar?");
                string entradaProductos = Console.ReadLine();
                int totalProductosDiferentes = 0;

                while (!int.TryParse(entradaProductos, out totalProductosDiferentes) || totalProductosDiferentes <= 0)
                {
                    Console.WriteLine("Ingrese un valor valido por favor:");
                    entradaProductos = Console.ReadLine();
                }

                double subtotalGeneral = 0;

                for (int i = 1; i <= totalProductosDiferentes; i++)
                {
                    AlmacenClass almacen = new AlmacenClass();
                    almacen.MostrarMenu();

                    Console.WriteLine("Seleccione un producto:");
                    string entradaCodigo = Console.ReadLine();
                    int codigoProducto = 0;

                    while (!int.TryParse(entradaCodigo, out codigoProducto) || codigoProducto < 1 || codigoProducto > 6)
                    {
                        Console.WriteLine("Codigo invalido. Seleccione un producto del 1 al 6:");
                        entradaCodigo = Console.ReadLine();
                    }

                    string nombreProducto = "";
                    double precioProducto = 0;

                    switch (codigoProducto)
                    {
                        case 1:
                            nombreProducto = "Hamburguesa";
                            precioProducto = 65;
                            break;
                        case 2:
                            nombreProducto = "Pizza individual";
                            precioProducto = 85;
                            break;
                        case 3:
                            nombreProducto = "Hot dog";
                            precioProducto = 40;
                            break;
                        case 4:
                            nombreProducto = "Papas fritas";
                            precioProducto = 35;
                            break;
                        case 5:
                            nombreProducto = "Refresco";
                            precioProducto = 25;
                            break;
                        case 6:
                            nombreProducto = "Malteada";
                            precioProducto = 45;
                            break;
                    }

                    Console.WriteLine("Producto seleccionado: " + nombreProducto);
                    Console.WriteLine("¿Cuantas unidades desea?");
                    string entradaCantidad = Console.ReadLine();
                    int cantidadUnidades = 0;

                    while (!int.TryParse(entradaCantidad, out cantidadUnidades) || cantidadUnidades <= 0)
                    {
                        Console.WriteLine("Cantidad invalida. Ingrese un numero mayor a cero:");
                        entradaCantidad = Console.ReadLine();
                    }

                    double importeProducto = precioProducto * cantidadUnidades;
                    subtotalGeneral += importeProducto;

                    Console.WriteLine("Producto: " + nombreProducto);
                    Console.WriteLine("Cantidad: " + cantidadUnidades);
                    Console.WriteLine("Importe: $" + importeProducto);
                }

                double descuento = 0;

                if (subtotalGeneral < 200)
                {
                    descuento = 0;
                }
                else if (subtotalGeneral >= 200 && subtotalGeneral <= 399)
                {
                    descuento = subtotalGeneral * 0.05;
                }
                else if (subtotalGeneral >= 400 && subtotalGeneral <= 599)
                {
                    descuento = subtotalGeneral * 0.10;
                }
                else
                {
                    descuento = subtotalGeneral * 0.15;
                }

                double totalPagar = subtotalGeneral - descuento;

                Console.WriteLine("TICKET DE COMPRA");
                Console.WriteLine("Subtotal: $" + subtotalGeneral);
                Console.WriteLine("Descuento: $" + descuento);
                Console.WriteLine("Total a pagar: $" + totalPagar);

                Console.WriteLine("¿Desea realizar otro pedido?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                string entradaContinuar = Console.ReadLine();
                int opcionContinuar = 0;

                while (!int.TryParse(entradaContinuar, out opcionContinuar) || (opcionContinuar != 1 && opcionContinuar != 2))
                {
                    Console.WriteLine("Opcion invalida. Ingrese 1 para Si o 2 para No:");
                    entradaContinuar = Console.ReadLine();
                }

                otroPedido = opcionContinuar;

            } while (otroPedido == 1);

            Console.WriteLine("¡Gracias por visitar FAST FOOD RESTAURANT!");
            Console.WriteLine("¡Vuelva pronto!");
        }
    }
}
