using System;

    class Program
    {
        static void Main(string[] args)
        {
            double subtotalPedido = 0;
            int opcionAgregarMas;
            bool entradaValida;

            Console.WriteLine("====================================");
            Console.WriteLine("        FAST FOOD RESTAURANT        ");
            Console.WriteLine("====================================");

            do
            {
                int cantidadProductosDiferentes;
                do
                {
                    Console.WriteLine("\n¿Cuantos productos diferentes desea agregar?");
                    entradaValida = int.TryParse(Console.ReadLine(), out cantidadProductosDiferentes);

                    if (!entradaValida || cantidadProductosDiferentes <= 0)
                    {
                        Console.WriteLine("Error: Debe ingresar un numero valido mayor a 0.");
                    }
                } while (!entradaValida || cantidadProductosDiferentes <= 0);

                for (int contador = 1; contador <= cantidadProductosDiferentes; contador++)
                {
                    Console.WriteLine("\n--------------- MENU ---------------");
                    Console.WriteLine("1. Hamburguesa      | $65");
                    Console.WriteLine("2. Pizza individual | $85");
                    Console.WriteLine("3. Hot dog          | $40");
                    Console.WriteLine("4. Papas fritas     | $35");
                    Console.WriteLine("5. Refresco         | $25");
                    Console.WriteLine("6. Malteada         | $45");
                    Console.WriteLine("------------------------------------");

                    int codigoProducto;
                    double precioUnitario = 0;
                    string nombreProducto = "";
                    bool productoValido;

                    do
                    {
                        Console.WriteLine($"\nSeleccione el producto #{contador}:");
                        entradaValida = int.TryParse(Console.ReadLine(), out codigoProducto);
                        productoValido = true;

                        if (!entradaValida)
                        {
                            Console.WriteLine("Error: Debe ingresar un numero del menu.");
                            productoValido = false;
                        }
                        else
                        {
                            switch (codigoProducto)
                            {
                                case 1:
                                    nombreProducto = "Hamburguesa";
                                    precioUnitario = 65;
                                    break;
                                case 2:
                                    nombreProducto = "Pizza individual";
                                    precioUnitario = 85;
                                    break;
                                case 3:
                                    nombreProducto = "Hot dog";
                                    precioUnitario = 40;
                                    break;
                                case 4:
                                    nombreProducto = "Papas fritas";
                                    precioUnitario = 35;
                                    break;
                                case 5:
                                    nombreProducto = "Refresco";
                                    precioUnitario = 25;
                                    break;
                                case 6:
                                    nombreProducto = "Malteada";
                                    precioUnitario = 45;
                                    break;
                                default:
                                    Console.WriteLine("Error: Codigo de producto no valido. Intente de nuevo.");
                                    productoValido = false;
                                    break;
                            }
                        }
                    } while (!productoValido);

                    Console.WriteLine($"Producto seleccionado: {nombreProducto}");

                    int cantidadUnidades;
                    do
                    {
                        Console.WriteLine("¿Cuantas unidades desea?");
                        entradaValida = int.TryParse(Console.ReadLine(), out cantidadUnidades);

                        if (!entradaValida || cantidadUnidades <= 0)
                        {
                            Console.WriteLine("Error: La cantidad debe ser un numero mayor a 0.");
                        }
                    } while (!entradaValida || cantidadUnidades <= 0);

                    double importeProducto = precioUnitario * cantidadUnidades;
                    subtotalPedido += importeProducto;

                    Console.WriteLine("\n--- Resumen del producto ---");
                    Console.WriteLine($"Producto: {nombreProducto}");
                    Console.WriteLine($"Cantidad: {cantidadUnidades}");
                    Console.WriteLine($"Importe: ${importeProducto}");
                    Console.WriteLine($"Subtotal acumulado: ${subtotalPedido}");
                }

                double porcentajeDescuento;

                if (subtotalPedido >= 600)
                {
                    porcentajeDescuento = 0.15;
                }
                else if (subtotalPedido >= 400 && subtotalPedido <= 599)
                {
                    porcentajeDescuento = 0.10;
                }
                else if (subtotalPedido >= 200 && subtotalPedido <= 399)
                {
                    porcentajeDescuento = 0.05;
                }
                else
                {
                    porcentajeDescuento = 0.0;
                }

                double montoDescuento = subtotalPedido * porcentajeDescuento;
                double totalPagar = subtotalPedido - montoDescuento;

                Console.WriteLine("\n====================================");
                Console.WriteLine("          TICKET DE COMPRA          ");
                Console.WriteLine("====================================");
                Console.WriteLine($"Subtotal: ${subtotalPedido}");
                Console.WriteLine($"Descuento: ${montoDescuento}");
                Console.WriteLine($"Total a pagar: ${totalPagar}");
                Console.WriteLine("====================================");

                do
                {
                    Console.WriteLine("\n¿Desea agregar otros productos a su compra?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    entradaValida = int.TryParse(Console.ReadLine(), out opcionAgregarMas);

                    if (!entradaValida || (opcionAgregarMas != 1 && opcionAgregarMas != 2))
                    {
                        Console.WriteLine("Error: Seleccione 1 para Si o 2 para No.");
                    }
                } while (!entradaValida || (opcionAgregarMas != 1 && opcionAgregarMas != 2));

            } while (opcionAgregarMas == 1);

            Console.WriteLine("\n¡Gracias por visitar FAST FOOD RESTAURANT!");
            Console.WriteLine("¡Vuelva pronto!");
            Console.ReadKey();
        }
    }