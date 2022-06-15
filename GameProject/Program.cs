using System;


namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "İremnaz",
                LastName = "Savur",
                IdentityNumber = 123456
            };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                BirthYear = 1997,
                FirstName = "Şeyma",
                LastName = "Altundağ",
                IdentityNumber = 46851
            };

            Gamer gamer3 = new Gamer
            {
                Id = 3,
                BirthYear = 2001,
                FirstName = "Rümeysa",
                LastName = "Ören",
                IdentityNumber = 658745
            };


            Game fm = new Game() { Id = 21, Name = "Football Manager 2022", Description = "Futbol menajerliği simülasyonu", Price = 480 };
            Game etw = new Game() { Id = 22, Name = "Empire Total War", Description = "Tarihi strateji oyunu", Price = 257 };
            Game dota = new Game() { Id = 23, Name = "DOTA 2", Description = "Defence of the ancients", Price = 341 };

            Campaign yaz = new Campaign() { Id = 31, Name = "Yaz Kampanyası", Description = "Yaza özel harika indirimler!", DiscountRate = 20 };
            Campaign kis = new Campaign() { Id = 32, Name = "Kış Kampanyası", Description = "Soğuk günlerde oyun oynamak iyi gider", DiscountRate = 15 };
            Campaign bahar = new Campaign() { Id = 33, Name = "Bahar Kampanyası", Description = "Oyun sezonu başlasın!", DiscountRate = 18 };

            GamerManager playerManager = new GamerManager();
            ICampaignService campaignManager = new CampaignManager();
            ISaleService saleManager = new SaleManager();




            Console.WriteLine("OYUNCU İŞLEMLERİ");
            Console.WriteLine("Oyuncu kayıt İşlemleri;");
            Console.WriteLine("\n");
            gamerManager.Add(gamer1);
            Console.WriteLine("\n");
            gamerManager.Add(gamer2);
            Console.WriteLine("\n");
            gamerManager.Add(gamer3);
            Console.WriteLine("\n");
            Console.WriteLine("Oyuncu bilgileri güncelleme işlemi;");
            gamerManager.Update(new Gamer
            {
                Id = 3,
                BirthYear = 2001,
                FirstName = "Ayşe",
                LastName = "Ören",
                IdentityNumber = 658745
            });


            Console.WriteLine("KAMPANYA İŞLEMLERİ");
            Console.WriteLine("Kampanya ekleme işlemleri;");
            Console.WriteLine("\n");
            campaignManager.Add(yaz);
            Console.WriteLine("\n");
            campaignManager.Add(kis);
            Console.WriteLine("\n");
            campaignManager.Add(yaz);
            Console.WriteLine("\n");
            Console.WriteLine("Kampanya güncelleme işlemi;");
            campaignManager.Update(kis);
            Console.WriteLine("\n");
            Console.WriteLine("Kampanya silme işlemi;");
            campaignManager.Delete(bahar);
            Console.WriteLine("\n");
            Console.WriteLine("----------");


            Console.WriteLine("OYUN SATIŞI İŞLEMLERİ");
            Console.WriteLine("İndirimsiz oyun satışı işlemleri;");
            Console.WriteLine("\n");
            saleManager.Sale(fm, gamer1);
            Console.WriteLine("\n");
            saleManager.Sale(dota, gamer2);
            Console.WriteLine("\n");
            saleManager.Sale(etw, gamer3);
            Console.WriteLine("\n");
            Console.WriteLine("İndirimli Oyun satışı işlemleri");
            saleManager.DiscountSale(fm, gamer1, yaz);
            Console.WriteLine("\n");
            saleManager.DiscountSale(dota, gamer2, bahar);
            Console.WriteLine("\n");
            saleManager.DiscountSale(etw, gamer3, kis);
            Console.WriteLine("\n");



        }
    }
}
