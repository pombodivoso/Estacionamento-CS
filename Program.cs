using System;
using System.Collections.Generic;

public class ParkingLot
{
    public decimal inicialPrice { get; set; }
    public decimal priceHour { get; set; }
    public List<string> parkedCars { get; set; }


    public ParkingLot()
    {
        parkedCars = new List<string>();
    }
    public void AddCar(string plate)
    {
        parkedCars.Add(plate);
        Console.WriteLine("Carro adicionado!");
    }
    public void RemoveCar(string plate, int hours)
    {
        if (parkedCars.Contains(plate))
        {
            parkedCars.Remove(plate);
             decimal totalPrice = inicialPrice + (hours * priceHour);
            Console.WriteLine("========================================================================");
            Console.WriteLine($"Obrigado por confiar! Seu total foi de R$ {totalPrice}. Volte sempre!");
            Console.WriteLine("========================================================================");
        }
        else
        {
            Console.WriteLine("Carro não encontrado...");
        }

    }
    public void ListCars()
    {
        if (parkedCars.Count > 0)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Carros estacionados:");
            Console.WriteLine("========================");
            foreach (string car in parkedCars)
            {
                Console.WriteLine(car, "\n");
            }
            Console.WriteLine("========================");
        }
        else
        {
            Console.WriteLine("Não há carros estacionados no momento!");
        }
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("| Bem-vindo(a) ao estacionamento! |");
        Console.WriteLine("===================================");

        Console.Write("\nInforme o preço por hora: R$ ");
        decimal priceHour = Convert.ToDecimal(Console.ReadLine());

        var parkingLot = new ParkingLot();
        Console.Write("\nInforme o preço inicial para estacionar: R$ ");
        parkingLot.inicialPrice = Convert.ToDecimal(Console.ReadLine());
        parkingLot.priceHour = priceHour;

        bool execute = true;

        while (execute)
        {
            Console.Clear();
            Console.WriteLine("\n========================");
            Console.WriteLine("|  Escolha uma opção:   |");
            Console.WriteLine("========================");
            Console.WriteLine("| 1 - Adicionar carro   |");
            Console.WriteLine("|  2 - Remover carro    |");
            Console.WriteLine("|  3 - Listar carros    |");
            Console.WriteLine("| 4 - Encerrar programa |");
            Console.WriteLine("========================");
            Console.Write("Opção: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("\nDigite a placa do carro: ");
                    string placaAdd = Console.ReadLine();
                    parkingLot.AddCar(placaAdd);
                    Console.Write("\nDigite qualquer tecla para continuar: ");
                    var something = Console.ReadLine();
                    break;

                case "2":
                    Console.Write("\nDigite a placa do carro a remover: ");
                    string placaRemover = Console.ReadLine();

                    Console.Write("Informe o número de horas estacionado: ");
                    int horas = Convert.ToInt32(Console.ReadLine());

                    parkingLot.RemoveCar(placaRemover, horas);
                    Console.Write("\nDigite qualquer tecla para continuar: ");
                    something = Console.ReadLine();
                    break;

                case "3":
                    parkingLot.ListCars();
                    Console.Write("\nDigite qualquer tecla para continuar: ");
                    something = Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("\nEncerrando o programa... Obrigado!");
                    execute = false;
                    break;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Console.Write("\nDigite qualquer tecla para continuar: ");
                    something = Console.ReadLine();
                    break;
            }
        }
    }
}
