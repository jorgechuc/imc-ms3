namespace Imc.Gui
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			LimpiarInformacion();
		}

		private void OnCalcularButtonClicked(object sender, EventArgs e)
		{
			decimal peso = Convert.ToDecimal(PesoEntry.Text);
			decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
			decimal imc = IndiceDeMasaCorporal(peso, estatura);
			ImcLabel.Text = imc.ToString("G6");
			SituacionNutricionalLabel.Text = DeterminaEstadoNutricional(imc);
		}

		private void OnLimpiarButtonClicked(object sender, EventArgs e)
		{
			LimpiarInformacion();
		}

		private void LimpiarInformacion()
		{
			PesoEntry.Text = string.Empty;
			EstaturaEntry.Text = string.Empty;
			ImcLabel.Text = string.Empty;
			SituacionNutricionalLabel.Text = string.Empty;
		}

		private decimal IndiceDeMasaCorporal(decimal peso,  decimal estatura)
		{
			return peso / (estatura * estatura);
		}

		private string DeterminaEstadoNutricional(decimal imc)
		{
			if (imc < 18.5m)
			{
				return "Peso bajo";
			}
			if (imc < 25.00m) 
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

	}
}
