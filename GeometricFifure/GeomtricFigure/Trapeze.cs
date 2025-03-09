using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure;
class Trapeze : Triangle
{
    private double _d;
    public double D { get => _d; }

    public Trapeze(string name, double a, double b, double c, double h, double d)
        : base(name, a, b, c, h)
    {
        _d = ValidateD(d);
    }

    private double ValidateD(double d) => d > 0 ? d : throw new ArgumentException("Base superior inválida");

    public override double GetArea() => ((B + D) * H) / 2; // Se cambió _d por D para mayor claridad

    public override double GetPerimeter() => A + B + C + D; // Se cambió _d por D para mayor claridad
}