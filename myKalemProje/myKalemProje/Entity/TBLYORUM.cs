//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLYORUM
    {
        public int YORUMID { get; set; }
        public string KULLANICIAD { get; set; }
        public string MAIL { get; set; }
        public string YORUMICERIK { get; set; }
        public Nullable<int> YORUMMAKALE { get; set; }
    
        public virtual TBLMAKALE TBLMAKALE { get; set; }
    }
}
