//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wardrobe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sho
    {
        public Sho()
        {
            this.Outfits = new HashSet<Outfit>();
        }
    
        public int ShoeID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    
        public virtual ICollection<Outfit> Outfits { get; set; }
    }
}
