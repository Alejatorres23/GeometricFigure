using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure
{
    public class Circle : GeometricFigure
    {
        
            private double _r;
            public double R { get => _r; }
            public Circle(string name, double r) { Name = name; _r = ValidateR(r); }
            private double ValidateR(double r) => r > 0 ? r : throw new ArgumentException("Radio inválido");
            public override double GetArea() => Math.PI * _r * _r;
            public override double GetPerimeter() => 2 * Math.PI * _r;
        }
    }
