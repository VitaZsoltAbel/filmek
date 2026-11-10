using System.Windows;

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
        public MainWindow()
        {
            InitializeComponent(); 

            List<Filmadatok> filmek = new List<Filmadatok>()
            {
                new Filmadatok("Csillagok háborúja", "sci-fi", 121, 8.6),
                new Filmadatok("Titanic", "dráma", 195, 7.8),
                new Filmadatok("A Gyűrűk Ura", "fantasy", 201, 8.8),
                new Filmadatok("Mátrix", "sci-fi", 136, 8.7),
                new Filmadatok("Shrek", "animáció", 90, 7.9)
            };
        }
    }
}