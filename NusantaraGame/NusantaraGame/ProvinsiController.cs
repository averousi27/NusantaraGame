using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class ProvinsiController
    {
        NusantaraEntities1 context = new NusantaraEntities1();
        public IEnumerable<Provinsi> GetLevel(string idLevel)
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           where p.LevelSoal.Equals(idLevel)
                                           select p;
            return result;
        }

    }
}
