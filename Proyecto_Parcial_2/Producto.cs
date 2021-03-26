using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parcial_2
{ 
    class Producto
    {

        private string nombre;

        private uint precio;

        private bool existencia;

        private int contadorProducto_1 = 5;
        private int contadorProducto_2 = 5;
        private int contadorProducto_3 = 5;
        private int contadorProducto_4 = 5;
        private int contadorProducto_5 = 5;
        private int contadorProducto_6 = 5;
        private int contadorProducto_7 = 5;
        private int contadorProducto_8 = 5;
        private int contadorProducto_9 = 5;
        private int contadorProducto_10 = 5;



        public void FinDelDia() 
        {

            int suma = (contadorProducto_1 + contadorProducto_2 + contadorProducto_3 + contadorProducto_4 + contadorProducto_5 + contadorProducto_6 + contadorProducto_7 + contadorProducto_8 + contadorProducto_9 + contadorProducto_10);

            Console.WriteLine("\nDe 50 productos en la Maquina Dispensadora quedan: " + suma);

            Console.WriteLine("\n Del producto a quedan: " + contadorProducto_1);
            Console.WriteLine("\n Del producto b quedan: " + contadorProducto_2);
            Console.WriteLine("\n Del producto c quedan: " + contadorProducto_3);
            Console.WriteLine("\n Del producto d quedan: " + contadorProducto_4);
            Console.WriteLine("\n Del producto e quedan: " + contadorProducto_5);
            Console.WriteLine("\n Del producto f quedan: " + contadorProducto_6);
            Console.WriteLine("\n Del producto g quedan: " + contadorProducto_7);
            Console.WriteLine("\n Del producto h quedan: " + contadorProducto_8);
            Console.WriteLine("\n Del producto i quedan: " + contadorProducto_9);
            Console.WriteLine("\n Del producto j quedan: " + contadorProducto_10);

        }

        public void setProductos(string a, uint b, bool c) 
        {

            nombre = a;
            precio = b;
            existencia = c;
        
        }

        public void setC1(int a) 
        {

            contadorProducto_1 = a;
        
        }

        public void setC10(int a)
        {

            contadorProducto_10 = a;

        }

        public void setC2(int a)
        {

            contadorProducto_2 = a;

        }

        public void setC3(int a)
        {

            contadorProducto_3 = a;

        }

        public void setC4(int a)
        {

            contadorProducto_4 = a;

        }

        public void setC5(int a)
        {

            contadorProducto_5 = a;

        }

        public void setC6(int a)
        {

            contadorProducto_6 = a;

        }

        public void setC7(int a)
        {

            contadorProducto_7 = a;

        }

        public void setC8(int a)
        {

            contadorProducto_8 = a;

        }

        public void setC9(int a)
        {

            contadorProducto_9 = a;

        }

        public void getProductos() 
        {

            Console.WriteLine("\nProducto: " + nombre);

            Console.WriteLine("\nPrecio: " + precio + "$");

            Console.WriteLine("\nExistencia: " + existencia);        
        }

        public void getProductosPrecios() 
        {

            bool condicionBucle = true;

            while (condicionBucle == true)
            {

                Console.WriteLine(" _______________________________");
                Console.WriteLine("|                               |");
                Console.WriteLine("|   < Maquina Dispensadora >    |");
                Console.WriteLine("|_______________________________|");
                Console.WriteLine("|                               |");
                Console.WriteLine("|1-> Producto a Precio: 5$      |");
                Console.WriteLine("|2-> Producto b Precio: 5$      |");
                Console.WriteLine("|3-> Producto c Precio: 10$     |");
                Console.WriteLine("|4-> Producto d Precio: 10$     |");
                Console.WriteLine("|5-> Producto e Precio: 25$     |");
                Console.WriteLine("|6-> Producto f Precio: 25$     |");
                Console.WriteLine("|7-> Producto g Precio: 50$     |");
                Console.WriteLine("|8-> Producto h Precio: 50$     |");
                Console.WriteLine("|9-> Producto i Precio: 100$    |");
                Console.WriteLine("|10-> Producto j Precio: 200$   |");
                Console.WriteLine("|_______________________________|");

                condicionBucle = false;

            }


        }

        public void ProductoCompra(int producto) 
        {
            bool porDefecto = false;

            bool condicionSwitch_1 = true;

            bool condicionSwitch_2 = true;

            if (producto <= 6)
            {

                int moneda = 0;

                Console.WriteLine("\n1- Moneda de 5$");
                Console.WriteLine("\n2- Moneda de 10$");
                Console.WriteLine("\n3- Moneda de 25$");

                while (condicionSwitch_1== true)
                {

                    Console.Write("\nSeleccione la cantidad que tiene para pagar: ");

                    try
                    {
                        moneda = int.Parse(Console.ReadLine());

                        if (moneda > 0 && moneda <= 3)
                        {

                            condicionSwitch_1 = false;

                        }
                    }
                    catch
                    {
                        moneda = 0;
                    }

                }

                switch (moneda)
                {

                    case 1:

                        moneda = 5;

                        break;

                    case 2:

                        moneda = 10;

                        break;

                    case 3:

                        moneda = 25;

                        break;

                    default:

                        porDefecto = true;

                        break;

                }
                if (porDefecto == false)
                {
                    if (moneda == 5)
                    {

                        if (producto == 1)

                        {

                            if (contadorProducto_1 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC1(--contadorProducto_1);

                            }
                            else if (contadorProducto_1 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 2)
                        {

                            if (contadorProducto_2 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC2(--contadorProducto_2);

                            }
                            else if (contadorProducto_2 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else 
                        {

                            Console.WriteLine("\nMonto insuficiente.");
                        
                        }

                    }

                    else if (moneda == 10)
                    {
                        if (producto == 1)

                        {

                            if (contadorProducto_1 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC1(--contadorProducto_1); ;

                            }
                            else if (contadorProducto_1 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 2)
                        {

                            if (contadorProducto_2 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC2(--contadorProducto_2);

                            }
                            else if (contadorProducto_2 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 3)

                        {

                            if (contadorProducto_3 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto c", 10, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC3(--contadorProducto_3);

                            }
                            else if (contadorProducto_3 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto c", 10, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 4)
                        {

                            if (contadorProducto_4 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto d", 10, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC4(--contadorProducto_4);

                            }
                            else if (contadorProducto_4 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("roducto d", 10, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else 
                        {

                            Console.WriteLine("\nMonto insuficiente.");
                        
                        }

                    }

                    else if (moneda == 25)
                    {
                        if (producto == 1)

                        {

                            if (contadorProducto_1 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC1(--contadorProducto_1);

                            }
                            else if (contadorProducto_1 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto a", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 2)
                        {

                            if (contadorProducto_2 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC2(--contadorProducto_2);

                            }
                            else if (contadorProducto_2 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto b", 5, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 4)

                        {

                            if (contadorProducto_3 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto c", 10, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC3(--contadorProducto_3);

                            }
                            else if (contadorProducto_3 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto c", 10, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 4)
                        {

                            if (contadorProducto_4 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto d", 10, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC4(--contadorProducto_4);

                            }
                            else if (contadorProducto_4 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto d", 10, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else if (producto == 5)

                        {

                            if (contadorProducto_5 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto e", 25, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC5(--contadorProducto_5);

                            }
                            else if (contadorProducto_5 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto e", 25, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 6)
                        {

                            if (contadorProducto_6 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto f", 25, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC6(--contadorProducto_6);

                            }
                            else if (contadorProducto_6 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto f", 25, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                    }

                }



            }

            else if (producto > 6)
            {

                int billete = 0;

                Console.WriteLine("\n1- Billete de 50$");
                Console.WriteLine("\n2- Billete de 100$");
                Console.WriteLine("\n3- Billete de 200$");

                while (condicionSwitch_2 == true)
                {

                    Console.Write("\nSeleccione la cantidad que tiene para pagar: ");

                    try
                    {
                        billete = int.Parse(Console.ReadLine());

                        if (billete > 0 && billete <= 3)
                        {

                            condicionSwitch_2 = false;

                        }
                    }
                    catch
                    {
                        billete = 0;
                    }

                }

                switch (billete)
                {

                    case 1:

                        billete = 50;

                        break;

                    case 2:

                        billete = 100;

                        break;

                    case 3:

                        billete = 200;

                        break;

                    default:

                        porDefecto = true;

                        break;

                }

                if (porDefecto == false)
                {
                    if (billete == 50)
                    {

                        if (producto == 8)

                        {

                            if (contadorProducto_7 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC7(--contadorProducto_7);

                            }
                            else if (contadorProducto_7 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 8)
                        {

                            if (contadorProducto_8 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC8(--contadorProducto_8);

                            }
                            else if (contadorProducto_8 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else 
                        {

                            Console.WriteLine("\nMonto insuficiente.");

                        }

                    }

                    if (billete == 100)
                    {

                        if (producto == 8)

                        {

                            if (contadorProducto_7 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC7(--contadorProducto_7);

                            }
                            else if (contadorProducto_7 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 8)
                        {

                            if (contadorProducto_8 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC8(--contadorProducto_8);

                            }
                            else if (contadorProducto_8 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else if (producto == 9)

                        {

                            if (contadorProducto_9 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto i", 100, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC9(--contadorProducto_9);

                            }
                            else if (contadorProducto_9 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto i", 100, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else 
                        {

                            Console.WriteLine("\nMonto insuficiente.");
                        
                        }
                    }

                    if (billete == 200) 
                    {

                        if (producto == 8)

                        {

                            if (contadorProducto_7 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("Su compra ha sido un exito.");

                                setC7(--contadorProducto_7);

                            }
                            else if (contadorProducto_7 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto g", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }
                        else if (producto == 8)
                        {

                            if (contadorProducto_8 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC8(--contadorProducto_8);

                            }
                            else if (contadorProducto_8 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto h", 50, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else if (producto == 9)

                        {

                            if (contadorProducto_9 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto i", 100, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC9(--contadorProducto_9);

                            }
                            else if (contadorProducto_9 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto i", 100, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                        else if (producto == 10)

                        {

                            if (contadorProducto_10 != 0)
                            {
                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto j", 200, true);

                                pro_1.getProductos();

                                Console.WriteLine("\nSu compra ha sido un exito.");

                                setC10(--contadorProducto_10);

                            }
                            else if (contadorProducto_10 == 0)
                            {

                                Producto pro_1 = new Producto();

                                pro_1.setProductos("Producto j", 200, false);

                                pro_1.getProductos();

                                Console.WriteLine("\nSe ha agotado el producto.");

                            }

                        }

                    }
                }
            }

        }

    }
}
