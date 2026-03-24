Console.WriteLine("Insira um número de horaas de treinamento diárias(segunda a sexta):");
int horas = int.Parse(Console.ReadLine());

int metas = 1000;
int horas_acumuladas = 0;   
int dias_passados = 0;

while (horas_acumuladas < metas)
{
    horas_acumuladas += horas;
    dias_passados++;
}

double total_semanas = (double)dias_passados / 5;
double total_meses = total_semanas / 4.5;

Console.WriteLine($"Tota de horas: {horas_acumuladas}h");
Console.WriteLine($"Total de dias: {dias_passados} dias");
Console.WriteLine($"semanas necessárias: {total_semanas:F2} semanas");
Console.WriteLine($"meses necessários: {total_meses:F2} meses");