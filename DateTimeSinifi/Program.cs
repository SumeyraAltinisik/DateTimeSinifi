﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = new DateTime(2010, 10, 24, 12, 00, 10);
            Console.WriteLine("Kendi oluşturduğum tarih bilgisi:{0}", tarih);
            DateTime suan = DateTime.Now;
            int yil = DateTime.Now.Year;
            int ay = DateTime.Now.Month;
            int ayinKaci = DateTime.Now.Day;
            DayOfWeek haftaninGunu = DateTime.Now.DayOfWeek;
            int yilinKacinciGunu = DateTime.Now.DayOfYear;
            int saat = DateTime.Now.Hour;
            int dakika = DateTime.Now.Minute;
            DateTime bugun=DateTime.Today;
           DateTime ucGunSonrasi= tarih.AddDays(3);
           TimeSpan sure =  tarih.Subtract(DateTime.Now);

            Console.WriteLine("Şuan:{0}", suan);
            Console.WriteLine("Yıl:{0}", yil);
            Console.WriteLine("Ay:{0}", ay);
            Console.WriteLine("Ayın kaçı:{0}", ayinKaci);
            Console.WriteLine("Haftanın hangi günü:{0}", haftaninGunu);
            Console.WriteLine("Yılın kaçıncı günü:{0}", yilinKacinciGunu);
            Console.WriteLine("Saat kaç:{0}", saat);
            Console.WriteLine("Saatin Dakikası kaç:{0}", dakika);
            Console.WriteLine("Bugünün tarihi ne:{0}", bugun);
            Console.WriteLine("Oluşturduğum tarihten üç gün sonrası ne zaman:{0}", ucGunSonrasi);
            Console.WriteLine("Oluşturduğum tarihten bugünü çıkarırsam:{0}", sure);

            Console.WriteLine(DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));
            Console.ReadKey();
        }
    }
}
