using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Identidadesecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
