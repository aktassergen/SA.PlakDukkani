using BA.PlakDukkani.BLL.Manager;
using BA.PlakDukkani.BLL.Services;
using BA.PlakDukkani.DAL.Context;
using BA.PlakDukkani.Entity.Entities;
using System.Drawing;

namespace BA.PlakDukkani.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAlbumService a = new AlbumManager(new DAL.Repository.GenericRepository<Entity.Entities.Album>(new PlakDbContext()));

            a.Add(new Album() 
            {
              AlbumAdi="Album1",
               Sanatci = "Sanatcı1",
              CikisTarihi =DateTime.Now.AddDays(-20),
              Fiyat=100,
              İndirimOrani=10,
              SatistaMi=true
       
     
            });
            a.Add(new Album()
            {
                AlbumAdi = "Album2",
                Sanatci = "Sanatcı2",
                CikisTarihi = DateTime.Now.AddDays(-30),
                Fiyat = 110,
                
                SatistaMi = true


            });
            a.Add(new Album()
            {
                AlbumAdi = "Album3",
                Sanatci = "Sanatcı3",
                CikisTarihi = DateTime.Now.AddDays(-40),
                Fiyat = 140,
                İndirimOrani = 10,
                SatistaMi = false


            });
            a.Add(new Album()
            {
                AlbumAdi = "Album4",
                Sanatci = "Sanatcı4",
                CikisTarihi = DateTime.Now.AddDays(-10),
                Fiyat = 1120,
                İndirimOrani = 15,
                SatistaMi = true


            });

            IYoneticiService y = new YoneticiManager(new DAL.Repository.GenericRepository<Entity.Entities.Yonetici>(new PlakDbContext()));

            y.KayitOl("yonetici1" , "sifre1", "sifretekrar1"); // bu kayıt olmayacak çünkü kriterler uygun değildir.
            y.KayitOl("yonetici1" , "BBklj!+*", "BBklj!+*");  
            y.KayitOl("yonetici2" , "BBklj!+*", "BBklj!+*");
            y.KayitOl("yonetici2" , "BBklj!+*", "BBklj!+*");  // bu kayıt olmayacak çünkü kullanıcı adı mevcut.



        }
    }
}