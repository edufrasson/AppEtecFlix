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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_comedia.png");

            btnGente.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.gente_grande.jpg");
            btnEsposa.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.esposa.jpg");
            btnJuntos.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.juntos.jpg");
            btnGente2.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.gente_grande_2.jpg");
            btnClick.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.click.jpg");
            btnGemea.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.gemea.jpg");
            btnTrocando.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.trocando.jpg");
            btnHeranca.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Comedia.heranca.jpg");
        }

        private void btnGente_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEsposa_Clicked(object sender, EventArgs e)
        {

        }

        private void btnJuntos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGente2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnClick_Clicked(object sender, EventArgs e)
        {

        }

        private void btnGemea_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTrocando_Clicked(object sender, EventArgs e)
        {

        }

        private void btnHeranca_Clicked(object sender, EventArgs e)
        {

        }
    }
}