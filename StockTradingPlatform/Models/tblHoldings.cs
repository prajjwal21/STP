//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblHoldings
    {
        public int id { get; set; }
        public Nullable<int> uid { get; set; }
        public Nullable<int> stockId { get; set; }
        public Nullable<int> Qty { get; set; }
    
        public virtual tblStock tblStocks { get; set; }
        public virtual tblUser tblUsers { get; set; }
    }
}
