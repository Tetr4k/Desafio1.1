using System;
using System.CodeDom;
using System.Collections.Generic;

public class Poligono
{
	public List<Vertice> vertices;
	public Poligono(params double[] lista)
	{
		if (lista.Length < 6) throw new Exception();
		vertices = new List<Vertice>();
		for (int i = 0; i < lista.Length; i += 2)
        {
            AddVertice(lista[i], lista[i + 1]);
        }
	}

	public bool AddVertice(double x, double y)
	{
		var n = new Vertice(x, y);
		foreach (Vertice v in vertices)
		{
			if (vertices.Equals(n)) return false;
		}
		vertices.Add(n);
		return true;
	}

	public void RemoveVertice(double x, double y)
	{
        var n = new Vertice(x, y);
        if (vertices.Count == 3) throw new Exception();
		vertices.Remove(n);
    }

	public double Perimetro()
	{
		double soma = 0;
		for(int i = 0; i < vertices.Count-1; i++)
		{
			soma += vertices[i].Distancia(vertices[i + 1]);
		}
		soma += vertices[0].Distancia(vertices.Last());
		return soma;
	}

	public int QVertices {
		get => vertices.Count;
	}
}
