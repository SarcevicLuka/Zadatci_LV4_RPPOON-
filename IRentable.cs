using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_3_5
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
