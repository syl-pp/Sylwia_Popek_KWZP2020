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
    
    public partial class Elementy_Proces
    {
        public int ID_Elementy_Proces { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Element { get; set; }
        public int Liczba { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
    }
}
