//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace helalinden_dev1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Araclar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Araclar()
        {
            this.Foto = new HashSet<Foto>();
            this.Kiralama = new HashSet<Kiralama>();
        }
    
        public int AracId { get; set; }
        public string AracAdi { get; set; }
        public int AracFiyat { get; set; }
        public string AracAciklama { get; set; }
        public int AracKatId { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Foto> Foto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kiralama> Kiralama { get; set; }
    }
}
