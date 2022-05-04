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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_terror.png");

            btnMal1.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.mal1.jpg");
            btnMal2.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.mal2.jpg");
            btnMal3.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.mal3.jpg");
            btnFreira.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.freira.jpg");
            btnIt.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.it.jpg");
            btnIt2.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.it2.jpg");
            btnPanico.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Terror.panico.jpg");
        }

        private void btnMal1_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMal2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMal3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnFreira_Clicked(object sender, EventArgs e)
        {

        }

        private void btnIt_Clicked(object sender, EventArgs e)
        {

        }

        private void btnIt2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPanico_Clicked(object sender, EventArgs e)
        {

        }
    }
}