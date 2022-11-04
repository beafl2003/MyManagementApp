namespace MyManagementApp.Data
{
    public class DataConfig
    {
        public string Server { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public string ConnectionString { get { 
            return $@"Server={Server};Database=DbManagmentApp;User Id={User};Password={Password}";
         } }

        public static class Factory {
            public static DataConfig GetConnectionConfig() 
            {
                return new DataConfig() {
                    Server = @"ANNA-BEATRIZ\SQLEXPRESS",
                    User = "sa",
                    Password = "dp"                
                };
            }
        }

    }
}
