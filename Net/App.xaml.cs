using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace Fotos.UI
{
    public partial class App : Application
    {
        public App()
        {
            MainPage mainPage = new MainPage();
        }
    }
}
