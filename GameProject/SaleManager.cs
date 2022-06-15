using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {

        public void DiscountSale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.Price * ((100 - campaign.DiscountRate) / 100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı " + game.Name + " oyununu indirimli şekilde satın almıştır. Satış ayrıntıları;");
            Console.WriteLine("Oyunun adı: " + game.Name + " Oyunun açıklaması: " + game.Description + " Oyunun indirimsiz fiyatı: " + game.Price + "TL");
            Console.WriteLine("Uygulanan kampanyanın adı: " + campaign.Name + " Kampanyanın açıklaması: " + campaign.Description + " İndirim oranı: %" + campaign.DiscountRate);
            Console.WriteLine("Oyunun indirimli fiyatı: " + newPrice + "TL");
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı kullanıcı " + game.Name + " oyununu satın almıştır. Satış ayrıntıları;");
            Console.WriteLine("Oyunun adı: " + game.Name + " Oyunun açıklaması: " + game.Description + " Satış fiyatı: " + game.Price + "TL");
        }
    }
}
