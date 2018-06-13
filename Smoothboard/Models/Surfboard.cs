using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smoothboard.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Beschrijving { get; set; }
        public string Afbeelding { get; set; }
        public string Verkoopprijs { get; set; }
    }
}