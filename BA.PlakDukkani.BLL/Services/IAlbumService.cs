using BA.PlakDukkani.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Services
{
    public interface IAlbumService : IService<Album>
    {

        public void SatisiDurmusAlbumler(); 
        public void SatisiDevamEdenAlbumler(); 
        public void EnSonEklenenOnAlbum(); 
        public void İndirimdekiAlbumler(); 
    }
}
