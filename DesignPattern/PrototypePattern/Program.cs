using PrototypePattern.Oyun;
using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    class Program
    {//bir objenin özelliklerine sahip olan aynı tipte bir obje üretmek istiyorsak kullanırız.Yeni clonelanacak nesne orjinal özelliklerini etkilemez
        static void Main(string[] args)
        {
            var dailymeetingmorning = new DailyMeeting()
            {
                StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 08:00")),
                EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 08:15")),
                Location = "Balat-302",
                Metarials = new List<string>
                {
                    "projeksiyon cihazı","laptop","notepadd"
                },
                Participants = new List<string>
                {
                    "Eda","Leyla","Sinem","Mehmet"
                },
                Summary = "Toplantıda alınan kararlar.........."
            };


            var dailymeetingnoon = dailymeetingmorning.Clone();
            dailymeetingnoon.StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 12:00"));
            dailymeetingnoon.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 12:15"));

            var dailymeetingNight = dailymeetingmorning.Clone();
            dailymeetingNight.StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 20:00"));
            dailymeetingNight.StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 20:15"));

            Console.WriteLine(string.Format("Sabah Oturumu:{0}-{1}", dailymeetingmorning.StartTime, dailymeetingmorning.EndTime));
            Console.WriteLine(string.Format("Öğlen Oturumu:{0}-{1}", dailymeetingmorning.StartTime, dailymeetingmorning.EndTime));
            Console.WriteLine(string.Format("Akşam Oturumu:{0}-{1}", dailymeetingmorning.StartTime, dailymeetingmorning.EndTime));


            var OyunBulusması1 = new OyunBulusması()
            {
                Adı = "Tabu",
                OyunTur = "Eğlence",
                Oyuncular = new List<string>
                {
                    "şeyda", "gül", "hümeysa", "türkan"
                },
                Oyunkarakterleri = new List<string>
                {
                    "maymun", "kum saati", "oyun kartları"
                }
            };

            var OyunBulusması2 = OyunBulusması1.Clone();
            OyunBulusması2.Adı = "kelimelik";
            OyunBulusması2.Oyunkarakterleri = new List<string> { "oyun tahtası", "puan çizelgesi" };
            var Oyunbulusması3 = OyunBulusması1.Clone();
            Oyunbulusması3.OyunTur = "Komedi";


            Console.WriteLine("1.oyun buluşması *******");
            Console.WriteLine(OyunBulusması1.Adı+OyunBulusması1.OyunTur);
            foreach (var item in OyunBulusması1.Oyunkarakterleri)
            {
                Console.WriteLine("Karakterler:" + item);
            }
            foreach (var item in OyunBulusması1.Oyuncular)
            {
                Console.WriteLine("Oyuncular:"+item);
            }


            Console.WriteLine("2.oyun buluşması *******");
            Console.WriteLine(OyunBulusması2.Adı + OyunBulusması2.OyunTur);
            foreach (var item in OyunBulusması2.Oyunkarakterleri)
            {
                Console.WriteLine("Karakterler:" + item);
            }
            foreach (var item in OyunBulusması2.Oyuncular)
            {
                Console.WriteLine("Oyuncular:" + item);
            }

            Console.WriteLine("3.oyun buluşması *******");
            Console.WriteLine(Oyunbulusması3.Adı + Oyunbulusması3.OyunTur);
            foreach (var item in Oyunbulusması3.Oyunkarakterleri)
            {
                Console.WriteLine("Karakterler:" + item);
            }
            foreach (var item in Oyunbulusması3.Oyuncular)
            {
                Console.WriteLine("Oyuncular:" + item);
            }


            Console.ReadLine();
        }
    }
}
