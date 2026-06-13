namespace Ejercicio04
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaDos());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}