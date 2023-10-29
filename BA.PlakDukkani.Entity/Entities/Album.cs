using BA.PlakDukkani.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.Entity.Entities
{
    public class Album : IEntity
    {
        public int Id { get ; set ; }
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal? İndirimOrani { get; set; }
        public bool SatistaMi { get; set; }
        public Yonetici Yonetici { get; set; } //=> navigation property
        public int YoneticiId { get; set; }

    }
}
