using System;
using System.Collections.Generic;
using System.IO;

namespace ntpOdev2
{
    internal class FilmDukkani
    {
        public List<Film> Filmler { get; set; }
        public List<Kisi> Kisiler { get; set; }
        public List<Kiralama> Kiralamalar { get; set; }
        public Dictionary<string, double> TurUcretleri { get; set; }

        public FilmDukkani()
        {
            Filmler = new List<Film>();
            Kisiler = new List<Kisi>();
            Kiralamalar = new List<Kiralama>();
            TurUcretleri = new Dictionary<string, double>();
        }

        public void FilmEkle(Film film)
        {
            Filmler.Add(film);
        }

        public void KisiEkle(Kisi kisi)
        {
            Kisiler.Add(kisi);
        }

        public void KiralamaEkle(Kiralama kiralama)
        {
            Kiralamalar.Add(kiralama);
        }

        public void VerileriKaydet()
        {
            File.WriteAllLines(@"C:\Users\admin\Desktop\ntp ödev\filmler.txt", Filmler.ConvertAll(f => f.ToString()));
            File.WriteAllLines(@"C:\Users\admin\Desktop\ntp ödev\kisiler.txt", Kisiler.ConvertAll(k => k.ToString()));
            File.WriteAllLines(@"C:\Users\admin\Desktop\ntp ödev\kiralamalar.txt", Kiralamalar.ConvertAll(k => k.ToString()));
        }

        public void VerileriOku()
        {
            if (File.Exists(@"C:\Users\admin\Desktop\ntp ödev\filmler.txt"))
            {
                var filmLines = File.ReadAllLines(@"C:\Users\admin\Desktop\ntp ödev\filmler.txt");
                foreach (var line in filmLines)
                {
                    Filmler.Add(Film.FromString(line));
                }
            }

            if (File.Exists(@"C:\Users\admin\Desktop\ntp ödev\kisiler.txt"))
            {
                var kisiLines = File.ReadAllLines(@"C:\Users\admin\Desktop\ntp ödev\kisiler.txt");
                foreach (var line in kisiLines)
                {
                    Kisiler.Add(Kisi.FromString(line));
                }
            }

            if (File.Exists(@"C:\Users\admin\Desktop\ntp ödev\kiralamalar.txt"))
            {
                var kiralamaLines = File.ReadAllLines(@"C:\Users\admin\Desktop\ntp ödev\kiralamalar.txt");
                foreach (var line in kiralamaLines)
                {
                    Kiralamalar.Add(Kiralama.FromString(line, Filmler, Kisiler));
                }
            }
        }

        public void TurUcretleriEkle(string tur, double ucret)
        {
            TurUcretleri[tur] = ucret;
        }
    }
}
