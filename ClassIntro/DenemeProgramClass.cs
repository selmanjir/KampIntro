using System;
using System.Collections.Generic;
using System.Text;

namespace ClassIntro
{
    class DenemeProgramClass
    {
        static void Main (string[] args)
        {

            DenemeClass Video1 = new DenemeClass();
            Video1.videoName = " My Mother Told Me ";
            Video1.views = 537000;
            Video1.passingTime = 90;
            Video1.like = 13000;
            Video1.disLike = 100;
            


            DenemeClass Video2 = new DenemeClass();
            Video2.videoName = " The Misty Mountain Cold";
            Video2.views = 7500;
            Video2.passingTime =365*8;
            Video2.like = 668000;
            Video2.disLike = 8500;

            DenemeClass Video3 = new DenemeClass();
            Video3.videoName = " The Immortal";
            Video3.views = 450000 ;
            Video3.passingTime = 90;
            Video3.like = 7300;
            Video3.disLike = 9200;

            if (Video1.likeRate == true)
            {
                Video1.likeRateResult = "Beğenildi";
            }
            else
            {
                Video1.likeRateResult = "Beğenilmedi";
            }
            if (Video2.likeRate  == true)
            {
                Video2.likeRateResult = "Beğenildi";
            }
            else
            {
                Video2.likeRateResult = "Beğenilmedi";
            }
            if (Video3.likeRate  == true)
            {
                Video3.likeRateResult = "Beğenildi";
            }
            else
            {
                Video3.likeRateResult = "Beğenilmedi";
            }
            DenemeClass[] Videos = new DenemeClass[] { Video1, Video2, Video3, };

            foreach (var item in Videos)
            {
                Console.WriteLine( item.videoName + " " + item.views + " " + item.passingTime );
                Console.WriteLine(item.likeRateResult);
            }
            Console.WriteLine("Foreach bitti");

            for (int i = 0; i <Videos.Length; i++)
            {
                Console.WriteLine(Videos[i].videoName + " " + Videos[i].views + " " + Videos[i].passingTime);
                Console.WriteLine(Videos[i].likeRateResult);
            }
            Console.WriteLine("For Bitti");

            int f  = 0 ;

            while ( f < Videos.Length)
            {
                Console.WriteLine(Videos[f].videoName + " " + Videos[f].views + " " + Videos[f].passingTime);
                Console.WriteLine(Videos[f].likeRateResult);
                f++;
            }
            Console.WriteLine("While Bitti");

            

            if (Video1.like > Video1.disLike) 
            {
                Video1.likeRate = true;
            }
            else
            {
                Video1.likeRate = false;
            }
            if (Video2.like > Video2.disLike)
            {
                Video2.likeRate = true;
            }
            else
            {
                Video2.likeRate = false;
            }
            if (Video3.like > Video3.disLike)
            {
                Video3.likeRate = true;
            }
            else
            {
                Video3.likeRate = false;
            }

        }
    }
}
