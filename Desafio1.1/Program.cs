// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
//Quebra para numeros com mais de 1 digito
var p1 = new Piramide(9);
p1.Desenha();
*/

/*
//Voltar na escrita privada
var v1 = new Vertice(0, 0);
var v2 = new Vertice(3, 4);

Console.WriteLine(v1.Distancia(v2));

Console.WriteLine(v1.equals(v2));

v1.Move(3, 4);
Console.WriteLine(v1.equals(v2));
*/

/*
var t1 = new Triangulo(0, 0, 0, 4, 3, 0);
var t2 = new Triangulo(0, 0, 2, 0, 0, 2);

Console.WriteLine(t1.equals(t1));
Console.WriteLine(t1.Perimetro);
Console.WriteLine(t1.Tipo);
Console.WriteLine(t1.Area);

Console.WriteLine(t1.equals(t2));
Console.WriteLine(t2.Tipo);
*/

//var tErro = new Triangulo(0, 0, 0, 0, 0, 0);

var p = new Poligono(0, 0, 1, 2, 3, 4, 5, 6);
Console.WriteLine(p.Perimetro());
p.RemoveVertice(5, 6);
Console.WriteLine(p.Perimetro());

//Console.WriteLine(Armstrong.isArmstrong(371));

Console.WriteLine("Numeros de Armstrong:");
for (int i = 1; i <= 10000; i++)
    if (Armstrong.isArmstrong(i)) Console.Write(i+" ");
Console.WriteLine();

//Projeto ValidaçãoDados:

while (true)
{
    Console.WriteLine("Digite o nome:");
    var nome = Console.ReadLine();
    if (nome.Trim().Length < 5) Console.WriteLine("O nome tem menos de 5 caracteres");
    else break;
}

while (true)
{
    Console.WriteLine("Digite o CPF:");
    string cpf = Console.ReadLine();
    if (cpf.Length > 11)
    {
        Console.WriteLine("O CPF deve ter 11 digitos!");
        continue;
    }
    string[] iguais = { "00000000000", "11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999" };
    if (iguais.Contains(cpf))
    {
        Console.WriteLine("Os digitos não podem ser todos iguais!");
        continue;
    }
    var J = Int32.Parse(Char.ToString(cpf[9]));
    var K = Int32.Parse(Char.ToString(cpf[10]));

    var somaJ = 0;
    for (int i = 0; i<9; i++)
    {
        var c = Char.ToString(cpf[i]);
        somaJ += Int32.Parse(c)*(10-i);
    }
    var restoJ = somaJ % 11;
    if (restoJ >= 2)
    {
        if (J != 11 - restoJ)
        {
            Console.WriteLine("jCPF Invalido!");
            continue;
        }
    }
    else if (J != 0)
    {
        Console.WriteLine("jjCPF Invalido!");
        continue;
    }

    var somaK = 0;
    for (int i = 0; i < 10; i++)
    {
        var c = Char.ToString(cpf[i]);
        somaK += Int32.Parse(c) * (11 - i);
    }

    var restoK = somaK % 11;
    if (restoK >= 2)
    {
        if (K != 11 - restoK)
        {
            Console.WriteLine("kCPF Invalido!");
            continue;
        }
    }
    else if (K != 0)
    {
        Console.WriteLine("kkCPF Invalido!");
        continue;
    }

    break;
}


while (true)
{
    Console.WriteLine("Digite a data de nascimento:");
    var data = Console.ReadLine();
    var arrayData = data.Trim().Split("/");
    var nascimento = new DateTime(Int32.Parse(arrayData[2]), Int32.Parse(arrayData[0]), Int32.Parse(arrayData[1]));
    var idade = DateTime.Now - nascimento;
    if (idade.Days/365 < 18) Console.WriteLine("O cliente deve ter pelo menos 18 anos!");
    else break;
}

while (true)
{
    Console.WriteLine("Digite a renda mensal:");
    var renda = Console.ReadLine();
    var rendaTratada = float.Parse(renda.Trim().Replace(",", "."));
    if (rendaTratada < 0) Console.WriteLine("A renda deve ser positiva!");
    else break;
}

while (true)
{
    Console.WriteLine("Digite o estado civil:");
    var estado = Console.ReadLine();
    var estadoTratado = estado.Trim().ToUpper();
    string[] estados = {"C", "S", "V", "D"};
    if (!estados.Contains(estado)) Console.WriteLine("A renda deve ser positiva!");
    else break;
}

while (true)
{
    Console.WriteLine("Digite o estado civil:");
    var estado = Console.ReadLine();
    var estadoTratado = estado.Trim().ToUpper();
    string[] estados = { "C", "S", "V", "D" };
    if (!estados.Contains(estado)) Console.WriteLine("Estado civil invalido!");
    else break;
}

while (true)
{
    Console.WriteLine("Digite a quantidade de dependentes:");
    var dependentes = Int32.Parse(Console.ReadLine().Trim());
    if (dependentes < 0 || dependentes > 10) Console.WriteLine("O cliente deve ter de 0 a 10 dependentes!");
    else break;
}