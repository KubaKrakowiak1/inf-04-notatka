using System.Collections.ObjectModel;

namespace mobilna
{

    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> elementy = new();
        public MainPage()
        {
            InitializeComponent();
            lista.ItemsSource = elementy;
        }

        void Dodaj(object sender, EventArgs e)
        {
            string tytulZm = tytul.Text;
            string trescZm = tresc.Text;

            string notatka = $"{tytulZm} {trescZm}";
            elementy.Add(notatka);
        }
    }
}