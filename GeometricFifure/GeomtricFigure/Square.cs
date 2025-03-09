using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure
{
   public class Square : GeometricFigure
    {
        private double _a;
        public double A { get => _a; }
        public Square(string name, double a) { Name = name; _a = ValidateA(a); }
        private double ValidateA(double a) => a > 0 ? a : throw new ArgumentException("Lado inválido");
        public override double GetArea() => _a * _a;
        public override double GetPerimeter() => 4 * _a;
    }
}