//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvEntityProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calismalar
    {
        public int Id { get; set; }
        public Nullable<int> KisiId { get; set; }
        public string Adres { get; set; }
    
        public virtual Bilgiler Bilgiler { get; set; }
    }
}