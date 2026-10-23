using Microsoft.Maui.Controls.Shapes;
using System.IO;
using System.Text.RegularExpressions;

namespace GoogleDriveClient
{
    public partial class MainPage : ContentPage
    {
        List<string> Adresy = new List<string>();
        public string Sciezka { set; get; }
        private string pattern = @"^[a-zA-Z]:\\(?:[^<>:""/\\|?*\r\n]+\\)*[^<>:""/\\|?*\r\n]";
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private bool CzyJedenPlik(string sciezka)
        {
            return sciezka.Any(s => s == '.' );
        }
       
        private void DodajPliki(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Sciezka) || !Regex.IsMatch(Sciezka, pattern))
            {
                DisplayAlert("Blad", "Niepoprawna sciezka", "dziala");
                return;
            }

            if (CzyJedenPlik(Sciezka))
            {
               Adresy.Add(Sciezka);
               List<string> nazwaPliku = Sciezka.Split('\\').ToList();
               
            }
        }
    }
}
