using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePleno.Models
{
    public class Operator : IModel
    {
        public Operator()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Code { get; set; }

    }
}
