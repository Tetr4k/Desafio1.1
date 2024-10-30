using System;

public class Pessoa
{
	public string nome;
	public readonly CertidaoNascimento? certidao;

	public Pessoa(string nome, CertidaoNascimento? certidao = null)
	{
		this.nome = nome;
		this.certidao = certidao;

    }
}
