using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MostrarioComponentes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            placeHolderDireccion.Text = switchActivar.IsToggled.ToString();
            //placeHolderDireccion.Text = ((Switch)sender).IsToggled.ToString();
        }

        private async void MostrarDireccion_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", $"Dirección: {placeHolderDireccion.Text}", "Ok");
        }

        private async void ButtonPregunta_Clicked(object sender, EventArgs e)
        {
            bool activar = await DisplayAlert("Activar", "¿Desea activar?", "Sí", "No");
            switchActivar.IsToggled = activar;
        }

        private async void ButtonCiudad_Clicked(object sender, EventArgs e)
        {
            string ciudad = await DisplayActionSheet("Ciudad", "Cancelar", null, "Bogotá", "Cali", "Medellín");
            if (ciudad != "Cancelar")
            {
                EditorComentarios.Text += "\n" + ciudad;
            }
        }
    }
}
