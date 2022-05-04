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
    public partial class Romance : ContentPage
    {
        public Romance()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_romance.png");

            btnBenjamin.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.benjamin.jpg");
            btnCincoPassos.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.cinco_passos.jpg");
            btnEuEra.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.eu_era.jpg");
            btnExtraordinario.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.extraordinario.png");
            btnLadoBom.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.lado_bom.jpg");
            btnSeuNome.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.seu_nome.jpg");
            btnTeoria.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Romance.teoria.jpg");
        }

        private void btnBenjamin_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCincoPassos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEuEra_Clicked(object sender, EventArgs e)
        {

        }

        private void btnExtraordinario_Clicked(object sender, EventArgs e)
        {

        }

        private void btnLadoBom_Clicked(object sender, EventArgs e)
        {

        }

        private void btnTeoria_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSeuNome_Clicked(object sender, EventArgs e)
        {

        }
    }
}