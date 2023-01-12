using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MyManagementApp.Domain.Enums
{
    public enum OrderItemStatusEnum
    {        
        Ordered = 0,
        InTransit = 1,
        Delivered = 2
    }

    public static class OrderItemStatusEnumExtensions
    {

        private const string ORDERED = "Ordered";
        private const string INTRANSIT = "InTransit";
        private const string DELIVERED = "Delivered";


        public static string ToDataValue(this OrderItemStatusEnum value)
        {
            return value == OrderItemStatusEnum.Delivered ? DELIVERED : value == OrderItemStatusEnum.InTransit ? INTRANSIT : ORDERED;
        }

        public static OrderItemStatusEnum? ToOrderItemStatusEnum(this string value)

        {
            if (string.IsNullOrEmpty(value))
                return default;
            if (value.Trim().ToLowerInvariant() == ORDERED.ToLowerInvariant())
                return OrderItemStatusEnum.Ordered;
            if (value.Trim().ToLowerInvariant() == INTRANSIT.ToLowerInvariant())
                return OrderItemStatusEnum.InTransit;
            if (value.Trim().ToLowerInvariant() == DELIVERED.ToLowerInvariant())
                return OrderItemStatusEnum.Delivered;
            else return default;
        
        }
    
    }
}
