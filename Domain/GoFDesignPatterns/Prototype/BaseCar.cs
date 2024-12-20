using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GoFDesignPatterns.Prototype
{
    public abstract class BaseCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }

        public abstract BaseCar Clone();
    }
}
