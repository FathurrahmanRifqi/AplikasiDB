//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikasiDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_jadwal
    {
        public System.DateTime hari { get; set; }
        public System.TimeSpan waktu { get; set; }
        public int id_TA { get; set; }
        public string sidang { get; set; }
        public string ruangan { get; set; }
    
        public virtual tbl_TA tbl_TA { get; set; }
    }
}
