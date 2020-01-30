using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paginas.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageNuevoLibro : ContentPage
    {
        public PageNuevoLibro()
        {
            InitializeComponent();
        }

        private void ButtonGuardar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryNombre.Text))
            {
                DisplayAlert("Error", "Debe escribir el nombre del libro", "Entendito");
                return;
            }
            Libro libro = new Libro()
            {
                Nombre = EntryNombre.Text,
                Autor = EntryAutor.Text,
                Editorial = EntryEditorial.Text
            };
            MessagingCenter.Send<ContentPage, Libro>(this, "NuevoLibro", libro);
            Navigation.PopAsync(true);
        }

        private async void ButtonEditoriales_Clicked(object sender, EventArgs e)
        {
            string editorial = await DisplayActionSheet("Editoriales", "Cancelar", null, "La Oveja Negra", "Salamandra", "Fondo de Cultura Económica", "Alfaomega");
            EntryEditorial.Text = editorial;
        }
    }
}