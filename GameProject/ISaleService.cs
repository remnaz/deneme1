using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ISaleService
    {
        void DiscountSale(Game game, Gamer gamer, Campaign campaign);
        void Sale(Game game, Gamer gamer);
    }
}
