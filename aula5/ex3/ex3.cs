int soma = 0;

for (int i = 50; i < 501; i++)
{
    if (i % 2 != 0 && i % 3 == 0)
    soma += i;
}
Console.WriteLine($"A soma dos números ímpares entre 50 e 501 que são múltiplos de 3 é: {soma}");