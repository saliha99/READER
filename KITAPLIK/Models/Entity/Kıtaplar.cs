//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KITAPLIK.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kıtaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kıtaplar()
        {
            this.Yorum = new HashSet<Yorum>();
            this.Kategorıler = new HashSet<Kategorıler>();
            this.yazarlar = new HashSet<yazarlar>();
        }
    
        public int kıtapıd { get; set; }
        public string kıtapadı { get; set; }
        public string acıklama { get; set; }
        public string kıtapresım { get; set; }
        public Nullable<bool> cokokunanlar { get; set; }
        public Nullable<bool> edıtorunsectıklerı { get; set; }
        public Nullable<bool> Anasayfa { get; set; }
        public Nullable<bool> Surukleyıcıyenılerıcın { get; set; }
    
        public virtual KıtapDetay KıtapDetay { get; set; }
        public virtual Kutuphanem Kutuphanem { get; set; }
        public virtual Kutuphanem Kutuphanem1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategorıler> Kategorıler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yazarlar> yazarlar { get; set; }
    }
}
