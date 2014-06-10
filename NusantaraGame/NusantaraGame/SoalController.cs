using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class SoalController
    {
        NusantaraEntities1 context = new NusantaraEntities1();
        public IEnumerable<Provinsi> GetAllData()
        {
            IEnumerable<Provinsi> result = from p in context.Provinsis
                                           select p;
            return result;
        }
    }
}
