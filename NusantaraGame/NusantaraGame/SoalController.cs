using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class SoalController
    {
        NusantaraEntities2 context = new NusantaraEntities2();
        public IEnumerable<Provinsi> GetLevel()
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           where p.LevelSoal==1 
                                           select p;
            return result;
        }
    }
}
