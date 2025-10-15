using Imc.Model;

Console.WriteLine(
	"Aplicación que calcula el índice de masa corporal de una persona\n");

decimal peso =
	ReadDecimal("Proporcione el peso en kilogramos de la persona: ");
decimal estatura =
	ReadDecimal("Proporcione la estatura en metros de la persona: ");

decimal imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);

Console.WriteLine();
Console.WriteLine(
	$"El índice de masa corporal de la persona es: {imc:G6}");
Console.WriteLine(
	$"El estado nutricional de la persona es: {IndiceDeMasaCorporalLib.DeterminarEstadoNutricional(imc)}" );

Console.WriteLine();

static decimal ReadDecimal(string indicacion)
{
	Console.Write(indicacion);
	var entradaComoTexto = Console.ReadLine();
	return Convert.ToDecimal(entradaComoTexto);
}
