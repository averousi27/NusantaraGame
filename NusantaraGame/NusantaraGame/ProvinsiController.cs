using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    public class ProvinsiController
    {
        NusantaraEntities context = new NusantaraEntities();
        public IEnumerable<Provinsi> GetLevel(string idLevel)
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           where p.LevelSoal.Equals(idLevel)
                                           select p;
            return result;
        }

        //Untuk mendapatkan konten provinsi berdasarkan idSoal
        //public IEnumerable<Provinsi> GetKonten(int idSoal)
        //{
        //    IEnumerable<Provinsi> result = from p in context.Provinsis
        //                                   where p.SoalId.Equals(idSoal)
        //                                   select p;
        //    return result;
        //}
        public Provinsi GetKonten(string KotaYgBenar)
        {
            Provinsi result = (from p in context.Provinsis
                               where p.URLGambar.Equals(KotaYgBenar)
                               select p).FirstOrDefault();
            return result;
        }

        //public void CheckAnswer(string IdSoal)
        //{
        //    Provinsi jawaban = from p in context.Provinsis
        //                       where p.IbuKota
        //                       select p;
        //}
    }
}
