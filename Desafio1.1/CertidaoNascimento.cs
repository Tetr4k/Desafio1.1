using System;

public class CertidaoNascimento
{
	public DateTime dataEmissao;
	public readonly Pessoa pessoa;

	public CertidaoNascimento(DateTime dataEmissao, string nome)
	{
		this.dataEmissao = dataEmissao;
		this.pessoa = new Pessoa(nome, this);
	}
}
