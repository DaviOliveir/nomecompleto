string nome, sobrenome;

Console.Write("digite seu nome...");


nome = Console.ReadLine()!;


Console.Write("digite seu sobrenome..");


sobrenome = Console.ReadLine()!;



Console.WriteLine($"nome completo: {nome} {sobrenome}");



Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");