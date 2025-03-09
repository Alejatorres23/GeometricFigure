using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomtricFigure;
public class Triangle : Rectangle
{
    private double _c, _h;
    public double C { get => _c; }
    public double H { get => _h; }
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b) { _c = ValidateC(c); _h = ValidateH(h); }
    private double ValidateC(double c) => c > 0 ? c : throw new ArgumentException("Lado C inválido");
    private double ValidateH(double h) => h > 0 ? h : throw new ArgumentException("Altura inválida");
    public override double GetArea() => (B * _h) / 2;
    public override double GetPerimeter() => A + B + _c;
}
