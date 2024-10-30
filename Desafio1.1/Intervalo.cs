using System;

public class Intervalo
{
	public DateTime inicial;
	public DateTime final;
    public Intervalo(int anoInicial, int diaInicial, int mesIncial, int horaInicial, int minutoInicial, int segundoInicial, int anoFinal, int diaFinal, int mesFinal, int horaFinal, int minutoFinal, int segundoFinal)
	{
		inicial = new DateTime(anoInicial, diaInicial, mesIncial, horaInicial, minutoInicial, segundoInicial);
		final = new DateTime(anoFinal, diaFinal, mesFinal, horaFinal, minutoFinal, segundoFinal);
        if (inicial > final) throw new Exception();
    }

	public bool TemIntercecao(Intervalo o)
	{
		return (this.inicial > o.inicial && this.inicial < o.final) || (this.final > o.inicial && this.final < o.inicial);
    }

	public bool Equals(Intervalo o)
	{
		return this.inicial == o.inicial && this.final == o.final;
	}

	public TimeSpan Duracao {
		get => this.final - this.inicial;
	}
}
