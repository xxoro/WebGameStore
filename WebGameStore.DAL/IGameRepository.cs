﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGameStore.Model;

namespace WebGameStore.DAL
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        Game GetById(string id);
    }
}
