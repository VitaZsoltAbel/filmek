using System.Windows;
using System.Windows.Controls;

namespace filmek
{
    public class Filmadatok
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public int Hossz { get; set; }
        public double Ertekeles { get; set; }

        public Filmadatok(string cim, string mufaj, int hossz, double ertekeles)
        {
            Cim = cim;
            Mufaj = mufaj;
            Hossz = hossz;
            Ertekeles = ertekeles;
        }
    } 

    public partial class MainWindow : Window
    {
        List<Filmadatok> filmek = new List<Filmadatok>();
        public MainWindow()
        {
            InitializeComponent(); 

            filmek = new List<Filmadatok>()
            {
                new Filmadatok("Csillagok háborúja", "sci-fi", 121, 8.6),
                new Filmadatok("Titanic", "dráma", 195, 7.8),
                new Filmadatok("A Gyűrűk Ura", "fantasy", 201, 8.8),
                new Filmadatok("Mátrix", "sci-fi", 136, 8.7),
                new Filmadatok("Shrek", "animáció", 90, 7.9)
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek;
            datagrid.Items.Refresh();
        }
    }
}