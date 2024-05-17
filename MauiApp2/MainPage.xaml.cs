
namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        string Vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            if (string.IsNullOrEmpty(btn.Text))
            {
                btn.Text = Vez;
                if (Conferir_Vencedor())
                {
                    DisplayAlert("Parabéns", $"{Vez} ganhou", "Ok");
                    Recomeçar();
                }
                else if (Conferir_Empate())
                {
                    DisplayAlert("Que pena!", "Empate entre os jogadores", "Ok");
                    Recomeçar();
                }
                else
                {
                    Vez = Vez == "X" ? "O" : "X";
                }
            }
        }

        private bool Conferir_Vencedor()
        {
          
            return linha(btn10, btn11, btn12) || linha(btn13, btn14, btn15) || linha(btn16, btn17, btn18) ||
                   linha(btn10, btn13, btn16) || linha(btn11, btn14, btn17) || linha(btn12, btn15, btn18) ||
                   linha(btn10, btn14, btn18) || linha(btn12, btn14, btn16);
        }

        private bool Conferir_Empate()
        {
           
            return !string.IsNullOrEmpty(btn10.Text) && !string.IsNullOrEmpty(btn11.Text) && !string.IsNullOrEmpty(btn12.Text) &&
                   !string.IsNullOrEmpty(btn13.Text) && !string.IsNullOrEmpty(btn14.Text) && !string.IsNullOrEmpty(btn15.Text) &&
                   !string.IsNullOrEmpty(btn16.Text) && !string.IsNullOrEmpty(btn17.Text) && !string.IsNullOrEmpty(btn18.Text) &&
                   !Conferir_Vencedor();
        }

        private bool linha(Button b1, Button b2, Button b3)
        {
            return b1.Text == Vez && b2.Text == Vez && b3.Text == Vez;
        }

        private void Recomeçar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
            Vez = "X";
        }
    }
}