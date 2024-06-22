using System;

namespace ntpOdev2
{
    internal class Kisi
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public override string ToString()
        {
            return $"{Id},{Isim},{Soyisim}";
        }

        public static Kisi FromString(string data)
        {
            var parts = data.Split(',');
            return new Kisi
            {
                Id = int.Parse(parts[0]),
                Isim = parts[1],
                Soyisim = parts[2]
            };
        }
    }
}
