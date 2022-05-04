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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_drama.png");

            btnRocky1.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky1.jpg");
            btnRocky2.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky2.jpg");
            btnRocky3.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky3.jpg");
            btnRocky4.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky4.jpg");
            btnRocky5.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky5.jpg");
            btnRocky6.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.rocky6.jpg");
            btnCreed.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.creed.jpg");
            btnCreed2.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Drama.creed2.jpg");
        }

        private void btnRocky1_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRocky2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRocky3_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRocky4_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRocky5_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRocky6_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCreed_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCreed2_Clicked(object sender, EventArgs e)
        {

        }
    }
}