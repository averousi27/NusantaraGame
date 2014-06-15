using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class ProvinsiController
    {
        NusantaraEntities context = new NusantaraEntities();
        public IEnumerable<Provinsi> GetLevel(string idLevel)
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           where p.LevelSoal.Equals(idLevel)
                                           select p;
            return result;
        }

    }
}
