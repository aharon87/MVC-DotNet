//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularStart1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receipts
    {
        public int IDReceipt { get; set; }
        public int PurchaseAmount { get; set; }
        public string DatePurchas { get; set; }
        public int GiftCardID { get; set; }
        public string StoreId { get; set; }
    
        public virtual GiftCards GiftCards { get; set; }
    }
}
