using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePleno.Models
{
    public class Fare : IModel
    {
        public Fare()
        {
            this.Status = 1;
        }
        public Guid Id { get; set; }
        public Guid OperatorId { get; set; }
        public int Status { get; set; }
        public decimal Value { get; set; }
        public DateTime Data { get; set; }

    }
}
