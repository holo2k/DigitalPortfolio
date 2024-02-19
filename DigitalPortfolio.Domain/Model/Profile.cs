using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPortfolio.Domain.Model
{
    public class Profile
    {
        int Id { get; set; }

        string Description { get; set; }
        User User { get; set; }

    }
}
