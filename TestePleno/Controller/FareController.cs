using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controller
{
    public class FareController
    {
        private OperatorService _operatorService;
        private FareService _fareService;

        public FareController()
        {
            _operatorService = new OperatorService();
            _fareService = new FareService();
        }

        public void CreateFare(Fare fare, string operatorCode)
        {
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode);
            fare.OperatorId = selectedOperator.Id;
            if (ExistsFareInOperator(fare.OperatorId, fare))
            {
                Console.WriteLine("Operadora já Possui uma Fare Cadastrada Ativa, de Mesmo Valor e com Data Inferior a 6 Meses.");
                Console.Read();
                Environment.Exit(0);
                return;
            }
            _fareService.Create(fare);
        }

        public bool ExistsFareInOperator(Guid id, Fare fare)
        {
            var allFares = _fareService.GetFares();

            return allFares.Any(fares => fares.OperatorId == id && fares.Status == 1 && fares.Value == fare.Value && IsDateRangemoreThan6Months(fares.Data,fare.Data));
        }

        public bool IsDateRangemoreThan6Months(DateTime dt1, DateTime dt2)
        {
            var distinction = dt1 - dt2;
            if (distinction.Days >= 182)
            {
                return false;
            }
            return true;
        }


    }
}
