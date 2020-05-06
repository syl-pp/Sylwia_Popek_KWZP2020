﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SzwalniaEntities : DbContext
    {
        public SzwalniaEntities()
            : base("name=SzwalniaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Czesci_Obsluga> Czesci_Obsluga { get; set; }
        public virtual DbSet<Dokumentacja_Proces> Dokumentacja_Proces { get; set; }
        public virtual DbSet<Dokumentacje> Dokumentacje { get; set; }
        public virtual DbSet<Dostarczenia_Wewn> Dostarczenia_Wewn { get; set; }
        public virtual DbSet<Dostarczenia_Zewn> Dostarczenia_Zewn { get; set; }
        public virtual DbSet<Dostawcy_Oferta> Dostawcy_Oferta { get; set; }
        public virtual DbSet<Dostawcy_Zaopatrzenie> Dostawcy_Zaopatrzenie { get; set; }
        public virtual DbSet<Dostawy_Zawartosc> Dostawy_Zawartosc { get; set; }
        public virtual DbSet<Elementy> Elementy { get; set; }
        public virtual DbSet<Elementy_Cechy> Elementy_Cechy { get; set; }
        public virtual DbSet<Elementy_Cechy_Slownik> Elementy_Cechy_Slownik { get; set; }
        public virtual DbSet<Elementy_Jednostki> Elementy_Jednostki { get; set; }
        public virtual DbSet<Elementy_Proces> Elementy_Proces { get; set; }
        public virtual DbSet<Elementy_Typy> Elementy_Typy { get; set; }
        public virtual DbSet<Etapy_W_Procesie> Etapy_W_Procesie { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Faktury> Faktury { get; set; }
        public virtual DbSet<Faktury_Zewnetrzne> Faktury_Zewnetrzne { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<Jezyk> Jezyk { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Kontrola_Efektywnosci> Kontrola_Efektywnosci { get; set; }
        public virtual DbSet<Koszt_Jednostkowy> Koszt_Jednostkowy { get; set; }
        public virtual DbSet<Kurierzy> Kurierzy { get; set; }
        public virtual DbSet<Maszyny> Maszyny { get; set; }
        public virtual DbSet<Maszyny_Proces> Maszyny_Proces { get; set; }
        public virtual DbSet<Material_Na_Produkcji> Material_Na_Produkcji { get; set; }
        public virtual DbSet<Miejsca> Miejsca { get; set; }
        public virtual DbSet<Obsluga_Techniczna> Obsluga_Techniczna { get; set; }
        public virtual DbSet<Oferta> Oferta { get; set; }
        public virtual DbSet<Pensja> Pensja { get; set; }
        public virtual DbSet<Polki> Polki { get; set; }
        public virtual DbSet<Polki_Rozmiary> Polki_Rozmiary { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
        public virtual DbSet<Proces_Produkcyjny> Proces_Produkcyjny { get; set; }
        public virtual DbSet<Proces_Technologiczny> Proces_Technologiczny { get; set; }
        public virtual DbSet<Proces_Zamowienie> Proces_Zamowienie { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Przydzial_Zasobow> Przydzial_Zasobow { get; set; }
        public virtual DbSet<Realizacja_Procesu> Realizacja_Procesu { get; set; }
        public virtual DbSet<Rodzaj_Dokumentacji> Rodzaj_Dokumentacji { get; set; }
        public virtual DbSet<Rodzaj_Etapu> Rodzaj_Etapu { get; set; }
        public virtual DbSet<Rodzaj_Maszyny> Rodzaj_Maszyny { get; set; }
        public virtual DbSet<Rodzaj_Obslugi> Rodzaj_Obslugi { get; set; }
        public virtual DbSet<Rodzaj_Umowy> Rodzaj_Umowy { get; set; }
        public virtual DbSet<Stanowisko> Stanowisko { get; set; }
        public virtual DbSet<Umowy_Kurierzy> Umowy_Kurierzy { get; set; }
        public virtual DbSet<Urlop> Urlop { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
        public virtual DbSet<Zamowienia_Dostawy> Zamowienia_Dostawy { get; set; }
        public virtual DbSet<Zamowienia_Przydzial> Zamowienia_Przydzial { get; set; }
        public virtual DbSet<Zamowienia_Zawartosc> Zamowienia_Zawartosc { get; set; }
        public virtual DbSet<Zamowienie_Produkt> Zamowienie_Produkt { get; set; }
        public virtual DbSet<Zapotrzebowanie_Opakowan> Zapotrzebowanie_Opakowan { get; set; }
        public virtual DbSet<Zawartosc> Zawartosc { get; set; }
        public virtual DbSet<Znajomosc_Jezykow> Znajomosc_Jezykow { get; set; }
    }
}