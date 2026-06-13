using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio04
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Inicializamos la NewPage1 como página de navegación y página principal o de inicio
            MainPage = new NavigationPage(new NewPage1());
        }

         
    }
}