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
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_acao.png");

            btnInfiltrado.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.infiltrado.jpg");
            btnAnonimo.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.anonimo.jpg");
            btnMateMorra.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.mate_morra.jpg");
            btnBloodshot.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.bloodshot.jpg");
            btnResidentEvil.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.resident_evil.jpg");
            btnBlackout.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.blackout.jpg");
            btnMatrix.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.matrix.jpg");
            btnDjango.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.django.jpg");
        }

        private void btnInfiltrado_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAnonimo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.Anonimo());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnMateMorra_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.MateMorra());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnBloodshot_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.Bloodshot());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnResidentEvil_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.ResidentEvil());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnBlackout_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.Blackout());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnMatrix_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.Matrix());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnDjango_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.Acao.Django());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}