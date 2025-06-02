using System.ComponentModel.Design;

namespace MauiAppMeuCompustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            { 
                String marca = txt_Marca.Text;
                String modelo = txt_Modelo.Text;

                double etanol = Convert.ToDouble (txt_etanol.Text);
                double gasolina = Convert.ToDouble (txt_gasolina.Text);

                String msg = "";

                if (etanol <= (gasolina * 0.7) ) 
                {
                    msg = $"O etanol está compensando para o seu {marca} {modelo}.";
                } else
                {
                    msg = $"A gasolina está compensando para o seu {marca} {modelo}";
                }

                DisplayAlert("Calculando", msg, 
            "OK");

            } catch(Exception ex)
            {
                DisplayAlert("Ops",ex.Message, "Fechar");
            }
           



        } // Fecha método
    } // Fecha Class
} // Fecha namespace
