using BA.PlakDukkani.BLL.Services;
using BA.PlakDukkani.DAL.Repository;
using BA.PlakDukkani.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Manager
{
    public class AlbumManager : BaseManager<Album>, IAlbumService
    {
        GenericRepository<Album> _repository;
        public AlbumManager(GenericRepository<Album> repository):base(repository)
        {
            _repository = repository;  
        }
        public void EnSonEklenenOnAlbum()
        {
            var data = _repository.GetQueryable().OrderByDescending(a => a.Id)
                .Take(10).ToList();
            foreach (var album in data) 
            {
                Console.WriteLine("Albüm Adı : "+ album.AlbumAdi+ " Sanatçı Adı: " +album.Sanatci);

            }
                
        }

        public void SatisiDevamEdenAlbumler()
        {
            var data = _repository.GetQueryable().Where(a=>a.SatistaMi==true).ToList();
            foreach (var album in data)
            {
                Console.WriteLine("Satışı Devam Eden Albüm Adı : " + album.AlbumAdi + "Satışı Devam Eden Sanatçı Adı: " + album.Sanatci);

            }
        }

        public void SatisiDurmusAlbumler()
        {
            var data = _repository.GetQueryable().Where(a => a.SatistaMi == false).ToList();
            foreach (var album in data)
            {
                Console.WriteLine("Satışı Durmuş Albüm Adı : " + album.AlbumAdi + "Satışı Durmuş Sanatçı Adı: " + album.Sanatci);

            }
        }

        public void İndirimdekiAlbumler()
        {
            var data = _repository.GetQueryable().Where(a => a.İndirimOrani != null).OrderByDescending(a=>a.İndirimOrani).ToList();
            foreach (var album in data)
            {
                Console.WriteLine("İndirim Olan Albüm Adı : " + album.AlbumAdi + "İndirim Olan Sanatçı Adı: " + album.Sanatci);

            }
        }
    }
}
