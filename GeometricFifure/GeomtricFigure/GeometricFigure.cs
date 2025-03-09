using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"{Name,-20} => Área . . . . : {GetArea(),15:N5}   Perímetro: {GetPerimeter(),15:N5}";
        }
}
}

