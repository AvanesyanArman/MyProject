using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL.Entities
{
    public class Cards
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public int CardId { get; set; }
        public int Cost { get; set; }
    }
}
