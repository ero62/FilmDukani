using System;
using System.Collections.Generic;

namespace ntpOdev2
{
    internal class Kiralama
    {
        public int KisiId { get; set; }
        public int FilmId { get; set; }
        public int Gun { get; set; }
        public double Ucret { get; private set; }

        public Kiralama(int kisiId, int filmId, int gun)
        {
            KisiId = kisiId;
            FilmId = filmId;
            Gun = gun;
            Ucret = 0;
        }

        public void UcretiHesapla(Film film)
        {
            if (film != null)
            {
                Ucret = film.GunlukUcret * Gun;
            }
            else
            {
                throw new ArgumentNullException(nameof(film), "Film nesnesi null olamaz.");
            }
        }

        public override string ToString()
        {
            return $"{KisiId},{FilmId},{Gun},{Ucret}";
        }

        public static Kiralama FromString(string data, List<Film> filmler, List<Kisi> kisiler)
        {
            var parts = data.Split(',');
            var film = filmler.Find(f => f.Id == int.Parse(parts[1]));

            var kiralama = new Kiralama(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
            kiralama.UcretiHesapla(film);

            return kiralama;
        }
    }
}
