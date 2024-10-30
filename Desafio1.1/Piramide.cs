using System;

public class Piramide
{
	int N {  get; set; }

	public Piramide(int N)
	{
		if (N < 1) throw new Exception();
		this.N = N;
    }

    public void Desenha()
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < N - i; j++) Console.Write(" ");
            for (int j = 1; j < i; j++) Console.Write(j);
            for (int j = i; j >= 1; j--) Console.Write(j);
            Console.WriteLine();
        }
    }
}
