using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure
{
   public  class Rectangle : Square
    {
        private double _b;
        public double B { get => _b; }
        public Rectangle(string name, double a, double b) : base(name, a) { _b = ValidateB(b); }
        private double ValidateB(double b) => b > 0 ? b : throw new ArgumentException("Base inválida");
        public override double GetArea() => A * _b;
        public override double GetPerimeter() => 2 * (A + _b);
    }
}
