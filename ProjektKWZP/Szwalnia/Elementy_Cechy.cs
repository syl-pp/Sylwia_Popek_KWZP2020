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
    
    public partial class Elementy_Cechy
    {
        public int ID_Elementy_Cechy { get; set; }
        public Nullable<int> ID_Element { get; set; }
        public Nullable<int> ID_Cecha { get; set; }
        public Nullable<float> Wartosc_Cechy_Liczbowa { get; set; }
        public Nullable<int> ID_Jednostka { get; set; }
        public string Wartosc_Cechy_Slowna { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Elementy_Cechy_Slownik Elementy_Cechy_Slownik { get; set; }
        public virtual Elementy_Jednostki Elementy_Jednostki { get; set; }
    }
}
