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
    using System.ComponentModel.DataAnnotations;

    public partial class Uyeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uyeler()
        {
            this.Kutuphanem = new HashSet<Kutuphanem>();
            this.Yorum = new HashSet<Yorum>();
        }
    
        public int Uyeıd { get; set; }
        public string takmaad { get; set; }
        public string AdSoyad { get; set; }
        public string emaıl { get; set; }
        public string sıfre { get; set; }
        public Nullable<bool> Cınsıyet { get; set; }
        public string DogumYeri { get; set; }
        public Nullable<System.DateTime> DogumTarıhı { get; set; }
        public string Telefon { get; set; }
        public string Meslegi { get; set; }
        public string Biografi { get; set; }
        public string role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kutuphanem> Kutuphanem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }
    }
}
