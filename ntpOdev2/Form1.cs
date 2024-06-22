using System;
using System.Linq;
using System.Windows.Forms;

namespace ntpOdev2
{
    public partial class Form1 : Form
    {
        private FilmDukkani filmDukkani;

        public Form1()
        {
            InitializeComponent();
            filmDukkani = new FilmDukkani();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmDukkani.VerileriOku();
            UpdateFilmGrid();
            UpdateKisiGrid();
            UpdateKiralamaGrid();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            var tur = txtFilmTur.Text;
            var film = new Film
            {
                Id = filmDukkani.Filmler.Count + 1,
                Ad = txtFilmAd.Text,
                Tur = tur
            };

            double ucret = double.Parse(txtFilmUcret.Text);
            filmDukkani.TurUcretleriEkle(tur, ucret);
            film.HesaplaGunlukUcret(filmDukkani.TurUcretleri);
            filmDukkani.FilmEkle(film);

            UpdateFilmGrid();
            MessageBox.Show("Film eklendi.");
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            var kisi = new Kisi
            {
                Id = filmDukkani.Kisiler.Count + 1,
                Isim = txtKisiAd.Text,
                Soyisim = txtKisiSoyad.Text
            };
            filmDukkani.KisiEkle(kisi);
            UpdateKisiGrid();
        }

        private void btnKiralamaEkle_Click(object sender, EventArgs e)
        {
            var kiralama = new Kiralama(
                kisiId: int.Parse(txtKisiId.Text),
                filmId: int.Parse(txtFilmId.Text),
                gun: int.Parse(txtKiralamaGun.Text)
            );
            var film = filmDukkani.Filmler.FirstOrDefault(f => f.Id == kiralama.FilmId);
            kiralama.UcretiHesapla(film);
            filmDukkani.KiralamaEkle(kiralama);
            UpdateKiralamaGrid();
        }

        private void btnVerileriKaydet_Click(object sender, EventArgs e)
        {
            filmDukkani.VerileriKaydet();
        }

        private void btnVerileriOku_Click(object sender, EventArgs e)
        {
            filmDukkani.VerileriOku();
            UpdateFilmGrid();
            UpdateKisiGrid();
            UpdateKiralamaGrid();
        }

        private void UpdateFilmGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filmDukkani.Filmler;
        }

        private void UpdateKisiGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = filmDukkani.Kisiler;
        }

        private void UpdateKiralamaGrid()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = filmDukkani.Kiralamalar;
        }
    }
}
