using System;
using System.Collections.Immutable;

public class ListaIntervalo
{

	public List<Intervalo> lista;

	public ListaIntervalo()
	{
		lista = [];
	}

	public void Add(Intervalo i)
	{
		foreach (Intervalo l in lista)
		{
			if (l.TemIntercecao(i)) return;
		}
		lista.Add(i);
	}

	public ImmutableList<Intervalo> Intervalos {
		get => lista.OrderBy(x => x.inicial).ToImmutableList();
	}
}
