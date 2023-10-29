using BA.PlakDukkani.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.Entity.Entities
{
    public class Yonetici : IEntity
    {
        public Yonetici()
        {
            Albumler = new List<Album>();
        }
        public int Id { get ; set ; }
        public string KullaniciAdi { get ; set ; }
        
        public string Sifre { get ; set ; }
        public ICollection<Album> Albumler { get; set; } //=> navigation property

    }
}
