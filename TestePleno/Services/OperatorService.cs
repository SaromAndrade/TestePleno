using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePleno.Models;

namespace TestePleno.Services
{
    public class OperatorService
    {
        public Repository _repository = new Repository();

        public OperatorService()
        {
            //OP01, OP02, OP03
            var OP01 = new Operator() { Code = "OP01" };
            var OP02 = new Operator() { Code = "OP02" };
            var OP03 = new Operator() { Code = "OP03" };

            _repository.Insert(OP01);
            _repository.Insert(OP02);
            _repository.Insert(OP03);
        }
        public Operator GetOperatorByCode(string code)
        {
            var operators = _repository.GetAll<Operator>();
            var selectedOperator = operators.FirstOrDefault(o => o.Code == code);
            return selectedOperator;
        }

        public Operator GetOperatorById(Guid id)
        {
            var selectedOperator = _repository.GetById<Operator>(id);
            return selectedOperator;
        }

        public List<Operator> GetOperators()
        {
            var operators = _repository.GetAll<Operator>();
            return operators;
        }

        public void Create(Operator insertingOperator)
        {
            _repository.Insert(insertingOperator);
        }

        public void Update(Operator updatingOperator)
        {
            _repository.Update(updatingOperator);
        }
    }
}
