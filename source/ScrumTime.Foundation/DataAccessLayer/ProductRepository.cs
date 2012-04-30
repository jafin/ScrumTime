﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using ScrumTime.Foundation.Models;

namespace ScrumTime.Foundation.DataAccessLayer
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository()
            : base("Products")
        {
        }
        
    }
}
