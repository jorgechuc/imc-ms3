using Imc.Model;

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
			decimal imc = 
				IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
			ImcLabel.Text = imc.ToString("G6");
			SituacionNutricionalLabel.Text = 
				IndiceDeMasaCorporalLib.DeterminarEstadoNutricional(imc);
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
	}
}
