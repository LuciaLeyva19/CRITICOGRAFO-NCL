using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRITICOGRAFO_NCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private void OnCriticarClicked(object sender, EventArgs e)
        {
            string nombre = nomEntry.Text;
            string genero = hom.IsChecked ? "Hombre" : "Mujer";
            List<string> caracteristicas = new List<string>();
            if (alto.IsChecked) caracteristicas.Add("Alto");
            if (feo.IsChecked) caracteristicas.Add("Feo");
            if (listo.IsChecked) caracteristicas.Add("Listo");
            if (extravagante.IsChecked) caracteristicas.Add("Extravagante");
            if (raro.IsChecked) caracteristicas.Add("Raro");
            if (grande.IsChecked) caracteristicas.Add("Grande");
            string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nCaracterísticas: {string.Join(", ", caracteristicas)}";
            DisplayAlert("Datos Críticos", mensaje, "Aceptar");
        }
    }
}