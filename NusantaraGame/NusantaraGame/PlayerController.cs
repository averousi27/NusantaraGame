using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NusantaraGame
{
    class PlayerController
    {
        NusantaraEntities context = new NusantaraEntities();
        public void AddPlayer()
        {
            Player ToUpdate = (from pUpdate in context.Players
                               where pUpdate.PlayerId == 1
                               select pUpdate).FirstOrDefault();

            ToUpdate.LastNyawa = 3;
            ToUpdate.LastScore = 0;

            context.SaveChanges();

        }

        public int TampilNyawa()
        {
            Player a = (from nyawaUpdate in context.Players
                        where nyawaUpdate.PlayerId == 1
                        select nyawaUpdate).FirstOrDefault();

            return Convert.ToInt32(a.LastNyawa);
        }

        public int TampilScore()
        {
            Player a = (from nyawaUpdate in context.Players
                        where nyawaUpdate.PlayerId == 1
                        select nyawaUpdate).FirstOrDefault();

            return Convert.ToInt32(a.LastScore);
        }
    }
}
