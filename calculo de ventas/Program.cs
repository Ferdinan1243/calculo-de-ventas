using System;
using System.ComponentModel.Design;
class Mercado
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos a nuestro Mercado los Durones");
        Console.WriteLine("Pon Tu Nombre Por Favor");
       
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("Elija el Producto que desee");
        Console.WriteLine("1.comida");
        Console.WriteLine("2.carnes");
        Console.WriteLine("3.verduras");
        string categoria = Console.ReadLine();

        if (categoria == "1")
        {
            Console.WriteLine("Estos son Todos los Tipos de comida que desea comprar");
            Console.WriteLine("1.Chuleta");
            Console.WriteLine("2.Hamburguesas");
            Console.WriteLine("3.Pizza");
            Console.WriteLine("4.Alitas con papas");
            Console.WriteLine("5.Tortas de pollos");
            string Comidas = Console.ReadLine();

            if (Comidas == "1")
            {
                Console.WriteLine("1.Pequeño");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 62;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de chuleta a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 80;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Comidas == "2")
            {
                Console.WriteLine("1.pequeña");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Hamburguesas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 70;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Hamburguesas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 105;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Hamburguesas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 136;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comidas == "3")
            {
                Console.WriteLine("1.pequeña");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de pizza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 100;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de pizza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 125;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de pizza a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 162;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comidas == "4")
            {
                Console.WriteLine("1.pequeña");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de alitas con papas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 90;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de alitas con papas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 112;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de alitas con papas a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 145;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comidas == "5")
            {
                Console.WriteLine("1.pequeña");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de tortas de pollos a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 75;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de tortas de pollos a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 93;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de tortas de pollos a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 120;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }
        }
        else  if (categoria == "2")
            {
                Console.WriteLine("Estos son Todos los Tipos de Carnes que desea comprar");
                Console.WriteLine("1.Carne para asar");
                Console.WriteLine("2.Carne para bistec");
                Console.WriteLine("3.Fajitas");
                Console.WriteLine("4.Lomo de res");
                Console.WriteLine("5.Filete");
                string Carnes = Console.ReadLine();

                if (Carnes == "1")
                {
                    Console.WriteLine("1.Pequeño");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para asar a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 20;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para asar a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 25;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para asar a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 32;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }

                if (Carnes == "2")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para bistec a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 50;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para bistec a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 62;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de carne para bistec a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 80;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "3")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de fajitas a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 100;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de fajitas a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 125;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de fajitas a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 162;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "4")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de lomo de res a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 120;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de lomo de res a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 150;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de lomo de res a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 195;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "5")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de filete a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 160;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de filete a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 200;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de filete a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal2 = Cantidad * 160;
                        Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }


                }
            }
        else if  (categoria == "3")
            {
                Console.WriteLine("Estos son Todos los Tipos de Verduras que desea comprar");
                Console.WriteLine("1.Tomates");
                Console.WriteLine("2.Chiles dulces");
                Console.WriteLine("3.Culantro");
                Console.WriteLine("4.Cebolla");
                Console.WriteLine("5.Elotes");
                string Carnes = Console.ReadLine();

                if (Carnes == "1")
                {
                    Console.WriteLine("1.Pequeño");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de tomates a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 25;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de tomates a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 31;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de tomates a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 40;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }

                if (Carnes == "2")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de chiles dulces a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 30;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de chiles dulces a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 37;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de chiles dulces a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 48;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "3")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de culantro a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 60;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de culantro a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 75;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de culantro a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 97;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "4")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de cebolla a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 70;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de cebolla a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 87;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de cebolla a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 113;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }




                }
                if (Carnes == "5")
                {
                    Console.WriteLine("1.pequeña");
                    Console.WriteLine("2.Mediano");
                    Console.WriteLine("3.Grande");
                    string Tamaño = Console.ReadLine();
                    if (Tamaño == "1")
                    {
                        Console.WriteLine("Ingrese la Cantidad de elotes a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 75;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "2")
                    {
                        Console.WriteLine("Ingrese la Cantidad de elotes a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3 = Cantidad * 93;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }
                    else if (Tamaño == "3")
                    {
                        Console.WriteLine("Ingrese la Cantidad de elotes a Comprar");
                        int Cantidad = Convert.ToInt32(Console.ReadLine());
                        int subtotal3= Cantidad * 121;
                        Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"SubTotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                    }


                }
            }
    }
}





