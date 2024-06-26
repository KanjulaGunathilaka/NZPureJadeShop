﻿using System.IO.Pipelines;

namespace NZPureJadeShop.Models
{
    public interface IJadeRepository
    {
        IEnumerable<Jade> AllJades { get; }

        IEnumerable<Jade> PopularJadeGifts { get; }

        Jade? GetJadeById(int jadeId);

        IEnumerable<Jade> SearchJades(string searchQuery);
    }
}
