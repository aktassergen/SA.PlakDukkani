using BA.PlakDukkani.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Services
{
    public interface IYoneticiService:IService<Yonetici>
    {
        void GirisYap(string kullaniciAdi, string sifre);
        void KayitOl(string kullaniciAdi, string sifre, string sifreTekrar);





    }
}
