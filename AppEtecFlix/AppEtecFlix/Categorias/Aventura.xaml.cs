﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_aventura.png");

            btnUncharted.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.uncharted.jpg");
            btnMoonfall.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.moonfall.jpg");
            btnBatman.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.batman.jpg");
            btnProjetoAdam.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.projeto_adam.jpg");
            btnFreeGuy.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.freeguy.jpeg");
            btnEternos.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.eternos.jpg");
            btnDuna.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.duna.jpg");
            btnViuvaNegra.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.viuva_negra.jpg");
        }

        private void btnUncharted_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMoonfall_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBatman_Clicked(object sender, EventArgs e)
        {

        }

        private void btnProjetoAdam_Clicked(object sender, EventArgs e)
        {

        }

        private void btnFreeGuy_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEternos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnViuvaNegra_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDuna_Clicked(object sender, EventArgs e)
        {

        }
    }
}