using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
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

        private int _likes;

        private void mostrarLikes()
        {
            _textLikes.Text = "Me gusta: " + _likes;
        }

        private void _unLike_Clicked(object sender, EventArgs e)
        {
            _likes = (_likes > 0) ? --_likes : _likes;
            mostrarLikes();
        }

        private void _like_Clicked(object sender, EventArgs e)
        {
            _likes++;
            mostrarLikes();
        }
    }
}
