using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Enums.CustomerStatusEnum
{
    public enum CustomerStatusEnum
    {
        Active,
        Inactive
    }
    public static class CustomerStatusEnumExtensions
    {
        private const string ACTIVE = "A";
        private const string INACTIVE = "I";
    }
}
