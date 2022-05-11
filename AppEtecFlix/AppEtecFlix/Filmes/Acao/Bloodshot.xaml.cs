using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Filmes.Acao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bloodshot : ContentPage
    {
        public Bloodshot()
        {
            InitializeComponent();
            img_filme.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.bloodshot.jpg");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}