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
    
    public partial class tblTradeRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTradeRequest()
        {
            this.tblTransactions = new HashSet<tblTransactions>();
            this.tblTransactions1 = new HashSet<tblTransactions>();
        }
    
        public int requestId { get; set; }
        public Nullable<int> uid { get; set; }
        public string requestType { get; set; }
        public Nullable<int> stockId { get; set; }
        public Nullable<int> requestQty { get; set; }
        public Nullable<int> remainingQty { get; set; }
        public Nullable<decimal> requestPrice { get; set; }
        public Nullable<System.DateTime> requestTime { get; set; }
        public string requestStatus { get; set; }
    
        public virtual tblStock tblStock { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransactions> tblTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransactions> tblTransactions1 { get; set; }
    }
}
