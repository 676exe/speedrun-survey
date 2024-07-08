using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AnketViewModel
    {
        public List<Soru> Sorular { get; set; }
        public List<String> Cevaplar { get; set; }
    }
}