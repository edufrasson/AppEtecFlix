using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scifi : ContentPage
    {
        public Scifi()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_scifi.png");
            
            btnAmeacaFantasma.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.ameaca_fantasma.jpg");
            btnAtaqueClones.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.ataque_clones.jpg");
            btnDespertarForca.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.despertar_forca.jpg");
            btnImperioContra.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.imperio_contra.jpg");
            btnInterstelar.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.interstelar.jpg");
            btnNovaEsperanca.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.nova_esperanca.jpg");
            btnRetornoJedi.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Scifi.retorno_jedi.jpg");
        }

        private void btn2067_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAmeacaFantasma_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAtaqueClones_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDespertarForca_Clicked(object sender, EventArgs e)
        {

        }

        private void btnImperioContra_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInterstelar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnNovaEsperanca_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRetornoJedi_Clicked(object sender, EventArgs e)
        {

        }
    }
}