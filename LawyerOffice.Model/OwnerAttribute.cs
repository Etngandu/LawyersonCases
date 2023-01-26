using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Entities
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OwnerAttribute: Attribute
    {

    }
}
