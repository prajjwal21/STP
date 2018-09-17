﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTradingPlatform.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StpDBEntities : DbContext
    {
        public StpDBEntities()
            : base("name=StpDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAuthenticate> tblAuthenticates { get; set; }
        public virtual DbSet<tblSessionsData> tblSessionsDatas { get; set; }
        public virtual DbSet<tblStock> tblStocks { get; set; }
        public virtual DbSet<tblStocksHistory> tblStocksHistories { get; set; }
        public virtual DbSet<tblStocksPrice> tblStocksPrices { get; set; }
        public virtual DbSet<tblTradeRequest> tblTradeRequests { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblWallet> tblWallets { get; set; }
        public virtual DbSet<tblTransactions> tblTransactions { get; set; }
        public virtual DbSet<tblHoldings> tblHoldings { get; set; }
    
        public virtual ObjectResult<Nullable<int>> getLastStockId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getLastStockId");
        }
    
        public virtual ObjectResult<string> getStockName(Nullable<int> reqId)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getStockName", reqIdParameter);
        }
    
        public virtual ObjectResult<string> getUserName(Nullable<int> reqId)
        {
            var reqIdParameter = reqId.HasValue ?
                new ObjectParameter("reqId", reqId) :
                new ObjectParameter("reqId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getUserName", reqIdParameter);
        }
    
        public virtual ObjectResult<GetStocksData_Result> GetStocksData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStocksData_Result>("GetStocksData");
        }
    
        public virtual ObjectResult<Nullable<double>> getCurrentprice(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("getCurrentprice", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getLastStockId1(Nullable<int> stockId)
        {
            var stockIdParameter = stockId.HasValue ?
                new ObjectParameter("stockId", stockId) :
                new ObjectParameter("stockId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getLastStockId1", stockIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getIdexFromStockPriceTable(Nullable<int> stockId)
        {
            var stockIdParameter = stockId.HasValue ?
                new ObjectParameter("stockId", stockId) :
                new ObjectParameter("stockId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getIdexFromStockPriceTable", stockIdParameter);
        }
    
        public virtual ObjectResult<UserTransactionsDetailByUid_Result> UserTransactionsDetailByUid(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserTransactionsDetailByUid_Result>("UserTransactionsDetailByUid", idParameter);
        }
    }
}
