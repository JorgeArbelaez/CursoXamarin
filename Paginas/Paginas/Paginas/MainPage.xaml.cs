using Paginas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paginas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<ContentPage, Libro>(this, "NuevoLibro", 
                (sender_contentpage, arg_libro) =>
                {
                    Label label = new Label() { 
                        Text = arg_libro.ToString() 
                    };
                    StackLibros.Children.Add(label);
                }
            );
        }

        private async void ButtonPage2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void ButtonAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageNuevoLibro());
        }
    }
}
