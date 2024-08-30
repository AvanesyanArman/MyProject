using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL.Entities
{
    public class Transfers
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public int SumOfTransfer  { get; set; }
        public int PercentOfSum {  get; set; }

    }
}
