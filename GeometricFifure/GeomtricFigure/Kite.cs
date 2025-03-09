using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure;

   public class Kite : Rhombus
    {
        private double _b;
        public double B { get => _b; }
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2) { _b = ValidateB(b); }
        private double ValidateB(double b) => b > 0 ? b : throw new ArgumentException("Base inválida");
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);
    }
