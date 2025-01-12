using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ataseven_Optik
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }

    public class Urun
    {
        public Guid ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public string Numara { get; set; }
        public double Fiyat { get; set; }
        public double Stok { get; set; }

        public override string ToString()
        {
            return $"{Model} {Marka}";
        }

    }
    public class Siparis
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid UrunID { get; set; }
        public double Adet { get; set; }
        public double Fiyat { get; set; }
        public DateTime Tarih { get; set; }


    }

    public class Odeme
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public double Tutar { get; set; }
        public string Tur { get; set; }


    }
}
