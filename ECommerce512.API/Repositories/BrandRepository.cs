﻿namespace ECommerce512.API.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _context;

        //
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
