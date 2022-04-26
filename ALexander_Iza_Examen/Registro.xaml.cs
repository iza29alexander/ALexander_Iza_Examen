using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ALexander_Iza_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double mensual;
        double totalapagar;
        public Registro( string nombreUsuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = "Usuario Conectado: " + nombreUsuario;
        }


        private void btnCalcular_Clicked(object sender, EventArgs e)

        {
            

           double monto = Convert.ToDouble(txtMonto.Text);
           double saldo = 1800 - monto;

            mensual = (saldo / 3) + (1800 * 0.05);

            totalapagar = monto + (mensual * 3);

            txtMensual.Text = mensual.ToString(); 

        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Resumen(lblNombreUsuario.Text, txtNombre.Text,totalapagar));


        }
    }
}