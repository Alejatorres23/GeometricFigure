using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure
{
    public class Rhombus : Square
    {
        private double _d1, _d2;
        public double D1 { get => _d1; }
        public double D2 { get => _d2; }
        public Rhombus(string name, double a, double d1, double d2) : base(name, a) { _d1 = ValidateD1(d1); _d2 = ValidateD2(d2); }
        private double ValidateD1(double d1) => d1 > 0 ? d1 : throw new ArgumentException("Diagonal 1 inválida");
        private double ValidateD2(double d2) => d2 > 0 ? d2 : throw new ArgumentException("Diagonal 2 inválida");
        public override double GetArea() => (_d1 * _d2) / 2;
        public override double GetPerimeter() => 4 * A;
    }
}