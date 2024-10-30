using System;

public class Vertice
{
	public double X { get; private set; }
    public double Y { get; private set; }

	public Vertice(double X, double Y)
	{
		this.X = X;
		this.Y = Y;
	}

	public double Distancia(Vertice v)
	{
		return Math.Sqrt(Math.Pow(X - v.X, 2) + Math.Pow(Y - v.Y, 2));
	}

	public void Move(double X, double Y)
	{
		this.X = X;
		this.Y = Y;
	}

	public bool Equals(Vertice other) {
		return X == other.X && Y == other.Y;
	}
}
