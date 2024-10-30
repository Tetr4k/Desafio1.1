using System;

public class Triangulo
{
    public Vertice v1 { get; private set; }
    public Vertice v2 { get; private set; }
    public Vertice v3 { get; private set; }

    public Triangulo(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        v1 = new Vertice(x1, y1);
        v2 = new Vertice(x2, y2);
        v3 = new Vertice(x3, y3);

        if (Area == 0) throw new Exception();
    }

    public double A
    {
        get => v1.Distancia(v2);
    }

    public double B
    {
        get => v1.Distancia(v3);
    }

    public double C
    {
        get => v2.Distancia(v3);
    }

    public bool Equals(Triangulo t)
    {
        double[] lados = { A, B, C };
        Array.Sort(lados);
        double[] ladosT = { t.A, t.B, t.C };
        Array.Sort(ladosT);

        for (int i = 0; i < lados.Length; i++)
            if (lados[i] != ladosT[i]) return false;

        return true;
    }

    public double Perimetro
    {
        get => A + B + C;
    }

    public enum Tipos
    {
        equilatero,
        isosceles,
        escaleno
    }

    public Tipos Tipo
    {
        get
        {
            if (A.Equals(B) && A.Equals(C)) return Tipos.equilatero;
            if (A.Equals(B) || A.Equals(C) || B.Equals(C)) return Tipos.isosceles;
            return Tipos.escaleno;
        }
    }

    public double Area
    {
        get
        {
            double S = this.Perimetro/2;
            return Math.Sqrt(S * (S - A) * (S - B) * (S - C));
        }
    }
}
