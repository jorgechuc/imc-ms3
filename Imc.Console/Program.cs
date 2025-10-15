decimal peso =
	ReadDecimal("Proporcione el peso en kilogramos de la persona: ");
decimal estatura =
	ReadDecimal("Proporcione la estatura en metros de la persona: ");

decimal imc = IndiceDeMasaCorporal(peso, estatura);

Console.WriteLine($"El índice de masa corporal de la persona es: {imc:G6}");
Console.WriteLine($"El estado nutricional de la persona es: {DeterminarEstadoNutricional(imc)}" );

Console.WriteLine();

static decimal ReadDecimal(string indicacion)
{
	Console.Write(indicacion);
	var entradaComoTexto = Console.ReadLine();
	return Convert.ToDecimal(entradaComoTexto);
}

static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
{
	return peso / (estatura * estatura);
}

static string DeterminarEstadoNutricional(decimal imc)
{
	if (imc < 18.5m)
	{
		return "Peso bajo";
	}
	if (imc < 25.0m)
	{
		return "Peso normal";
	}
	if (imc < 30.0m)
	{
		return "Sobrepeso";
	}
	if (imc < 40.0m)
	{
		return "Obesidad";
	}
	return "Obesidad extrema";
}