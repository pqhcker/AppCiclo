using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCiclo
{
    public class MainPageViewModel : ObservableObject
    {
        private int contador;

        public MainPageViewModel()
        {
            EjecutarCommand = new(async () => await EjecutarContador());
        }

        private async Task EjecutarContador()
        {
            for(int i =1; i <= 10000; i++)
            {
                Contador = i;
                await Task.Delay(100);
            }
        }

        public int Contador
        {
            get => contador;
            set => SetProperty(ref contador, value);
        }

        public Command EjecutarCommand { get; set; }

    }
}
