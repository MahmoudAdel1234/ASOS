﻿using ASOS.DAL.Models;
using ASOS.DAL.Repositories.Generic;

namespace ASOS.DAL;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetAllProductAsync();
}
