﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendingMachineWeb.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VendingMachines_v3Entities : DbContext
    {
        public VendingMachines_v3Entities()
            : base("name=VendingMachines_v3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Coins> Coins { get; set; }
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<VendingMachineCoins> VendingMachineCoins { get; set; }
        public virtual DbSet<VendingMachineDrinks> VendingMachineDrinks { get; set; }
        public virtual DbSet<VendingMachines> VendingMachines { get; set; }
        public virtual DbSet<CountNapitki> CountNapitki { get; set; }
        public virtual DbSet<drinkReport> drinkReport { get; set; }
    
        public virtual int ButtonMoneyOffAndOn(Nullable<int> coin_value, Nullable<int> button_value)
        {
            var coin_valueParameter = coin_value.HasValue ?
                new ObjectParameter("coin_value", coin_value) :
                new ObjectParameter("coin_value", typeof(int));
    
            var button_valueParameter = button_value.HasValue ?
                new ObjectParameter("button_value", button_value) :
                new ObjectParameter("button_value", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ButtonMoneyOffAndOn", coin_valueParameter, button_valueParameter);
        }
    
        public virtual int CoinsAdd(Nullable<int> coin_value)
        {
            var coin_valueParameter = coin_value.HasValue ?
                new ObjectParameter("coin_value", coin_value) :
                new ObjectParameter("coin_value", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CoinsAdd", coin_valueParameter);
        }
    
        public virtual int CoinsDrop(Nullable<int> coin_value)
        {
            var coin_valueParameter = coin_value.HasValue ?
                new ObjectParameter("coin_value", coin_value) :
                new ObjectParameter("coin_value", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CoinsDrop", coin_valueParameter);
        }
    
        public virtual int CountCoinsUpdate(Nullable<int> coin_value, Nullable<int> coin_count)
        {
            var coin_valueParameter = coin_value.HasValue ?
                new ObjectParameter("coin_value", coin_value) :
                new ObjectParameter("coin_value", typeof(int));
    
            var coin_countParameter = coin_count.HasValue ?
                new ObjectParameter("coin_count", coin_count) :
                new ObjectParameter("coin_count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CountCoinsUpdate", coin_valueParameter, coin_countParameter);
        }
    
        public virtual int DrinksDrop(Nullable<int> drinks_id)
        {
            var drinks_idParameter = drinks_id.HasValue ?
                new ObjectParameter("drinks_id", drinks_id) :
                new ObjectParameter("drinks_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DrinksDrop", drinks_idParameter);
        }
    }
}