//Definindo um numero aleatorio
Random numeroAleatorio = new Random();
int numeroSecreto = numeroAleatorio.Next(1, 101);

do 
{
	Console.WriteLine("Digite um número entre 1 e 100: ");
	int chute = int.Parse(Console.ReadLine());

	if (chute == numeroSecreto)
	{
		Console.WriteLine("Parabéns! Você acertou o número.");
		break;
	}
	else if (chute < numeroSecreto)
	{
		Console.WriteLine("O número secreto é maior que o número digitado.");
	}
	else
	{
		Console.WriteLine("O número secreto é menor que o número digitado.");
	}
} while (true);

Console.WriteLine("Fim do jogo! Você acertou o número secreto.");