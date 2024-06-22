using System;
using System.Collections.Generic;

namespace ntpOdev2
{
    internal class Film : FilmDukkani
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public double GunlukUcret { get; set; }

        public void HesaplaGunlukUcret(Dictionary<string, double> turUcretleri)
        {
            if (turUcretleri.ContainsKey(Tur))
            {
                GunlukUcret = turUcretleri[Tur];
            }
            else
            {
                throw new ArgumentException("Bu tür için günlük ücret tanımlı değil.");
            }
        }

        public override string ToString()
        {
            return $"{Id},{Ad},{Tur},{GunlukUcret}";
        }

        public static Film FromString(string data)
        {
            var parts = data.Split(',');
            return new Film
            {
                Id = int.Parse(parts[0]),
                Ad = parts[1],
                Tur = parts[2],
                GunlukUcret = double.Parse(parts[3])
            };
        }
    }
}
