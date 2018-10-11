using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Order
    {
        public DateTime Date { get; set; }
        public Item Item { get; set; }
        public Supplyer Supplyer { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
