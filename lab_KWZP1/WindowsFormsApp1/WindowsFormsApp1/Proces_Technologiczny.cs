//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proces_Technologiczny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proces_Technologiczny()
        {
            this.Proces_Produkcyjny = new HashSet<Proces_Produkcyjny>();
        }
    
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Dokumentacja_Proces { get; set; }
        public int ID_Pracownika { get; set; }
    
        public virtual Dokumentacja_Proces Dokumentacja_Proces { get; set; }
        public virtual Etapy_W_Procesie Etapy_W_Procesie { get; set; }
        public virtual Maszyny_Proces Maszyny_Proces { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Produkcyjny> Proces_Produkcyjny { get; set; }
        public virtual Proces_Zamowienie Proces_Zamowienie { get; set; }
    }
}
