using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEtecFlix.Filmes.Aventura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eternos : ContentPage
    {
        public Eternos()
        {
            InitializeComponent();
            img_filme.Source = ImageSource.FromResource("AppEtecFlix.Img.Filmes_Aventura.eternos.jpg");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}