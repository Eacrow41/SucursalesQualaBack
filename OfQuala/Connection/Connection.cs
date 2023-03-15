namespace OfQuala.Connection
{
    public class Connectionbd
    {
        private string connectionString = string.Empty;
        public Connectionbd()
        {
            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connectionString = builder.GetSection("ConnectionString:connectiondb").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
