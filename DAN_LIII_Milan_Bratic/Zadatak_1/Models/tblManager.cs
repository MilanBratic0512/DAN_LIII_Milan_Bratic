//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zadatak_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblManager
    {
        public int ManagerID { get; set; }
        public int AccountID { get; set; }
        public Nullable<int> HotelFloor { get; set; }
        public Nullable<int> Experience { get; set; }
        public string QualificationsLevel { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
    }
}