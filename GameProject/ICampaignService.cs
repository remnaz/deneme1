using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICampaignService
    {
        void Add(Campaign campaing);
        void Update(Campaign campaing);
        void Delete(Campaign campaing);
    }
}
