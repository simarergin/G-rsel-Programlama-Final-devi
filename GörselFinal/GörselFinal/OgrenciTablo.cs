//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GörselFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciTablo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OgrenciTablo()
        {
            this.OgrenciDersTabloes = new HashSet<OgrenciDersTablo>();
        }
    
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int KayitTarih { get; set; }
        public int OgrenciNo { get; set; }
        public System.DateTime DTarih { get; set; }
        public string Bolum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciDersTablo> OgrenciDersTabloes { get; set; }
    }
}
