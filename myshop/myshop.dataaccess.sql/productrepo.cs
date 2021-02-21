using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using Myshop.core;

namespace myshop.dataaccess.sql
{
    class productrepo
    {
        ObjectCache cache = MemoryCache.Default;
        List<Product> products = new List<Product>();

    }
}
