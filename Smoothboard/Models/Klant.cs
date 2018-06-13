using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Smoothboard.Models.Klant;

namespace Smoothboard.Models
{
    public class Klant
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public int Telefoonnummer { get; set; }
        public bool Bevestigd { get; set; }
        public Geslachten Geslacht { get; set; }
        public string Land { get; set; }
        public bool Nieuwsbrief { get; set; }
    }
    public enum Geslachten
    {
        Man,
        Vrouw,
        Anders
    }
}