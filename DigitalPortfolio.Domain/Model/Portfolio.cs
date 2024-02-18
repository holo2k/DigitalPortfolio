using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPortfolio.Domain.Model
{
    internal class Portfolio
    {
        public int Id {  get; set; }
        public int UserId { get; set; }

        public List<string> Links { get; set; }
    }
}
