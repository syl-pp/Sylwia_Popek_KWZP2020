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
    
    public partial class Dostarczenia_Wewn
    {
        public int ID_Dostarczenia { get; set; }
        public Nullable<int> ID_Pracownicy { get; set; }
        public Nullable<int> ID_Dostawy { get; set; }
        public Nullable<double> Ilosc_Dostarczona { get; set; }
        public Nullable<int> ID_Miejsca { get; set; }
        public string Data_Dostarczenia { get; set; }
    
        public virtual Zamowienia_Dostawy Zamowienia_Dostawy { get; set; }
        public virtual Miejsca Miejsca { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
    }
}
