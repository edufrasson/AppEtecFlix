using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppEtecFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppEtecFlix.Img.logo_etecflix.png");

            
        }       

        private void btnAventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnAcao_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Categorias.Acao());

            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnComedia_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Categorias.Comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnRomance_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Categorias.Romance());

            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnScifi_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Scifi());
            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnDrama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Drama());
            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnTerror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Terror());
            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnBiografia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Biografia());
            }catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
