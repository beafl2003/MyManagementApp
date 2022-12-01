namespace MyManagementApp.Domain.Enums
{
    public enum OrderStatusEnum
    {
        Open = 0,
        Closed = 1,
        Finished = 2
    }

    public static class OrderStatusEnumExtensions
    {
        private const string OPEN = "Open";
        private const string CLOSED = "Closed";
        private const string FINISHED = "Finished";

        public static string ToDataValue(this OrderStatusEnum value)
        {
            return value == OrderStatusEnum.Finished ? FINISHED : value == OrderStatusEnum.Closed ? CLOSED : OPEN;
        }
        public static OrderStatusEnum? ToOrderStatusEnum(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return default;
            if (value.Trim().ToLowerInvariant() == OPEN.ToLowerInvariant())
                return OrderStatusEnum.Open;
            if (value.Trim().ToLowerInvariant() == CLOSED.ToLowerInvariant())
                return OrderStatusEnum.Closed;
            if (value.Trim().ToLowerInvariant() == FINISHED.ToLowerInvariant())
                return OrderStatusEnum.Finished;
            else return default;
        }
    }
}
