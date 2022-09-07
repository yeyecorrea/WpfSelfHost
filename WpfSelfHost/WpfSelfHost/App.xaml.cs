using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSelfHost
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        // La case App es el punto de partida de la aplicacion
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Indicamos la url
            String baseAdress = "http://localhost:9000/";
            StartOptions options = new StartOptions();
            options.Urls.Add(baseAdress);

            // Indicamos la clase principal a ejecutar, en este caso Startup
            WebApp.Start<Startup>(options);

            // Indicamos la ventana de WPF
            MainWindow main = new MainWindow();
            main.webBrowser.Navigate($"http://localhost:9000/AppWeb/Login.html");
            main.Show();
        }
    }
}
