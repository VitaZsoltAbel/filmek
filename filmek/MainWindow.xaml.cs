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

        private void betoltes(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek;
            datagrid.Items.Refresh();
        }

        private void hanyfilm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"A listában {filmek.Count} film található.");
        }

        private void leghosszabb(object sender, RoutedEventArgs e)
        {
            var leghosszabbFilm = filmek.OrderByDescending(f => f.Hossz).FirstOrDefault();
            MessageBox.Show($"A leghosszabb film: {leghosszabbFilm.Cim}, Hossz: {leghosszabbFilm.Hossz} perc.");
        }

        private void atlagert(object sender, RoutedEventArgs e)
        {
            double atlag = filmek.Average(f => f.Ertekeles);
            MessageBox.Show($"A filmek átlagos értékelése: {atlag}");
        }

        private void csakscifi(object sender, RoutedEventArgs e)
        {
            List<Filmadatok>
        }

        private void csakcim(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek.Select(t => new { Cim = t.Cim }).ToList();
            datagrid.Items.Refresh();
        }

        private void cimrend(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = filmek.OrderBy(f => f.Cim).ToList();
        }
    }
}