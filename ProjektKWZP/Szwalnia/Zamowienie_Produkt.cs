//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szwalnia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zamowienie_Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie_Produkt()
        {
            this.Proces_Produkcyjny = new HashSet<Proces_Produkcyjny>();
            this.Proces_Zamowienie = new HashSet<Proces_Zamowienie>();
        }
    
        public int ID_Zamowienie_Produkt { get; set; }
        public Nullable<int> ID_Zamowienia { get; set; }
        public Nullable<int> ID_Produkt { get; set; }
        public int Ilosc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Produkcyjny> Proces_Produkcyjny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Zamowienie> Proces_Zamowienie { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienia Zamowienia { get; set; }
    }
}
