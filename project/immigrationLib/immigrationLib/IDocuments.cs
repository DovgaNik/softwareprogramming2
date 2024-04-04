using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace immigrationLib
{
    internal interface IDocuments
    {
        int daysBeforeExpiry();
        int daysAfterIssuance();
    }
}
