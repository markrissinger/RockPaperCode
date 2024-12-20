using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GoFDesignPatterns.Prototype
{
    internal class HondaCar : BaseCar
    {
        public HondaCar(string modelName) 
        {
            ModelName = modelName;
        }

        public override BaseCar Clone()
        {
            return (HondaCar)base.MemberwiseClone();
        }
    }
}
