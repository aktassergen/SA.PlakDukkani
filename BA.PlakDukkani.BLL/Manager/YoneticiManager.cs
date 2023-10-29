using BA.PlakDukkani.BLL.Services;
using BA.PlakDukkani.DAL.Repository;
using BA.PlakDukkani.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Manager
{
    public class YoneticiManager: BaseManager<Yonetici>,IYoneticiService 
    {
        GenericRepository<Yonetici> _repository;
        public YoneticiManager(GenericRepository<Yonetici> repository) : base(repository)
        {
            _repository = repository;
        }

        public void GirisYap(string kullaniciAdi, string sifre)
        {
            var hashedSifre = Sha256Hash(sifre);
            var yonetici = _repository.GetAll().FirstOrDefault(y => y.KullaniciAdi == kullaniciAdi && y.Sifre == hashedSifre);
            if (yonetici != null) 
            {
                
                Console.WriteLine("Giriş Başarılı");
            }
            Console.WriteLine("Giriş Başarısız ");
        }

        public void KayitOl(string kullaniciAdi, string sifre, string sifreTekrar)
        {
            var data = _repository.GetQueryable().Where(y => y.KullaniciAdi == kullaniciAdi).First();
            if (data == null) 
            {
               if(sifre.Length >= 8 && (sifre.Any(char.IsUpper) && sifre.Any(char.IsLower) && (sifre.Contains("!") || sifre.Contains(":") || sifre.Contains("*") || sifre.Contains("+"))))
                {
                    if (sifre == sifreTekrar) 
                    {

                        Console.WriteLine("Kayıt işlemi başarılı.");
                        _repository.Add(new Yonetici() 
                        {
                         KullaniciAdi= kullaniciAdi,
                         Sifre= sifre,
                         
                        
                        
                        });


                    }
                    Console.WriteLine("İkinci şifreyi doğru giriniz.");



                }
                Console.WriteLine("Lütfen şifreyi istenilen doğrulukta giriniz.");

            }
            Console.WriteLine("Bu kullanıcı adı zaten var lütfen yeni kullanıcı alanı giriniz.");
        }
        private string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


    }
}
