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
    public partial class Biografia : ContentPage
    {
        public Biografia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_biografia.png");

            btnBohemian.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.bohemian.jpg");
            btnRede.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.rede.jpg");
            btnWallstreet.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.wallstreet.jpg");
            btnJobs.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.jobs.jpg");
            btnMente.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.mente.jpg");
            btnImitacao.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Biografia.imitacao.jpg");

        }

        private void btnBohemian_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRede_Clicked(object sender, EventArgs e)
        {

        }

        private void btnWallstreet_Clicked(object sender, EventArgs e)
        {

        }

        private void btnJobs_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMente_Clicked(object sender, EventArgs e)
        {

        }

        private void btnImitacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}