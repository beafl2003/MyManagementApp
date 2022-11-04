namespace MyManagementApp.Domain.Enums
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
