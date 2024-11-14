

namespace _5M12mauiKoty
{
    public partial class MainPage : ContentPage
    {
        int count = 1000000;
        string[] tablica = { "kot1.png", "kot2.png", "kot3.png", "kot4.png" };

        public MainPage()
        {
            InitializeComponent();
        }
        private void onBtnPrev(object sender, EventArgs e)
        {
            count--;
            imgName.Source = tablica[count % tablica.Length].ToString();
        }
        private void onBtnNext(object sender, EventArgs e)
        {
            count++;
            imgName.Source = tablica[count % tablica.Length].ToString();

        }
        private void onTloToggled(object sender, EventArgs e)
        {
            if (Togswitch.IsToggled)
            {
                Tlo.Background = Colors.LightBlue;
            }
            else
            {
                Tlo.Background = Colors.LightSeaGreen;
            }
        }
        private void onEntryCom(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entObraz.Text))
                return;
            int nr = 0;
            if(int.TryParse(entObraz.Text, out nr))
            {
                if(nr >= 0 && nr < tablica.Length) 
                    imgName.Source = tablica[nr];
            }
            entObraz.Text = "";
        }


    }

}
