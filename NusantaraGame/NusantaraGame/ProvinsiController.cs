using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class ProvinsiController
    {
        NusantaraEntities2 context = new NusantaraEntities2();
        public IEnumerable<Provinsi> GetLevel(int idLevel)
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           where p.LevelSoal==idLevel
                                           select p;
            return result;
        }

    }
}
