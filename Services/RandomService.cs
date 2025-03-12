﻿using Microsoft.EntityFrameworkCore;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
    public class RandomService
    {
        int seed;
        TestDbContext _ctx;
        private static Random random;

        public RandomService()
        {
            var contextOptions = new DbContextOptionsBuilder<TestDbContext>()
    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Teste;Trusted_Connection=True;")
    .Options;
            seed = Guid.NewGuid().GetHashCode();

            _ctx = new TestDbContext(contextOptions);

            random = new Random(seed);
        }
        public async Task<int> GetRandom()
        {
            var number = random.Next(100);
            _ctx.Numbers.Add(new RandomNumber() { Number = number });
            _ctx.SaveChanges();

            return number;
        }
    }
}
