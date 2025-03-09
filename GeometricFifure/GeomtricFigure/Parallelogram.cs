using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure;

   public class Parallelogram : Rectangle
    {
        private double _h;
        public double H { get => _h; }
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b) { _h = ValidateH(h); }
        private double ValidateH(double h) => h > 0 ? h : throw new ArgumentException("Altura inválida");
        public override double GetArea() => B * _h;
        public override double GetPerimeter() => 2 * (A + B);
    }