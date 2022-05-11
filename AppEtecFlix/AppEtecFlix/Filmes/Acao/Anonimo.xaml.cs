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
    public partial class Anonimo : ContentPage
    {
        public Anonimo()
        {
            InitializeComponent();
            img_filme.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Acao.anonimo.jpg");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}