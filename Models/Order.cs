using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime DateTime { get; set; }
    }
}
