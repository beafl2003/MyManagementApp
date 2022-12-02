namespace MyManagementApp.Data
{
    public class DataConfig
    {
        public string Server { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }
        public string DataBase { get; private set; }

        public string ConnectionString { get { 
            return $@"Server={Server};Database={DataBase};User Id={User};Password={Password}";
         } }

        public static class Factory {
            public static DataConfig GetConnectionConfig() 
            {
                return new DataConfig() {
                    DataBase = "MyManagementAppDb",
                    Server = @"localhost\SQLEXPRESS",
                    User = "sa",
                    Password = "dp"                
                };
            }
        }

    }
}
