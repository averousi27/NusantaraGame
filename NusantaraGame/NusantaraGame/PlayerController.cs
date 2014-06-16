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

        //Fungsi untuk menambahkan player baru setiap tombol mulai di klik
        public void AddPlayer()
        {
            Player ToUpdate = (from pUpdate in context.Players
                               where pUpdate.PlayerId == 1
                               select pUpdate).FirstOrDefault();

            ToUpdate.LastNyawa = 3;
            ToUpdate.LastScore = 0;
            Convert.ToInt32(ToUpdate.LastScore);
            context.SaveChanges();

        }

        public int TampilNyawa()
        {
            Player a = (from pUpdate in context.Players
                        where pUpdate.PlayerId == 1
                        select pUpdate).FirstOrDefault();

            return Convert.ToInt32(a.LastNyawa);
        }

        public int KurangNyawa()
        {
            Player nyawa = (from pUpdate in context.Players
                            where pUpdate.PlayerId == 1
                            select pUpdate).FirstOrDefault();

            nyawa.LastNyawa -= 1;
            context.SaveChanges();

            return Convert.ToInt32(nyawa.LastNyawa);
        }

        public int TampilScore()
        {
            Player a = (from pUpdate in context.Players
                        where pUpdate.PlayerId == 1
                        select pUpdate).FirstOrDefault();

            context.SaveChanges();

            return Convert.ToInt32(a.LastScore);
        }

        public void AddScore()
        {
            Player score = (from pUpdate in context.Players
                            where pUpdate.PlayerId == 1
                            select pUpdate).FirstOrDefault();
            Convert.ToInt32(score.LastScore);
            score.LastScore = score.LastScore + 10;
            //Console.WriteLine(score.LastScore);

            context.SaveChanges();

            //return Convert.ToInt32(score.LastScore);
        }
    }
}
