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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreUsuario, string nombre, double total)
        {
            InitializeComponent();

            lblNombreUsuario.Text = nombreUsuario;
            txtNombreR.Text = nombre;
            txtTot.Text = Convert.ToString(total);
        }


    }
}