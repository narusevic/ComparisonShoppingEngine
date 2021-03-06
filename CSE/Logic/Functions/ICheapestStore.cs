﻿using System.Collections.Generic;
using Logic.Metadata;
using Logic.Models;

namespace Logic.Functions
{
    interface ICheapestStore
    {
        Store GetCheapestStore<T>(IEnumerable<T> products);
    }
}
