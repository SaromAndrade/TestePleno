using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Controller;
using TestePleno.Models;

namespace TestePleno
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fare = new Fare();
            fare.Id = Guid.NewGuid();
            fare.Data = new DateTime(2022, 1, 13);

            Console.WriteLine("Informe o valor da tarifa a ser cadastrada:");
            var fareValueInput = Console.ReadLine();
            fare.Value = decimal.Parse(fareValueInput);

            Console.WriteLine("Informe o código da operadora para a tarifa:");
            Console.WriteLine("Exemplos: OP01, OP02, OP03...");
            var operatorCodeInput = Console.ReadLine();

            var fareController = new FareController();
            fareController.CreateFare(fare, operatorCodeInput);




            var fare2 = new Fare();
            fare2.Id = Guid.NewGuid();
            fare2.Data = new DateTime(2022, 1, 13);


            Console.WriteLine("Informe o valor da segunda tarifa a ser cadastrada:");
            var fare2ValueInput = Console.ReadLine();
            fare2.Value = decimal.Parse(fare2ValueInput);

            fareController.CreateFare(fare2, operatorCodeInput);

            Console.WriteLine("Tarifa cadastrada com sucesso!");
            Console.Read();
        }
    }
}
