﻿using PetShop.Data.Models;
using System.Data.Entity;

namespace PetShop.Data.Context
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext() : base("name=PetShopDbContext")
        {
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetImage> PetImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
